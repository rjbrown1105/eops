using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvfaEOC
{
    public partial class Srch : Form
    {
        public Srch()
        {
            InitializeComponent();
        }
        public Srch(string stype)
        {
            InitializeComponent();
            label1.Visible = false;
            txt_srch1.Visible = false;
            label2a.Visible = false;
            txt_srch2a.Visible = false;
            label2b.Visible = false;
            txt_srch2b.Visible = false;
            label4.Visible = false;
            chk_srch1.Visible = false;
            switch (stype)
            {
                case "Event":
                    {
                        Srch.ActiveForm.Text = "Event Search";
                        label1.Text = "Event Name or Code";
                        label2a.Text = "Start Date";
                        label2b.Text = "End Date";
                        txt_srch1.Visible = true;
                        txt_srch2a.Visible = true;
                        txt_srch2b.Visible = true;
                        label1.Visible = true;
                        label2a.Visible = true;
                        label2b.Visible = true;
                        break;
                    }
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_srch_Click(object sender, EventArgs e)
        {
            evfawr.evfawsa rb = new evfawr.evfawsa();
            DataSet ds=rb.SearchEvents("all", Convert.ToDateTime("1900-01-01"), Convert.ToDateTime("1900-01-01"), false);
           // dg_srch.Columns.Add("EventID", "ID");
           // dg_srch.Columns.Add("EventCode", "Code");
           // dg_srch.Columns.Add("EventName", "Name");
            dg_srch.AutoGenerateColumns = true;
            dg_srch.DataSource = ds;
            dg_srch.DataMember = "EventHdr";
        }

        private void txt_srch2a_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
