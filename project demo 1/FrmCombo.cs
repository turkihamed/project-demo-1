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
    public partial class FrmCombo : Form
    {
        public FrmCombo()
        {
            InitializeComponent();
            CmbDays.Items.Add("Sunday");
            CmbDays.Items.Add("Monday");
            CmbDays.Items.Add("Tuesday");
            CmbDays.Items.Add("Wendesday");
            CmbDays.Items.Add("Thursday");
            CmbDays.Items.Add("Friday");
            CmbDays.Items.Add("Saturday");

        }

        private void BtnRemoveByName_Click(object sender, EventArgs e)
        {
            //remove item by giving a specified item by name .
            CmbDays.Items.Remove("Friday");
        }

        private void BtnRemove2ndLastItem_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 2)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 2);
            }
            else
            {
                MessageBox.Show("Cant remove 2nd last item");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnShowSelectedMethod1_Click(object sender, EventArgs e)
        {
            //using Method1
            MessageBox.Show(CmbDays.Text);


        }

        private void FrmCombo_Load(object sender, EventArgs e)
        {

        }

        private void BtnShowSelectedMethod2_Click(object sender, EventArgs e)
        {
            //Method2
            var item = CmbDays.GetItemText(this.CmbDays.SelectedItem);
            MessageBox.Show(item);
                
        }

        private void BtnRemoveByIndex_Click(object sender, EventArgs e)
        {
            //remove item at a the specified index or giving a specified item by name.
            CmbDays.Items.RemoveAt(1);
            // The above code will remove the second item from the combobox.  
        }

        private void BtnRemoveLastItem_Click(object sender, EventArgs e)
        {

            if (CmbDays.Items.Count >= 1)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Cant remove last item");
            }
        }
    
            private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
