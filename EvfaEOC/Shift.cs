using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvfaEOC
{
    public partial class Shift : UserControl
    {
        private DateTime sdate;
        private string ampm="A";
        private int evid;

        public int EventID
        {
            get { return evid; }
            set { evid = value;
                load_it();
            }
        }
        public DateTime ShiftDate
        {
            get
            {
                return sdate;
            }
            set
            {
                sdate = value;
                if (sdate.Year > 1900)
                {
                    dt_shift.Value = sdate;
                    load_it();
                }
            }
        }
        public string AMPM
        {
            get { return ampm; }
            set {
                ampm = value;
                if (ampm == "A")
                {
                    cmb_ampm.SelectedItem = "AM";
                }
                else
                {
                    cmb_ampm.SelectedItem = "PM";
                }
                load_it();
            }
        }
        public Shift()
        {
            InitializeComponent();
            staffTableAdapter1.Fill(dsref1.Staff);
 /*           if (EventID > 0 && ShiftDate.Day > 0)
            {
                  staffandRoleTableAdapter.Fill(dsref1.StaffandRole, EventID, ShiftDate, AMPM);
            }*/
        }

        private void load_it()
        {
            if (evid > 0 && sdate.Year > 1900 && ampm.Length > 0)
            {
                staffandRoleTableAdapter.Fill(dsref1.StaffandRole, evid, sdate, ampm);
                bds_shift.ResetBindings(true);
                dg_shift.Refresh();
            }
        
        }
        private void dt_shift_ValueChanged(object sender, EventArgs e)
        {
            if (evid > 0 && sdate.Year > 1900)
            {
                staffandRoleTableAdapter.Fill(dsref1.StaffandRole, evid, sdate, ampm);
                bds_shift.ResetBindings(true);
                dg_shift.Refresh();
            }
            
        }

        private void cmb_ampm_SelectedIndexChanged(object sender, EventArgs e)
        {
            ampm = cmb_ampm.SelectedItem.ToString().Substring(0,1);
            if (evid > 0 && sdate.Year > 1900)
            {
                staffandRoleTableAdapter.Fill(dsref1.StaffandRole, evid, sdate, ampm);
                
                bds_shift.ResetBindings(true);
                dg_shift.Refresh();
            }
        }

        private void bds_shift_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            int a = 0;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            int a = 0;
        }

        private void Shift_Load(object sender, EventArgs e)
        {
            if (EventID > 0 && ShiftDate.Year > 1900)
            {
                staffandRoleTableAdapter.Fill(dsref1.StaffandRole, EventID, ShiftDate, AMPM);
                bds_shift.ResetBindings(false);
            }
        }

        private void Shift_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void dg_shift_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int a = 0;
        }

        private void dg_shift_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
// code here to add new row 
            int a = 0;
        }
    }
}
