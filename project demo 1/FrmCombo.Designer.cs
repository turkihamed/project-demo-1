using System;

namespace project_demo_1
{
    partial class FrmCombo
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
            this.BtnShowSelectedMethod1 = new System.Windows.Forms.Button();
            this.BtnShowSelectedMethod2 = new System.Windows.Forms.Button();
            this.BtnRemoveLastItem = new System.Windows.Forms.Button();
            this.BtnRemove2ndLastItem = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnRemoveByName = new System.Windows.Forms.Button();
            this.BtnRemoveByIndex = new System.Windows.Forms.Button();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.BtnShowSelectedMethod3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnShowSelectedMethod1
            // 
            this.BtnShowSelectedMethod1.Location = new System.Drawing.Point(37, 60);
            this.BtnShowSelectedMethod1.Name = "BtnShowSelectedMethod1";
            this.BtnShowSelectedMethod1.Size = new System.Drawing.Size(270, 75);
            this.BtnShowSelectedMethod1.TabIndex = 0;
            this.BtnShowSelectedMethod1.Text = "Show Selected Method1";
            this.BtnShowSelectedMethod1.UseVisualStyleBackColor = true;
            this.BtnShowSelectedMethod1.Click += new System.EventHandler(this.BtnShowSelectedMethod1_Click);
            // 
            // BtnShowSelectedMethod2
            // 
            this.BtnShowSelectedMethod2.Location = new System.Drawing.Point(313, 60);
            this.BtnShowSelectedMethod2.Name = "BtnShowSelectedMethod2";
            this.BtnShowSelectedMethod2.Size = new System.Drawing.Size(319, 75);
            this.BtnShowSelectedMethod2.TabIndex = 1;
            this.BtnShowSelectedMethod2.Text = "Show Selected Method2";
            this.BtnShowSelectedMethod2.UseVisualStyleBackColor = true;
            this.BtnShowSelectedMethod2.Click += new System.EventHandler(this.BtnShowSelectedMethod2_Click);
            // 
            // BtnRemoveLastItem
            // 
            this.BtnRemoveLastItem.Location = new System.Drawing.Point(1362, 94);
            this.BtnRemoveLastItem.Name = "BtnRemoveLastItem";
            this.BtnRemoveLastItem.Size = new System.Drawing.Size(173, 113);
            this.BtnRemoveLastItem.TabIndex = 2;
            this.BtnRemoveLastItem.Text = "Remove Last Item";
            this.BtnRemoveLastItem.UseVisualStyleBackColor = true;
            this.BtnRemoveLastItem.Click += new System.EventHandler(this.BtnRemoveLastItem_Click);
            // 
            // BtnRemove2ndLastItem
            // 
            this.BtnRemove2ndLastItem.Location = new System.Drawing.Point(1362, 258);
            this.BtnRemove2ndLastItem.Name = "BtnRemove2ndLastItem";
            this.BtnRemove2ndLastItem.Size = new System.Drawing.Size(173, 113);
            this.BtnRemove2ndLastItem.TabIndex = 3;
            this.BtnRemove2ndLastItem.Text = "Remove 2nd Last Item";
            this.BtnRemove2ndLastItem.UseVisualStyleBackColor = true;
            this.BtnRemove2ndLastItem.Click += new System.EventHandler(this.BtnRemove2ndLastItem_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(1017, 577);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(157, 48);
            this.BtnBack.TabIndex = 4;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnRemoveByName
            // 
            this.BtnRemoveByName.Location = new System.Drawing.Point(376, 438);
            this.BtnRemoveByName.Name = "BtnRemoveByName";
            this.BtnRemoveByName.Size = new System.Drawing.Size(247, 87);
            this.BtnRemoveByName.TabIndex = 5;
            this.BtnRemoveByName.Text = "Remove By Name";
            this.BtnRemoveByName.UseVisualStyleBackColor = true;
            this.BtnRemoveByName.Click += new System.EventHandler(this.BtnRemoveByName_Click);
            // 
            // BtnRemoveByIndex
            // 
            this.BtnRemoveByIndex.Location = new System.Drawing.Point(52, 438);
            this.BtnRemoveByIndex.Name = "BtnRemoveByIndex";
            this.BtnRemoveByIndex.Size = new System.Drawing.Size(278, 87);
            this.BtnRemoveByIndex.TabIndex = 6;
            this.BtnRemoveByIndex.Text = "Remove By Index";
            this.BtnRemoveByIndex.UseVisualStyleBackColor = true;
            this.BtnRemoveByIndex.Click += new System.EventHandler(this.BtnRemoveByIndex_Click);
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(236, 211);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(274, 33);
            this.CmbDays.TabIndex = 7;
            this.CmbDays.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnShowSelectedMethod3
            // 
            this.BtnShowSelectedMethod3.Location = new System.Drawing.Point(638, 60);
            this.BtnShowSelectedMethod3.Name = "BtnShowSelectedMethod3";
            this.BtnShowSelectedMethod3.Size = new System.Drawing.Size(394, 75);
            this.BtnShowSelectedMethod3.TabIndex = 8;
            this.BtnShowSelectedMethod3.Text = "Show Selected Method3";
            this.BtnShowSelectedMethod3.UseVisualStyleBackColor = true;
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 665);
            this.Controls.Add(this.BtnShowSelectedMethod3);
            this.Controls.Add(this.CmbDays);
            this.Controls.Add(this.BtnRemoveByIndex);
            this.Controls.Add(this.BtnRemoveByName);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnRemove2ndLastItem);
            this.Controls.Add(this.BtnRemoveLastItem);
            this.Controls.Add(this.BtnShowSelectedMethod2);
            this.Controls.Add(this.BtnShowSelectedMethod1);
            this.Name = "FrmCombo";
            this.Text = "FrmCombo";
            this.Load += new System.EventHandler(this.FrmCombo_Load);
            this.ResumeLayout(false);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button BtnShowSelectedMethod1;
        private System.Windows.Forms.Button BtnShowSelectedMethod2;
        private System.Windows.Forms.Button BtnRemoveLastItem;
        private System.Windows.Forms.Button BtnRemove2ndLastItem;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnRemoveByName;
        private System.Windows.Forms.Button BtnRemoveByIndex;
        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.Button BtnShowSelectedMethod3;
    }
}