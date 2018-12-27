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
            this.Bt_top_players = new System.Windows.Forms.Button();
            this.Bt_personal_scores = new System.Windows.Forms.Button();
            this.Bt_play_game = new System.Windows.Forms.Button();
            this.Bt_get_tip = new System.Windows.Forms.Button();
            this.Bt_usersOptions_exit = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.Bt_Continue_change_details = new System.Windows.Forms.Button();
            this.Lb_title = new System.Windows.Forms.Label();
            this.CB_music = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Bt_Givefeedback
            // 
            this.Bt_Givefeedback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_Givefeedback.BackgroundImage")));
            this.Bt_Givefeedback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_Givefeedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Givefeedback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_Givefeedback.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Givefeedback.Location = new System.Drawing.Point(448, 277);
            this.Bt_Givefeedback.Name = "Bt_Givefeedback";
            this.Bt_Givefeedback.Size = new System.Drawing.Size(238, 65);
            this.Bt_Givefeedback.TabIndex = 1;
            this.Bt_Givefeedback.Text = "Give Feedback";
            this.Bt_Givefeedback.UseVisualStyleBackColor = true;
            this.Bt_Givefeedback.Click += new System.EventHandler(this.Bt_Give_feedback);
            // 
            // Bt_top_players
            // 
            this.Bt_top_players.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_top_players.BackgroundImage")));
            this.Bt_top_players.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_top_players.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_top_players.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_top_players.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_top_players.Location = new System.Drawing.Point(448, 465);
            this.Bt_top_players.Name = "Bt_top_players";
            this.Bt_top_players.Size = new System.Drawing.Size(238, 65);
            this.Bt_top_players.TabIndex = 3;
            this.Bt_top_players.Text = "Top Players";
            this.Bt_top_players.UseVisualStyleBackColor = true;
            this.Bt_top_players.Click += new System.EventHandler(this.Bt_Top_Players_click);
            // 
            // Bt_personal_scores
            // 
            this.Bt_personal_scores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_personal_scores.BackgroundImage")));
            this.Bt_personal_scores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_personal_scores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_personal_scores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_personal_scores.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_personal_scores.Location = new System.Drawing.Point(448, 372);
            this.Bt_personal_scores.Name = "Bt_personal_scores";
            this.Bt_personal_scores.Size = new System.Drawing.Size(238, 65);
            this.Bt_personal_scores.TabIndex = 4;
            this.Bt_personal_scores.Text = "Personal Scores";
            this.Bt_personal_scores.UseVisualStyleBackColor = true;
            this.Bt_personal_scores.Click += new System.EventHandler(this.Bt_Personal_scores_click);
            // 
            // Bt_play_game
            // 
            this.Bt_play_game.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_play_game.BackgroundImage")));
            this.Bt_play_game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_play_game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_play_game.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_play_game.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_play_game.Location = new System.Drawing.Point(448, 185);
            this.Bt_play_game.Name = "Bt_play_game";
            this.Bt_play_game.Size = new System.Drawing.Size(238, 65);
            this.Bt_play_game.TabIndex = 5;
            this.Bt_play_game.Text = "Play Game";
            this.Bt_play_game.UseVisualStyleBackColor = true;
            this.Bt_play_game.Click += new System.EventHandler(this.Bt_Play_game_click);
            // 
            // Bt_get_tip
            // 
            this.Bt_get_tip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_get_tip.BackgroundImage")));
            this.Bt_get_tip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_get_tip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_get_tip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_get_tip.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_get_tip.Location = new System.Drawing.Point(1014, 626);
            this.Bt_get_tip.Name = "Bt_get_tip";
            this.Bt_get_tip.Size = new System.Drawing.Size(156, 65);
            this.Bt_get_tip.TabIndex = 6;
            this.Bt_get_tip.Text = "Get Tip";
            this.Bt_get_tip.UseVisualStyleBackColor = true;
            this.Bt_get_tip.Click += new System.EventHandler(this.Bt_get_tip_click);
            // 
            // Bt_usersOptions_exit
            // 
            this.Bt_usersOptions_exit.BackColor = System.Drawing.Color.Black;
            this.Bt_usersOptions_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_usersOptions_exit.BackgroundImage")));
            this.Bt_usersOptions_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_usersOptions_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_usersOptions_exit.FlatAppearance.BorderSize = 0;
            this.Bt_usersOptions_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_usersOptions_exit.Location = new System.Drawing.Point(1070, 11);
            this.Bt_usersOptions_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bt_usersOptions_exit.Name = "Bt_usersOptions_exit";
            this.Bt_usersOptions_exit.Size = new System.Drawing.Size(100, 55);
            this.Bt_usersOptions_exit.TabIndex = 30;
            this.Bt_usersOptions_exit.UseVisualStyleBackColor = false;
            this.Bt_usersOptions_exit.Click += new System.EventHandler(this.Bt_UserOptions_exit_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(964, 11);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 55);
            this.button8.TabIndex = 31;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Bt_UserOPtions_Back);
            // 
            // Bt_Continue_change_details
            // 
            this.Bt_Continue_change_details.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_Continue_change_details.BackgroundImage")));
            this.Bt_Continue_change_details.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_Continue_change_details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Continue_change_details.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_Continue_change_details.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Continue_change_details.Location = new System.Drawing.Point(448, 558);
            this.Bt_Continue_change_details.Name = "Bt_Continue_change_details";
            this.Bt_Continue_change_details.Size = new System.Drawing.Size(238, 65);
            this.Bt_Continue_change_details.TabIndex = 32;
            this.Bt_Continue_change_details.Text = "Edit Personal Details";
            this.Bt_Continue_change_details.UseVisualStyleBackColor = true;
            this.Bt_Continue_change_details.Click += new System.EventHandler(this.Bt_Change_Details);
            // 
            // Lb_title
            // 
            this.Lb_title.AutoSize = true;
            this.Lb_title.BackColor = System.Drawing.Color.Transparent;
            this.Lb_title.Font = new System.Drawing.Font("Modern No. 20", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_title.ForeColor = System.Drawing.Color.Beige;
            this.Lb_title.Location = new System.Drawing.Point(383, 71);
            this.Lb_title.Name = "Lb_title";
            this.Lb_title.Size = new System.Drawing.Size(377, 62);
            this.Lb_title.TabIndex = 33;
            this.Lb_title.Text = "Menu Options";
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
            this.CB_music.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_music.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CB_music.Location = new System.Drawing.Point(13, 13);
            this.CB_music.Margin = new System.Windows.Forms.Padding(4);
            this.CB_music.Name = "CB_music";
            this.CB_music.Size = new System.Drawing.Size(157, 53);
            this.CB_music.TabIndex = 34;
            this.CB_music.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_music.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CB_music.UseVisualStyleBackColor = false;
            this.CB_music.CheckedChanged += new System.EventHandler(this.CB_music_CheckedChanged);
            // 
            // Users_options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.ControlBox = false;
            this.Controls.Add(this.CB_music);
            this.Controls.Add(this.Lb_title);
            this.Controls.Add(this.Bt_Continue_change_details);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.Bt_usersOptions_exit);
            this.Controls.Add(this.Bt_get_tip);
            this.Controls.Add(this.Bt_play_game);
            this.Controls.Add(this.Bt_personal_scores);
            this.Controls.Add(this.Bt_top_players);
            this.Controls.Add(this.Bt_Givefeedback);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximumSize = new System.Drawing.Size(1200, 750);
            this.MinimumSize = new System.Drawing.Size(1200, 750);
            this.Name = "Users_options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_Givefeedback;

        public Button b8_click { get; private set; }

 
        private System.Windows.Forms.Button Bt_top_players;
        private System.Windows.Forms.Button Bt_personal_scores;
        private System.Windows.Forms.Button Bt_play_game;
        private System.Windows.Forms.Button Bt_get_tip;
        private System.Windows.Forms.Button Bt_usersOptions_exit;
        private System.Windows.Forms.Button button8;
        private Button Bt_Continue_change_details;
        private Label Lb_title;
        public CheckBox CB_music;
    }
}