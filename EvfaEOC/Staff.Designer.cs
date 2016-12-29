namespace EvfaEOC
{
    partial class Staff
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsref1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsref1 = new EvfaEOC.Properties.DataSources.dsref();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableAdapter = new EvfaEOC.Properties.DataSources.dsrefTableAdapters.RolesTableAdapter();
            this.staffTableAdapter = new EvfaEOC.Properties.DataSources.dsrefTableAdapters.StaffTableAdapter();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffRoleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.staffTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsref1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsref1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.staffCodeDataGridViewTextBoxColumn,
            this.staffNameDataGridViewTextBoxColumn,
            this.staffRoleIDDataGridViewTextBoxColumn,
            this.staffTelDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.auditByDataGridViewTextBoxColumn,
            this.auditDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dsref1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(666, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // dsref1BindingSource
            // 
            this.dsref1BindingSource.DataMember = "Staff";
            this.dsref1BindingSource.DataSource = this.dsref1;
            // 
            // dsref1
            // 
            this.dsref1.DataSetName = "dsref";
            this.dsref1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(666, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.dsref1;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffCodeDataGridViewTextBoxColumn
            // 
            this.staffCodeDataGridViewTextBoxColumn.DataPropertyName = "StaffCode";
            this.staffCodeDataGridViewTextBoxColumn.HeaderText = "StaffCode";
            this.staffCodeDataGridViewTextBoxColumn.Name = "staffCodeDataGridViewTextBoxColumn";
            // 
            // staffNameDataGridViewTextBoxColumn
            // 
            this.staffNameDataGridViewTextBoxColumn.DataPropertyName = "StaffName";
            this.staffNameDataGridViewTextBoxColumn.HeaderText = "StaffName";
            this.staffNameDataGridViewTextBoxColumn.Name = "staffNameDataGridViewTextBoxColumn";
            // 
            // staffRoleIDDataGridViewTextBoxColumn
            // 
            this.staffRoleIDDataGridViewTextBoxColumn.DataPropertyName = "StaffRoleID";
            this.staffRoleIDDataGridViewTextBoxColumn.DataSource = this.rolesBindingSource;
            this.staffRoleIDDataGridViewTextBoxColumn.DisplayMember = "RoleDesc";
            this.staffRoleIDDataGridViewTextBoxColumn.HeaderText = "StaffRoleID";
            this.staffRoleIDDataGridViewTextBoxColumn.Name = "staffRoleIDDataGridViewTextBoxColumn";
            this.staffRoleIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.staffRoleIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.staffRoleIDDataGridViewTextBoxColumn.ValueMember = "RoleID";
            // 
            // staffTelDataGridViewTextBoxColumn
            // 
            this.staffTelDataGridViewTextBoxColumn.DataPropertyName = "StaffTel";
            this.staffTelDataGridViewTextBoxColumn.HeaderText = "StaffTel";
            this.staffTelDataGridViewTextBoxColumn.Name = "staffTelDataGridViewTextBoxColumn";
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
            this.auditByDataGridViewTextBoxColumn.Visible = false;
            // 
            // auditDateDataGridViewTextBoxColumn
            // 
            this.auditDateDataGridViewTextBoxColumn.DataPropertyName = "AuditDate";
            this.auditDateDataGridViewTextBoxColumn.HeaderText = "AuditDate";
            this.auditDateDataGridViewTextBoxColumn.Name = "auditDateDataGridViewTextBoxColumn";
            this.auditDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 351);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsref1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsref1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.BindingSource dsref1BindingSource;
        private Properties.DataSources.dsref dsref1;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private Properties.DataSources.dsrefTableAdapters.RolesTableAdapter rolesTableAdapter;
        private Properties.DataSources.dsrefTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn staffRoleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditDateDataGridViewTextBoxColumn;
    }
}