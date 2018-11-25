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
            this.CB_music2 = new System.Windows.Forms.CheckBox();
            this.TB_user_name2 = new System.Windows.Forms.MaskedTextBox();
            this.TB_password2 = new System.Windows.Forms.MaskedTextBox();
            this.Bt_user_continue = new System.Windows.Forms.Button();
            this.COB_user2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Bt_MainForm_exit = new System.Windows.Forms.Button();
            this.Bt_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 34.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(64, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Player 2";
            // 
            // CB_music2
            // 
            this.CB_music2.AutoSize = true;
            this.CB_music2.BackColor = System.Drawing.Color.Transparent;
            this.CB_music2.Checked = true;
            this.CB_music2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_music2.FlatAppearance.BorderSize = 0;
            this.CB_music2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_music2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_music2.ForeColor = System.Drawing.Color.Gold;
            this.CB_music2.Image = ((System.Drawing.Image)(resources.GetObject("CB_music2.Image")));
            this.CB_music2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CB_music2.Location = new System.Drawing.Point(7, -7);
            this.CB_music2.Margin = new System.Windows.Forms.Padding(4);
            this.CB_music2.Name = "CB_music2";
            this.CB_music2.Size = new System.Drawing.Size(196, 48);
            this.CB_music2.TabIndex = 26;
            this.CB_music2.Text = "Music on";
            this.CB_music2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CB_music2.UseVisualStyleBackColor = false;
            this.CB_music2.CheckedChanged += new System.EventHandler(this.CB_music2_CheckedChanged);
            // 
            // TB_user_name2
            // 
            this.TB_user_name2.Location = new System.Drawing.Point(191, 232);
            this.TB_user_name2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_user_name2.Name = "TB_user_name2";
            this.TB_user_name2.Size = new System.Drawing.Size(165, 22);
            this.TB_user_name2.TabIndex = 1;
            // 
            // TB_password2
            // 
            this.TB_password2.Location = new System.Drawing.Point(191, 266);
            this.TB_password2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_password2.Name = "TB_password2";
            this.TB_password2.PasswordChar = '*';
            this.TB_password2.Size = new System.Drawing.Size(165, 22);
            this.TB_password2.TabIndex = 6;
            // 
            // Bt_user_continue
            // 
            this.Bt_user_continue.BackColor = System.Drawing.Color.DarkGray;
            this.Bt_user_continue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_user_continue.Location = new System.Drawing.Point(191, 346);
            this.Bt_user_continue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bt_user_continue.Name = "Bt_user_continue";
            this.Bt_user_continue.Size = new System.Drawing.Size(165, 50);
            this.Bt_user_continue.TabIndex = 8;
            this.Bt_user_continue.Text = "Continue As User";
            this.Bt_user_continue.UseVisualStyleBackColor = false;
            this.Bt_user_continue.Click += new System.EventHandler(this.Bt_Player2_continue_Click);
            // 
            // COB_user2
            // 
            this.COB_user2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.COB_user2.FormattingEnabled = true;
            this.COB_user2.Items.AddRange(new object[] {
            "Login",
            "Sign up"});
            this.COB_user2.Location = new System.Drawing.Point(191, 300);
            this.COB_user2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.COB_user2.Name = "COB_user2";
            this.COB_user2.Size = new System.Drawing.Size(165, 24);
            this.COB_user2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(40, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name(2-10 chars)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(40, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Password(5 chars)";
            // 
            // Bt_MainForm_exit
            // 
            this.Bt_MainForm_exit.BackColor = System.Drawing.Color.Gainsboro;
            this.Bt_MainForm_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_MainForm_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_MainForm_exit.Location = new System.Drawing.Point(904, 11);
            this.Bt_MainForm_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bt_MainForm_exit.Name = "Bt_MainForm_exit";
            this.Bt_MainForm_exit.Size = new System.Drawing.Size(85, 41);
            this.Bt_MainForm_exit.TabIndex = 30;
            this.Bt_MainForm_exit.Text = "Exit";
            this.Bt_MainForm_exit.UseVisualStyleBackColor = false;
            this.Bt_MainForm_exit.Click += new System.EventHandler(this.Bt_login_exit_Click);
            // 
            // Bt_back
            // 
            this.Bt_back.Location = new System.Drawing.Point(813, 12);
            this.Bt_back.Name = "Bt_back";
            this.Bt_back.Size = new System.Drawing.Size(85, 40);
            this.Bt_back.TabIndex = 31;
            this.Bt_back.Text = "Back";
            this.Bt_back.UseVisualStyleBackColor = true;
            this.Bt_back.Click += new System.EventHandler(this.Bt_back_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 562);
            this.ControlBox = false;
            this.Controls.Add(this.Bt_back);
            this.Controls.Add(this.Bt_MainForm_exit);
            this.Controls.Add(this.CB_music2);
            this.Controls.Add(this.COB_user2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Bt_user_continue);
            this.Controls.Add(this.TB_password2);
            this.Controls.Add(this.TB_user_name2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CB_music2;
        private System.Windows.Forms.MaskedTextBox TB_user_name2;
        private System.Windows.Forms.MaskedTextBox TB_password2;
        private System.Windows.Forms.Button Bt_user_continue;
        private System.Windows.Forms.ComboBox COB_user2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Bt_MainForm_exit;
        private System.Windows.Forms.Button Bt_back;
    }
}