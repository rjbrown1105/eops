namespace EvfaEOC
{
    partial class Srch
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_srch1 = new System.Windows.Forms.TextBox();
            this.label2a = new System.Windows.Forms.Label();
            this.txt_srch2b = new System.Windows.Forms.TextBox();
            this.label2b = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_srch2a = new System.Windows.Forms.TextBox();
            this.chk_srch1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dg_srch = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_srch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_srch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // txt_srch1
            // 
            this.txt_srch1.Location = new System.Drawing.Point(236, 14);
            this.txt_srch1.Name = "txt_srch1";
            this.txt_srch1.Size = new System.Drawing.Size(100, 20);
            this.txt_srch1.TabIndex = 1;
            // 
            // label2a
            // 
            this.label2a.AutoSize = true;
            this.label2a.Location = new System.Drawing.Point(171, 47);
            this.label2a.Name = "label2a";
            this.label2a.Size = new System.Drawing.Size(35, 13);
            this.label2a.TabIndex = 2;
            this.label2a.Text = "label2";
            // 
            // txt_srch2b
            // 
            this.txt_srch2b.Location = new System.Drawing.Point(420, 40);
            this.txt_srch2b.Name = "txt_srch2b";
            this.txt_srch2b.Size = new System.Drawing.Size(100, 20);
            this.txt_srch2b.TabIndex = 5;
            // 
            // label2b
            // 
            this.label2b.AutoSize = true;
            this.label2b.Location = new System.Drawing.Point(368, 47);
            this.label2b.Name = "label2b";
            this.label2b.Size = new System.Drawing.Size(35, 13);
            this.label2b.TabIndex = 4;
            this.label2b.Text = "label3";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(550, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txt_srch2a
            // 
            this.txt_srch2a.Location = new System.Drawing.Point(236, 40);
            this.txt_srch2a.Name = "txt_srch2a";
            this.txt_srch2a.Size = new System.Drawing.Size(100, 20);
            this.txt_srch2a.TabIndex = 7;
            this.txt_srch2a.DoubleClick += new System.EventHandler(this.txt_srch2a_DoubleClick);
            // 
            // chk_srch1
            // 
            this.chk_srch1.AutoSize = true;
            this.chk_srch1.Location = new System.Drawing.Point(236, 72);
            this.chk_srch1.Name = "chk_srch1";
            this.chk_srch1.Size = new System.Drawing.Size(15, 14);
            this.chk_srch1.TabIndex = 8;
            this.chk_srch1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // dg_srch
            // 
            this.dg_srch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_srch.Location = new System.Drawing.Point(12, 92);
            this.dg_srch.Name = "dg_srch";
            this.dg_srch.Size = new System.Drawing.Size(738, 232);
            this.dg_srch.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(675, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_srch
            // 
            this.btn_srch.Location = new System.Drawing.Point(550, 62);
            this.btn_srch.Name = "btn_srch";
            this.btn_srch.Size = new System.Drawing.Size(75, 23);
            this.btn_srch.TabIndex = 12;
            this.btn_srch.Text = "Search";
            this.btn_srch.UseVisualStyleBackColor = true;
            this.btn_srch.Click += new System.EventHandler(this.btn_srch_Click);
            // 
            // Srch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 355);
            this.Controls.Add(this.btn_srch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dg_srch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chk_srch1);
            this.Controls.Add(this.txt_srch2a);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_srch2b);
            this.Controls.Add(this.label2b);
            this.Controls.Add(this.label2a);
            this.Controls.Add(this.txt_srch1);
            this.Controls.Add(this.label1);
            this.Name = "Srch";
            this.Text = "Srch";
            ((System.ComponentModel.ISupportInitialize)(this.dg_srch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_srch1;
        private System.Windows.Forms.Label label2a;
        private System.Windows.Forms.TextBox txt_srch2b;
        private System.Windows.Forms.Label label2b;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_srch2a;
        private System.Windows.Forms.CheckBox chk_srch1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dg_srch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_srch;
    }
}