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
            this.Bt_back = new System.Windows.Forms.Button();
            this.bt_reversi = new System.Windows.Forms.Button();
            this.bt_snake_and_ladders = new System.Windows.Forms.Button();
            this.CB_music = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(292, 467);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECT GAME";
            // 
            // Bt_Exit
            // 
            this.Bt_Exit.BackColor = System.Drawing.Color.Transparent;
            this.Bt_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_Exit.BackgroundImage")));
            this.Bt_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Exit.FlatAppearance.BorderSize = 0;
            this.Bt_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_Exit.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bt_Exit.Location = new System.Drawing.Point(885, 9);
            this.Bt_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_Exit.Name = "Bt_Exit";
            this.Bt_Exit.Size = new System.Drawing.Size(100, 55);
            this.Bt_Exit.TabIndex = 8;
            this.Bt_Exit.UseVisualStyleBackColor = false;
            this.Bt_Exit.Click += new System.EventHandler(this.Bt_Exit_Click);
            // 
            // Bt_back
            // 
            this.Bt_back.BackColor = System.Drawing.Color.Transparent;
            this.Bt_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_back.BackgroundImage")));
            this.Bt_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_back.FlatAppearance.BorderSize = 0;
            this.Bt_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_back.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_back.Location = new System.Drawing.Point(776, 9);
            this.Bt_back.Name = "Bt_back";
            this.Bt_back.Size = new System.Drawing.Size(100, 55);
            this.Bt_back.TabIndex = 11;
            this.Bt_back.UseVisualStyleBackColor = false;
            this.Bt_back.Click += new System.EventHandler(this.Bt_back_Click);
            // 
            // bt_reversi
            // 
            this.bt_reversi.BackColor = System.Drawing.Color.Transparent;
            this.bt_reversi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_reversi.BackgroundImage")));
            this.bt_reversi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_reversi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_reversi.Location = new System.Drawing.Point(98, 245);
            this.bt_reversi.Name = "bt_reversi";
            this.bt_reversi.Size = new System.Drawing.Size(141, 86);
            this.bt_reversi.TabIndex = 12;
            this.bt_reversi.Text = "Reversi";
            this.bt_reversi.UseVisualStyleBackColor = false;
            this.bt_reversi.Click += new System.EventHandler(this.Bt_reversi_Click);
            // 
            // bt_snake_and_ladders
            // 
            this.bt_snake_and_ladders.BackColor = System.Drawing.Color.Transparent;
            this.bt_snake_and_ladders.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_snake_and_ladders.BackgroundImage")));
            this.bt_snake_and_ladders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_snake_and_ladders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_snake_and_ladders.Location = new System.Drawing.Point(776, 245);
            this.bt_snake_and_ladders.Name = "bt_snake_and_ladders";
            this.bt_snake_and_ladders.Size = new System.Drawing.Size(141, 86);
            this.bt_snake_and_ladders.TabIndex = 13;
            this.bt_snake_and_ladders.Text = "Snake and Ladders";
            this.bt_snake_and_ladders.UseVisualStyleBackColor = false;
            this.bt_snake_and_ladders.Click += new System.EventHandler(this.Bt_snake_and_ladders_Click);
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
            this.CB_music.Location = new System.Drawing.Point(13, 9);
            this.CB_music.Margin = new System.Windows.Forms.Padding(4);
            this.CB_music.Name = "CB_music";
            this.CB_music.Size = new System.Drawing.Size(157, 53);
            this.CB_music.TabIndex = 30;
            this.CB_music.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_music.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CB_music.UseVisualStyleBackColor = false;
            this.CB_music.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            this.Controls.Add(this.CB_music);
            this.Controls.Add(this.bt_snake_and_ladders);
            this.Controls.Add(this.bt_reversi);
            this.Controls.Add(this.Bt_back);
            this.Controls.Add(this.Bt_Exit);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1016, 609);
            this.MinimumSize = new System.Drawing.Size(1016, 609);
            this.Name = "GameChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_Exit;
        private System.Windows.Forms.Button Bt_back;
        private System.Windows.Forms.Button bt_reversi;
        private System.Windows.Forms.Button bt_snake_and_ladders;
        private System.Windows.Forms.CheckBox CB_music;
    }
}

