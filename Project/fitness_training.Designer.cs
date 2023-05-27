
namespace Log_Reg
{
    partial class fitness_training
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
            this.button_F_Done = new System.Windows.Forms.Button();
            this.lboxInfo = new System.Windows.Forms.ListBox();
            this.labelWorkout = new System.Windows.Forms.Label();
            this.button_B_home_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_F_Done
            // 
            this.button_F_Done.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_F_Done.Location = new System.Drawing.Point(213, 392);
            this.button_F_Done.Name = "button_F_Done";
            this.button_F_Done.Size = new System.Drawing.Size(409, 46);
            this.button_F_Done.TabIndex = 1;
            this.button_F_Done.Text = "DONE";
            this.button_F_Done.UseVisualStyleBackColor = false;
            this.button_F_Done.Click += new System.EventHandler(this.button_F_Done_Click);
            // 
            // lboxInfo
            // 
            this.lboxInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lboxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxInfo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lboxInfo.FormattingEnabled = true;
            this.lboxInfo.ItemHeight = 25;
            this.lboxInfo.Items.AddRange(new object[] {
            "1 - DECLINE PRESS UP JACKS.",
            "2 - BURPEES.",
            "3 - FROG JUMPS.",
            "4 - SIDE BOX JUMPS.",
            "5 - HIGH KNEES.",
            "6 - MOUNTAIN CLIMBERS.",
            "7 - ALTERNATING JUMPING LUNGES.",
            "8 - QUICK STEP UPS.",
            "9 - SIDE-TO-SIDE JUMPS.",
            "10 - LEG RAISES.",
            ""});
            this.lboxInfo.Location = new System.Drawing.Point(6, 73);
            this.lboxInfo.Margin = new System.Windows.Forms.Padding(0);
            this.lboxInfo.Name = "lboxInfo";
            this.lboxInfo.Size = new System.Drawing.Size(789, 304);
            this.lboxInfo.TabIndex = 14;
            // 
            // labelWorkout
            // 
            this.labelWorkout.AutoSize = true;
            this.labelWorkout.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelWorkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelWorkout.Location = new System.Drawing.Point(127, 22);
            this.labelWorkout.Name = "labelWorkout";
            this.labelWorkout.Size = new System.Drawing.Size(454, 39);
            this.labelWorkout.TabIndex = 15;
            this.labelWorkout.Text = "WORKOUTS FOR FITNESS";
            // 
            // button_B_home_update
            // 
            this.button_B_home_update.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_B_home_update.Location = new System.Drawing.Point(12, 12);
            this.button_B_home_update.Name = "button_B_home_update";
            this.button_B_home_update.Size = new System.Drawing.Size(75, 23);
            this.button_B_home_update.TabIndex = 20;
            this.button_B_home_update.Text = "BACK";
            this.button_B_home_update.UseVisualStyleBackColor = false;
            this.button_B_home_update.Click += new System.EventHandler(this.button_B_home_update_Click);
            // 
            // fitness_training
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_B_home_update);
            this.Controls.Add(this.labelWorkout);
            this.Controls.Add(this.lboxInfo);
            this.Controls.Add(this.button_F_Done);
            this.Name = "fitness_training";
            this.Text = "fitness_training";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_F_Done;
        private System.Windows.Forms.ListBox lboxInfo;
        private System.Windows.Forms.Label labelWorkout;
        private System.Windows.Forms.Button button_B_home_update;
    }
}