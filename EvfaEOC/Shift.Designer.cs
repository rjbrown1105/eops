namespace EvfaEOC
{
    partial class Shift
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dt_shift = new System.Windows.Forms.DateTimePicker();
            this.cmb_ampm = new System.Windows.Forms.ComboBox();
            this.dg_shift = new System.Windows.Forms.DataGridView();
            this.StaffEventAvailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bds_staff = new System.Windows.Forms.BindingSource(this.components);
            this.dsref1 = new EvfaEOC.Properties.DataSources.dsref();
            this.roleDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffPINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bds_shift = new System.Windows.Forms.BindingSource(this.components);
            this.staffandRoleTableAdapter = new EvfaEOC.Properties.DataSources.dsrefTableAdapters.StaffandRoleTableAdapter();
            this.staffTableAdapter1 = new EvfaEOC.Properties.DataSources.dsrefTableAdapters.StaffTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dg_shift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_staff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsref1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_shift)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_shift
            // 
            this.dt_shift.CustomFormat = "dddd dd-MM-yyyy";
            this.dt_shift.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_shift.Location = new System.Drawing.Point(0, 0);
            this.dt_shift.Name = "dt_shift";
            this.dt_shift.Size = new System.Drawing.Size(200, 20);
            this.dt_shift.TabIndex = 0;
            this.dt_shift.ValueChanged += new System.EventHandler(this.dt_shift_ValueChanged);
            // 
            // cmb_ampm
            // 
            this.cmb_ampm.FormattingEnabled = true;
            this.cmb_ampm.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmb_ampm.Location = new System.Drawing.Point(0, 26);
            this.cmb_ampm.Name = "cmb_ampm";
            this.cmb_ampm.Size = new System.Drawing.Size(121, 21);
            this.cmb_ampm.TabIndex = 1;
            this.cmb_ampm.SelectedIndexChanged += new System.EventHandler(this.cmb_ampm_SelectedIndexChanged);
            // 
            // dg_shift
            // 
            this.dg_shift.AutoGenerateColumns = false;
            this.dg_shift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_shift.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffEventAvailID,
            this.staffIDDataGridViewTextBoxColumn,
            this.staffNameDataGridViewTextBoxColumn,
            this.roleDescDataGridViewTextBoxColumn,
            this.staffPINDataGridViewTextBoxColumn});
            this.dg_shift.DataMember = "StaffandRole";
            this.dg_shift.DataSource = this.dsref1;
            this.dg_shift.Location = new System.Drawing.Point(0, 53);
            this.dg_shift.Name = "dg_shift";
            this.dg_shift.Size = new System.Drawing.Size(297, 343);
            this.dg_shift.TabIndex = 2;
            this.dg_shift.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dg_shift.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dg_shift_RowsAdded);
            this.dg_shift.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dg_shift_UserAddedRow);
            // 
            // StaffEventAvailID
            // 
            this.StaffEventAvailID.DataPropertyName = "StaffEventAvailID";
            this.StaffEventAvailID.HeaderText = "StaffEventAvailID";
            this.StaffEventAvailID.Name = "StaffEventAvailID";
            this.StaffEventAvailID.ReadOnly = true;
            this.StaffEventAvailID.Visible = false;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // staffNameDataGridViewTextBoxColumn
            // 
            this.staffNameDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffNameDataGridViewTextBoxColumn.DataSource = this.bds_staff;
            this.staffNameDataGridViewTextBoxColumn.DisplayMember = "StaffName";
            this.staffNameDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.staffNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.staffNameDataGridViewTextBoxColumn.MaxDropDownItems = 30;
            this.staffNameDataGridViewTextBoxColumn.Name = "staffNameDataGridViewTextBoxColumn";
            this.staffNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.staffNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.staffNameDataGridViewTextBoxColumn.ValueMember = "StaffID";
            // 
            // bds_staff
            // 
            this.bds_staff.DataMember = "Staff";
            this.bds_staff.DataSource = this.dsref1;
            // 
            // dsref1
            // 
            this.dsref1.DataSetName = "dsref";
            this.dsref1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roleDescDataGridViewTextBoxColumn
            // 
            this.roleDescDataGridViewTextBoxColumn.DataPropertyName = "RoleDesc";
            this.roleDescDataGridViewTextBoxColumn.HeaderText = "RoleDesc";
            this.roleDescDataGridViewTextBoxColumn.Name = "roleDescDataGridViewTextBoxColumn";
            // 
            // staffPINDataGridViewTextBoxColumn
            // 
            this.staffPINDataGridViewTextBoxColumn.DataPropertyName = "StaffPIN";
            this.staffPINDataGridViewTextBoxColumn.FillWeight = 50F;
            this.staffPINDataGridViewTextBoxColumn.HeaderText = "StaffPIN";
            this.staffPINDataGridViewTextBoxColumn.MaxInputLength = 4;
            this.staffPINDataGridViewTextBoxColumn.Name = "staffPINDataGridViewTextBoxColumn";
            this.staffPINDataGridViewTextBoxColumn.Width = 50;
            // 
            // bds_shift
            // 
            this.bds_shift.DataMember = "StaffandRole";
            this.bds_shift.DataSource = this.dsref1;
            this.bds_shift.DataError += new System.Windows.Forms.BindingManagerDataErrorEventHandler(this.bds_shift_DataError);
            // 
            // staffandRoleTableAdapter
            // 
            this.staffandRoleTableAdapter.ClearBeforeFill = true;
            // 
            // staffTableAdapter1
            // 
            this.staffTableAdapter1.ClearBeforeFill = true;
            // 
            // Shift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dg_shift);
            this.Controls.Add(this.cmb_ampm);
            this.Controls.Add(this.dt_shift);
            this.Name = "Shift";
            this.Size = new System.Drawing.Size(297, 396);
            this.Load += new System.EventHandler(this.Shift_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.Shift_Layout);
            ((System.ComponentModel.ISupportInitialize)(this.dg_shift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_staff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsref1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_shift)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_shift;
        private System.Windows.Forms.ComboBox cmb_ampm;
        private System.Windows.Forms.DataGridView dg_shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffCodeDataGridViewTextBoxColumn;
        private Properties.DataSources.dsref dsref1;
        private System.Windows.Forms.BindingSource bds_shift;
        private Properties.DataSources.dsrefTableAdapters.StaffandRoleTableAdapter staffandRoleTableAdapter;
        private Properties.DataSources.dsrefTableAdapters.StaffTableAdapter staffTableAdapter1;
        private System.Windows.Forms.BindingSource bds_staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffEventAvailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn staffNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffPINDataGridViewTextBoxColumn;
    }
}
