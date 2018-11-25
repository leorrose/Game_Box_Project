namespace GameBox
{
    partial class GameChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameChoice));
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_Exit = new System.Windows.Forms.Button();
            this.CB_music = new System.Windows.Forms.CheckBox();
            this.Bt_back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Bt_One_players_SAL = new System.Windows.Forms.Button();
            this.Bt_Two_players_SAL = new System.Windows.Forms.Button();
            this.Bt_Two_players_Reversi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(292, 467);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECT GAME";
            // 
            // Bt_Exit
            // 
            this.Bt_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Exit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Bt_Exit.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Exit.Location = new System.Drawing.Point(884, 9);
            this.Bt_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_Exit.Name = "Bt_Exit";
            this.Bt_Exit.Size = new System.Drawing.Size(101, 66);
            this.Bt_Exit.TabIndex = 8;
            this.Bt_Exit.Text = "Exit";
            this.Bt_Exit.UseVisualStyleBackColor = true;
            this.Bt_Exit.Click += new System.EventHandler(this.Bt_Exit_Click);
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
            this.CB_music.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_music.ForeColor = System.Drawing.Color.Orange;
            this.CB_music.Image = ((System.Drawing.Image)(resources.GetObject("CB_music.Image")));
            this.CB_music.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CB_music.Location = new System.Drawing.Point(13, 9);
            this.CB_music.Margin = new System.Windows.Forms.Padding(4);
            this.CB_music.Name = "CB_music";
            this.CB_music.Size = new System.Drawing.Size(180, 54);
            this.CB_music.TabIndex = 10;
            this.CB_music.Text = "Music on";
            this.CB_music.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_music.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CB_music.UseVisualStyleBackColor = false;
            this.CB_music.CheckedChanged += new System.EventHandler(this.CB_music_CheckedChanged);
            this.CB_music.BackgroundImageChanged += new System.EventHandler(this.CB_music_CheckedChanged);
            // 
            // Bt_back
            // 
            this.Bt_back.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_back.Location = new System.Drawing.Point(776, 9);
            this.Bt_back.Name = "Bt_back";
            this.Bt_back.Size = new System.Drawing.Size(101, 66);
            this.Bt_back.TabIndex = 11;
            this.Bt_back.Text = "Back";
            this.Bt_back.UseVisualStyleBackColor = true;
            this.Bt_back.Click += new System.EventHandler(this.Bt_back_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 86);
            this.button1.TabIndex = 12;
            this.button1.Text = "Reversi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Bt_reversi_show_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(774, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 86);
            this.button2.TabIndex = 13;
            this.button2.Text = "Snake and Ladders";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Bt_SAL_show_Click);
            // 
            // Bt_One_players_SAL
            // 
            this.Bt_One_players_SAL.Location = new System.Drawing.Point(774, 343);
            this.Bt_One_players_SAL.Name = "Bt_One_players_SAL";
            this.Bt_One_players_SAL.Size = new System.Drawing.Size(135, 37);
            this.Bt_One_players_SAL.TabIndex = 14;
            this.Bt_One_players_SAL.Text = "VS computer";
            this.Bt_One_players_SAL.UseVisualStyleBackColor = true;
            this.Bt_One_players_SAL.Visible = false;
            this.Bt_One_players_SAL.Click += new System.EventHandler(this.One_Player_SAL_click);
            // 
            // Bt_Two_players_SAL
            // 
            this.Bt_Two_players_SAL.Location = new System.Drawing.Point(774, 398);
            this.Bt_Two_players_SAL.Name = "Bt_Two_players_SAL";
            this.Bt_Two_players_SAL.Size = new System.Drawing.Size(135, 37);
            this.Bt_Two_players_SAL.TabIndex = 15;
            this.Bt_Two_players_SAL.Text = "VS player";
            this.Bt_Two_players_SAL.UseVisualStyleBackColor = true;
            this.Bt_Two_players_SAL.Visible = false;
            this.Bt_Two_players_SAL.Click += new System.EventHandler(this.Two_Players_SAL_Click);
            // 
            // Bt_Two_players_Reversi
            // 
            this.Bt_Two_players_Reversi.Location = new System.Drawing.Point(106, 343);
            this.Bt_Two_players_Reversi.Name = "Bt_Two_players_Reversi";
            this.Bt_Two_players_Reversi.Size = new System.Drawing.Size(141, 37);
            this.Bt_Two_players_Reversi.TabIndex = 16;
            this.Bt_Two_players_Reversi.Text = "VS player";
            this.Bt_Two_players_Reversi.UseVisualStyleBackColor = true;
            this.Bt_Two_players_Reversi.Visible = false;
            this.Bt_Two_players_Reversi.Click += new System.EventHandler(this.Two_players_reversi_click);
            // 
            // GameChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 562);
            this.ControlBox = false;
            this.Controls.Add(this.Bt_Two_players_Reversi);
            this.Controls.Add(this.Bt_Two_players_SAL);
            this.Controls.Add(this.Bt_One_players_SAL);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Bt_back);
            this.Controls.Add(this.CB_music);
            this.Controls.Add(this.Bt_Exit);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_Exit;
        private System.Windows.Forms.CheckBox CB_music;
        private System.Windows.Forms.Button Bt_back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Bt_One_players_SAL;
        private System.Windows.Forms.Button Bt_Two_players_SAL;
        private System.Windows.Forms.Button Bt_Two_players_Reversi;
    }
}

