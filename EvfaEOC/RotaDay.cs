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
    public partial class RotaDay : UserControl
    {
        private DateTime sdate;
        private int evid;

        public int EventID
        {
            get { return evid; }
            set
            {
                evid = value;
                sh1.EventID = evid;
                sh2.EventID = evid;
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
                sh1.ShiftDate = sdate;
                sh2.ShiftDate = sdate;
            }
        }
        public RotaDay()
        {
            InitializeComponent();
        }
    }
}
