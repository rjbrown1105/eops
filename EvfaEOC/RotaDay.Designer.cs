namespace EvfaEOC
{
    partial class RotaDay
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sh1 = new EvfaEOC.Shift();
            this.sh2 = new EvfaEOC.Shift();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.sh1);
            this.flowLayoutPanel1.Controls.Add(this.sh2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(607, 406);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // sh1
            // 
            this.sh1.AMPM = "A";
            this.sh1.EventID = 0;
            this.sh1.Location = new System.Drawing.Point(3, 3);
            this.sh1.Name = "sh1";
            this.sh1.ShiftDate = new System.DateTime(2016, 8, 20, 0, 0, 0, 0);
            this.sh1.Size = new System.Drawing.Size(297, 396);
            this.sh1.TabIndex = 0;
            // 
            // sh2
            // 
            this.sh2.AMPM = "P";
            this.sh2.EventID = 0;
            this.sh2.Location = new System.Drawing.Point(306, 3);
            this.sh2.Name = "sh2";
            this.sh2.ShiftDate = new System.DateTime(((long)(0)));
            this.sh2.Size = new System.Drawing.Size(297, 396);
            this.sh2.TabIndex = 1;
            // 
            // RotaDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "RotaDay";
            this.Size = new System.Drawing.Size(613, 412);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Shift sh1;
        private Shift sh2;
    }
}
