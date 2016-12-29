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
    public partial class m_Event : Form
    {
        public m_Event()
        {
            InitializeComponent();
        }

        private void btn_srch_Click(object sender, EventArgs e)
        {
            Srch s1 = new Srch("Event");
            DialogResult res = s1.ShowDialog();
            int a = 0;
        }
    }
}
