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
    public partial class Edit_Profile : Form
    {
        public Edit_Profile()
        {
            InitializeComponent();
        }

        private void button_SAVE_Click(object sender, EventArgs e)
        {
            EProduct eProduct = new EProduct();
            eProduct.EPhone = txtEdit_Phone.Text;
            eProduct.CPassword = txt_Edit_Pass.Text;
            eProduct.EPassword = txt_New_pass.Text;
            OProduct oProduct = new OProduct();
            int check = oProduct.Save(eProduct);
            if (check > 0)
            {
                MessageBox.Show("Successfully Changed");
            }
            else
            {
                MessageBox.Show("Invalid Phone Number or password");
            }
        }

        private void button_B_home_update_Click(object sender, EventArgs e)
        {
            this.Hide();
            new home().Show();
        }
    }
}
