
namespace Log_Reg
{
    partial class Muscle_gain
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
            this.button_Muscle_Done = new System.Windows.Forms.Button();
            this.lboxInfo = new System.Windows.Forms.ListBox();
            this.labelWorkOut = new System.Windows.Forms.Label();
            this.button_B_home_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Muscle_Done
            // 
            this.button_Muscle_Done.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Muscle_Done.Location = new System.Drawing.Point(268, 402);
            this.button_Muscle_Done.Name = "button_Muscle_Done";
            this.button_Muscle_Done.Size = new System.Drawing.Size(253, 36);
            this.button_Muscle_Done.TabIndex = 1;
            this.button_Muscle_Done.Text = "DONE";
            this.button_Muscle_Done.UseVisualStyleBackColor = false;
            this.button_Muscle_Done.Click += new System.EventHandler(this.button_Muscle_Done_Click);
            // 
            // lboxInfo
            // 
            this.lboxInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lboxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxInfo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lboxInfo.FormattingEnabled = true;
            this.lboxInfo.ItemHeight = 25;
            this.lboxInfo.Items.AddRange(new object[] {
            "1.Squats",
            "2.Push-ups",
            "3.Bench Dips",
            "4.lunges",
            "5.Crunches",
            "6.Glute Kickback",
            "7.Pull-Ups",
            "8.Bench Press",
            "9.Deadlift",
            "10.Burpees"});
            this.lboxInfo.Location = new System.Drawing.Point(9, 75);
            this.lboxInfo.Margin = new System.Windows.Forms.Padding(0);
            this.lboxInfo.Name = "lboxInfo";
            this.lboxInfo.Size = new System.Drawing.Size(789, 304);
            this.lboxInfo.TabIndex = 13;
            this.lboxInfo.SelectedIndexChanged += new System.EventHandler(this.lboxInfo_SelectedIndexChanged);
            // 
            // labelWorkOut
            // 
            this.labelWorkOut.AutoSize = true;
            this.labelWorkOut.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelWorkOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelWorkOut.Location = new System.Drawing.Point(136, 19);
            this.labelWorkOut.Name = "labelWorkOut";
            this.labelWorkOut.Size = new System.Drawing.Size(544, 39);
            this.labelWorkOut.TabIndex = 14;
            this.labelWorkOut.Text = "WORKOUTS FOR MUSCLE GAIN";
            this.labelWorkOut.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_B_home_update
            // 
            this.button_B_home_update.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_B_home_update.Location = new System.Drawing.Point(9, 19);
            this.button_B_home_update.Name = "button_B_home_update";
            this.button_B_home_update.Size = new System.Drawing.Size(75, 23);
            this.button_B_home_update.TabIndex = 21;
            this.button_B_home_update.Text = "BACK";
            this.button_B_home_update.UseVisualStyleBackColor = false;
            this.button_B_home_update.Click += new System.EventHandler(this.button_B_home_update_Click);
            // 
            // Muscle_gain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_B_home_update);
            this.Controls.Add(this.labelWorkOut);
            this.Controls.Add(this.lboxInfo);
            this.Controls.Add(this.button_Muscle_Done);
            this.Name = "Muscle_gain";
            this.Text = "Muscle_gain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Muscle_Done;
        private System.Windows.Forms.ListBox lboxInfo;
        private System.Windows.Forms.Label labelWorkOut;
        private System.Windows.Forms.Button button_B_home_update;
    }
}