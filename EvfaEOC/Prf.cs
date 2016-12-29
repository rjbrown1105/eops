using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventCommon;


namespace EvfaEOC
{
    
    public partial class Prf : Form
    {
        public static int evid = 0;
        public static int jid = 0;
        public static int pid = 0;
        public evfawr.evfawsa rb;
        public evfasr.evfawsaSoapClient rbs;
        public static EventPrf eprf_orig = new EventPrf();
        public static EventPrf eprf_new = new EventPrf();

        public Prf()
        {
            InitializeComponent();
        }
        public Prf(int eventid, int jobid, int prfid)
        {
            evid = eventid;
            jid = jobid;
            pid = prfid;
            InitializeComponent();
            //dd_Sex.Items.Clear();

            rb = new evfawr.evfawsa();
            // rb = new evfasr.evfawsaSoapClient();
            rbs = new evfasr.evfawsaSoapClient();
            DataSet ds = rbs.getJobData(eventid, jobid);
            DataTableReader dtr = new DataTableReader(new DataTable("EventJob"));
            dtr = ds.CreateDataReader();

            if (dtr.Read())
            {
                DateTime dt = (DateTime)dtr["JobDate"];
                TimeSpan dtt = (TimeSpan)dtr["JobTime"];
                txt_JobDate.Text = dt.ToString("dd/MM/yyyy");
                txt_JobTime.Text = dtt.ToString();
                txt_JobNo.Text = eventid.ToString() + "/" + jobid.ToString();
                txt_jobdesc.Text = dtr["JobDescription"].ToString();
            }
        
         //   txt_JobDate.Text = ds.Tables[0].Columns["JobDate"].ToString();

            bs_prf.DataSource = rb.getPrfData(eventid, jobid, prfid);
            bs_prf.DataMember = "Prfs";

            dd_prf.DataSource = bs_prf;
            dd_prf.DisplayMember = "prfdesc";
            dd_prf.ValueMember = "prfID";
            
            bds_prfdetail.DataSource = bs_prf.DataSource;
            bds_prfdetail.DataMember = "Prf";
            pid = Convert.ToInt32(dd_prf.SelectedValue.ToString());
            

           // dd_Sex.Items.Add(

            //  txt_JobDate.Text = bs_prf. [0].ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Prf_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsref.Title' table. You can move, or remove it, as needed.
            this.titleTableAdapter.Fill(this.dsref.Title);
            this.sexTableAdapter.Fill(this.dsref.Sex);
            this.jobStatusTableAdapter.Fill(this.dsref.JobStatus);
            // TODO: This line of code loads data into the 'ds_prf.EventPrf' table. You can move, or remove it, as needed.
            this.eventPrfTableAdapter.Fill(this.ds_prf.EventPrf);
            cmbTitle.Refresh();
            dd_prf.SelectedIndex = 0;
            pid = Convert.ToInt32(dd_prf.SelectedValue.ToString());
            bds_prfdetail.DataSource = rb.getPrfData(evid, jid, pid);

        }
        private void fill_co()
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dd_prf_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                pid = Convert.ToInt32(dd_prf.SelectedValue.ToString());
                bds_prfdetail.DataSource = rb.getPrfData(evid, jid, pid);
                // load_data();
                //txt_prfptName.DataBindings.Add(.Refresh();
                // bs_prf.ResetBindings(false);
               // txt_prfptName.Add(new Binding("Text", ds_prf, "Prf.ptName", false, DataSourceUpdateMode.OnPropertyChanged));
              //  int a = bds_prfdetail.Tables["Prf"].Columns.Count;
                txt_prfptName.Update();
                txt_prfptName.Refresh();
                eprf_orig = load_data();
            }
            catch (Exception )
            {

             
            }

        }
        private EventCommon.EventPrf load_data()
        {
            EventCommon.EventPrf ep = new EventCommon.EventPrf();
            ep.prfID = pid;
            //  txt_JobDate.DataBindings.Add(new Binding("Text", bs_prf.DataSource, "Prf.prfDateTime"));
            //  cmbTitle.DataBindings.Add(new Binding("SelectedValue", bs_prf.DataSource, "Prf.ptTitleID"));
            //   cmbTitle.SelectedValue = 2;
            if (cmbTitle.SelectedIndex > -1)
            {
                ep.ptTitleID = (int)cmbTitle.SelectedValue;
            }
           ep.ptName = txt_prfptName.Text;
            ep.ptAdd1 = txt_Add1.Text;
            ep.ptAdd2 = txt_Add2.Text;
            ep.ptAdd3 = txt_Add3.Text;
            ep.ptAdd4 = txt_Add4.Text;
            ep.ptPCode = txt_pcode.Text;
            ep.ptTelno = txt_telno.Text;
            ep.ptAge = txt_age.Text;
            ep.ptSex = dd_Sex.SelectedValue.ToString();
            ep.ptDOB = Convert.ToDateTime(txt_dob.Text);
            ep.ptComplaint = txt_ptComplaint.Text;
            ep.ptHistory = txt_ptHistory.Text;
            ep.ptMeds = txt_ptMedications.Text;
            ep.ptAllergies = txt_ptAllergies.Text;
            if (txt_CalloutTime.TextLength > 0)
            {
                ep.prfCallouttime = TimeSpan.Parse(txt_CalloutTime.Text);
            }
            if (txt_ArrivalTime.TextLength > 0)
            {
                ep.prfArrivaltime = TimeSpan.Parse(txt_ArrivalTime.Text);
            }
            if (txt_ReleaseTime.TextLength > 0)
            {
                ep.prfReleasetime = TimeSpan.Parse(txt_ReleaseTime.Text);
            }
            ep.ptTreatment = txt_ptNotes.Text;
            ep.TreatedBy = txt_RespName.Text;
            ep.TreatedByPIN = txt_RespPin.Text;
              /*
              txt_ptComplaint.DataBindings.Add(new Binding("Text", bs_prf.DataSource, "Prf.ptComplaint"));
              txt_ptHistory.DataBindings.Add(new Binding("Text", bs_prf.DataSource, "Prf.ptHistory"));
              txt_ptMedications.DataBindings.Add(new Binding("Text", bs_prf.DataSource, "Prf.ptMeds"));
              txt_ptAllergies.DataBindings.Add(new Binding("Text", bs_prf.DataSource, "Prf.ptAllergies"));
              txt_CalloutTime.DataBindings.Add(new Binding("Text", bs_prf.DataSource, "Prf.prfCallouttime"));
              txt_ArrivalTime.DataBindings.Add(new Binding("Text", bs_prf.DataSource, "Prf.prfArrivaltime"));
              txt_ReleaseTime.DataBindings.Add(new Binding("Text", bs_prf.DataSource, "Prf.prfReleasetime"));
              txt_ptNotes.DataBindings.Add(new Binding("Text", bs_prf.DataSource, "Prf.ptTreatment"));
              txt_RespName.DataBindings.Add(new Binding("Text", bs_prf.DataSource, "Prf.TreatedBy"));
              txt_RespPin.DataBindings.Add(new Binding("Text", bs_prf.DataSource, "Prf.TreatedByPIN"));
              */
            /*
            txt_JobTime.DataBindings.Add(new Binding("Text", ds_prf, "Prf.prfReleasetime"));
            txt_JobNo.DataBindings.Add(new Binding("Text", ds_prf, "Prf.prfReleasetime"));
            */

            return ep;
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void bds_prfdetail_CurrentItemChanged(object sender, EventArgs e)
        {
           // int a = 0;
        }

        private void bds_prfdetail_CurrentChanged(object sender, EventArgs e)
        {
            int a = 0;
        }

        private void Prf_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!tsb_save.Enabled)
            {
                eprf_orig = load_data();
            }
            tsb_save.Enabled = true;
            tsb_new.Enabled = false;
        }



        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsb_save_Click(object sender, EventArgs e)
        {
            try
            {
                eprf_new = load_data();
                if (eprf_new != eprf_orig)
                {
                    EventPrf ps = eprf_new;
                    // save it
                    string cmdstr = "update EventPrf SET ptTitleID = " + ps.ptTitleID.ToString() + ", ptName ='" + ps.ptName + "' , ptAdd1 = '" + ps.ptAdd1 + "', ptAdd2 = '" + ps.ptAdd2 + "', ptAdd3 = '" + ps.ptAdd3 + "', ptAdd4 = '" + ps.ptAdd4 + "', ptPCode = '" + ps.ptPCode + "', ";
                    cmdstr = cmdstr + " ptTelno = '" + ps.ptTelno + "', ptAge = '" + ps.ptAge + "', ptDOB = '" + ps.ptDOB + "', ptSex = '" + ps.ptSex + "', incidentArea = '" + ps.incidentArea + "', ptComplaint = '" + ps.ptComplaint + "', ";
                    cmdstr = cmdstr + " ptMeds = '" + ps.ptMeds + "', ptAllergies = '" + ps.ptAllergies + "', ptHistory = '" + ps.ptHistory + "', ptTreatment = '" + ps.ptTreatment + "', ptTransferDischID = " + ps.ptTransferDischID.ToString() + ", TreatedByPIN = '" + ps.TreatedByPIN + "', ";
                    cmdstr = cmdstr + " TreatedBy = '" + ps.TreatedBy + "', prfDateTime = " + ps.prfCallouttime + ", Status = 'A', AuditBy = " + ps.AuditBy.ToString() + ", AuditDate = '" + DateTime.Now + "', ";
                    cmdstr = cmdstr + " ptOutcomeID = " + ps.ptOutcomeID.ToString() + ", prfCallouttime = '" + ps.prfCallouttime.ToString() + "', prfArrivaltime = '" + ps.prfArrivaltime.ToString() + "', prfReleasetime = '" + ps.prfReleasetime.ToString() + "'";
                    cmdstr = cmdstr + " WHERE(prfID = " + ps.prfID.ToString() + ")";

                    DataSet ds = prftodata(eprf_new);
                   int a = rbs.savePrf(ds,eprf_new.prfID);
                    eprf_orig = eprf_new;
                }
                  }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
        }
        private EventPrf datatoprf(DataSet ds)
        {
            EventPrf ep = new EventPrf();
            ep.prfID = Convert.ToInt32(ds.Tables["EventPrf"].Columns["prfID"].Expression);
            ep.incidentArea = ds.Tables["EventPrf"].Columns["incidentArea"].Expression;
            ep.prfArrivaltime = new TimeSpan(Convert.ToInt32(ds.Tables["EventPrf"].Columns["prfArrivalTime"].Expression.Substring(0,2)), Convert.ToInt32(ds.Tables["EventPrf"].Columns["prfArrivalTime"].Expression.Substring(3, 2)), Convert.ToInt32(ds.Tables["EventPrf"].Columns["prfArrivalTime"].Expression.Substring(5, 2)));
            ep.prfCallouttime = new TimeSpan(Convert.ToInt32(ds.Tables["EventPrf"].Columns["prfCallouttime"].Expression.Substring(0, 2)), Convert.ToInt32(ds.Tables["EventPrf"].Columns["prfCallouttime"].Expression.Substring(3, 2)), Convert.ToInt32(ds.Tables["EventPrf"].Columns["prfCallouttime"].Expression.Substring(5, 2)));
            ep.prfReleasetime = new TimeSpan(Convert.ToInt32(ds.Tables["EventPrf"].Columns["prfReleasetime"].Expression.Substring(0, 2)), Convert.ToInt32(ds.Tables["EventPrf"].Columns["prfReleasetime"].Expression.Substring(3, 2)), Convert.ToInt32(ds.Tables["EventPrf"].Columns["prfReleasetime"].Expression.Substring(5, 2)));
            ep.ptAdd1 = ds.Tables["EventPrf"].Columns["ptAdd1"].Expression;
            ep.ptAdd2 = ds.Tables["EventPrf"].Columns["ptAdd2"].Expression;
            ep.ptAdd3 = ds.Tables["EventPrf"].Columns["ptAdd3"].Expression;
            ep.ptAdd4 = ds.Tables["EventPrf"].Columns["ptAdd4"].Expression;
            ep.ptAge = ds.Tables["EventPrf"].Columns["ptAge"].Expression;
            ep.ptAllergies = ds.Tables["EventPrf"].Columns["ptAllergies"].Expression;
            ep.ptComplaint = ds.Tables["EventPrf"].Columns["ptComplaint"].Expression;
            ep.ptDOB = Convert.ToDateTime(ds.Tables["EventPrf"].Columns["ptDOB"].Expression);
            ep.ptHistory = ds.Tables["EventPrf"].Columns["ptHistory"].Expression;
            ep.ptMeds = ds.Tables["EventPrf"].Columns["ptMeds"].Expression;
            ep.ptName = ds.Tables["EventPrf"].Columns["ptName"].Expression;
            ep.ptOutcomeID = Convert.ToInt32(ds.Tables["EventPrf"].Columns["ptOutcomeID"].Expression);
            ep.ptPCode = ds.Tables["EventPrf"].Columns["ptPCode"].Expression;
            ep.ptSex = ds.Tables["EventPrf"].Columns["ptSex"].Expression;
            ep.ptTelno = ds.Tables["EventPrf"].Columns["ptTelno"].Expression;
            ep.ptTitleID = Convert.ToInt32(ds.Tables["EventPrf"].Columns["ptTitleID"].Expression);
            ep.ptTransferDischID = Convert.ToInt32(ds.Tables["EventPrf"].Columns["ptTransferDischID"].Expression);
            ep.ptTreatment = ds.Tables["EventPrf"].Columns["ptTreatment"].Expression;
            ep.TreatedBy = ds.Tables["EventPrf"].Columns["TreatedBy"].Expression;
            ep.TreatedByPIN = ds.Tables["EventPrf"].Columns["TreatedByPIN"].Expression;
            ep.AuditBy = Convert.ToInt32(ds.Tables["EventPrf"].Columns["AuditBy"].Expression);

            return ep;
        }
        private DataSet prftodata(EventPrf ps)
        {
           
            DataSet ds = ds_prf;
            ds.Tables["EventPrf"].Rows[0]["ptName"] = ps.ptName;
            ds.Tables["EventPrf"].Rows[0]["ptTitleID"] = ps.ptTitleID.ToString();
            ds.Tables["EventPrf"].Rows[0]["ptName"] = ps.ptName;
            ds.Tables["EventPrf"].Rows[0]["ptAdd1"] = ps.ptAdd1;
            ds.Tables["EventPrf"].Rows[0]["ptAdd2"] = ps.ptAdd2;
            ds.Tables["EventPrf"].Rows[0]["ptAdd3"] = ps.ptAdd3;
            ds.Tables["EventPrf"].Rows[0]["ptAdd4"] = ps.ptAdd4;
            ds.Tables["EventPrf"].Rows[0]["ptPCode"] = ps.ptPCode;
            ds.Tables["EventPrf"].Rows[0]["ptTelno"] = ps.ptTelno;
            ds.Tables["EventPrf"].Rows[0]["ptAge"] = ps.ptAge;
            ds.Tables["EventPrf"].Rows[0]["ptDOB"] = ps.ptDOB.ToString("dd/MM/yyyy");
            ds.Tables["EventPrf"].Rows[0]["ptSex"] = ps.ptSex;
            ds.Tables["EventPrf"].Rows[0]["incidentArea"] = ps.incidentArea;
            ds.Tables["EventPrf"].Rows[0]["ptComplaint"] = ps.ptComplaint;
            ds.Tables["EventPrf"].Rows[0]["ptMeds"] = ps.ptMeds;
            ds.Tables["EventPrf"].Rows[0]["ptAllergies"] = ps.ptAllergies;
            ds.Tables["EventPrf"].Rows[0]["ptHistory"] = ps.ptHistory;
            ds.Tables["EventPrf"].Rows[0]["ptTreatment"] = ps.ptTreatment;
            ds.Tables["EventPrf"].Rows[0]["ptTransferDischID"] = ps.ptTransferDischID.ToString();
            ds.Tables["EventPrf"].Rows[0]["TreatedByPIN"] = ps.TreatedByPIN.ToString();
            ds.Tables["EventPrf"].Rows[0]["TreatedBy"] = ps.TreatedBy;
            ds.Tables["EventPrf"].Rows[0]["prfDateTime"] = ps.prfCallouttime.ToString();
            ds.Tables["EventPrf"].Rows[0]["Status"] = "A";
            ds.Tables["EventPrf"].Rows[0]["AuditBy"] = "1";
            ds.Tables["EventPrf"].Rows[0]["AuditDate"] = DateTime.Now.ToString("dd/MM/yyyy");
            ds.Tables["EventPrf"].Rows[0]["ptOutcomeID"] = ps.ptOutcomeID.ToString();
            ds.Tables["EventPrf"].Rows[0]["prfCalloutTime"] = ps.prfCallouttime.ToString();
            ds.Tables["EventPrf"].Rows[0]["prfArrivalTime"] = ps.prfArrivaltime.ToString();
            ds.Tables["EventPrf"].Rows[0]["prfReleaseTime"] = ps.prfReleasetime.ToString();


      //      string st = ds_prf.EventPrf.prfCallouttimeColumn.ToString();
      //      bds_prfdetail.EndEdit();
            
      //      ds_prf.EventPrf.AcceptChanges();
      //      ds_prf.AcceptChanges();
            
         //   bool test =  bds_prfdetail.AllowEdit;
            return ds;
        }
        private void tsb_new_Click(object sender, EventArgs e)
        {
            ds_prf.EventPrf.Rows.Clear();
            bds_prfdetail.AddNew();


            // ds_prf.EventPrf.Rows.Add()
        }

        private void txt_JobNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.eventPrfTableAdapter.FillBy(this.dsref.EventPrf);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.sexTableAdapter.FillBy(this.dsref.Sex);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.jobStatusTableAdapter.FillBy(this.dsref.JobStatus);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bds_prfdetail_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            
        }

        private void bds_prfdetail_ListChanged(object sender, ListChangedEventArgs e)
        {
            int a = 0;
        }
    }
}
