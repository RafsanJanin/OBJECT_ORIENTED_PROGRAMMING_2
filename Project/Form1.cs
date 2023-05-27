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
    
    public partial class LoginForm : System.Windows.Forms.Form
    {
        public double value;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new RegistrationForm().Show();
        }

        private void lblUseremail_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EProduct eProduct = new EProduct();
            eProduct.Password = txtPass.Text;
            eProduct.Phone = txtUserPhone.Text;

            OProduct oProduct = new OProduct();
            int check = oProduct.login(eProduct);
            oProduct.GetBMI(eProduct);
            value = eProduct.NBmi;
            home h = new home();
            h.val = value;
            if (txtPass.Text == "" || txtUserPhone.Text == "")
            {
                MessageBox.Show("Insert Phone No. and Password");
            }
            else {
                if (check > 0)
                {

                    if (value <= 21)
                    {
                        this.Hide();
                        new home().Show();
                        MessageBox.Show("Your BMI Value:" + value.ToString() + Environment.NewLine + "Select muscle-gain Workout.");
                    }
                     else if (value > 21)
                    {
                        this.Hide();
                        new home().Show();
                        MessageBox.Show("Your BMI Value:" + value.ToString() + Environment.NewLine + "Select Fitness Workout.");
                    }
                    else
                    {
                        MessageBox.Show("Insert Phone No. and Password");
                    }
                } 
                else
                {
                MessageBox.Show("Invalid Phone No. or Password");
                }

            }
           

        }

             

 

        private void lBL_LOGIN_Click(object sender, EventArgs e)
        {

        }

        private void linkLblAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Admin().Show();
            
        }
    }
}
