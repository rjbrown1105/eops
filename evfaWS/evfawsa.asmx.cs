using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using EventCommon;

namespace evfaWS
{
    /// <summary>
    /// Summary description for evfawsa
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class evfawsa : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public DataSet SearchEvents(string partial, DateTime sd, DateTime ed,bool incdel)
        {
            
            DataSet ds = getevent(partial,sd,ed,incdel);
            return ds;
        }
        [WebMethod]
        public DataSet getEventJobs(int EventID,int JobStatus)
        {

            DataSet ds = getJobs(EventID, JobStatus);
            return ds;
        }

        [WebMethod]
        public string getEventCodeName(int EventID)
        {

            return getEventCode(EventID, true);
        }
        [WebMethod]
        public DataSet getTeamRota(int EventID)
        {
            string sel = "SELECT EventID, TeamID, LocationNowID, LocationNowTime, LocationNextID, LocationNextTime, TeamStatusID, Status, AuditBy, AuditDate";
            sel = sel + " FROM TeamRota";
            sel = sel + " WHERE(EventID = @EventID) AND(Status = 'A')";
            SqlParameter p1 = new SqlParameter("@EventID", SqlDbType.Int);
            p1.Value = EventID;

            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Evfa"].ConnectionString);
            SqlCommand cmd = new SqlCommand(sel, conn);
            cmd.Parameters.Add(p1);
            SqlDataAdapter daEvents = new SqlDataAdapter (cmd);
            //daEvents.GetFillParameters()

            //Create a client-side DataSet to hold the Customers and Orders tables.
            DataSet ds = new DataSet();

            //Explicitly open the connection to allow explicit closing.
            conn.Open();

            //Fill the DataSet with the Customers table and the Orders table.
            daEvents.Fill(ds, "TeamRota");


            //Explicitly close the connection - do not wait for garbage collection.
            conn.Close();


            return ds;
        }
        [WebMethod]
        public string getEventStartDateTime(int EventID, string SE)
        {
            string evdate = "";
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Evfa"].ConnectionString);
            string cmdtext = "";
            if (SE=="S")
            {
                cmdtext = "select CONVERT(nvarchar(10), EventStartDate,120) + ' ' + cast(EventStartTime as nvarchar(10)) from EventHdr where EventID = ";
            }
            else
            {
                cmdtext = "select CONVERT(nvarchar(10), EventEndDate,120) +' ' + cast(EventEndTime as nvarchar(10)) from EventHdr where EventID = ";
            }
            SqlCommand cmd = new SqlCommand(cmdtext + EventID.ToString(), conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            evdate = dr[0].ToString();
            dr.Close();
            conn.Close();
            return evdate;

        }
        [WebMethod]
        public DataSet getJobData(int EventID,int JobID)
        {
            string sel = "SELECT TeamID, Location, PriorityID, CategoryID, JobDescription, JobStatusID, JobDate, JobTime, EventJobID, EventID";
            sel = sel + " FROM EventJobsList";
            sel = sel + " WHERE(Status = 'A') AND(EventJobID = " + JobID.ToString() + ") AND(EventID = " + EventID.ToString() + ")";
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Evfa"].ConnectionString);
            SqlDataAdapter daJob = new SqlDataAdapter(sel, conn);
            DataSet ds = new DataSet();
            conn.Open();
            daJob.Fill(ds, "EventJob");
            conn.Close();
            return ds;
        }
        [WebMethod]
        public int savePrf(DataSet ds,int prfid)
        {
            EventPrf ps = new EventPrf();
            EventCommon.eprfutils eu = new eprfutils();
            ps = eu.datatoprf(ds,prfid);
            int retval = savePrf(ps);
            return retval;

        }

        
        private int savePrf(EventCommon.EventPrf ps)
        {
            int pno = 0;
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Evfa"].ConnectionString);

            if (ps.prfID>0)
            {
                string cmdstr = "update EventPrf SET ptTitleID = " + ps.ptTitleID.ToString() + ", ptName ='" + ps.ptName + "' , ptAdd1 = '" + ps.ptAdd1 + "', ptAdd2 = '" + ps.ptAdd2 + "', ptAdd3 = '" + ps.ptAdd3 + "', ptAdd4 = '" + ps.ptAdd4 + "', ptPCode = '" + ps.ptPCode + "', ";
                cmdstr = cmdstr + " ptTelno = '" + ps.ptTelno + "', ptAge = '" + ps.ptAge + "', ptDOB = '" + ps.ptDOB + "', ptSex = '" + ps.ptSex + "', incidentArea = '" + ps.incidentArea + "', ptComplaint = '" + ps.ptComplaint + "', ";
                cmdstr = cmdstr + " ptMeds = '" + ps.ptMeds + "', ptAllergies = '" + ps.ptAllergies + "', ptHistory = '" + ps.ptHistory + "', ptTreatment = '" + ps.ptTreatment + "', ptTransferDischID = " + ps.ptTransferDischID.ToString() + ", TreatedByPIN = '" + ps.TreatedByPIN + "', ";
                cmdstr = cmdstr + " TreatedBy = '" + ps.TreatedBy + "', prfDateTime = '" + ps.prfCallouttime + "', Status = 'A', AuditBy = " + ps.AuditBy.ToString() + ", AuditDate = '" + DateTime.Now + "', ";
                cmdstr = cmdstr + " ptOutcomeID = " + ps.ptOutcomeID.ToString() + ", prfCallouttime = '" + ps.prfCallouttime.ToString() + "', prfArrivaltime = '" + ps.prfArrivaltime.ToString() + "', prfReleasetime = '" + ps.prfReleasetime.ToString() + "'";
                cmdstr = cmdstr + " WHERE(prfID = " + ps.prfID.ToString() + ")";
                SqlCommand cmd = new SqlCommand(cmdstr, conn);

                conn.Open();

                int rv= cmd.ExecuteNonQuery();
                if (rv == 1)
                {
                    pno = ps.prfID;
                }
                //dr.Close();
                conn.Close();

            }
            else
            {

                string cmdstr = "insert into EventPrf(ptTitleID, ptName, ptAdd1, ptAdd2, ptAdd3, ptAdd4, ptPCode, ptTelno, ptAge, ptDOB, ptSex, incidentArea, ptComplaint, ptMeds, ptAllergies, ptHistory, ptTreatment, ptTransferDischID, TreatedByPIN, TreatedBy, prfDateTime, Status, AuditBy, AuditDate, ptOutcomeID, prfCallouttime, prfArrivaltime, prfReleasetime) ";
                cmdstr = cmdstr + " VALUES('" + ps.ptTitleID + "','" + ps.ptName + "','" + ps.ptAdd1 + "','" + ps.ptAdd2 + "','" + ps.ptAdd3 + "','" + ps.ptAdd4 + "',";
                cmdstr = cmdstr + "'" + ps.ptPCode + "','" + ps.ptTelno + "','" + ps.ptAge + "','" + ps.ptDOB + "','" + ps.ptSex + "','" + ps.incidentArea + "','" + ps.ptComplaint + "','" + ps.ptMeds + "','" + ps.ptAllergies + "','" + ps.ptHistory + "','" + ps.ptTreatment + "','" + ps.ptTransferDischID + "','" + ps.TreatedByPIN + "','" + ps.TreatedBy + "','" + ps.prfCallouttime.ToString() + "','A','" + ps.AuditBy + "','" + DateTime.Now.ToString() + "'," + ps.ptOutcomeID.ToString() + ",'" + ps.prfCallouttime.ToString() + "','" + ps.prfArrivaltime.ToString() + "','" + ps.prfReleasetime.ToString() + ")";
                SqlCommand cmd = new SqlCommand(cmdstr,conn);

                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select @@IDENTITY";
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                pno = Convert.ToInt32(dr[0].ToString());
                dr.Close();
                conn.Close();
            }
            
            return pno;
        }
        [WebMethod]
        public DataSet getPrfData(int EventID,int JobID, int PrfID)
        {
            return getPrf(EventID, JobID, PrfID);
        }
        [WebMethod]
        public string getnextJobID (int EventID,int TeamID, int AuditID)
        {
            string jobno = "";
            jobno = getEventCode(EventID,false);
            jobno += getNextJob(EventID,TeamID,AuditID);
            return jobno;
        }

        public string getNextJob(int EventID,int TeamID, int AuditID )
        {
            string jobno = "";
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Evfa"].ConnectionString);

            SqlCommand cmd = new SqlCommand("insert into EventJobsList(EventID, TeamID, Status, AuditBy, AuditDate) values(" + EventID.ToString() + "," + TeamID.ToString() + ",'A'," + AuditID.ToString() + ", SYSDATETIME())", conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@IDENTITY";
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            jobno = dr[0].ToString();
            dr.Close();
            conn.Close();
            return jobno;
        }
        public string getEventCode(int EventID, bool addName)
        {
            string evcode = "";
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Evfa"].ConnectionString);
            string cmdtext = "";
            if (addName)
            {
                cmdtext = "select EventCode + ' - ' + EventName from EventHdr where EventID = ";
            }
            else
            {
                cmdtext = "select EventCode from EventHdr where EventID = ";
            }
            SqlCommand cmd = new SqlCommand(cmdtext + EventID.ToString(), conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            evcode = dr[0].ToString();
            dr.Close();
            conn.Close();
            return evcode;
        }
        public DataSet getevent(string partial, DateTime sd, DateTime ed, bool incdel)
        {
            string srch = "";
            int cr = 0;
            if (partial.Length > 0)
            {
                cr++;
                srch = "EventCode like '%" + partial + "%' or EventName like '%" + partial + "%'";
            }
            if (sd.Year > 1900)
            {
                if (srch.Length > 0)
                {
                    srch = srch + " and ";
                }

                srch += " EventStartDate = " + sd.ToString("yyyy-mm-dd");
            }
            if (ed.Year > 1900)
            {
                if (srch.Length > 0)
                {
                    srch = srch + " and ";
                }

                srch += " EventEndDate = " + ed.ToString("yyyy-mm-dd");
            }
            if (!incdel)
            {
                if (srch.Length > 0)
                {
                    srch = srch + " and ";
                }
                srch += " Status = 'A'";
            }

            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Evfa"].ConnectionString);

            SqlDataAdapter daEvents = new SqlDataAdapter("Select * from EventHdr where 1=1 and " + srch, conn);


            //Create a client-side DataSet to hold the Customers and Orders tables.
            DataSet ds = new DataSet();

            //Explicitly open the connection to allow explicit closing.
            conn.Open();

            //Fill the DataSet with the Customers table and the Orders table.
            daEvents.Fill(ds, "EventHdr");


            //Explicitly close the connection - do not wait for garbage collection.
            conn.Close();


            return ds;

        }

        public DataSet getJobs(int EventID,int JobStatus)
        {
            string sel = "  SELECT EventJobsList.EventID, EventJobsList.EventJobID, EventJobsList.Location, EventJobsList.JobDescription, EventJobsList.JobDate, EventJobsList.JobTime, EventJobsList.Status, EventJobsList.AuditBy, EventJobsList.AuditDate, Teams.TeamCode, Teams.TeamDesc, Priority.PriorityDesc, Category.CatDescription, JobStatus.JobStatusID, JobStatus.JobStatusDesc, COUNT(EventJobPrf.PrfID) AS PrfCount";
            sel = sel + " FROM EventJobsList INNER JOIN";
            sel = sel + " Teams ON EventJobsList.TeamID = Teams.TeamID INNER JOIN";
            sel = sel + " JobStatus ON EventJobsList.JobStatusID = JobStatus.JobStatusID INNER JOIN";
            sel = sel + " Priority ON EventJobsList.PriorityID = Priority.PriorityId INNER JOIN";
            sel = sel + " Category ON EventJobsList.CategoryID = Category.CategoryID";
            sel = sel + " LEFT OUTER JOIN EventJobPrf ON EventJobsList.EventID = EventJobPrf.EventID AND EventJobsList.EventJobID = EventJobPrf.EventJobID";
            sel = sel + " WHERE EventJobsList.Status = 'A' and EventJobsList.EventID = " + EventID.ToString();
            sel = sel + " GROUP BY EventJobsList.EventID, EventJobsList.EventJobID, EventJobsList.Location, EventJobsList.JobDescription, EventJobsList.JobDate, EventJobsList.JobTime, EventJobsList.Status, EventJobsList.AuditBy, EventJobsList.AuditDate, Teams.TeamCode, Teams.TeamDesc, Priority.PriorityDesc, Category.CatDescription, JobStatus.JobStatusID, JobStatus.JobStatusDesc";
            if (JobStatus>0)
            {
                sel = sel + " and JobStatusID = " + JobStatus.ToString();
            }
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Evfa"].ConnectionString);
            SqlDataAdapter daEvents = new SqlDataAdapter(sel, conn);
            DataSet ds = new DataSet();
            conn.Open();
            daEvents.Fill(ds, "EventJobsList");
            conn.Close();
            return ds;


        }
        public DataSet getPrf(int EventID, int JobID, int PrfID)
        {
          //  string selst = "";
          //  string wh = "";

            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Evfa"].ConnectionString);
            conn.Open();
            DataSet ds = new DataSet();

            //     string sel2 = "SELECT EventPrf.prfID, EventPrf.ptName, EventPrf.ptDOB, EventPrf.incidentArea, EventPrf.prfDateTime, EventPrf.ptComplaint";
            string sel2 = "SELECT EventPrf.prfID, EventPrf.ptName + ' ' + CONVERT(nvarchar(10),EventPrf.ptDOB,103) + ' ' + EventPrf.incidentArea + ' ' + CONVERT(nvarchar(20), EventPrf.prfDateTime,131) as prfdesc"; //, EventPrf.ptComplaint";
            //CONVERT(nvarchar(10), GETDATE(), 126)
            sel2 = sel2 + " FROM EventJobPrf";
            sel2 = sel2 + " INNER JOIN EventPrf ON EventJobPrf.PrfID = EventPrf.prfID";
            sel2 = sel2 + " WHERE EventJobPrf.EventID = " + EventID.ToString() + " AND EventJobPrf.EventJobID = " + JobID.ToString();
            SqlDataAdapter daPrfs = new SqlDataAdapter(sel2, conn);
            int rcnt = daPrfs.Fill(ds, "Prfs");

            DataTableReader dr = ds.CreateDataReader();
            
            dr.Read();

            if (PrfID==0 && dr.HasRows)
            {

                PrfID = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();

            string sel = "  SELECT prfID, ptTitleID, ptAdd1, ptName, ptAdd2, ptAdd3, ptAdd4, ptPCode, ptTelno, ptAge, ptDOB, ptSex, incidentArea, ptComplaint, ptMeds, ptAllergies, ptHistory, ptTreatment, ptTransferDischID, TreatedByPIN, TreatedBy, prfDateTime, Status, AuditBy, AuditDate, ptOutcomeID, prfCallouttime, prfArrivaltime,prfReleasetime";
            sel = sel + " FROM EventPrf";
            sel = sel + " WHERE prfID = " + PrfID.ToString();
            SqlDataAdapter daPrf = new SqlDataAdapter(sel, conn);
            
            
            daPrf.Fill(ds, "Prf");

            conn.Close();
            return ds;


        }

        /*
        */
    }
}
