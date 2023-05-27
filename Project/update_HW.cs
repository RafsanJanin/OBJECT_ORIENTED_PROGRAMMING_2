using DataAccessLayer.Entity;
using DataAccessLayer.Operation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_Reg
{
    public partial class update_HW : Form
    {
        public update_HW()
        {
            InitializeComponent();
        }

        private void button_New_Update_Click(object sender, EventArgs e)
        {
            EProduct eProduct = new EProduct();
            eProduct.NPhone = txtUp_Phone.Text;
            eProduct.NHeight = double.Parse(txt_New_Height.Text);
            eProduct.NWeight = double.Parse(txt_New_Weight.Text);
            eProduct.NPassword = txt_N_Pass.Text;
            OProduct oProduct = new OProduct();
            int check = oProduct.Update(eProduct);
            if (check > 0)
            {
                MessageBox.Show("Successfully Updated");
            }
            else
            {
                MessageBox.Show("Invalid Phone Number");
            }
        }

        private void txt_New_Height_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_New_Weight_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_B_home_update_Click(object sender, EventArgs e)
        {
            this.Hide();
            new home().Show();
        }

        private void txt_N_Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_N_Pass_Click(object sender, EventArgs e)
        {

        }

        private void label_Update_Weight_Click(object sender, EventArgs e)
        {

        }

        private void label_Update_Height_Click(object sender, EventArgs e)
        {

        }

        private void txtUp_Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Update_Phone_Click(object sender, EventArgs e)
        {

        }
    }
}
