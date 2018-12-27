namespace GameBox
{
    partial class Winner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Winner));
            this.label1 = new System.Windows.Forms.Label();
            this.Lb_winner = new System.Windows.Forms.Label();
            this.Bt_continue = new System.Windows.Forms.Button();
            this.BT_New_game = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(269, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Winner is :";
            // 
            // Lb_winner
            // 
            this.Lb_winner.BackColor = System.Drawing.Color.Transparent;
            this.Lb_winner.Font = new System.Drawing.Font("Modern No. 20", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_winner.ForeColor = System.Drawing.Color.Gold;
            this.Lb_winner.Location = new System.Drawing.Point(269, 196);
            this.Lb_winner.Name = "Lb_winner";
            this.Lb_winner.Size = new System.Drawing.Size(342, 50);
            this.Lb_winner.TabIndex = 1;
            this.Lb_winner.Text = "Name";
            this.Lb_winner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bt_continue
            // 
            this.Bt_continue.BackColor = System.Drawing.Color.Transparent;
            this.Bt_continue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_continue.BackgroundImage")));
            this.Bt_continue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_continue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_continue.FlatAppearance.BorderSize = 0;
            this.Bt_continue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_continue.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_continue.Location = new System.Drawing.Point(380, 401);
            this.Bt_continue.Name = "Bt_continue";
            this.Bt_continue.Size = new System.Drawing.Size(133, 55);
            this.Bt_continue.TabIndex = 2;
            this.Bt_continue.Text = "Menu";
            this.Bt_continue.UseVisualStyleBackColor = false;
            this.Bt_continue.Click += new System.EventHandler(this.Bt_continue_Click);
            // 
            // BT_New_game
            // 
            this.BT_New_game.BackColor = System.Drawing.Color.Transparent;
            this.BT_New_game.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_New_game.BackgroundImage")));
            this.BT_New_game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_New_game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_New_game.FlatAppearance.BorderSize = 0;
            this.BT_New_game.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_New_game.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_New_game.Location = new System.Drawing.Point(380, 307);
            this.BT_New_game.Name = "BT_New_game";
            this.BT_New_game.Size = new System.Drawing.Size(133, 55);
            this.BT_New_game.TabIndex = 3;
            this.BT_New_game.Text = "Rematch";
            this.BT_New_game.UseVisualStyleBackColor = false;
            this.BT_New_game.Click += new System.EventHandler(this.BT_New_game_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(606, 279);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 193);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(36, 279);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(253, 193);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Winner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BT_New_game);
            this.Controls.Add(this.Bt_continue);
            this.Controls.Add(this.Lb_winner);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Winner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_winner;
        private System.Windows.Forms.Button Bt_continue;
        private System.Windows.Forms.Button BT_New_game;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}