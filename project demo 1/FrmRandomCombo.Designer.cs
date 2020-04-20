namespace project_demo_1
{
    partial class FrmRandomCombo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnGenerate2 = new System.Windows.Forms.Button();
            this.BtnReset2 = new System.Windows.Forms.Button();
            this.RdoLess = new System.Windows.Forms.RadioButton();
            this.RdoGreater = new System.Windows.Forms.RadioButton();
            this.ComM1 = new System.Windows.Forms.ComboBox();
            this.ComM2 = new System.Windows.Forms.ComboBox();
            this.RdoLess2 = new System.Windows.Forms.RadioButton();
            this.RdoGreater2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComM1);
            this.groupBox1.Controls.Add(this.RdoGreater);
            this.groupBox1.Controls.Add(this.RdoLess);
            this.groupBox1.Controls.Add(this.BtnReset);
            this.groupBox1.Controls.Add(this.BtnGenerate);
            this.groupBox1.Location = new System.Drawing.Point(49, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 494);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quiz03_AAF19";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.RdoGreater2);
            this.groupBox2.Controls.Add(this.RdoLess2);
            this.groupBox2.Controls.Add(this.ComM2);
            this.groupBox2.Controls.Add(this.BtnReset2);
            this.groupBox2.Controls.Add(this.BtnGenerate2);
            this.groupBox2.Location = new System.Drawing.Point(613, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 494);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quiz03_EAF19";
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(310, 84);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(115, 41);
            this.BtnGenerate.TabIndex = 0;
            this.BtnGenerate.Text = "Generate";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(310, 335);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(113, 45);
            this.BtnReset.TabIndex = 1;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnGenerate2
            // 
            this.BtnGenerate2.Location = new System.Drawing.Point(287, 92);
            this.BtnGenerate2.Name = "BtnGenerate2";
            this.BtnGenerate2.Size = new System.Drawing.Size(127, 39);
            this.BtnGenerate2.TabIndex = 0;
            this.BtnGenerate2.Text = "Generate";
            this.BtnGenerate2.UseVisualStyleBackColor = true;
            this.BtnGenerate2.Click += new System.EventHandler(this.BtnGenerate2_Click);
            // 
            // BtnReset2
            // 
            this.BtnReset2.Location = new System.Drawing.Point(271, 340);
            this.BtnReset2.Name = "BtnReset2";
            this.BtnReset2.Size = new System.Drawing.Size(121, 35);
            this.BtnReset2.TabIndex = 1;
            this.BtnReset2.Text = "Reset";
            this.BtnReset2.UseVisualStyleBackColor = true;
            this.BtnReset2.Click += new System.EventHandler(this.BtnReset2_Click);
            // 
            // RdoLess
            // 
            this.RdoLess.AutoSize = true;
            this.RdoLess.Location = new System.Drawing.Point(191, 159);
            this.RdoLess.Name = "RdoLess";
            this.RdoLess.Size = new System.Drawing.Size(179, 31);
            this.RdoLess.TabIndex = 2;
            this.RdoLess.TabStop = true;
            this.RdoLess.Text = "Less than 500";
            this.RdoLess.UseVisualStyleBackColor = true;
            // 
            // RdoGreater
            // 
            this.RdoGreater.AutoSize = true;
            this.RdoGreater.Location = new System.Drawing.Point(191, 221);
            this.RdoGreater.Name = "RdoGreater";
            this.RdoGreater.Size = new System.Drawing.Size(210, 31);
            this.RdoGreater.TabIndex = 3;
            this.RdoGreater.TabStop = true;
            this.RdoGreater.Text = "Greater than 500";
            this.RdoGreater.UseVisualStyleBackColor = true;
            // 
            // ComM1
            // 
            this.ComM1.FormattingEnabled = true;
            this.ComM1.Location = new System.Drawing.Point(19, 92);
            this.ComM1.Name = "ComM1";
            this.ComM1.Size = new System.Drawing.Size(147, 33);
            this.ComM1.TabIndex = 4;
            this.ComM1.SelectedIndexChanged += new System.EventHandler(this.ComM1_SelectedIndexChanged);
            // 
            // ComM2
            // 
            this.ComM2.FormattingEnabled = true;
            this.ComM2.Location = new System.Drawing.Point(50, 89);
            this.ComM2.Name = "ComM2";
            this.ComM2.Size = new System.Drawing.Size(121, 33);
            this.ComM2.TabIndex = 2;
            this.ComM2.SelectedIndexChanged += new System.EventHandler(this.ComM2_SelectedIndexChanged);
            // 
            // RdoLess2
            // 
            this.RdoLess2.AutoSize = true;
            this.RdoLess2.Location = new System.Drawing.Point(159, 158);
            this.RdoLess2.Name = "RdoLess2";
            this.RdoLess2.Size = new System.Drawing.Size(179, 31);
            this.RdoLess2.TabIndex = 3;
            this.RdoLess2.TabStop = true;
            this.RdoLess2.Text = "Less than 500";
            this.RdoLess2.UseVisualStyleBackColor = true;
            // 
            // RdoGreater2
            // 
            this.RdoGreater2.AutoSize = true;
            this.RdoGreater2.Location = new System.Drawing.Point(159, 221);
            this.RdoGreater2.Name = "RdoGreater2";
            this.RdoGreater2.Size = new System.Drawing.Size(210, 31);
            this.RdoGreater2.TabIndex = 4;
            this.RdoGreater2.TabStop = true;
            this.RdoGreater2.Text = "Greater than 500";
            this.RdoGreater2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Count";
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(837, 595);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(113, 38);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FrmRandomCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 661);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRandomCombo";
            this.Text = "FrmRandomCombo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdoGreater;
        private System.Windows.Forms.RadioButton RdoLess;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnReset2;
        private System.Windows.Forms.Button BtnGenerate2;
        private System.Windows.Forms.ComboBox ComM1;
        private System.Windows.Forms.RadioButton RdoGreater2;
        private System.Windows.Forms.RadioButton RdoLess2;
        private System.Windows.Forms.ComboBox ComM2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBack;
    }
}