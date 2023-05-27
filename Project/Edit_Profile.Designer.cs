
namespace Log_Reg
{
    partial class Edit_Profile
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
            this.button_B_home_update = new System.Windows.Forms.Button();
            this.txt_Edit_Pass = new System.Windows.Forms.TextBox();
            this.label_N_Pass = new System.Windows.Forms.Label();
            this.button_SAVE = new System.Windows.Forms.Button();
            this.txt_New_pass = new System.Windows.Forms.TextBox();
            this.label_Update_Pass = new System.Windows.Forms.Label();
            this.txtEdit_Phone = new System.Windows.Forms.TextBox();
            this.label_Update_Phone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_B_home_update
            // 
            this.button_B_home_update.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_B_home_update.Location = new System.Drawing.Point(42, 31);
            this.button_B_home_update.Name = "button_B_home_update";
            this.button_B_home_update.Size = new System.Drawing.Size(75, 23);
            this.button_B_home_update.TabIndex = 19;
            this.button_B_home_update.Text = "BACK";
            this.button_B_home_update.UseVisualStyleBackColor = false;
            this.button_B_home_update.Click += new System.EventHandler(this.button_B_home_update_Click);
            // 
            // txt_Edit_Pass
            // 
            this.txt_Edit_Pass.Location = new System.Drawing.Point(366, 135);
            this.txt_Edit_Pass.Name = "txt_Edit_Pass";
            this.txt_Edit_Pass.PasswordChar = '*';
            this.txt_Edit_Pass.Size = new System.Drawing.Size(204, 22);
            this.txt_Edit_Pass.TabIndex = 18;
            // 
            // label_N_Pass
            // 
            this.label_N_Pass.AutoSize = true;
            this.label_N_Pass.Location = new System.Drawing.Point(181, 135);
            this.label_N_Pass.Name = "label_N_Pass";
            this.label_N_Pass.Size = new System.Drawing.Size(171, 17);
            this.label_N_Pass.TabIndex = 17;
            this.label_N_Pass.Text = " CURRENT PASSWORD :";
            // 
            // button_SAVE
            // 
            this.button_SAVE.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_SAVE.Location = new System.Drawing.Point(280, 282);
            this.button_SAVE.Name = "button_SAVE";
            this.button_SAVE.Size = new System.Drawing.Size(240, 72);
            this.button_SAVE.TabIndex = 16;
            this.button_SAVE.Text = "SAVE";
            this.button_SAVE.UseVisualStyleBackColor = false;
            this.button_SAVE.Click += new System.EventHandler(this.button_SAVE_Click);
            // 
            // txt_New_pass
            // 
            this.txt_New_pass.Location = new System.Drawing.Point(366, 172);
            this.txt_New_pass.Name = "txt_New_pass";
            this.txt_New_pass.Size = new System.Drawing.Size(204, 22);
            this.txt_New_pass.TabIndex = 13;
            // 
            // label_Update_Pass
            // 
            this.label_Update_Pass.AutoSize = true;
            this.label_Update_Pass.Location = new System.Drawing.Point(220, 172);
            this.label_Update_Pass.Name = "label_Update_Pass";
            this.label_Update_Pass.Size = new System.Drawing.Size(132, 17);
            this.label_Update_Pass.TabIndex = 12;
            this.label_Update_Pass.Text = "NEW PASSWORD :";
            // 
            // txtEdit_Phone
            // 
            this.txtEdit_Phone.Location = new System.Drawing.Point(366, 98);
            this.txtEdit_Phone.Name = "txtEdit_Phone";
            this.txtEdit_Phone.Size = new System.Drawing.Size(204, 22);
            this.txtEdit_Phone.TabIndex = 11;
            // 
            // label_Update_Phone
            // 
            this.label_Update_Phone.AutoSize = true;
            this.label_Update_Phone.Location = new System.Drawing.Point(262, 98);
            this.label_Update_Phone.Name = "label_Update_Phone";
            this.label_Update_Phone.Size = new System.Drawing.Size(90, 17);
            this.label_Update_Phone.TabIndex = 10;
            this.label_Update_Phone.Text = "PHONE NO :";
            // 
            // Edit_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_B_home_update);
            this.Controls.Add(this.txt_Edit_Pass);
            this.Controls.Add(this.label_N_Pass);
            this.Controls.Add(this.button_SAVE);
            this.Controls.Add(this.txt_New_pass);
            this.Controls.Add(this.label_Update_Pass);
            this.Controls.Add(this.txtEdit_Phone);
            this.Controls.Add(this.label_Update_Phone);
            this.Name = "Edit_Profile";
            this.Text = "Edit_Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_B_home_update;
        private System.Windows.Forms.TextBox txt_Edit_Pass;
        private System.Windows.Forms.Label label_N_Pass;
        private System.Windows.Forms.Button button_SAVE;
        private System.Windows.Forms.TextBox txt_New_pass;
        private System.Windows.Forms.Label label_Update_Pass;
        private System.Windows.Forms.TextBox txtEdit_Phone;
        private System.Windows.Forms.Label label_Update_Phone;
    }
}