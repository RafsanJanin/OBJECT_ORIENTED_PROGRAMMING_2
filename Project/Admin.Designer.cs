
namespace Log_Reg
{
    partial class Admin
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
            this.txtAdmin_Pass = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUserphone = new System.Windows.Forms.Label();
            this.txtAdmin_id = new System.Windows.Forms.TextBox();
            this.lBL_LOGIN = new System.Windows.Forms.Label();
            this.linkLblUSER_LOGIN = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtAdmin_Pass
            // 
            this.txtAdmin_Pass.Location = new System.Drawing.Point(363, 207);
            this.txtAdmin_Pass.Name = "txtAdmin_Pass";
            this.txtAdmin_Pass.PasswordChar = '*';
            this.txtAdmin_Pass.Size = new System.Drawing.Size(193, 22);
            this.txtAdmin_Pass.TabIndex = 11;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblPassword.Location = new System.Drawing.Point(244, 212);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(96, 17);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "PASSWORD :";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogin.Location = new System.Drawing.Point(332, 281);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(134, 33);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUserphone
            // 
            this.lblUserphone.AutoSize = true;
            this.lblUserphone.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblUserphone.Location = new System.Drawing.Point(244, 177);
            this.lblUserphone.Name = "lblUserphone";
            this.lblUserphone.Size = new System.Drawing.Size(29, 17);
            this.lblUserphone.TabIndex = 15;
            this.lblUserphone.Text = "ID :";
            // 
            // txtAdmin_id
            // 
            this.txtAdmin_id.Location = new System.Drawing.Point(363, 174);
            this.txtAdmin_id.Name = "txtAdmin_id";
            this.txtAdmin_id.Size = new System.Drawing.Size(193, 22);
            this.txtAdmin_id.TabIndex = 16;
            // 
            // lBL_LOGIN
            // 
            this.lBL_LOGIN.AutoSize = true;
            this.lBL_LOGIN.BackColor = System.Drawing.SystemColors.Highlight;
            this.lBL_LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBL_LOGIN.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lBL_LOGIN.Location = new System.Drawing.Point(224, 54);
            this.lBL_LOGIN.Name = "lBL_LOGIN";
            this.lBL_LOGIN.Size = new System.Drawing.Size(332, 58);
            this.lBL_LOGIN.TabIndex = 17;
            this.lBL_LOGIN.Text = "LOGIN PAGE";
            // 
            // linkLblUSER_LOGIN
            // 
            this.linkLblUSER_LOGIN.AutoSize = true;
            this.linkLblUSER_LOGIN.BackColor = System.Drawing.SystemColors.HighlightText;
            this.linkLblUSER_LOGIN.LinkColor = System.Drawing.Color.Red;
            this.linkLblUSER_LOGIN.Location = new System.Drawing.Point(505, 289);
            this.linkLblUSER_LOGIN.Name = "linkLblUSER_LOGIN";
            this.linkLblUSER_LOGIN.Size = new System.Drawing.Size(93, 17);
            this.linkLblUSER_LOGIN.TabIndex = 18;
            this.linkLblUSER_LOGIN.TabStop = true;
            this.linkLblUSER_LOGIN.Text = "USER LOGIN";
            this.linkLblUSER_LOGIN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblUSER_LOGIN_LinkClicked);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLblUSER_LOGIN);
            this.Controls.Add(this.lBL_LOGIN);
            this.Controls.Add(this.txtAdmin_id);
            this.Controls.Add(this.lblUserphone);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtAdmin_Pass);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdmin_Pass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUserphone;
        private System.Windows.Forms.TextBox txtAdmin_id;
        private System.Windows.Forms.Label lBL_LOGIN;
        private System.Windows.Forms.LinkLabel linkLblUSER_LOGIN;
    }
}