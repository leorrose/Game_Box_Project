namespace GameBox
{
    partial class login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_user_continue = new System.Windows.Forms.Button();
            this.COB_user2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Bt_login_exit = new System.Windows.Forms.Button();
            this.Bt_login_back = new System.Windows.Forms.Button();
            this.CB_music = new System.Windows.Forms.CheckBox();
            this.TB_user_name2 = new System.Windows.Forms.TextBox();
            this.TB_password2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 34.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(388, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Player 2";
            // 
            // Bt_user_continue
            // 
            this.Bt_user_continue.BackColor = System.Drawing.Color.DarkGray;
            this.Bt_user_continue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_user_continue.BackgroundImage")));
            this.Bt_user_continue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_user_continue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_user_continue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_user_continue.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_user_continue.Location = new System.Drawing.Point(318, 366);
            this.Bt_user_continue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bt_user_continue.Name = "Bt_user_continue";
            this.Bt_user_continue.Size = new System.Drawing.Size(204, 55);
            this.Bt_user_continue.TabIndex = 8;
            this.Bt_user_continue.Text = "Login";
            this.Bt_user_continue.UseVisualStyleBackColor = false;
            this.Bt_user_continue.Click += new System.EventHandler(this.Bt_Player2_continue_Click);
            // 
            // COB_user2
            // 
            this.COB_user2.BackColor = System.Drawing.Color.Salmon;
            this.COB_user2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.COB_user2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.COB_user2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COB_user2.FormattingEnabled = true;
            this.COB_user2.ItemHeight = 22;
            this.COB_user2.Items.AddRange(new object[] {
            "Sign in",
            "Sign up"});
            this.COB_user2.Location = new System.Drawing.Point(318, 319);
            this.COB_user2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.COB_user2.Name = "COB_user2";
            this.COB_user2.Size = new System.Drawing.Size(204, 30);
            this.COB_user2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Beige;
            this.label3.Location = new System.Drawing.Point(85, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name(2-10 chars)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Beige;
            this.label5.Location = new System.Drawing.Point(85, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Password(5 chars)";
            // 
            // Bt_login_exit
            // 
            this.Bt_login_exit.BackColor = System.Drawing.Color.Black;
            this.Bt_login_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_login_exit.BackgroundImage")));
            this.Bt_login_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_login_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_login_exit.FlatAppearance.BorderSize = 0;
            this.Bt_login_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_login_exit.Location = new System.Drawing.Point(1061, 16);
            this.Bt_login_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bt_login_exit.Name = "Bt_login_exit";
            this.Bt_login_exit.Size = new System.Drawing.Size(100, 55);
            this.Bt_login_exit.TabIndex = 30;
            this.Bt_login_exit.UseVisualStyleBackColor = false;
            this.Bt_login_exit.Click += new System.EventHandler(this.Bt_login_exit_Click);
            // 
            // Bt_login_back
            // 
            this.Bt_login_back.BackColor = System.Drawing.Color.Black;
            this.Bt_login_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_login_back.BackgroundImage")));
            this.Bt_login_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_login_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_login_back.FlatAppearance.BorderSize = 0;
            this.Bt_login_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_login_back.Location = new System.Drawing.Point(955, 16);
            this.Bt_login_back.Name = "Bt_login_back";
            this.Bt_login_back.Size = new System.Drawing.Size(100, 55);
            this.Bt_login_back.TabIndex = 31;
            this.Bt_login_back.UseVisualStyleBackColor = false;
            this.Bt_login_back.Click += new System.EventHandler(this.Bt_back_Click);
            // 
            // CB_music
            // 
            this.CB_music.Appearance = System.Windows.Forms.Appearance.Button;
            this.CB_music.BackColor = System.Drawing.Color.Black;
            this.CB_music.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CB_music.BackgroundImage")));
            this.CB_music.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CB_music.Checked = true;
            this.CB_music.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_music.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_music.FlatAppearance.BorderSize = 0;
            this.CB_music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_music.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_music.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CB_music.Location = new System.Drawing.Point(23, 18);
            this.CB_music.Margin = new System.Windows.Forms.Padding(4);
            this.CB_music.Name = "CB_music";
            this.CB_music.Size = new System.Drawing.Size(157, 53);
            this.CB_music.TabIndex = 33;
            this.CB_music.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_music.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CB_music.UseVisualStyleBackColor = false;
            this.CB_music.CheckedChanged += new System.EventHandler(this.Cb_music);
            // 
            // TB_user_name2
            // 
            this.TB_user_name2.BackColor = System.Drawing.Color.Salmon;
            this.TB_user_name2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_user_name2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TB_user_name2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_user_name2.Location = new System.Drawing.Point(318, 222);
            this.TB_user_name2.Multiline = true;
            this.TB_user_name2.Name = "TB_user_name2";
            this.TB_user_name2.Size = new System.Drawing.Size(204, 32);
            this.TB_user_name2.TabIndex = 34;
            // 
            // TB_password2
            // 
            this.TB_password2.BackColor = System.Drawing.Color.Salmon;
            this.TB_password2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_password2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TB_password2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_password2.Location = new System.Drawing.Point(318, 270);
            this.TB_password2.Multiline = true;
            this.TB_password2.Name = "TB_password2";
            this.TB_password2.PasswordChar = '*';
            this.TB_password2.Size = new System.Drawing.Size(204, 34);
            this.TB_password2.TabIndex = 35;
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.ControlBox = false;
            this.Controls.Add(this.TB_password2);
            this.Controls.Add(this.TB_user_name2);
            this.Controls.Add(this.CB_music);
            this.Controls.Add(this.Bt_login_back);
            this.Controls.Add(this.Bt_login_exit);
            this.Controls.Add(this.COB_user2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Bt_user_continue);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1200, 750);
            this.MinimumSize = new System.Drawing.Size(1200, 750);
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_user_continue;
        private System.Windows.Forms.ComboBox COB_user2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Bt_login_exit;
        private System.Windows.Forms.Button Bt_login_back;
        public  System.Windows.Forms.CheckBox CB_music;
        private System.Windows.Forms.TextBox TB_user_name2;
        private System.Windows.Forms.TextBox TB_password2;
    }
}