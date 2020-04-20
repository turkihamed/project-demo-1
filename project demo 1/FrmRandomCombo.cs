using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_demo_1
{
    public partial class FrmRandomCombo : Form
    {
        public FrmRandomCombo()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            ComM1.ResetText();      //Resets the Text 
            ComM1.Items.Clear();    //Removes all items from Combo
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 51); i++)
            {
                ComM1.Items.Add(r.Next(100, 999));
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {

            ComM1.ResetText();
            ComM1.Items.Clear();
            RdoLess.Checked = false;
            RdoGreater.Checked = false;
        }

        private void ComM1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Convert.ToInt32(ComM1.Text) > 499)
            {
                RdoGreater.Checked = true;
            }
            else
            {
                RdoLess.Checked = true;
            }

        }

        private void BtnGenerate2_Click(object sender, EventArgs e)
        {
            ComM2.ResetText();
            ComM2.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(2, 9) - 1; i++)
            {
                ComM2.Items.Add(r.Next(10, 99));
            }
            label1.Text = Convert.ToString(ComM2.Items.Count);
        }

        private void ComM2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ComM2.Text) > 49)
            {
                RdoGreater2.Checked = true;
            }
            else
            {
                RdoLess2.Checked = true;
            }

        }

        private void BtnReset2_Click(object sender, EventArgs e)
        {
            ComM2.ResetText();
            ComM2.Items.Clear();
            RdoLess2.Checked = false;
            RdoGreater2.Checked = false;
            label1.Text = Convert.ToString(ComM2.Items.Count);

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
