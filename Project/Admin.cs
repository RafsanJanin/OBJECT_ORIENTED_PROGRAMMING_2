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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EProduct eProduct = new EProduct();
            eProduct.AId = txtAdmin_id.Text;
            eProduct.APassword = txtAdmin_Pass.Text;
            OProduct oProduct = new OProduct();
            int check = oProduct.Admin_login(eProduct);
                                      
            if (check > 0)
            {
                this.Hide();
                new User_info().Show();
            
            }
            else
            {
                MessageBox.Show("Invalid Phone No. or Password");
            }
        }

        private void linkLblUSER_LOGIN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }
    }
}
