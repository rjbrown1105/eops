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
    public partial class JobsView : Form
    {
        public int evID;
        public JobsView(int EventID)
        {
            InitializeComponent();
            fillgrid(EventID);
            evID = EventID;
        }
        private void fillgrid(int EventID)
        {
            evfawr.evfawsa rb = new evfawr.evfawsa();
            DataSet ds = rb.getEventJobs(EventID, 0);
            // dg_srch.Columns.Add("EventID", "ID");
            // dg_srch.Columns.Add("EventCode", "Code");
            // dg_srch.Columns.Add("EventName", "Name");
            dg_joblist.AutoGenerateColumns = false;
            dg_joblist.DataSource = ds;
            dg_joblist.DataMember = "EventJobsList";
        }

        private void JobsView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsref.JobStatus' table. You can move, or remove it, as needed.
            this.jobStatusTableAdapter.Fill(this.dsref.JobStatus);
            // TODO: This line of code loads data into the 'evfads1.JobData' table. You can move, or remove it, as needed.
            this.jobDataTableAdapter.Fill(this.evfads1.JobData);
            // TODO: This line of code loads data into the 'evfads1.EventJobsList' table. You can move, or remove it, as needed.
            this.eventJobsListTableAdapter.Fill(this.evfads1.EventJobsList);

        }

        private void dg_joblist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==10)
            {
                Prf p = new Prf(evID, Convert.ToInt32(dg_joblist.Rows[e.RowIndex].Cells[0].Value.ToString()), 0);
                p.MdiParent = this.MdiParent;
                p.Show();
            }
        }
    }

}
