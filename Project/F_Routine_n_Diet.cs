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
    public partial class F_Routine_n_Diet : Form
    {
        public F_Routine_n_Diet()
        {
            InitializeComponent();
        }

        private void button_F_Complete_Click(object sender, EventArgs e)
        {
            this.Hide();
            new home().Show();
        }

        private void label_F_Diet_1_Click(object sender, EventArgs e)
        {

        }

        private void lboxInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelROUTINE_Click(object sender, EventArgs e)
        {

        }

        private void button_B_home_update_Click(object sender, EventArgs e)
        {        
                this.Hide();
            new fitness_training().Show();
        }
    }
}
