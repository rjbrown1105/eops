namespace EvfaEOC
{
    partial class JobsView
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
            System.Windows.Forms.BindingSource eventJobsListBindingSource;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobsView));
            this.evfads1 = new EvfaEOC.Properties.DataSources.evfads();
            this.dg_joblist = new System.Windows.Forms.DataGridView();
            this.jobStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsref = new EvfaEOC.Properties.DataSources.dsref();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.eventJobsListTableAdapter = new EvfaEOC.Properties.DataSources.evfadsTableAdapters.EventJobsListTableAdapter();
            this.jobDataTableAdapter = new EvfaEOC.Properties.DataSources.evfadsTableAdapters.JobDataTableAdapter();
            this.jobStatusTableAdapter = new EvfaEOC.Properties.DataSources.dsrefTableAdapters.JobStatusTableAdapter();
            this.EventID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventJobID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriorityDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobStatusID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PrfCount = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuditBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuditDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventJobIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobStatusDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prfCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobStatusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            eventJobsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(eventJobsListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evfads1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_joblist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsref)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventJobsListBindingSource
            // 
            eventJobsListBindingSource.DataMember = "JobData";
            eventJobsListBindingSource.DataSource = this.evfads1;
            // 
            // evfads1
            // 
            this.evfads1.DataSetName = "evfads";
            this.evfads1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dg_joblist
            // 
            this.dg_joblist.AutoGenerateColumns = false;
            this.dg_joblist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_joblist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventID,
            this.EventJobID,
            this.JobDate,
            this.JobTime,
            this.JobDescription,
            this.JobLocation,
            this.TeamCode,
            this.PriorityDesc,
            this.CatDescription,
            this.JobStatusID,
            this.PrfCount,
            this.Status,
            this.AuditBy,
            this.AuditDate,
            this.eventIDDataGridViewTextBoxColumn,
            this.eventJobIDDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.jobDescriptionDataGridViewTextBoxColumn,
            this.jobDateDataGridViewTextBoxColumn,
            this.jobTimeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.auditByDataGridViewTextBoxColumn,
            this.auditDateDataGridViewTextBoxColumn,
            this.teamCodeDataGridViewTextBoxColumn,
            this.teamDescDataGridViewTextBoxColumn,
            this.priorityDescDataGridViewTextBoxColumn,
            this.catDescriptionDataGridViewTextBoxColumn,
            this.jobStatusDescDataGridViewTextBoxColumn,
            this.prfCountDataGridViewTextBoxColumn,
            this.jobStatusIDDataGridViewTextBoxColumn});
            this.dg_joblist.DataSource = eventJobsListBindingSource;
            this.dg_joblist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_joblist.Location = new System.Drawing.Point(0, 25);
            this.dg_joblist.Name = "dg_joblist";
            this.dg_joblist.Size = new System.Drawing.Size(974, 236);
            this.dg_joblist.TabIndex = 0;
            this.dg_joblist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_joblist_CellContentClick);
            // 
            // jobStatusBindingSource
            // 
            this.jobStatusBindingSource.DataMember = "JobStatus";
            this.jobStatusBindingSource.DataSource = this.dsref;
            // 
            // dsref
            // 
            this.dsref.DataSetName = "dsref";
            this.dsref.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(974, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // eventJobsListTableAdapter
            // 
            this.eventJobsListTableAdapter.ClearBeforeFill = true;
            // 
            // jobDataTableAdapter
            // 
            this.jobDataTableAdapter.ClearBeforeFill = true;
            // 
            // jobStatusTableAdapter
            // 
            this.jobStatusTableAdapter.ClearBeforeFill = true;
            // 
            // EventID
            // 
            this.EventID.DataPropertyName = "EventID";
            this.EventID.HeaderText = "EventID";
            this.EventID.Name = "EventID";
            this.EventID.ReadOnly = true;
            this.EventID.Visible = false;
            this.EventID.Width = 50;
            // 
            // EventJobID
            // 
            this.EventJobID.DataPropertyName = "EventJobID";
            this.EventJobID.HeaderText = "JobID";
            this.EventJobID.Name = "EventJobID";
            this.EventJobID.ReadOnly = true;
            this.EventJobID.Width = 50;
            // 
            // JobDate
            // 
            this.JobDate.DataPropertyName = "JobDate";
            this.JobDate.HeaderText = "JobDate";
            this.JobDate.Name = "JobDate";
            // 
            // JobTime
            // 
            this.JobTime.DataPropertyName = "JobTime";
            this.JobTime.HeaderText = "JobTime";
            this.JobTime.Name = "JobTime";
            // 
            // JobDescription
            // 
            this.JobDescription.DataPropertyName = "JobDescription";
            this.JobDescription.FillWeight = 200F;
            this.JobDescription.HeaderText = "JobDescription";
            this.JobDescription.Name = "JobDescription";
            this.JobDescription.Width = 150;
            // 
            // JobLocation
            // 
            this.JobLocation.DataPropertyName = "Location";
            this.JobLocation.HeaderText = "Location";
            this.JobLocation.Name = "JobLocation";
            // 
            // TeamCode
            // 
            this.TeamCode.DataPropertyName = "TeamCode";
            this.TeamCode.HeaderText = "TeamCode";
            this.TeamCode.Name = "TeamCode";
            // 
            // PriorityDesc
            // 
            this.PriorityDesc.DataPropertyName = "PriorityDesc";
            this.PriorityDesc.HeaderText = "PriorityDesc";
            this.PriorityDesc.Name = "PriorityDesc";
            this.PriorityDesc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CatDescription
            // 
            this.CatDescription.DataPropertyName = "CatDescription";
            this.CatDescription.HeaderText = "CatDescription";
            this.CatDescription.Name = "CatDescription";
            this.CatDescription.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // JobStatusID
            // 
            this.JobStatusID.DataPropertyName = "JobStatusID";
            this.JobStatusID.DataSource = this.jobStatusBindingSource;
            this.JobStatusID.DisplayMember = "JobStatusDesc";
            this.JobStatusID.HeaderText = "JobStatus";
            this.JobStatusID.Name = "JobStatusID";
            this.JobStatusID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.JobStatusID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.JobStatusID.ValueMember = "JobStatusID";
            // 
            // PrfCount
            // 
            this.PrfCount.DataPropertyName = "PrfCount";
            this.PrfCount.HeaderText = "PRF(s)";
            this.PrfCount.Name = "PrfCount";
            this.PrfCount.ReadOnly = true;
            this.PrfCount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PrfCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Visible = false;
            // 
            // AuditBy
            // 
            this.AuditBy.DataPropertyName = "AuditBy";
            this.AuditBy.HeaderText = "AuditBy";
            this.AuditBy.Name = "AuditBy";
            this.AuditBy.Visible = false;
            // 
            // AuditDate
            // 
            this.AuditDate.DataPropertyName = "AuditDate";
            this.AuditDate.HeaderText = "AuditDate";
            this.AuditDate.Name = "AuditDate";
            this.AuditDate.Visible = false;
            // 
            // eventIDDataGridViewTextBoxColumn
            // 
            this.eventIDDataGridViewTextBoxColumn.DataPropertyName = "EventID";
            this.eventIDDataGridViewTextBoxColumn.HeaderText = "EventID";
            this.eventIDDataGridViewTextBoxColumn.Name = "eventIDDataGridViewTextBoxColumn";
            // 
            // eventJobIDDataGridViewTextBoxColumn
            // 
            this.eventJobIDDataGridViewTextBoxColumn.DataPropertyName = "EventJobID";
            this.eventJobIDDataGridViewTextBoxColumn.HeaderText = "EventJobID";
            this.eventJobIDDataGridViewTextBoxColumn.Name = "eventJobIDDataGridViewTextBoxColumn";
            this.eventJobIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // jobDescriptionDataGridViewTextBoxColumn
            // 
            this.jobDescriptionDataGridViewTextBoxColumn.DataPropertyName = "JobDescription";
            this.jobDescriptionDataGridViewTextBoxColumn.HeaderText = "JobDescription";
            this.jobDescriptionDataGridViewTextBoxColumn.Name = "jobDescriptionDataGridViewTextBoxColumn";
            // 
            // jobDateDataGridViewTextBoxColumn
            // 
            this.jobDateDataGridViewTextBoxColumn.DataPropertyName = "JobDate";
            this.jobDateDataGridViewTextBoxColumn.HeaderText = "JobDate";
            this.jobDateDataGridViewTextBoxColumn.Name = "jobDateDataGridViewTextBoxColumn";
            // 
            // jobTimeDataGridViewTextBoxColumn
            // 
            this.jobTimeDataGridViewTextBoxColumn.DataPropertyName = "JobTime";
            this.jobTimeDataGridViewTextBoxColumn.HeaderText = "JobTime";
            this.jobTimeDataGridViewTextBoxColumn.Name = "jobTimeDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // auditByDataGridViewTextBoxColumn
            // 
            this.auditByDataGridViewTextBoxColumn.DataPropertyName = "AuditBy";
            this.auditByDataGridViewTextBoxColumn.HeaderText = "AuditBy";
            this.auditByDataGridViewTextBoxColumn.Name = "auditByDataGridViewTextBoxColumn";
            // 
            // auditDateDataGridViewTextBoxColumn
            // 
            this.auditDateDataGridViewTextBoxColumn.DataPropertyName = "AuditDate";
            this.auditDateDataGridViewTextBoxColumn.HeaderText = "AuditDate";
            this.auditDateDataGridViewTextBoxColumn.Name = "auditDateDataGridViewTextBoxColumn";
            // 
            // teamCodeDataGridViewTextBoxColumn
            // 
            this.teamCodeDataGridViewTextBoxColumn.DataPropertyName = "TeamCode";
            this.teamCodeDataGridViewTextBoxColumn.HeaderText = "TeamCode";
            this.teamCodeDataGridViewTextBoxColumn.Name = "teamCodeDataGridViewTextBoxColumn";
            // 
            // teamDescDataGridViewTextBoxColumn
            // 
            this.teamDescDataGridViewTextBoxColumn.DataPropertyName = "TeamDesc";
            this.teamDescDataGridViewTextBoxColumn.HeaderText = "TeamDesc";
            this.teamDescDataGridViewTextBoxColumn.Name = "teamDescDataGridViewTextBoxColumn";
            // 
            // priorityDescDataGridViewTextBoxColumn
            // 
            this.priorityDescDataGridViewTextBoxColumn.DataPropertyName = "PriorityDesc";
            this.priorityDescDataGridViewTextBoxColumn.HeaderText = "PriorityDesc";
            this.priorityDescDataGridViewTextBoxColumn.Name = "priorityDescDataGridViewTextBoxColumn";
            // 
            // catDescriptionDataGridViewTextBoxColumn
            // 
            this.catDescriptionDataGridViewTextBoxColumn.DataPropertyName = "CatDescription";
            this.catDescriptionDataGridViewTextBoxColumn.HeaderText = "CatDescription";
            this.catDescriptionDataGridViewTextBoxColumn.Name = "catDescriptionDataGridViewTextBoxColumn";
            // 
            // jobStatusDescDataGridViewTextBoxColumn
            // 
            this.jobStatusDescDataGridViewTextBoxColumn.DataPropertyName = "JobStatusDesc";
            this.jobStatusDescDataGridViewTextBoxColumn.HeaderText = "JobStatusDesc";
            this.jobStatusDescDataGridViewTextBoxColumn.Name = "jobStatusDescDataGridViewTextBoxColumn";
            // 
            // prfCountDataGridViewTextBoxColumn
            // 
            this.prfCountDataGridViewTextBoxColumn.DataPropertyName = "PrfCount";
            this.prfCountDataGridViewTextBoxColumn.HeaderText = "PrfCount";
            this.prfCountDataGridViewTextBoxColumn.Name = "prfCountDataGridViewTextBoxColumn";
            this.prfCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobStatusIDDataGridViewTextBoxColumn
            // 
            this.jobStatusIDDataGridViewTextBoxColumn.DataPropertyName = "JobStatusID";
            this.jobStatusIDDataGridViewTextBoxColumn.HeaderText = "JobStatusID";
            this.jobStatusIDDataGridViewTextBoxColumn.Name = "jobStatusIDDataGridViewTextBoxColumn";
            // 
            // JobsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 261);
            this.Controls.Add(this.dg_joblist);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "JobsView";
            this.ShowInTaskbar = false;
            this.Text = "View Jobs";
            this.Load += new System.EventHandler(this.JobsView_Load);
            ((System.ComponentModel.ISupportInitialize)(eventJobsListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evfads1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_joblist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsref)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_joblist;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private Properties.DataSources.evfads evfads1;
        private Properties.DataSources.evfadsTableAdapters.EventJobsListTableAdapter eventJobsListTableAdapter;
        private Properties.DataSources.evfadsTableAdapters.JobDataTableAdapter jobDataTableAdapter;
        private Properties.DataSources.dsref dsref;
        private System.Windows.Forms.BindingSource jobStatusBindingSource;
        private Properties.DataSources.dsrefTableAdapters.JobStatusTableAdapter jobStatusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventJobID;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriorityDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatDescription;
        private System.Windows.Forms.DataGridViewComboBoxColumn JobStatusID;
        private System.Windows.Forms.DataGridViewButtonColumn PrfCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuditBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuditDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventJobIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobStatusDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prfCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobStatusIDDataGridViewTextBoxColumn;
    }
}