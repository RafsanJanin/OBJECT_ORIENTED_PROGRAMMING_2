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
    public partial class M_Routine_n_Diet : Form
    {
        public M_Routine_n_Diet()
        {
            InitializeComponent();
        }

        private void button_M_complete_Click(object sender, EventArgs e)
        {
            this.Hide();
            new home().Show();
        }

        private void labelROUTINE_Click(object sender, EventArgs e)
        {

        }

        private void button_B_home_update_Click(object sender, EventArgs e)
        {
         
                 this.Hide();
            new Muscle_gain().Show();
        }
    }
}
