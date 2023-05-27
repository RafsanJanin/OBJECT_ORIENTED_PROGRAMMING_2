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
    public partial class User_info : Form
    {
        public User_info()
        {
            InitializeComponent();
        }

        private void User_info_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBproductInfoDataSet.TProduct' table. You can move, or remove it, as needed.
            this.tProductTableAdapter.Fill(this.dBproductInfoDataSet.TProduct);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelWorkOut_Click(object sender, EventArgs e)
        {

        }
    }
}
