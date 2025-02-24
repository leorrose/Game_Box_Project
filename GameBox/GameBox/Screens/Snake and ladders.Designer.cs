﻿namespace GameBox
{
    partial class Snake_and_ladders
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Snake_and_ladders));
            this.pb_player2 = new System.Windows.Forms.PictureBox();
            this.bt_music = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.Bt_SAL_back = new System.Windows.Forms.Button();
            this.bt_roll = new System.Windows.Forms.Button();
            this.lb_player1_name = new System.Windows.Forms.Label();
            this.lb_player2_name = new System.Windows.Forms.Label();
            this.pb_player1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_dice = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.bt_instraction = new System.Windows.Forms.Button();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_player2
            // 
            this.pb_player2.BackColor = System.Drawing.Color.Transparent;
            this.pb_player2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_player2.BackgroundImage")));
            this.pb_player2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_player2.Location = new System.Drawing.Point(30, 735);
            this.pb_player2.Name = "pb_player2";
            this.pb_player2.Size = new System.Drawing.Size(53, 45);
            this.pb_player2.TabIndex = 6;
            this.pb_player2.TabStop = false;
            // 
            // bt_music
            // 
            this.bt_music.BackgroundImage = global::GameBox.Properties.Resources.Music_red;
            this.bt_music.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_music.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_music.FlatAppearance.BorderSize = 0;
            this.bt_music.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_music.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_music.Location = new System.Drawing.Point(1121, 73);
            this.bt_music.Name = "bt_music";
            this.bt_music.Size = new System.Drawing.Size(215, 55);
            this.bt_music.TabIndex = 0;
            this.bt_music.TabStop = false;
            this.bt_music.UseVisualStyleBackColor = true;
            this.bt_music.Click += new System.EventHandler(this.bt_music_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.BackgroundImage = global::GameBox.Properties.Resources.Exit_red;
            this.bt_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Exit.FlatAppearance.BorderSize = 0;
            this.bt_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Exit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Exit.Location = new System.Drawing.Point(1236, 12);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(100, 55);
            this.bt_Exit.TabIndex = 0;
            this.bt_Exit.TabStop = false;
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // Bt_SAL_back
            // 
            this.Bt_SAL_back.BackgroundImage = global::GameBox.Properties.Resources.Back_red;
            this.Bt_SAL_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_SAL_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_SAL_back.FlatAppearance.BorderSize = 0;
            this.Bt_SAL_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_SAL_back.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_SAL_back.Location = new System.Drawing.Point(1121, 12);
            this.Bt_SAL_back.Name = "Bt_SAL_back";
            this.Bt_SAL_back.Size = new System.Drawing.Size(100, 55);
            this.Bt_SAL_back.TabIndex = 0;
            this.Bt_SAL_back.TabStop = false;
            this.Bt_SAL_back.UseVisualStyleBackColor = true;
            this.Bt_SAL_back.Click += new System.EventHandler(this.Bt_SAL_back_Click);
            // 
            // bt_roll
            // 
            this.bt_roll.BackColor = System.Drawing.Color.Red;
            this.bt_roll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_roll.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_roll.Location = new System.Drawing.Point(1103, 488);
            this.bt_roll.Name = "bt_roll";
            this.bt_roll.Size = new System.Drawing.Size(233, 60);
            this.bt_roll.TabIndex = 0;
            this.bt_roll.TabStop = false;
            this.bt_roll.Text = "Roll!";
            this.bt_roll.UseVisualStyleBackColor = false;
            this.bt_roll.Click += new System.EventHandler(this.bt_roll_Click);
            // 
            // lb_player1_name
            // 
            this.lb_player1_name.AutoSize = true;
            this.lb_player1_name.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_player1_name.ForeColor = System.Drawing.Color.Red;
            this.lb_player1_name.Location = new System.Drawing.Point(1098, 182);
            this.lb_player1_name.Name = "lb_player1_name";
            this.lb_player1_name.Size = new System.Drawing.Size(87, 30);
            this.lb_player1_name.TabIndex = 8;
            this.lb_player1_name.Text = "label1";
            // 
            // lb_player2_name
            // 
            this.lb_player2_name.AutoSize = true;
            this.lb_player2_name.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_player2_name.ForeColor = System.Drawing.Color.Gold;
            this.lb_player2_name.Location = new System.Drawing.Point(1098, 231);
            this.lb_player2_name.Name = "lb_player2_name";
            this.lb_player2_name.Size = new System.Drawing.Size(87, 30);
            this.lb_player2_name.TabIndex = 9;
            this.lb_player2_name.Text = "label1";
            // 
            // pb_player1
            // 
            this.pb_player1.BackColor = System.Drawing.Color.Transparent;
            this.pb_player1.BackgroundImage = global::GameBox.Properties.Resources.red;
            this.pb_player1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_player1.Location = new System.Drawing.Point(30, 735);
            this.pb_player1.MaximumSize = new System.Drawing.Size(53, 45);
            this.pb_player1.MinimumSize = new System.Drawing.Size(53, 45);
            this.pb_player1.Name = "pb_player1";
            this.pb_player1.Size = new System.Drawing.Size(53, 45);
            this.pb_player1.TabIndex = 5;
            this.pb_player1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GameBox.Properties.Resources.snakeandladders;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pb_player1);
            this.panel1.Controls.Add(this.pb_player2);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 799);
            this.panel1.TabIndex = 10;
            // 
            // pb_dice
            // 
            this.pb_dice.BackColor = System.Drawing.Color.Transparent;
            this.pb_dice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_dice.Image = global::GameBox.Properties.Resources.roll;
            this.pb_dice.Location = new System.Drawing.Point(1108, 309);
            this.pb_dice.Name = "pb_dice";
            this.pb_dice.Size = new System.Drawing.Size(228, 141);
            this.pb_dice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_dice.TabIndex = 11;
            this.pb_dice.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // bt_instraction
            // 
            this.bt_instraction.BackgroundImage = global::GameBox.Properties.Resources.Instructions_red;
            this.bt_instraction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_instraction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_instraction.FlatAppearance.BorderSize = 0;
            this.bt_instraction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_instraction.Location = new System.Drawing.Point(1103, 733);
            this.bt_instraction.Name = "bt_instraction";
            this.bt_instraction.Size = new System.Drawing.Size(233, 55);
            this.bt_instraction.TabIndex = 0;
            this.bt_instraction.TabStop = false;
            this.bt_instraction.UseVisualStyleBackColor = true;
            this.bt_instraction.Click += new System.EventHandler(this.bt_instraction_Click);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::GameBox.Properties.Resources.animated_snake_image_0050;
            this.pictureBox1.Location = new System.Drawing.Point(1103, 581);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Snake_and_ladders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 800);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_instraction);
            this.Controls.Add(this.pb_dice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_player2_name);
            this.Controls.Add(this.lb_player1_name);
            this.Controls.Add(this.bt_roll);
            this.Controls.Add(this.Bt_SAL_back);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_music);
            this.MaximumSize = new System.Drawing.Size(1400, 847);
            this.MinimumSize = new System.Drawing.Size(1400, 847);
            this.Name = "Snake_and_ladders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameBox";
            this.Load += new System.EventHandler(this.Snake_and_ladders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_dice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button bt_music;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Button Bt_SAL_back;
        private System.Windows.Forms.PictureBox pb_player2;
        private System.Windows.Forms.Button bt_roll;
        private System.Windows.Forms.Label lb_player1_name;
        private System.Windows.Forms.Label lb_player2_name;
        private System.Windows.Forms.PictureBox pb_player1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_dice;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button bt_instraction;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}