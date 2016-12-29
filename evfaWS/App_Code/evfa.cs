using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace evfaWS
{
    public class evfa
    {

        public struct Obs
        {
            public string Avpu;
            public int Resps;
            public int Pulse;
            public int O2Sats;
            public string onO2;
            public decimal Temp;
            public int BPsys;
            public int BPdia;
            public decimal CBG;
            public string infection;
            public int News;
            public int Sepsis;
            public string ObsTime;
            public string ObsDate;
            public string Status;
            public int Process;
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
            if (sd.Year > 0)
            {
                if (srch.Length > 0)
                {
                    srch = srch + " and ";
                }

                srch += " EventStartDate = " + sd.ToString("yyyy-mm-dd");
            }
            if (ed.Year > 0)
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

            SqlDataAdapter daEvents = new SqlDataAdapter(srch, conn);


            //Create a client-side DataSet to hold the Customers and Orders tables.
            DataSet ds = new DataSet();

            //Explicitly open the connection to allow explicit closing.
            conn.Open();

            //Fill the DataSet with the Customers table and the Orders table.
            daEvents.Fill(ds, "EventHdr");


            //Explicitly close the connection - do not wait for garbage collection.
            conn.Close();

            //Relate Customers to Orders.
            //      ds.Relations.Add("CustOrd", ds.Tables["Cust"].Columns["CustomerID"],
            //            ds.Tables["Orders"].Columns["CustomerID"]);

            //The relationship is Orders nested in Customers.
            //       ds.Relations[0].Nested = true;

            //Return the DataSet to the client.
            return ds;
            /*
                    SqlParameter djobno = new SqlParameter("JobNo", jobno);
                    SqlParameter dname = new SqlParameter("Pname", name);
                    SqlParameter dobsno = new SqlParameter("ObsNo", obsno);
                    SqlParameter davpu = new SqlParameter("Avpu", ob.Avpu);
                    SqlParameter dresps = new SqlParameter("Resps", ob.Resps);
                    SqlParameter dpulse = new SqlParameter("Pulse", ob.Pulse);
                    SqlParameter dO2Sats = new SqlParameter("O2Sats", ob.O2Sats);
                    SqlParameter donO2 = new SqlParameter("onO2", ob.onO2);
                    SqlParameter dTemp = new SqlParameter("Temp", ob.Temp);
                    SqlParameter dBPSys = new SqlParameter("BPSys", ob.BPsys);
                    SqlParameter dBPDia = new SqlParameter("BPDia", ob.BPdia);
                    SqlParameter dCBG = new SqlParameter("CBG", ob.CBG);
                    SqlParameter dinfection = new SqlParameter("Infection", ob.infection);
                    SqlParameter dnews = new SqlParameter("News", ob.News);
                    SqlParameter dsepsis = new SqlParameter("Sepsis", ob.Sepsis);
                    SqlParameter dobstime = new SqlParameter("ObsTime", ob.ObsTime);
                    SqlParameter dobsdate = new SqlParameter("ObsDate", ob.ObsDate);
                    SqlParameter dstatus = new SqlParameter("Status", ob.Status);
                    SqlParameter dprocess = new SqlParameter("Process", ob.Process);

                    SqlCommand command = new SqlCommand("insertCAS", conn);
                    conn.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(djobno);
                    command.Parameters.Add(dname);
                    command.Parameters.Add(dobsno);
                    command.Parameters.Add(davpu);
                    command.Parameters.Add(dresps);
                    command.Parameters.Add(dpulse);
                    command.Parameters.Add(dO2Sats);
                    command.Parameters.Add(donO2);
                    command.Parameters.Add(dTemp);
                    command.Parameters.Add(dBPSys);
                    command.Parameters.Add(dBPDia);
                    command.Parameters.Add(dCBG);
                    command.Parameters.Add(dinfection);
                    command.Parameters.Add(dnews);
                    command.Parameters.Add(dsepsis);
                    command.Parameters.Add(dobstime);
                    command.Parameters.Add(dobsdate);
                    command.Parameters.Add(dstatus);
                    command.Parameters.Add(dprocess);

                    //command.CommandText = "dbo.insertCAS";
                    command.ExecuteNonQuery();
                    conn.Close();
                    */
        }
    }
}