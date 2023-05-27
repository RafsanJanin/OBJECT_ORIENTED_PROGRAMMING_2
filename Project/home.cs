using DataAccessLayer.Entity;
using DataAccessLayer.Operation;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Log_Reg
{
    public partial class home : Form
    {   
        public double val;
              
        public home()
        {
            InitializeComponent();
           
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void button_Start_Click(object sender, EventArgs e)
        {                      
            this.Hide();
            new fitness_training().Show();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            this.Hide();
            new update_HW().Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Edit_Profile().Show();
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show(); 
        }

        private void buttonMuscleGain_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Muscle_gain().Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
