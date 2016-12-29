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
    public partial class EventTeams : Form
    {
        public int evID;
        public EventTeams()
        {
            InitializeComponent();
        }
        public EventTeams(int EventID)
        {
            InitializeComponent();
            fillgrid(EventID);
            evID = EventID;
        }

        private void fillgrid(int EventID)
        {
            evfasr.evfawsaSoapClient rb = new evfasr.evfawsaSoapClient();
            
           // evfawr.evfawsa rb = new evfawr.evfawsa();
            //DataSet ds = rb.getEventJobs(EventID, 0);
            DataSet ds = rb.getTeamRota(EventID);
            // dg_srch.Columns.Add("EventID", "ID");
            // dg_srch.Columns.Add("EventCode", "Code");
            // dg_srch.Columns.Add("EventName", "Name");
            dg_evTeams.AutoGenerateColumns = false;
            dg_evTeams.DataSource = ds;
            dg_evTeams.DataMember = "TeamRota";
        }
        private void EventTeams_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsref1.TeamStatus' table. You can move, or remove it, as needed.
            this.teamStatusTableAdapter.Fill(this.dsref1.TeamStatus);
            // TODO: This line of code loads data into the 'dsref1.EventLocation' table. You can move, or remove it, as needed.
            this.eventLocationTableAdapter.Fill(this.dsref1.EventLocation);
            // TODO: This line of code loads data into the 'dsref1.Teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.dsref1.Teams);
            // TODO: This line of code loads data into the 'dsref1.EventTeamStatus' table. You can move, or remove it, as needed.
            this.eventTeamStatusTableAdapter.Fill(this.dsref1.EventTeamStatus);
            
        }

        private void dg_evTeams_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }

}
