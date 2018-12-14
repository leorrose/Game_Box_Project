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
            this.Bt_selectgame_Exit = new System.Windows.Forms.Button();
            this.Bt_selectgame_back = new System.Windows.Forms.Button();
            this.bt_reversi = new System.Windows.Forms.Button();
            this.bt_snake_and_ladders = new System.Windows.Forms.Button();
            this.CB_music = new System.Windows.Forms.CheckBox();
            this.SAl_instruction = new System.Windows.Forms.Button();
            this.reversi_insruction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(374, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECT GAME";
            // 
            // Bt_selectgame_Exit
            // 
            this.Bt_selectgame_Exit.BackColor = System.Drawing.Color.Black;
            this.Bt_selectgame_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_selectgame_Exit.BackgroundImage")));
            this.Bt_selectgame_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_selectgame_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_selectgame_Exit.FlatAppearance.BorderSize = 0;
            this.Bt_selectgame_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_selectgame_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_selectgame_Exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bt_selectgame_Exit.Location = new System.Drawing.Point(1069, 13);
            this.Bt_selectgame_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_selectgame_Exit.Name = "Bt_selectgame_Exit";
            this.Bt_selectgame_Exit.Size = new System.Drawing.Size(100, 55);
            this.Bt_selectgame_Exit.TabIndex = 8;
            this.Bt_selectgame_Exit.UseVisualStyleBackColor = false;
            this.Bt_selectgame_Exit.Click += new System.EventHandler(this.Bt_Exit_Click);
            // 
            // Bt_selectgame_back
            // 
            this.Bt_selectgame_back.BackColor = System.Drawing.Color.Black;
            this.Bt_selectgame_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_selectgame_back.BackgroundImage")));
            this.Bt_selectgame_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_selectgame_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_selectgame_back.FlatAppearance.BorderSize = 0;
            this.Bt_selectgame_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_selectgame_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_selectgame_back.Location = new System.Drawing.Point(962, 13);
            this.Bt_selectgame_back.Name = "Bt_selectgame_back";
            this.Bt_selectgame_back.Size = new System.Drawing.Size(100, 55);
            this.Bt_selectgame_back.TabIndex = 11;
            this.Bt_selectgame_back.UseVisualStyleBackColor = false;
            this.Bt_selectgame_back.Click += new System.EventHandler(this.Bt_back_Click);
            // 
            // bt_reversi
            // 
            this.bt_reversi.BackColor = System.Drawing.Color.Transparent;
            this.bt_reversi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_reversi.BackgroundImage")));
            this.bt_reversi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_reversi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_reversi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_reversi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reversi.Location = new System.Drawing.Point(105, 245);
            this.bt_reversi.Name = "bt_reversi";
            this.bt_reversi.Size = new System.Drawing.Size(175, 86);
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
            this.bt_snake_and_ladders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_snake_and_ladders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_snake_and_ladders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_snake_and_ladders.Location = new System.Drawing.Point(934, 245);
            this.bt_snake_and_ladders.Name = "bt_snake_and_ladders";
            this.bt_snake_and_ladders.Size = new System.Drawing.Size(175, 86);
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
            this.CB_music.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_music.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CB_music.Location = new System.Drawing.Point(24, 15);
            this.CB_music.Margin = new System.Windows.Forms.Padding(4);
            this.CB_music.Name = "CB_music";
            this.CB_music.Size = new System.Drawing.Size(157, 53);
            this.CB_music.TabIndex = 30;
            this.CB_music.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_music.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CB_music.UseVisualStyleBackColor = false;
            this.CB_music.CheckedChanged += new System.EventHandler(this.CB_music_click);
            // 
            // SAl_instruction
            // 
            this.SAl_instruction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SAl_instruction.BackgroundImage")));
            this.SAl_instruction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SAl_instruction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SAl_instruction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SAl_instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAl_instruction.Location = new System.Drawing.Point(934, 354);
            this.SAl_instruction.Name = "SAl_instruction";
            this.SAl_instruction.Size = new System.Drawing.Size(175, 57);
            this.SAl_instruction.TabIndex = 31;
            this.SAl_instruction.Text = "Instructions";
            this.SAl_instruction.UseVisualStyleBackColor = true;
            this.SAl_instruction.Click += new System.EventHandler(this.SAl_instruction_Click);
            // 
            // reversi_insruction
            // 
            this.reversi_insruction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reversi_insruction.BackgroundImage")));
            this.reversi_insruction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reversi_insruction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reversi_insruction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reversi_insruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reversi_insruction.Location = new System.Drawing.Point(105, 354);
            this.reversi_insruction.Name = "reversi_insruction";
            this.reversi_insruction.Size = new System.Drawing.Size(175, 57);
            this.reversi_insruction.TabIndex = 32;
            this.reversi_insruction.Text = "Instructions";
            this.reversi_insruction.UseVisualStyleBackColor = true;
            this.reversi_insruction.Click += new System.EventHandler(this.reversi_insruction_Click);
            // 
            // GameChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.ControlBox = false;
            this.Controls.Add(this.reversi_insruction);
            this.Controls.Add(this.SAl_instruction);
            this.Controls.Add(this.CB_music);
            this.Controls.Add(this.bt_snake_and_ladders);
            this.Controls.Add(this.bt_reversi);
            this.Controls.Add(this.Bt_selectgame_back);
            this.Controls.Add(this.Bt_selectgame_Exit);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1200, 750);
            this.MinimumSize = new System.Drawing.Size(1200, 750);
            this.Name = "GameChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_selectgame_Exit;
        private System.Windows.Forms.Button Bt_selectgame_back;
        private System.Windows.Forms.Button bt_reversi;
        private System.Windows.Forms.Button bt_snake_and_ladders;
        public  System.Windows.Forms.CheckBox CB_music;
        private System.Windows.Forms.Button SAl_instruction;
        private System.Windows.Forms.Button reversi_insruction;
    }
}

