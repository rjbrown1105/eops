using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCommon
{
    public class eprfutils
    {
   
    public EventPrf datatoprf(DataSet ds,int prfid)
    {
        EventPrf ep = new EventPrf();
        ep.prfID = prfid;
        ep.incidentArea = ds.Tables["EventPrf"].Rows[0]["incidentArea"].ToString();
        ep.prfArrivaltime = (TimeSpan)ds.Tables["EventPrf"].Rows[0]["prfArrivalTime"];
            ep.prfCallouttime = (TimeSpan)ds.Tables["EventPrf"].Rows[0]["prfCallouttime"];
            ep.prfReleasetime = (TimeSpan)ds.Tables["EventPrf"].Rows[0]["prfReleasetime"];
        ep.ptAdd1 = ds.Tables["EventPrf"].Rows[0]["ptAdd1"].ToString();
        ep.ptAdd2 = ds.Tables["EventPrf"].Rows[0]["ptAdd2"].ToString();
        ep.ptAdd3 = ds.Tables["EventPrf"].Rows[0]["ptAdd3"].ToString();
        ep.ptAdd4 = ds.Tables["EventPrf"].Rows[0]["ptAdd4"].ToString();
        ep.ptAge = ds.Tables["EventPrf"].Rows[0]["ptAge"].ToString();
        ep.ptAllergies = ds.Tables["EventPrf"].Rows[0]["ptAllergies"].ToString();
        ep.ptComplaint = ds.Tables["EventPrf"].Rows[0]["ptComplaint"].ToString();
        ep.ptDOB = Convert.ToDateTime(ds.Tables["EventPrf"].Rows[0]["ptDOB"].ToString());
        ep.ptHistory = ds.Tables["EventPrf"].Rows[0]["ptHistory"].ToString();
        ep.ptMeds = ds.Tables["EventPrf"].Rows[0]["ptMeds"].ToString();
        ep.ptName = ds.Tables["EventPrf"].Rows[0]["ptName"].ToString();
        ep.ptOutcomeID = Convert.ToInt32(ds.Tables["EventPrf"].Rows[0]["ptOutcomeID"].ToString());
        ep.ptPCode = ds.Tables["EventPrf"].Rows[0]["ptPCode"].ToString();
        ep.ptSex = ds.Tables["EventPrf"].Rows[0]["ptSex"].ToString();
        ep.ptTelno = ds.Tables["EventPrf"].Rows[0]["ptTelno"].ToString();
        ep.ptTitleID = Convert.ToInt32(ds.Tables["EventPrf"].Rows[0]["ptTitleID"].ToString());
        ep.ptTransferDischID = Convert.ToInt32(ds.Tables["EventPrf"].Rows[0]["ptTransferDischID"].ToString());
        ep.ptTreatment = ds.Tables["EventPrf"].Rows[0]["ptTreatment"].ToString();
        ep.TreatedBy = ds.Tables["EventPrf"].Rows[0]["TreatedBy"].ToString();
        ep.TreatedByPIN = ds.Tables["EventPrf"].Rows[0]["TreatedByPIN"].ToString();
        ep.AuditBy = Convert.ToInt32(ds.Tables["EventPrf"].Rows[0]["AuditBy"].ToString());

        return ep;
    }
    }
}
