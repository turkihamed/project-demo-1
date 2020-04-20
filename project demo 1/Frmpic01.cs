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
    public partial class Frmpic01 : Form
    {
        public Frmpic01()
        {
            InitializeComponent();
        }

        private void BtnLoadImage_Click(object sender, EventArgs e)
        {

            Pictry.Image = Image.FromFile("C:\\Users\\MacBook\\Desktop\\pic 1845106\\imagess.jpg");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Frmpic01_Load(object sender, EventArgs e)
        {

        }
    }
}
