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
    public partial class FrmCheck : Form
    {
        public FrmCheck()
        {
            InitializeComponent();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (ChkCoffee.Checked == true)
            {
                msg = ChkCoffee.Text;
            }
            
                if (ChkDount.Checked == true)
                {
                msg = msg + " "+ChkDount.Text;
            }
            if (ChkBrownie.Checked == true)
            {
                msg = msg + " " + ChkBrownie.Text;
            }
            if (msg.Length>0)
            { MessageBox.Show(msg + "ordered");

            }
            else // lenght is zero 
            {
                MessageBox.Show("Nothing ordered,sir/MmE");
            }

        }

        private void ChkDount_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmCheck_Load(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
