namespace EvfaEOC
{
    partial class EvSrch
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
            this.dg_srch = new System.Windows.Forms.DataGridView();
            this.eventIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventStartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventEndTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evsrchbs = new System.Windows.Forms.BindingSource(this.components);
            this.evfads1 = new EvfaEOC.Properties.DataSources.evfads();
            this.chk_pastevents = new System.Windows.Forms.CheckBox();
            this.eventHdrTableAdapter = new EvfaEOC.Properties.DataSources.evfadsTableAdapters.EventHdrTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dg_srch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evsrchbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evfads1)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_srch
            // 
            this.dg_srch.AllowUserToAddRows = false;
            this.dg_srch.AllowUserToDeleteRows = false;
            this.dg_srch.AllowUserToOrderColumns = true;
            this.dg_srch.AllowUserToResizeRows = false;
            this.dg_srch.AutoGenerateColumns = false;
            this.dg_srch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_srch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventIDDataGridViewTextBoxColumn,
            this.eventCodeDataGridViewTextBoxColumn,
            this.eventNameDataGridViewTextBoxColumn,
            this.eventStartDateDataGridViewTextBoxColumn,
            this.eventStartTimeDataGridViewTextBoxColumn,
            this.eventEndDateDataGridViewTextBoxColumn,
            this.eventEndTimeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.auditByDataGridViewTextBoxColumn,
            this.auditDateDataGridViewTextBoxColumn});
            this.dg_srch.DataSource = this.evsrchbs;
            this.dg_srch.Location = new System.Drawing.Point(3, 30);
            this.dg_srch.MultiSelect = false;
            this.dg_srch.Name = "dg_srch";
            this.dg_srch.ReadOnly = true;
            this.dg_srch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dg_srch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_srch.Size = new System.Drawing.Size(838, 150);
            this.dg_srch.TabIndex = 0;
            this.dg_srch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_srch_CellClick);
            this.dg_srch.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_srch_RowEnter);
            this.dg_srch.SelectionChanged += new System.EventHandler(this.dg_srch_SelectionChanged);
            this.dg_srch.Click += new System.EventHandler(this.dg_srch_Click);
            // 
            // eventIDDataGridViewTextBoxColumn
            // 
            this.eventIDDataGridViewTextBoxColumn.DataPropertyName = "EventID";
            this.eventIDDataGridViewTextBoxColumn.HeaderText = "EventID";
            this.eventIDDataGridViewTextBoxColumn.Name = "eventIDDataGridViewTextBoxColumn";
            this.eventIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eventCodeDataGridViewTextBoxColumn
            // 
            this.eventCodeDataGridViewTextBoxColumn.DataPropertyName = "EventCode";
            this.eventCodeDataGridViewTextBoxColumn.HeaderText = "EventCode";
            this.eventCodeDataGridViewTextBoxColumn.Name = "eventCodeDataGridViewTextBoxColumn";
            // 
            // eventNameDataGridViewTextBoxColumn
            // 
            this.eventNameDataGridViewTextBoxColumn.DataPropertyName = "EventName";
            this.eventNameDataGridViewTextBoxColumn.HeaderText = "EventName";
            this.eventNameDataGridViewTextBoxColumn.Name = "eventNameDataGridViewTextBoxColumn";
            // 
            // eventStartDateDataGridViewTextBoxColumn
            // 
            this.eventStartDateDataGridViewTextBoxColumn.DataPropertyName = "EventStartDate";
            this.eventStartDateDataGridViewTextBoxColumn.HeaderText = "EventStartDate";
            this.eventStartDateDataGridViewTextBoxColumn.Name = "eventStartDateDataGridViewTextBoxColumn";
            // 
            // eventStartTimeDataGridViewTextBoxColumn
            // 
            this.eventStartTimeDataGridViewTextBoxColumn.DataPropertyName = "EventStartTime";
            this.eventStartTimeDataGridViewTextBoxColumn.HeaderText = "EventStartTime";
            this.eventStartTimeDataGridViewTextBoxColumn.Name = "eventStartTimeDataGridViewTextBoxColumn";
            // 
            // eventEndDateDataGridViewTextBoxColumn
            // 
            this.eventEndDateDataGridViewTextBoxColumn.DataPropertyName = "EventEndDate";
            this.eventEndDateDataGridViewTextBoxColumn.HeaderText = "EventEndDate";
            this.eventEndDateDataGridViewTextBoxColumn.Name = "eventEndDateDataGridViewTextBoxColumn";
            // 
            // eventEndTimeDataGridViewTextBoxColumn
            // 
            this.eventEndTimeDataGridViewTextBoxColumn.DataPropertyName = "EventEndTime";
            this.eventEndTimeDataGridViewTextBoxColumn.HeaderText = "EventEndTime";
            this.eventEndTimeDataGridViewTextBoxColumn.Name = "eventEndTimeDataGridViewTextBoxColumn";
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
            // evsrchbs
            // 
            this.evsrchbs.AllowNew = false;
            this.evsrchbs.DataMember = "EventHdr";
            this.evsrchbs.DataSource = this.evfads1;
            // 
            // evfads1
            // 
            this.evfads1.DataSetName = "evfads";
            this.evfads1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chk_pastevents
            // 
            this.chk_pastevents.AutoSize = true;
            this.chk_pastevents.Location = new System.Drawing.Point(563, 7);
            this.chk_pastevents.Name = "chk_pastevents";
            this.chk_pastevents.Size = new System.Drawing.Size(121, 17);
            this.chk_pastevents.TabIndex = 1;
            this.chk_pastevents.Text = "Include Past Events";
            this.chk_pastevents.UseVisualStyleBackColor = true;
            this.chk_pastevents.CheckedChanged += new System.EventHandler(this.chk_pastevents_CheckedChanged);
            // 
            // eventHdrTableAdapter
            // 
            this.eventHdrTableAdapter.ClearBeforeFill = true;
            // 
            // EvSrch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 261);
            this.Controls.Add(this.chk_pastevents);
            this.Controls.Add(this.dg_srch);
            this.Name = "EvSrch";
            this.Text = "Select Event";
            ((System.ComponentModel.ISupportInitialize)(this.dg_srch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evsrchbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evfads1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_srch;
        private System.Windows.Forms.CheckBox chk_pastevents;
        private Properties.DataSources.evfads evfads1;
        private System.Windows.Forms.BindingSource evsrchbs;
        private Properties.DataSources.evfadsTableAdapters.EventHdrTableAdapter eventHdrTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventStartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventEndTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditDateDataGridViewTextBoxColumn;
    }
}