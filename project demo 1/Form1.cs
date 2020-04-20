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
    public partial class Form1 : Form
    {
        string username = "Turki";
        string myPassword = "1234";

        int attempt = 1;
        int MaxAttempts = 3;

        public Form1()
        {
            InitializeComponent();

        }

        private void BtnEXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            Frmradio frm = new Frmradio();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void BtnCheckbox_Click(object sender, EventArgs e)
        {
            FrmCheck frm = new FrmCheck();
            frm.ShowDialog();
        }

        private void BtnCombo_Click(object sender, EventArgs e)
        {
            FrmCombo frm = new FrmCombo();
            frm.ShowDialog();
        }

        private void BtnPictureBox_Click(object sender, EventArgs e)
        {
            Frmpic01 frm = new Frmpic01();
            frm.ShowDialog();
        }

        private void BtnPictureBox2_Click(object sender, EventArgs e)
        {
            Frmpic02 frm = new Frmpic02();
            frm.ShowDialog();
        }

        private void BtnSelifeApp_Click(object sender, EventArgs e)
        {

        }

        private void BtnProgress_Click(object sender, EventArgs e)
        {

        }

        private void BtnJohari_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            while (attempt <= MaxAttempts)
            {
                if (TxtUser.Text != username)
                {
                    // username is incorrect
                    MessageBox.Show("Invalid username, " + (MaxAttempts - attempt) + " attempts remaining");
                    attempt++;
                    return;
                }
                else
                {   // username is correct
                    // so check password			
                    if (Txtpw.Text != "1234")
                    {
                        // Incorrect password
                        attempt++;
                        MessageBox.Show("Incorrect password," + (MaxAttempts - attempt) + " attempts remaining");
                        return;
                    }
                    else
                    {
                        //Both are correct
                        attempt = 0; // reset the number of attempts
                        MessageBox.Show("Login successful");



                        BtnLogin.Text = "Logout";
                        
                        // this.Width = 1600;
                        break; // come out of while loop
                    }//endif

                }//endif
            }//end while
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Txtpw_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void BtnRandomcombo_Click(object sender, EventArgs e)
        {
            FrmRandomCombo frm = new FrmRandomCombo();
            frm.ShowDialog();
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            FrmRandom frm = new FrmRandom();
            frm.ShowDialog();
        }
    }
}
