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
    public partial class fitness_training : Form
    {
        public fitness_training()
        {
            InitializeComponent();
        }

        private void button_F_Done_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F_Routine_n_Diet().Show();
            
        }

        private void button_B_home_update_Click(object sender, EventArgs e)
        {
            this.Hide();
            new home().Show();
        }
    }
}
