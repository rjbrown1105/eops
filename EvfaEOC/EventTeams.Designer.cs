namespace EvfaEOC
{
    partial class EventTeams
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dg_evTeams = new System.Windows.Forms.DataGridView();
            this.dsref1 = new EvfaEOC.Properties.DataSources.dsref();
            this.bs_eventTeams = new System.Windows.Forms.BindingSource(this.components);
            this.eventTeamStatusTableAdapter = new EvfaEOC.Properties.DataSources.dsrefTableAdapters.EventTeamStatusTableAdapter();
            this.bs_teams = new System.Windows.Forms.BindingSource(this.components);
            this.teamsTableAdapter = new EvfaEOC.Properties.DataSources.dsrefTableAdapters.TeamsTableAdapter();
            this.bs_location = new System.Windows.Forms.BindingSource(this.components);
            this.eventLocationTableAdapter = new EvfaEOC.Properties.DataSources.dsrefTableAdapters.EventLocationTableAdapter();
            this.bs_teamstatus = new System.Windows.Forms.BindingSource(this.components);
            this.teamStatusTableAdapter = new EvfaEOC.Properties.DataSources.dsrefTableAdapters.TeamStatusTableAdapter();
            this.eventIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.locationNowIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.locationNowTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationNextIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.locationNextTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamStatusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_evTeams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsref1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_eventTeams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_teams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_location)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_teamstatus)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(669, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dg_evTeams
            // 
            this.dg_evTeams.AllowUserToAddRows = false;
            this.dg_evTeams.AllowUserToDeleteRows = false;
            this.dg_evTeams.AutoGenerateColumns = false;
            this.dg_evTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_evTeams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventIDDataGridViewTextBoxColumn,
            this.teamIDDataGridViewTextBoxColumn,
            this.locationNowIDDataGridViewTextBoxColumn,
            this.locationNowTimeDataGridViewTextBoxColumn,
            this.locationNextIDDataGridViewTextBoxColumn,
            this.locationNextTimeDataGridViewTextBoxColumn,
            this.teamStatusIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.auditByDataGridViewTextBoxColumn,
            this.auditDateDataGridViewTextBoxColumn});
            this.dg_evTeams.DataMember = "TeamRota";
            this.dg_evTeams.DataSource = this.dsref1;
            this.dg_evTeams.Location = new System.Drawing.Point(0, 28);
            this.dg_evTeams.Name = "dg_evTeams";
            this.dg_evTeams.Size = new System.Drawing.Size(669, 257);
            this.dg_evTeams.TabIndex = 1;
            this.dg_evTeams.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dg_evTeams_DataError);
            // 
            // dsref1
            // 
            this.dsref1.DataSetName = "dsref";
            this.dsref1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bs_eventTeams
            // 
            this.bs_eventTeams.DataMember = "EventTeamStatus";
            this.bs_eventTeams.DataSource = this.dsref1;
            this.bs_eventTeams.Filter = "EventID=1";
            // 
            // eventTeamStatusTableAdapter
            // 
            this.eventTeamStatusTableAdapter.ClearBeforeFill = true;
            // 
            // bs_teams
            // 
            this.bs_teams.DataMember = "Teams";
            this.bs_teams.DataSource = this.dsref1;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // bs_location
            // 
            this.bs_location.DataMember = "EventLocation";
            this.bs_location.DataSource = this.dsref1;
            // 
            // eventLocationTableAdapter
            // 
            this.eventLocationTableAdapter.ClearBeforeFill = true;
            // 
            // bs_teamstatus
            // 
            this.bs_teamstatus.DataMember = "TeamStatus";
            this.bs_teamstatus.DataSource = this.dsref1;
            // 
            // teamStatusTableAdapter
            // 
            this.teamStatusTableAdapter.ClearBeforeFill = true;
            // 
            // eventIDDataGridViewTextBoxColumn
            // 
            this.eventIDDataGridViewTextBoxColumn.DataPropertyName = "EventID";
            this.eventIDDataGridViewTextBoxColumn.HeaderText = "EventID";
            this.eventIDDataGridViewTextBoxColumn.Name = "eventIDDataGridViewTextBoxColumn";
            this.eventIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // teamIDDataGridViewTextBoxColumn
            // 
            this.teamIDDataGridViewTextBoxColumn.DataPropertyName = "TeamID";
            this.teamIDDataGridViewTextBoxColumn.DataSource = this.dsref1;
            this.teamIDDataGridViewTextBoxColumn.DisplayMember = "Teams.TeamDesc";
            this.teamIDDataGridViewTextBoxColumn.HeaderText = "Team";
            this.teamIDDataGridViewTextBoxColumn.Name = "teamIDDataGridViewTextBoxColumn";
            this.teamIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teamIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teamIDDataGridViewTextBoxColumn.ValueMember = "Teams.TeamID";
            // 
            // locationNowIDDataGridViewTextBoxColumn
            // 
            this.locationNowIDDataGridViewTextBoxColumn.DataPropertyName = "LocationNowID";
            this.locationNowIDDataGridViewTextBoxColumn.DataSource = this.dsref1;
            this.locationNowIDDataGridViewTextBoxColumn.DisplayMember = "EventLocation.LocationName";
            this.locationNowIDDataGridViewTextBoxColumn.HeaderText = "Location Now";
            this.locationNowIDDataGridViewTextBoxColumn.Name = "locationNowIDDataGridViewTextBoxColumn";
            this.locationNowIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.locationNowIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.locationNowIDDataGridViewTextBoxColumn.ValueMember = "EventLocation.LocationID";
            // 
            // locationNowTimeDataGridViewTextBoxColumn
            // 
            this.locationNowTimeDataGridViewTextBoxColumn.DataPropertyName = "LocationNowTime";
            this.locationNowTimeDataGridViewTextBoxColumn.HeaderText = "LocationNowTime";
            this.locationNowTimeDataGridViewTextBoxColumn.Name = "locationNowTimeDataGridViewTextBoxColumn";
            // 
            // locationNextIDDataGridViewTextBoxColumn
            // 
            this.locationNextIDDataGridViewTextBoxColumn.DataPropertyName = "LocationNextID";
            this.locationNextIDDataGridViewTextBoxColumn.DataSource = this.dsref1;
            this.locationNextIDDataGridViewTextBoxColumn.DisplayMember = "EventLocation.LocationName";
            this.locationNextIDDataGridViewTextBoxColumn.HeaderText = "Location Next";
            this.locationNextIDDataGridViewTextBoxColumn.Name = "locationNextIDDataGridViewTextBoxColumn";
            this.locationNextIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.locationNextIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.locationNextIDDataGridViewTextBoxColumn.ValueMember = "EventLocation.LocationID";
            // 
            // locationNextTimeDataGridViewTextBoxColumn
            // 
            this.locationNextTimeDataGridViewTextBoxColumn.DataPropertyName = "LocationNextTime";
            this.locationNextTimeDataGridViewTextBoxColumn.HeaderText = "LocationNextTime";
            this.locationNextTimeDataGridViewTextBoxColumn.Name = "locationNextTimeDataGridViewTextBoxColumn";
            // 
            // teamStatusIDDataGridViewTextBoxColumn
            // 
            this.teamStatusIDDataGridViewTextBoxColumn.DataPropertyName = "TeamStatusID";
            this.teamStatusIDDataGridViewTextBoxColumn.DataSource = this.dsref1;
            this.teamStatusIDDataGridViewTextBoxColumn.DisplayMember = "TeamStatus.TeamStatus";
            this.teamStatusIDDataGridViewTextBoxColumn.HeaderText = "TeamStatus";
            this.teamStatusIDDataGridViewTextBoxColumn.Name = "teamStatusIDDataGridViewTextBoxColumn";
            this.teamStatusIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teamStatusIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teamStatusIDDataGridViewTextBoxColumn.ValueMember = "TeamStatus.TeamStatusID";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // auditByDataGridViewTextBoxColumn
            // 
            this.auditByDataGridViewTextBoxColumn.DataPropertyName = "AuditBy";
            this.auditByDataGridViewTextBoxColumn.HeaderText = "AuditBy";
            this.auditByDataGridViewTextBoxColumn.Name = "auditByDataGridViewTextBoxColumn";
            this.auditByDataGridViewTextBoxColumn.Visible = false;
            // 
            // auditDateDataGridViewTextBoxColumn
            // 
            this.auditDateDataGridViewTextBoxColumn.DataPropertyName = "AuditDate";
            this.auditDateDataGridViewTextBoxColumn.HeaderText = "AuditDate";
            this.auditDateDataGridViewTextBoxColumn.Name = "auditDateDataGridViewTextBoxColumn";
            this.auditDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // EventTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 288);
            this.Controls.Add(this.dg_evTeams);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EventTeams";
            this.Text = "EventTeams";
            this.Load += new System.EventHandler(this.EventTeams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_evTeams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsref1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_eventTeams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_teams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_location)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_teamstatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dg_evTeams;
        private Properties.DataSources.dsref dsref1;
        private System.Windows.Forms.BindingSource bs_eventTeams;
        private Properties.DataSources.dsrefTableAdapters.EventTeamStatusTableAdapter eventTeamStatusTableAdapter;
        private System.Windows.Forms.BindingSource bs_teams;
        private Properties.DataSources.dsrefTableAdapters.TeamsTableAdapter teamsTableAdapter;
        private System.Windows.Forms.BindingSource bs_location;
        private Properties.DataSources.dsrefTableAdapters.EventLocationTableAdapter eventLocationTableAdapter;
        private System.Windows.Forms.BindingSource bs_teamstatus;
        private Properties.DataSources.dsrefTableAdapters.TeamStatusTableAdapter teamStatusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn locationNowIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationNowTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn locationNextIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationNextTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamStatusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditDateDataGridViewTextBoxColumn;
    }
}