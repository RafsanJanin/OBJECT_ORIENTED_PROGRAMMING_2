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
    public partial class Muscle_gain : Form
    {
        public Muscle_gain()
        {
            InitializeComponent();
        }

        private void button_Muscle_Done_Click(object sender, EventArgs e)
        {
            this.Hide();
            new M_Routine_n_Diet().Show();
            
        }

        private void lboxInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_B_home_update_Click(object sender, EventArgs e)
        {
            this.Hide();
            new home().Show();
        }
    }
}
