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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
            staffTableAdapter.Fill(dsref1.Staff);
            
        }

        private void Staff_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'dsref1.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.dsref1.Staff);
            // TODO: This line of code loads data into the 'dsref1.Roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.dsref1.Roles);

        }
    }
}
