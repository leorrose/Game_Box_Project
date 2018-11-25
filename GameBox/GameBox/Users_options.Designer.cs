using System.Windows.Forms;

namespace GameBox
{
    partial class Users_options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users_options));
            this.Bt_Givefeedback = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.CB_music = new System.Windows.Forms.CheckBox();
            this.Bt_usersOptions_exit = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.Bt_Continue_change_details = new System.Windows.Forms.Button();
            this.Lb_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bt_Givefeedback
            // 
            this.Bt_Givefeedback.Location = new System.Drawing.Point(400, 275);
            this.Bt_Givefeedback.Name = "Bt_Givefeedback";
            this.Bt_Givefeedback.Size = new System.Drawing.Size(159, 32);
            this.Bt_Givefeedback.TabIndex = 1;
            this.Bt_Givefeedback.Text = "Give Feedback";
            this.Bt_Givefeedback.UseVisualStyleBackColor = true;
            this.Bt_Givefeedback.Click += new System.EventHandler(this.Bt_Give_feedback);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(400, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Top players";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Bt_Top_Players);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(400, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 32);
            this.button4.TabIndex = 4;
            this.button4.Text = "Personal Scores";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Bt_Personal_scores);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(400, 397);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 32);
            this.button5.TabIndex = 5;
            this.button5.Text = "Play Game";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Bt_Play_game);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(799, 456);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(159, 32);
            this.button6.TabIndex = 6;
            this.button6.Text = "Get Tip";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Bt_get_tip);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(799, 505);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(159, 32);
            this.button7.TabIndex = 7;
            this.button7.Text = "Instructions";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Bt_Instructions);
            // 
            // CB_music
            // 
            this.CB_music.Appearance = System.Windows.Forms.Appearance.Button;
            this.CB_music.AutoSize = true;
            this.CB_music.BackColor = System.Drawing.Color.Transparent;
            this.CB_music.Checked = true;
            this.CB_music.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_music.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_music.FlatAppearance.BorderSize = 0;
            this.CB_music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_music.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_music.ForeColor = System.Drawing.Color.Gold;
            this.CB_music.Image = ((System.Drawing.Image)(resources.GetObject("CB_music.Image")));
            this.CB_music.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CB_music.Location = new System.Drawing.Point(13, 13);
            this.CB_music.Margin = new System.Windows.Forms.Padding(4);
            this.CB_music.Name = "CB_music";
            this.CB_music.Size = new System.Drawing.Size(188, 54);
            this.CB_music.TabIndex = 29;
            this.CB_music.Text = "Music on";
            this.CB_music.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_music.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CB_music.UseVisualStyleBackColor = false;
            // 
            // Bt_usersOptions_exit
            // 
            this.Bt_usersOptions_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_usersOptions_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_usersOptions_exit.Location = new System.Drawing.Point(904, 11);
            this.Bt_usersOptions_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bt_usersOptions_exit.Name = "Bt_usersOptions_exit";
            this.Bt_usersOptions_exit.Size = new System.Drawing.Size(82, 56);
            this.Bt_usersOptions_exit.TabIndex = 30;
            this.Bt_usersOptions_exit.Text = "Exit";
            this.Bt_usersOptions_exit.UseVisualStyleBackColor = true;
            this.Bt_usersOptions_exit.Click += new System.EventHandler(this.Bt_UserOptions_exit_Click);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(816, 11);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 56);
            this.button8.TabIndex = 31;
            this.button8.Text = "Go back";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Bt_UserOPtions_Back);
            // 
            // Bt_Continue_change_details
            // 
            this.Bt_Continue_change_details.Location = new System.Drawing.Point(400, 163);
            this.Bt_Continue_change_details.Name = "Bt_Continue_change_details";
            this.Bt_Continue_change_details.Size = new System.Drawing.Size(159, 32);
            this.Bt_Continue_change_details.TabIndex = 32;
            this.Bt_Continue_change_details.Text = "Change Details";
            this.Bt_Continue_change_details.UseVisualStyleBackColor = true;
            this.Bt_Continue_change_details.Click += new System.EventHandler(this.Bt_Change_Details);
            // 
            // Lb_title
            // 
            this.Lb_title.AutoSize = true;
            this.Lb_title.BackColor = System.Drawing.Color.Transparent;
            this.Lb_title.Font = new System.Drawing.Font("Modern No. 20", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_title.ForeColor = System.Drawing.Color.Gold;
            this.Lb_title.Location = new System.Drawing.Point(352, 86);
            this.Lb_title.Name = "Lb_title";
            this.Lb_title.Size = new System.Drawing.Size(115, 40);
            this.Lb_title.TabIndex = 33;
            this.Lb_title.Text = "label1";
            // 
            // Users_options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 562);
            this.ControlBox = false;
            this.Controls.Add(this.Lb_title);
            this.Controls.Add(this.Bt_Continue_change_details);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.Bt_usersOptions_exit);
            this.Controls.Add(this.CB_music);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Bt_Givefeedback);
            this.Name = "Users_options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users_options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_Givefeedback;

        public Button b8_click { get; private set; }

 
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.CheckBox CB_music;
        private System.Windows.Forms.Button Bt_usersOptions_exit;
        private System.Windows.Forms.Button button8;
        private Button Bt_Continue_change_details;
        private Label Lb_title;
    }
}