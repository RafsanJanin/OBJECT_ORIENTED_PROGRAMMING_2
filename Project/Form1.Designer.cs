
namespace Log_Reg
{
    partial class LoginForm
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
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkLblreg = new System.Windows.Forms.LinkLabel();
            this.lblUserphone = new System.Windows.Forms.Label();
            this.txtUserPhone = new System.Windows.Forms.TextBox();
            this.lBL_LOGIN = new System.Windows.Forms.Label();
            this.linkLblAdmin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(376, 186);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(193, 22);
            this.txtPass.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblPassword.Location = new System.Drawing.Point(257, 191);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(96, 17);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "PASSWORD :";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogin.Location = new System.Drawing.Point(376, 247);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(109, 28);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linkLblreg
            // 
            this.linkLblreg.AutoSize = true;
            this.linkLblreg.BackColor = System.Drawing.SystemColors.HighlightText;
            this.linkLblreg.LinkColor = System.Drawing.Color.Red;
            this.linkLblreg.Location = new System.Drawing.Point(328, 341);
            this.linkLblreg.Name = "linkLblreg";
            this.linkLblreg.Size = new System.Drawing.Size(125, 17);
            this.linkLblreg.TabIndex = 5;
            this.linkLblreg.TabStop = true;
            this.linkLblreg.Text = "CREAT ACCOUNT";
            this.linkLblreg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblUserphone
            // 
            this.lblUserphone.AutoSize = true;
            this.lblUserphone.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblUserphone.Location = new System.Drawing.Point(257, 156);
            this.lblUserphone.Name = "lblUserphone";
            this.lblUserphone.Size = new System.Drawing.Size(90, 17);
            this.lblUserphone.TabIndex = 7;
            this.lblUserphone.Text = "PHONE NO :";
            this.lblUserphone.Click += new System.EventHandler(this.lblUseremail_Click);
            // 
            // txtUserPhone
            // 
            this.txtUserPhone.Location = new System.Drawing.Point(376, 153);
            this.txtUserPhone.Name = "txtUserPhone";
            this.txtUserPhone.Size = new System.Drawing.Size(193, 22);
            this.txtUserPhone.TabIndex = 8;
            // 
            // lBL_LOGIN
            // 
            this.lBL_LOGIN.AutoSize = true;
            this.lBL_LOGIN.BackColor = System.Drawing.SystemColors.Highlight;
            this.lBL_LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBL_LOGIN.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lBL_LOGIN.Location = new System.Drawing.Point(237, 23);
            this.lBL_LOGIN.Name = "lBL_LOGIN";
            this.lBL_LOGIN.Size = new System.Drawing.Size(332, 58);
            this.lBL_LOGIN.TabIndex = 9;
            this.lBL_LOGIN.Text = "LOGIN PAGE";
            this.lBL_LOGIN.Click += new System.EventHandler(this.lBL_LOGIN_Click);
            // 
            // linkLblAdmin
            // 
            this.linkLblAdmin.AutoSize = true;
            this.linkLblAdmin.BackColor = System.Drawing.SystemColors.HighlightText;
            this.linkLblAdmin.LinkColor = System.Drawing.Color.Red;
            this.linkLblAdmin.Location = new System.Drawing.Point(337, 367);
            this.linkLblAdmin.Name = "linkLblAdmin";
            this.linkLblAdmin.Size = new System.Drawing.Size(98, 17);
            this.linkLblAdmin.TabIndex = 10;
            this.linkLblAdmin.TabStop = true;
            this.linkLblAdmin.Text = "ADMIN LOGIN";
            this.linkLblAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblAdmin_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLblAdmin);
            this.Controls.Add(this.lBL_LOGIN);
            this.Controls.Add(this.txtUserPhone);
            this.Controls.Add(this.lblUserphone);
            this.Controls.Add(this.linkLblreg);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPass);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linkLblreg;
        private System.Windows.Forms.Label lblUserphone;
        private System.Windows.Forms.TextBox txtUserPhone;
        private System.Windows.Forms.Label lBL_LOGIN;
        private System.Windows.Forms.LinkLabel linkLblAdmin;
    }
}

