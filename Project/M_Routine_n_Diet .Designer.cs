
namespace Log_Reg
{
    partial class M_Routine_n_Diet
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
            this.button_M_complete = new System.Windows.Forms.Button();
            this.labelROUTINE = new System.Windows.Forms.Label();
            this.lboxInfo = new System.Windows.Forms.ListBox();
            this.button_B_home_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_M_complete
            // 
            this.button_M_complete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_M_complete.Location = new System.Drawing.Point(258, 394);
            this.button_M_complete.Name = "button_M_complete";
            this.button_M_complete.Size = new System.Drawing.Size(272, 44);
            this.button_M_complete.TabIndex = 1;
            this.button_M_complete.Text = "Today Session Completed";
            this.button_M_complete.UseVisualStyleBackColor = false;
            this.button_M_complete.Click += new System.EventHandler(this.button_M_complete_Click);
            // 
            // labelROUTINE
            // 
            this.labelROUTINE.AutoSize = true;
            this.labelROUTINE.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelROUTINE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelROUTINE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelROUTINE.Location = new System.Drawing.Point(222, 23);
            this.labelROUTINE.Name = "labelROUTINE";
            this.labelROUTINE.Size = new System.Drawing.Size(342, 39);
            this.labelROUTINE.TabIndex = 16;
            this.labelROUTINE.Text = "ROUTINE AND DIET";
            this.labelROUTINE.Click += new System.EventHandler(this.labelROUTINE_Click);
            // 
            // lboxInfo
            // 
            this.lboxInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lboxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxInfo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lboxInfo.FormattingEnabled = true;
            this.lboxInfo.ItemHeight = 25;
            this.lboxInfo.Items.AddRange(new object[] {
            "1.BREAKFAST (8:00-8:30AM)",
            "         -> 2 cucmber potato sandwich + 1 orange juice + 3 cashews +4 almonds",
            "",
            "2.MID-MEAL(11:00-11:30AM)",
            "         ->1 cup buttermilk + 1 cup sweet potato chaat.",
            "",
            "3.LUNCH (2:00-2:30PM) ",
            "         -> 1 cup fish curry + 1/2 cup rice + salad.",
            "",
            "4.EVENING(4:00-4:30PM)",
            "         -> 1 cup almond milk + banana.",
            "",
            "5.DINNER(8:00-8:30PM)",
            "         -> 1 cup cauliflower potato vegetable + 1/2 cup rice + salad"});
            this.lboxInfo.Location = new System.Drawing.Point(6, 99);
            this.lboxInfo.Margin = new System.Windows.Forms.Padding(0);
            this.lboxInfo.Name = "lboxInfo";
            this.lboxInfo.Size = new System.Drawing.Size(789, 279);
            this.lboxInfo.TabIndex = 15;
            // 
            // button_B_home_update
            // 
            this.button_B_home_update.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_B_home_update.Location = new System.Drawing.Point(12, 12);
            this.button_B_home_update.Name = "button_B_home_update";
            this.button_B_home_update.Size = new System.Drawing.Size(75, 23);
            this.button_B_home_update.TabIndex = 22;
            this.button_B_home_update.Text = "BACK";
            this.button_B_home_update.UseVisualStyleBackColor = false;
            this.button_B_home_update.Click += new System.EventHandler(this.button_B_home_update_Click);
            // 
            // M_Routine_n_Diet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_B_home_update);
            this.Controls.Add(this.labelROUTINE);
            this.Controls.Add(this.lboxInfo);
            this.Controls.Add(this.button_M_complete);
            this.Name = "M_Routine_n_Diet";
            this.Text = "M_Routine_n_Diet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_M_complete;
        private System.Windows.Forms.Label labelROUTINE;
        private System.Windows.Forms.ListBox lboxInfo;
        private System.Windows.Forms.Button button_B_home_update;
    }
}