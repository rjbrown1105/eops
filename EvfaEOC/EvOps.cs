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
    public partial class EvOps : Form
    {
        private int childFormNumber = 0;
        private int evid;
        public int EventID
        {
            get { return evid; }
            set { evid = value; }
        }

        public EvOps()
        {
            InitializeComponent();
            
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void EvOps_Load(object sender, EventArgs e)
        {

        }

        private void jobsViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EventID == 0)
            {
                setevent();
            }
  /*          EvSrch ev = new EvSrch();
                //ev.MdiParent = this;
            if (ev.ShowDialog() == DialogResult.OK)
            {
              this.EventID = ev.evsel;
                evid = ev.evsel;
            }
            ev.Close();*/
                JobsView evJobsView = new JobsView(EventID);
                // Set the Parent Form of the Child window.
                if (!CheckMdiChildren(evJobsView))
                {
                    evJobsView.MdiParent = this;
                // Display the new form.
                evJobsView.Dock = DockStyle.Left & DockStyle.Top;
                evJobsView.Width = evJobsView.MdiParent.Width;
                evfawr.evfawsa rb = new evfawr.evfawsa();

                evJobsView.Text = rb.getEventCodeName(EventID);
                evJobsView.Show();
                }

        }
        private bool CheckMdiChildren(Form form)
        {
            bool present = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == form.GetType())
                {

                    present = true;
                }
            }
            return (present);


        }

        private void prfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prf eprf = new Prf();
            //JobsView evJobsView = new JobsView(EventID);
            // Set the Parent Form of the Child window.

                eprf.MdiParent = this;
                // Display the new form.
                eprf.Dock = DockStyle.Left & DockStyle.Top;
                eprf.Width = eprf.MdiParent.Width;

                eprf.Show();
            }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff st = new Staff();
            st.MdiParent = this;
            st.Show();
        }

        private void rotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EventID == 0)
            {
                setevent();
            }
            Rota rt = new Rota(EventID);
            rt.MdiParent = this;
            rt.EventID = this.EventID;
            rt.Show();
        }
        public void setevent()
        {
                    EvSrch ev = new EvSrch();
                //ev.MdiParent = this;
            if (ev.ShowDialog() == DialogResult.OK)
            {
              this.EventID = ev.evsel;
                evid = ev.evsel;
            }
            ev.Close();
         }

        private void EvOps_ResizeEnd(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Center;
            this.Refresh();
        }

        private void EvOps_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void teamManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EventID == 0)
            {
                setevent();
            }
            EventTeams et = new EventTeams(EventID);
            et.MdiParent = this;
            // Display the new form.
            et.Dock = DockStyle.Left & DockStyle.Bottom;
           // et.Width = et.MdiParent.Width;

            et.Show();
        }
    }
}
