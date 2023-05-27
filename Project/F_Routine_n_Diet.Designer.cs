
namespace Log_Reg
{
    partial class F_Routine_n_Diet
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
            this.button_F_Complete = new System.Windows.Forms.Button();
            this.lboxInfo = new System.Windows.Forms.ListBox();
            this.labelROUTINE = new System.Windows.Forms.Label();
            this.button_B_home_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_F_Complete
            // 
            this.button_F_Complete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_F_Complete.Location = new System.Drawing.Point(256, 384);
            this.button_F_Complete.Name = "button_F_Complete";
            this.button_F_Complete.Size = new System.Drawing.Size(270, 40);
            this.button_F_Complete.TabIndex = 1;
            this.button_F_Complete.Text = "Today Session Completed";
            this.button_F_Complete.UseVisualStyleBackColor = false;
            this.button_F_Complete.Click += new System.EventHandler(this.button_F_Complete_Click);
            // 
            // lboxInfo
            // 
            this.lboxInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lboxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxInfo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lboxInfo.FormattingEnabled = true;
            this.lboxInfo.ItemHeight = 25;
            this.lboxInfo.Items.AddRange(new object[] {
            "1. Early Morning (6:00-6:30AM)",
            "\t-> Any fruit of your choice + mixed seeds of any fruit",
            "2. Breakfast (8:00-8:30AM)",
            "\t-> 2 egg omelet with brown bread + fruit juice or vegetable juice.",
            "3. Mid-Morning (11:00-11:30AM)",
            "\t->4-5 walnuts + any fruit of your choice",
            "4. Pre lunch (1:00-1:30PM)",
            "\t-> 1 plate of salad with vinegar",
            "5. Lunch (2:00-2:30PM)",
            "\t-> 1 bowl of brown rice + 1 bowl any non veg curry + 1 bowl low fat curd",
            "6. Evening (4:00-4:30PM)",
            "\t->1 glass buttermilk or 1 cup tea or coffee (sugarless)",
            "7. Mid-evening(6:00-6:30PM)",
            "\t->1 glass protein drink or fruit of your choice or 1 bowl of sprouts",
            "8. Dinner (8:00-8:30PM)",
            "\t->1 bowl of rice + 1 bowl of any green vegetable of your choice ",
            "                    + 1 bowl of low fat curd + 1 bowl of salad or soup."});
            this.lboxInfo.Location = new System.Drawing.Point(18, 78);
            this.lboxInfo.Margin = new System.Windows.Forms.Padding(0);
            this.lboxInfo.Name = "lboxInfo";
            this.lboxInfo.Size = new System.Drawing.Size(773, 254);
            this.lboxInfo.TabIndex = 12;
            this.lboxInfo.SelectedIndexChanged += new System.EventHandler(this.lboxInfo_SelectedIndexChanged);
            // 
            // labelROUTINE
            // 
            this.labelROUTINE.AutoSize = true;
            this.labelROUTINE.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelROUTINE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelROUTINE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelROUTINE.Location = new System.Drawing.Point(227, 20);
            this.labelROUTINE.Name = "labelROUTINE";
            this.labelROUTINE.Size = new System.Drawing.Size(342, 39);
            this.labelROUTINE.TabIndex = 15;
            this.labelROUTINE.Text = "ROUTINE AND DIET";
            this.labelROUTINE.Click += new System.EventHandler(this.labelROUTINE_Click);
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
            // F_Routine_n_Diet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_B_home_update);
            this.Controls.Add(this.labelROUTINE);
            this.Controls.Add(this.lboxInfo);
            this.Controls.Add(this.button_F_Complete);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "F_Routine_n_Diet";
            this.Text = "F_Routine_n_Diet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_F_Complete;
        private System.Windows.Forms.ListBox lboxInfo;
        private System.Windows.Forms.Label labelROUTINE;
        private System.Windows.Forms.Button button_B_home_update;
    }
}