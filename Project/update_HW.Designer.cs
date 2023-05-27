
namespace Log_Reg
{
    partial class update_HW
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
            this.label_Update_Phone = new System.Windows.Forms.Label();
            this.txtUp_Phone = new System.Windows.Forms.TextBox();
            this.label_Update_Height = new System.Windows.Forms.Label();
            this.txt_New_Height = new System.Windows.Forms.TextBox();
            this.label_Update_Weight = new System.Windows.Forms.Label();
            this.txt_New_Weight = new System.Windows.Forms.TextBox();
            this.button_New_Update = new System.Windows.Forms.Button();
            this.label_N_Pass = new System.Windows.Forms.Label();
            this.txt_N_Pass = new System.Windows.Forms.TextBox();
            this.button_B_home_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Update_Phone
            // 
            this.label_Update_Phone.AutoSize = true;
            this.label_Update_Phone.Location = new System.Drawing.Point(226, 73);
            this.label_Update_Phone.Name = "label_Update_Phone";
            this.label_Update_Phone.Size = new System.Drawing.Size(90, 17);
            this.label_Update_Phone.TabIndex = 0;
            this.label_Update_Phone.Text = "PHONE NO :";
            this.label_Update_Phone.Click += new System.EventHandler(this.label_Update_Phone_Click);
            // 
            // txtUp_Phone
            // 
            this.txtUp_Phone.Location = new System.Drawing.Point(330, 73);
            this.txtUp_Phone.Name = "txtUp_Phone";
            this.txtUp_Phone.Size = new System.Drawing.Size(204, 22);
            this.txtUp_Phone.TabIndex = 1;
            this.txtUp_Phone.TextChanged += new System.EventHandler(this.txtUp_Phone_TextChanged);
            // 
            // label_Update_Height
            // 
            this.label_Update_Height.AutoSize = true;
            this.label_Update_Height.Location = new System.Drawing.Point(248, 150);
            this.label_Update_Height.Name = "label_Update_Height";
            this.label_Update_Height.Size = new System.Drawing.Size(68, 17);
            this.label_Update_Height.TabIndex = 2;
            this.label_Update_Height.Text = "HEIGHT :";
            this.label_Update_Height.Click += new System.EventHandler(this.label_Update_Height_Click);
            // 
            // txt_New_Height
            // 
            this.txt_New_Height.Location = new System.Drawing.Point(330, 147);
            this.txt_New_Height.Name = "txt_New_Height";
            this.txt_New_Height.Size = new System.Drawing.Size(204, 22);
            this.txt_New_Height.TabIndex = 3;
            this.txt_New_Height.TextChanged += new System.EventHandler(this.txt_New_Height_TextChanged);
            // 
            // label_Update_Weight
            // 
            this.label_Update_Weight.AutoSize = true;
            this.label_Update_Weight.Location = new System.Drawing.Point(245, 192);
            this.label_Update_Weight.Name = "label_Update_Weight";
            this.label_Update_Weight.Size = new System.Drawing.Size(71, 17);
            this.label_Update_Weight.TabIndex = 4;
            this.label_Update_Weight.Text = "WEIGHT :";
            this.label_Update_Weight.Click += new System.EventHandler(this.label_Update_Weight_Click);
            // 
            // txt_New_Weight
            // 
            this.txt_New_Weight.Location = new System.Drawing.Point(330, 187);
            this.txt_New_Weight.Name = "txt_New_Weight";
            this.txt_New_Weight.Size = new System.Drawing.Size(204, 22);
            this.txt_New_Weight.TabIndex = 5;
            this.txt_New_Weight.TextChanged += new System.EventHandler(this.txt_New_Weight_TextChanged);
            // 
            // button_New_Update
            // 
            this.button_New_Update.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_New_Update.Location = new System.Drawing.Point(276, 305);
            this.button_New_Update.Name = "button_New_Update";
            this.button_New_Update.Size = new System.Drawing.Size(240, 72);
            this.button_New_Update.TabIndex = 6;
            this.button_New_Update.Text = "UPDATE";
            this.button_New_Update.UseVisualStyleBackColor = false;
            this.button_New_Update.Click += new System.EventHandler(this.button_New_Update_Click);
            // 
            // label_N_Pass
            // 
            this.label_N_Pass.AutoSize = true;
            this.label_N_Pass.Location = new System.Drawing.Point(220, 113);
            this.label_N_Pass.Name = "label_N_Pass";
            this.label_N_Pass.Size = new System.Drawing.Size(96, 17);
            this.label_N_Pass.TabIndex = 7;
            this.label_N_Pass.Text = "PASSWORD :";
            this.label_N_Pass.Click += new System.EventHandler(this.label_N_Pass_Click);
            // 
            // txt_N_Pass
            // 
            this.txt_N_Pass.Location = new System.Drawing.Point(330, 110);
            this.txt_N_Pass.Name = "txt_N_Pass";
            this.txt_N_Pass.PasswordChar = '*';
            this.txt_N_Pass.Size = new System.Drawing.Size(204, 22);
            this.txt_N_Pass.TabIndex = 8;
            this.txt_N_Pass.TextChanged += new System.EventHandler(this.txt_N_Pass_TextChanged);
            // 
            // button_B_home_update
            // 
            this.button_B_home_update.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_B_home_update.Location = new System.Drawing.Point(27, 31);
            this.button_B_home_update.Name = "button_B_home_update";
            this.button_B_home_update.Size = new System.Drawing.Size(75, 23);
            this.button_B_home_update.TabIndex = 9;
            this.button_B_home_update.Text = "BACK";
            this.button_B_home_update.UseVisualStyleBackColor = false;
            this.button_B_home_update.Click += new System.EventHandler(this.button_B_home_update_Click);
            // 
            // update_HW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_B_home_update);
            this.Controls.Add(this.txt_N_Pass);
            this.Controls.Add(this.label_N_Pass);
            this.Controls.Add(this.button_New_Update);
            this.Controls.Add(this.txt_New_Weight);
            this.Controls.Add(this.label_Update_Weight);
            this.Controls.Add(this.txt_New_Height);
            this.Controls.Add(this.label_Update_Height);
            this.Controls.Add(this.txtUp_Phone);
            this.Controls.Add(this.label_Update_Phone);
            this.Name = "update_HW";
            this.Text = "Update ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Update_Phone;
        private System.Windows.Forms.TextBox txtUp_Phone;
        private System.Windows.Forms.Label label_Update_Height;
        private System.Windows.Forms.TextBox txt_New_Height;
        private System.Windows.Forms.Label label_Update_Weight;
        private System.Windows.Forms.TextBox txt_New_Weight;
        private System.Windows.Forms.Button button_New_Update;
        private System.Windows.Forms.Label label_N_Pass;
        private System.Windows.Forms.TextBox txt_N_Pass;
        private System.Windows.Forms.Button button_B_home_update;
    }
}