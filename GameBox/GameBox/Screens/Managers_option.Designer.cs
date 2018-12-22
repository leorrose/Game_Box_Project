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
            this.Bt_user_add = new System.Windows.Forms.Button();
            this.BT_login_reports = new System.Windows.Forms.Button();
            this.Bt_manager_add = new System.Windows.Forms.Button();
            this.Bt_score_report = new System.Windows.Forms.Button();
            this.Bt_manager_exit = new System.Windows.Forms.Button();
            this.Bt_feedback = new System.Windows.Forms.Button();
            this.Bt_manager_tips = new System.Windows.Forms.Button();
            this.Bt_manager_back = new System.Windows.Forms.Button();
            this.CB_music = new System.Windows.Forms.CheckBox();
            this.Lb_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bt_user_add
            // 
            this.Bt_user_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_user_add.BackgroundImage")));
            this.Bt_user_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_user_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_user_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_user_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_user_add.Location = new System.Drawing.Point(49, 275);
            this.Bt_user_add.Name = "Bt_user_add";
            this.Bt_user_add.Size = new System.Drawing.Size(236, 68);
            this.Bt_user_add.TabIndex = 0;
            this.Bt_user_add.Text = "Add/Remove User";
            this.Bt_user_add.UseVisualStyleBackColor = true;
            this.Bt_user_add.Click += new System.EventHandler(this.Bt_add_remove_user);
            // 
            // BT_login_reports
            // 
            this.BT_login_reports.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_login_reports.BackgroundImage")));
            this.BT_login_reports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_login_reports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_login_reports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_login_reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_login_reports.Location = new System.Drawing.Point(891, 275);
            this.BT_login_reports.Name = "BT_login_reports";
            this.BT_login_reports.Size = new System.Drawing.Size(236, 68);
            this.BT_login_reports.TabIndex = 1;
            this.BT_login_reports.Text = "Logins Report";
            this.BT_login_reports.UseVisualStyleBackColor = true;
            this.BT_login_reports.Click += new System.EventHandler(this.Bt_logins_report);
            // 
            // Bt_manager_add
            // 
            this.Bt_manager_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_manager_add.BackgroundImage")));
            this.Bt_manager_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_manager_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_manager_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_manager_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_manager_add.Location = new System.Drawing.Point(49, 370);
            this.Bt_manager_add.Name = "Bt_manager_add";
            this.Bt_manager_add.Size = new System.Drawing.Size(236, 68);
            this.Bt_manager_add.TabIndex = 2;
            this.Bt_manager_add.Text = "Add/Remove Manager";
            this.Bt_manager_add.UseVisualStyleBackColor = true;
            this.Bt_manager_add.Click += new System.EventHandler(this.Bt_add_remove_manager);
            // 
            // Bt_score_report
            // 
            this.Bt_score_report.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_score_report.BackgroundImage")));
            this.Bt_score_report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_score_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_score_report.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_score_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_score_report.Location = new System.Drawing.Point(891, 370);
            this.Bt_score_report.Name = "Bt_score_report";
            this.Bt_score_report.Size = new System.Drawing.Size(236, 68);
            this.Bt_score_report.TabIndex = 3;
            this.Bt_score_report.Text = "Scores Report";
            this.Bt_score_report.UseVisualStyleBackColor = true;
            this.Bt_score_report.Click += new System.EventHandler(this.Bt_scores_report);
            // 
            // Bt_manager_exit
            // 
            this.Bt_manager_exit.BackColor = System.Drawing.Color.Black;
            this.Bt_manager_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_manager_exit.BackgroundImage")));
            this.Bt_manager_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_manager_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_manager_exit.FlatAppearance.BorderSize = 0;
            this.Bt_manager_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_manager_exit.Location = new System.Drawing.Point(1070, 7);
            this.Bt_manager_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bt_manager_exit.Name = "Bt_manager_exit";
            this.Bt_manager_exit.Size = new System.Drawing.Size(100, 55);
            this.Bt_manager_exit.TabIndex = 28;
            this.Bt_manager_exit.UseVisualStyleBackColor = false;
            this.Bt_manager_exit.Click += new System.EventHandler(this.Bt_login_exit_Click);
            // 
            // Bt_feedback
            // 
            this.Bt_feedback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_feedback.BackgroundImage")));
            this.Bt_feedback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_feedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_feedback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_feedback.Location = new System.Drawing.Point(891, 464);
            this.Bt_feedback.Name = "Bt_feedback";
            this.Bt_feedback.Size = new System.Drawing.Size(236, 68);
            this.Bt_feedback.TabIndex = 29;
            this.Bt_feedback.Text = "Feedback Report";
            this.Bt_feedback.UseVisualStyleBackColor = true;
            this.Bt_feedback.Click += new System.EventHandler(this.Bt_FeedBack_report);
            // 
            // Bt_manager_tips
            // 
            this.Bt_manager_tips.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_manager_tips.BackgroundImage")));
            this.Bt_manager_tips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_manager_tips.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_manager_tips.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_manager_tips.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_manager_tips.Location = new System.Drawing.Point(49, 464);
            this.Bt_manager_tips.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bt_manager_tips.Name = "Bt_manager_tips";
            this.Bt_manager_tips.Size = new System.Drawing.Size(236, 68);
            this.Bt_manager_tips.TabIndex = 30;
            this.Bt_manager_tips.Text = "Get Tip";
            this.Bt_manager_tips.UseVisualStyleBackColor = true;
            this.Bt_manager_tips.Click += new System.EventHandler(this.Bt_get_tips_Click);
            // 
            // Bt_manager_back
            // 
            this.Bt_manager_back.BackColor = System.Drawing.Color.Black;
            this.Bt_manager_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_manager_back.BackgroundImage")));
            this.Bt_manager_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_manager_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_manager_back.FlatAppearance.BorderSize = 0;
            this.Bt_manager_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_manager_back.Location = new System.Drawing.Point(964, 7);
            this.Bt_manager_back.Name = "Bt_manager_back";
            this.Bt_manager_back.Size = new System.Drawing.Size(100, 55);
            this.Bt_manager_back.TabIndex = 31;
            this.Bt_manager_back.UseVisualStyleBackColor = false;
            this.Bt_manager_back.Click += new System.EventHandler(this.Bt_back_Click);
            // 
            // CB_music
            // 
            this.CB_music.Appearance = System.Windows.Forms.Appearance.Button;
            this.CB_music.BackColor = System.Drawing.Color.Transparent;
            this.CB_music.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CB_music.BackgroundImage")));
            this.CB_music.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CB_music.Checked = true;
            this.CB_music.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_music.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_music.FlatAppearance.BorderSize = 0;
            this.CB_music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_music.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_music.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CB_music.Location = new System.Drawing.Point(26, 9);
            this.CB_music.Margin = new System.Windows.Forms.Padding(4);
            this.CB_music.Name = "CB_music";
            this.CB_music.Size = new System.Drawing.Size(157, 53);
            this.CB_music.TabIndex = 32;
            this.CB_music.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_music.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CB_music.UseVisualStyleBackColor = false;
            this.CB_music.CheckedChanged += new System.EventHandler(this.CB_music_CheckedChanged);
            // 
            // Lb_title
            // 
            this.Lb_title.AutoSize = true;
            this.Lb_title.BackColor = System.Drawing.Color.Transparent;
            this.Lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_title.ForeColor = System.Drawing.Color.Beige;
            this.Lb_title.Location = new System.Drawing.Point(404, 70);
            this.Lb_title.Name = "Lb_title";
            this.Lb_title.Size = new System.Drawing.Size(413, 69);
            this.Lb_title.TabIndex = 34;
            this.Lb_title.Text = "Menu Options";
            // 
            // Managers_option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.ControlBox = false;
            this.Controls.Add(this.Lb_title);
            this.Controls.Add(this.CB_music);
            this.Controls.Add(this.Bt_manager_back);
            this.Controls.Add(this.Bt_manager_tips);
            this.Controls.Add(this.Bt_feedback);
            this.Controls.Add(this.Bt_manager_exit);
            this.Controls.Add(this.Bt_score_report);
            this.Controls.Add(this.Bt_manager_add);
            this.Controls.Add(this.BT_login_reports);
            this.Controls.Add(this.Bt_user_add);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 750);
            this.MinimumSize = new System.Drawing.Size(1200, 750);
            this.Name = "Managers_option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_user_add;
        private System.Windows.Forms.Button BT_login_reports;
        private System.Windows.Forms.Button Bt_manager_add;
        private System.Windows.Forms.Button Bt_score_report;
        private System.Windows.Forms.Button Bt_manager_exit;
        private System.Windows.Forms.Button Bt_feedback;
        private System.Windows.Forms.Button Bt_manager_tips;
        private System.Windows.Forms.Button Bt_manager_back;
        public  System.Windows.Forms.CheckBox CB_music;
        private System.Windows.Forms.Label Lb_title;
    }
}