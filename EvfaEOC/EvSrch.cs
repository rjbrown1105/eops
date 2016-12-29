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
    public partial class EvSrch : Form
    {
        public int evsel = 0;
        public EvSrch()
        {
            InitializeComponent();
            eventHdrTableAdapter.Fill(evfads1.EventHdr);
         //   TableAdapter.Fill(dsReportData.payments);
         //   dg_srch.Refresh();
            
        }

        private void eventHdrBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.evsrchbs.EndEdit();
            this.eventHdrTableAdapter.Update(this.evfads1);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               // this.eventHdrTableAdapter.Fill(this.evfads1.EventHdr, eStatusToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void chk_pastevents_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_pastevents.Checked)
            {
                evsrchbs.Filter = "";
            }
            else
            {
                evsrchbs.Filter = "Status = 'A'";
            }
        }

        private void dg_srch_Click(object sender, EventArgs e)
        {
            
          //  string a = dg_srch.SelectedRows[0].Cells[0].Value.ToString();
          //  evsel = Convert.ToInt32(evsel);
          //  this.DialogResult = DialogResult.OK;
        }

        private void dg_srch_SelectionChanged(object sender, EventArgs e)
        {


        }

        private void dg_srch_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dg_srch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string a = dg_srch.Rows[dg_srch.CurrentCell.RowIndex].Cells[0].Value.ToString();
            evsel = Convert.ToInt32(a);
            this.DialogResult = DialogResult.OK;
        }
    }
}
