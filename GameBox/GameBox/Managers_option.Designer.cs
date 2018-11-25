namespace GameBox
{
    partial class Managers_option
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Managers_option));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.CB_music2 = new System.Windows.Forms.CheckBox();
            this.Bt_login_exit = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Bt_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add/Remove user";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Bt_add_remove_user);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Logins report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Bt_logins_report);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 274);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add/Remove manager";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Bt_add_remove_manager);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(26, 328);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(210, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "Scores report";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Bt_scores_report);
            // 
            // CB_music2
            // 
            this.CB_music2.AutoSize = true;
            this.CB_music2.BackColor = System.Drawing.Color.Transparent;
            this.CB_music2.Checked = true;
            this.CB_music2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_music2.FlatAppearance.BorderSize = 0;
            this.CB_music2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_music2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_music2.ForeColor = System.Drawing.Color.Red;
            this.CB_music2.Image = ((System.Drawing.Image)(resources.GetObject("CB_music2.Image")));
            this.CB_music2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CB_music2.Location = new System.Drawing.Point(13, 13);
            this.CB_music2.Margin = new System.Windows.Forms.Padding(4);
            this.CB_music2.Name = "CB_music2";
            this.CB_music2.Size = new System.Drawing.Size(196, 48);
            this.CB_music2.TabIndex = 27;
            this.CB_music2.Text = "Music on";
            this.CB_music2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CB_music2.UseVisualStyleBackColor = false;
            // 
            // Bt_login_exit
            // 
            this.Bt_login_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_login_exit.Location = new System.Drawing.Point(911, 7);
            this.Bt_login_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bt_login_exit.Name = "Bt_login_exit";
            this.Bt_login_exit.Size = new System.Drawing.Size(72, 40);
            this.Bt_login_exit.TabIndex = 28;
            this.Bt_login_exit.Text = "Exit";
            this.Bt_login_exit.UseVisualStyleBackColor = true;
            this.Bt_login_exit.Click += new System.EventHandler(this.Bt_login_exit_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(26, 378);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(210, 44);
            this.button5.TabIndex = 29;
            this.button5.Text = "Feedback report";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Bt_FeedBack_report);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Location = new System.Drawing.Point(26, 513);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(210, 38);
            this.button6.TabIndex = 30;
            this.button6.Text = "Tip";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Bt_back
            // 
            this.Bt_back.Location = new System.Drawing.Point(830, 7);
            this.Bt_back.Name = "Bt_back";
            this.Bt_back.Size = new System.Drawing.Size(75, 40);
            this.Bt_back.TabIndex = 31;
            this.Bt_back.Text = "Back";
            this.Bt_back.UseVisualStyleBackColor = true;
            this.Bt_back.Click += new System.EventHandler(this.Bt_back_Click);
            // 
            // Managers_option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 562);
            this.ControlBox = false;
            this.Controls.Add(this.Bt_back);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Bt_login_exit);
            this.Controls.Add(this.CB_music2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Managers_option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Managers_option";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox CB_music2;
        private System.Windows.Forms.Button Bt_login_exit;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Bt_back;
    }
}