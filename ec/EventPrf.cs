using System;
using System.Collections.Generic;
using System.Text;

namespace ec
{
    class EventPrf
    {
        public int prfID { get; set; }
        public int ptTitleID { get; set; }
        public string ptName { get; set; }
        public string ptAdd1 { get; set; }
        public string ptAdd2 { get; set; }
        public string ptAdd3 { get; set; }
        public string ptAdd4 { get; set; }
        public string ptPCode { get; set; }
        public string ptTelno { get; set; }
        public string ptAge { get; set; }
        public DateTime ptDOB { get; set; }
        public string ptSex { get; set; }
        public string incidentArea { get; set; }
        public string ptComplaint { get; set; }
        public string ptMeds { get; set; }
        public string ptAllergies { get; set; }
        public string ptHistory { get; set; }
        public string ptTreatment { get; set; }
        public int ptTransferDischID { get; set; }
        public string TreatedByPIN { get; set; }
        public string TreatedBy { get; set; }
        public int AuditBy { get; set; }
        public int ptOutcomeID { get; set; }
        public TimeSpan prfCallouttime { get; set; }
        public TimeSpan prfArrivaltime { get; set; }
        public TimeSpan prfReleasetime { get; set; }
    }
}
