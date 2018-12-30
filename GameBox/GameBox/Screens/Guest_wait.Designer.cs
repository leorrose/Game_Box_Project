namespace GameBox
{
    partial class Guest_wait
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guest_wait));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bt_guistwait_exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Bt_guistwait_back = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.CB_music = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(577, 557);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "5";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bt_guistwait_exit
            // 
            this.bt_guistwait_exit.BackColor = System.Drawing.Color.Black;
            this.bt_guistwait_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_guistwait_exit.BackgroundImage")));
            this.bt_guistwait_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_guistwait_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_guistwait_exit.FlatAppearance.BorderSize = 0;
            this.bt_guistwait_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_guistwait_exit.Location = new System.Drawing.Point(1070, 10);
            this.bt_guistwait_exit.Name = "bt_guistwait_exit";
            this.bt_guistwait_exit.Size = new System.Drawing.Size(100, 55);
            this.bt_guistwait_exit.TabIndex = 0;
            this.bt_guistwait_exit.TabStop = false;
            this.bt_guistwait_exit.UseVisualStyleBackColor = false;
            this.bt_guistwait_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Beige;
            this.label2.Location = new System.Drawing.Point(348, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(485, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Registered users don\'t need to wait!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Beige;
            this.label3.Location = new System.Drawing.Point(499, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Please wait...";
            // 
            // Bt_guistwait_back
            // 
            this.Bt_guistwait_back.BackColor = System.Drawing.Color.Black;
            this.Bt_guistwait_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_guistwait_back.BackgroundImage")));
            this.Bt_guistwait_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_guistwait_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_guistwait_back.FlatAppearance.BorderSize = 0;
            this.Bt_guistwait_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_guistwait_back.Location = new System.Drawing.Point(964, 10);
            this.Bt_guistwait_back.Name = "Bt_guistwait_back";
            this.Bt_guistwait_back.Size = new System.Drawing.Size(100, 55);
            this.Bt_guistwait_back.TabIndex = 0;
            this.Bt_guistwait_back.TabStop = false;
            this.Bt_guistwait_back.UseVisualStyleBackColor = false;
            this.Bt_guistwait_back.Click += new System.EventHandler(this.Bt_back_Click);
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
            this.CB_music.Location = new System.Drawing.Point(25, 13);
            this.CB_music.Margin = new System.Windows.Forms.Padding(4);
            this.CB_music.Name = "CB_music";
            this.CB_music.Size = new System.Drawing.Size(157, 53);
            this.CB_music.TabIndex = 0;
            this.CB_music.TabStop = false;
            this.CB_music.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_music.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CB_music.UseVisualStyleBackColor = false;
            this.CB_music.CheckedChanged += new System.EventHandler(this.CB_music_click);
            // 
            // Guest_wait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.ControlBox = false;
            this.Controls.Add(this.CB_music);
            this.Controls.Add(this.Bt_guistwait_back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_guistwait_exit);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximumSize = new System.Drawing.Size(1200, 750);
            this.MinimumSize = new System.Drawing.Size(1200, 750);
            this.Name = "Guest_wait";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bt_guistwait_exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bt_guistwait_back;
        private System.Windows.Forms.Timer timer2;
        public  System.Windows.Forms.CheckBox CB_music;
    }
}