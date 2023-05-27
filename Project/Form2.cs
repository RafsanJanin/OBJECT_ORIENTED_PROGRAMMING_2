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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void lblDob_Click(object sender, EventArgs e)
        {

        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void txtnam_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void rbtnMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void rbtnFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnOtherGender_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReg_click_Click(object sender, EventArgs e)
        {
            
           
            EProduct eProduct = new EProduct();
            eProduct.Name = txtnam.Text;
            eProduct.Email = txtEmail.Text;
            eProduct.Phone = txtPhone.Text;
            eProduct.Password = textPass.Text;
            eProduct.Age = int.Parse(numericUpDownAge.Text);
            eProduct.Gender = string.Empty;
            if (rbtnMale.Checked == true)
            {
                eProduct.Gender = "Male";
            }
            if (rbtnFemale.Checked == true)
            {
                eProduct.Gender = "Female";
            }
            if (rbtnOtherGender.Checked == true)
            {
                eProduct.Gender = "Other";
            }
            eProduct.Address = txtAddress.Text;
            eProduct.Height = double.Parse(txtHeight.Text);
            eProduct.Weight = double.Parse(txtWeight.Text);
            
            double bmi = (double.Parse(txtWeight.Text) / (double.Parse(txtHeight.Text)* double.Parse(txtHeight.Text)))*10000;
            eProduct.Bmi = bmi ;

            OProduct oProduct = new OProduct();
           int check = oProduct.Insert(eProduct);
            if (txtnam.Text == "" || txtEmail.Text == "" || txtPhone.Text == "" || textPass.Text == "" || numericUpDownAge.Text == ""
               || txtAddress.Text == "" || txtHeight.Text == "" || txtWeight.Text == "")
            {
                MessageBox.Show("Not Inserted");
            }
            else
            {
                if (check >= 0)
                {  this.Hide();
                    new LoginForm().Show();
                    MessageBox.Show("Successfully Inserted");
                }
                else
                {
                    MessageBox.Show("Not Inserted");
                }
            }

        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
