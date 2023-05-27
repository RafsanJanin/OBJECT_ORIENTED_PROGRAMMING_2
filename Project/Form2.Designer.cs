
namespace Log_Reg
{
    partial class RegistrationForm
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
            this.lblname = new System.Windows.Forms.Label();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnOtherGender = new System.Windows.Forms.RadioButton();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.linkLblLogin = new System.Windows.Forms.LinkLabel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textPass = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblcm = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblkg = new System.Windows.Forms.Label();
            this.btnReg_click = new System.Windows.Forms.Button();
            this.LBL_REGISTRATION = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(350, 107);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(51, 17);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "NAME:";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(448, 102);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(200, 22);
            this.txtnam.TabIndex = 1;
            this.txtnam.TextChanged += new System.EventHandler(this.txtnam_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(350, 139);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 17);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "EMAIL :";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(448, 139);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(350, 176);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(90, 17);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "PHONE NO :";
            this.lblPhone.Click += new System.EventHandler(this.lblPhone_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(448, 176);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 22);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(449, 276);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(66, 21);
            this.rbtnMale.TabIndex = 6;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "MALE";
            this.rbtnMale.UseVisualStyleBackColor = true;
            this.rbtnMale.CheckedChanged += new System.EventHandler(this.rbtnMale_CheckedChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(350, 276);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(75, 17);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "GENDER :";
            this.lblGender.Click += new System.EventHandler(this.lblGender_Click);
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(449, 303);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(83, 21);
            this.rbtnFemale.TabIndex = 8;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "FEMALE";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            this.rbtnFemale.CheckedChanged += new System.EventHandler(this.rbtnFemale_CheckedChanged);
            // 
            // rbtnOtherGender
            // 
            this.rbtnOtherGender.AutoSize = true;
            this.rbtnOtherGender.Location = new System.Drawing.Point(449, 330);
            this.rbtnOtherGender.Name = "rbtnOtherGender";
            this.rbtnOtherGender.Size = new System.Drawing.Size(78, 21);
            this.rbtnOtherGender.TabIndex = 9;
            this.rbtnOtherGender.TabStop = true;
            this.rbtnOtherGender.Text = "OTHER";
            this.rbtnOtherGender.UseVisualStyleBackColor = true;
            this.rbtnOtherGender.CheckedChanged += new System.EventHandler(this.rbtnOtherGender_CheckedChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(350, 357);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(82, 17);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "ADDRESS :";
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(350, 246);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(45, 17);
            this.lblAge.TabIndex = 15;
            this.lblAge.Text = "AGE :";
            this.lblAge.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkLblLogin
            // 
            this.linkLblLogin.AutoSize = true;
            this.linkLblLogin.BackColor = System.Drawing.Color.Cornsilk;
            this.linkLblLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLblLogin.Location = new System.Drawing.Point(577, 496);
            this.linkLblLogin.Name = "linkLblLogin";
            this.linkLblLogin.Size = new System.Drawing.Size(51, 17);
            this.linkLblLogin.TabIndex = 20;
            this.linkLblLogin.TabStop = true;
            this.linkLblLogin.Text = "LOGIN";
            this.linkLblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(448, 357);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 22);
            this.txtAddress.TabIndex = 17;
            this.txtAddress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(449, 246);
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(66, 22);
            this.numericUpDownAge.TabIndex = 18;
            this.numericUpDownAge.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(350, 213);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(96, 17);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "PASSWORD :";
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(448, 213);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(200, 22);
            this.textPass.TabIndex = 22;
            this.textPass.TextChanged += new System.EventHandler(this.textPass_TextChanged);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(350, 413);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(68, 17);
            this.lblHeight.TabIndex = 23;
            this.lblHeight.Text = "HEIGHT :";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(449, 413);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(78, 22);
            this.txtHeight.TabIndex = 24;
            // 
            // lblcm
            // 
            this.lblcm.AutoSize = true;
            this.lblcm.Location = new System.Drawing.Point(533, 416);
            this.lblcm.Name = "lblcm";
            this.lblcm.Size = new System.Drawing.Size(36, 17);
            this.lblcm.TabIndex = 25;
            this.lblcm.Text = "(cm)";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(350, 444);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(71, 17);
            this.lblWeight.TabIndex = 26;
            this.lblWeight.Text = "WEIGHT :";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(448, 444);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(79, 22);
            this.txtWeight.TabIndex = 27;
            // 
            // lblkg
            // 
            this.lblkg.AutoSize = true;
            this.lblkg.Location = new System.Drawing.Point(533, 447);
            this.lblkg.Name = "lblkg";
            this.lblkg.Size = new System.Drawing.Size(33, 17);
            this.lblkg.TabIndex = 28;
            this.lblkg.Text = "(kg)";
            // 
            // btnReg_click
            // 
            this.btnReg_click.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReg_click.Location = new System.Drawing.Point(387, 493);
            this.btnReg_click.Name = "btnReg_click";
            this.btnReg_click.Size = new System.Drawing.Size(154, 23);
            this.btnReg_click.TabIndex = 29;
            this.btnReg_click.Text = "REGISTRATION";
            this.btnReg_click.UseVisualStyleBackColor = false;
            this.btnReg_click.Click += new System.EventHandler(this.btnReg_click_Click);
            // 
            // LBL_REGISTRATION
            // 
            this.LBL_REGISTRATION.AutoSize = true;
            this.LBL_REGISTRATION.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LBL_REGISTRATION.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_REGISTRATION.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBL_REGISTRATION.Location = new System.Drawing.Point(307, 25);
            this.LBL_REGISTRATION.Name = "LBL_REGISTRATION";
            this.LBL_REGISTRATION.Size = new System.Drawing.Size(400, 58);
            this.LBL_REGISTRATION.TabIndex = 30;
            this.LBL_REGISTRATION.Text = "REGISTRATION";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 545);
            this.Controls.Add(this.LBL_REGISTRATION);
            this.Controls.Add(this.btnReg_click);
            this.Controls.Add(this.lblkg);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblcm);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.numericUpDownAge);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.linkLblLogin);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.rbtnOtherGender);
            this.Controls.Add(this.rbtnFemale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.rbtnMale);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.lblname);
            this.Name = "RegistrationForm";
            this.Text = "REGISTRATION";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnOtherGender;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.LinkLabel linkLblLogin;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblcm;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblkg;
        private System.Windows.Forms.Button btnReg_click;
        private System.Windows.Forms.Label LBL_REGISTRATION;
    }
}