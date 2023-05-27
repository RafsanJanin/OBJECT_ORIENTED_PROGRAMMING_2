
namespace Log_Reg
{
    partial class home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelWelcome = new System.Windows.Forms.Label();
            this.button_Start_fit = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.btn_update_pro = new System.Windows.Forms.Button();
            this.button_Logout = new System.Windows.Forms.Button();
            this.buttonMuscleGain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelWelcome.Location = new System.Drawing.Point(55, 36);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(700, 58);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "WELCOME TO HOME PAGE";
            // 
            // button_Start_fit
            // 
            this.button_Start_fit.BackColor = System.Drawing.Color.IndianRed;
            this.button_Start_fit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Start_fit.Location = new System.Drawing.Point(434, 144);
            this.button_Start_fit.Name = "button_Start_fit";
            this.button_Start_fit.Size = new System.Drawing.Size(311, 50);
            this.button_Start_fit.TabIndex = 1;
            this.button_Start_fit.Text = " FITNESS WORKOUT";
            this.button_Start_fit.UseVisualStyleBackColor = false;
            this.button_Start_fit.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(12, 144);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(198, 36);
            this.button_Update.TabIndex = 2;
            this.button_Update.Text = "UPDATE";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // btn_update_pro
            // 
            this.btn_update_pro.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_update_pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_pro.Location = new System.Drawing.Point(12, 196);
            this.btn_update_pro.Name = "btn_update_pro";
            this.btn_update_pro.Size = new System.Drawing.Size(198, 36);
            this.btn_update_pro.TabIndex = 3;
            this.btn_update_pro.Text = "EDIT PROFILE ";
            this.btn_update_pro.UseVisualStyleBackColor = false;
            this.btn_update_pro.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Logout
            // 
            this.button_Logout.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Logout.Location = new System.Drawing.Point(12, 250);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(198, 35);
            this.button_Logout.TabIndex = 4;
            this.button_Logout.Text = "LOGOUT";
            this.button_Logout.UseVisualStyleBackColor = false;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // buttonMuscleGain
            // 
            this.buttonMuscleGain.BackColor = System.Drawing.Color.Khaki;
            this.buttonMuscleGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMuscleGain.Location = new System.Drawing.Point(434, 219);
            this.buttonMuscleGain.Name = "buttonMuscleGain";
            this.buttonMuscleGain.Size = new System.Drawing.Size(311, 50);
            this.buttonMuscleGain.TabIndex = 5;
            this.buttonMuscleGain.Text = "MUSCLE GAIN WORKOUT";
            this.buttonMuscleGain.UseVisualStyleBackColor = false;
            this.buttonMuscleGain.Click += new System.EventHandler(this.buttonMuscleGain_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMuscleGain);
            this.Controls.Add(this.button_Logout);
            this.Controls.Add(this.btn_update_pro);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Start_fit);
            this.Controls.Add(this.labelWelcome);
            this.Name = "home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button button_Start_fit;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button btn_update_pro;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.Button buttonMuscleGain;
    }
}