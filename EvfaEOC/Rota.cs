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
    public partial class Rota : Form
    {
        public evfawr.evfawsa rb;
        private int evid;
        public int EventID
        {
            get { return evid; }
            set { evid = value; }
        }
        public Rota(int eventid)
        {
            InitializeComponent();
            rb = new evfawr.evfawsa();
            this.Text = rb.getEventCodeName(eventid);
            string sd = rb.getEventStartDateTime(eventid, "S");
            string ed = rb.getEventStartDateTime(eventid, "E");
            
            DateTime d1 = Convert.ToDateTime(sd);
            DateTime d2 = Convert.ToDateTime(ed);
            int a = (d2 - d1).Days;
            tc_rota.TabPages.Clear();
            for (int i = 0; i < a+1; i++)
            {
                
                tc_rota.TabPages.Add("tp" + i.ToString().Trim(), Convert.ToString(d1.AddDays(i)).Substring(0,10));
                RotaDay rd = new RotaDay();
                rd.EventID = eventid;
                rd.ShiftDate = d1.AddDays(i);
                tc_rota.TabPages[i].Controls.Add(rd);

                /* FlowLayoutPanel flp = new FlowLayoutPanel();
                flp.Width = tc_rota.Width;
                flp.Height = tc_rota.Height;
                tc_rota.TabPages[i].Controls.Add( flp);
                Shift s1 = new Shift();
                
                s1.EventID = eventid;
                s1.ShiftDate = d1.AddDays(i);
                s1.AMPM = "A";
                s1.Name = "sh_" + i.ToString().Trim() + "1";
                flp.Controls.Add(s1);
                s1.Show();
                s1.Refresh();

                Shift s2 = new Shift();
                s2.EventID = eventid;
                s2.ShiftDate = d1.AddDays(i);
                s2.AMPM = "P";
                s2.Name = "sh_" + i.ToString().Trim() + "2";
                flp.Controls.Add(s2);
                s2.Show();
                s2.Refresh();
                */



            }
            int b = 0;
        }
    }
}
