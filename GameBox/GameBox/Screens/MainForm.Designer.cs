namespace GameBox
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Tb_user_password = new System.Windows.Forms.TextBox();
            this.Tb_manager_password = new System.Windows.Forms.TextBox();
            this.Tb_user_name = new System.Windows.Forms.TextBox();
            this.Tb_guest_name = new System.Windows.Forms.TextBox();
            this.Tb_manager_name = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Bt_User_login = new System.Windows.Forms.Button();
            this.Bt_manager_login = new System.Windows.Forms.Button();
            this.Bt_Guest_login = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_manager_name = new System.Windows.Forms.Label();
            this.lb_password_manager = new System.Windows.Forms.Label();
            this.lb_player_name = new System.Windows.Forms.Label();
            this.Bt_credits = new System.Windows.Forms.Button();
            this.CB_music = new System.Windows.Forms.CheckBox();
            this.Bt_MainForm_exit = new System.Windows.Forms.Button();
            this.lb_password_player = new System.Windows.Forms.Label();
            this.lb_guest_name = new System.Windows.Forms.Label();
            this.Bt_Continue_As_Manager = new System.Windows.Forms.Button();
            this.Bt_Continue_As_Player = new System.Windows.Forms.Button();
            this.Bt_Continue_As_Guest = new System.Windows.Forms.Button();
            this.cob_players = new System.Windows.Forms.ComboBox();
            this.Bt_why_to_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tb_user_password
            // 
            this.Tb_user_password.BackColor = System.Drawing.Color.Salmon;
            this.Tb_user_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_user_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tb_user_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_user_password.Location = new System.Drawing.Point(508, 368);
            this.Tb_user_password.Multiline = true;
            this.Tb_user_password.Name = "Tb_user_password";
            this.Tb_user_password.PasswordChar = '*';
            this.Tb_user_password.Size = new System.Drawing.Size(168, 30);
            this.Tb_user_password.TabIndex = 0;
            this.Tb_user_password.Visible = false;
            // 
            // Tb_manager_password
            // 
            this.Tb_manager_password.BackColor = System.Drawing.Color.Salmon;
            this.Tb_manager_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_manager_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tb_manager_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_manager_password.Location = new System.Drawing.Point(508, 210);
            this.Tb_manager_password.Multiline = true;
            this.Tb_manager_password.Name = "Tb_manager_password";
            this.Tb_manager_password.PasswordChar = '*';
            this.Tb_manager_password.Size = new System.Drawing.Size(168, 30);
            this.Tb_manager_password.TabIndex = 1;
            this.Tb_manager_password.Visible = false;
            // 
            // Tb_user_name
            // 
            this.Tb_user_name.BackColor = System.Drawing.Color.Salmon;
            this.Tb_user_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_user_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tb_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_user_name.Location = new System.Drawing.Point(508, 322);
            this.Tb_user_name.Multiline = true;
            this.Tb_user_name.Name = "Tb_user_name";
            this.Tb_user_name.Size = new System.Drawing.Size(168, 30);
            this.Tb_user_name.TabIndex = 2;
            this.Tb_user_name.Visible = false;
            // 
            // Tb_guest_name
            // 
            this.Tb_guest_name.BackColor = System.Drawing.Color.Salmon;
            this.Tb_guest_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_guest_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tb_guest_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_guest_name.Location = new System.Drawing.Point(508, 521);
            this.Tb_guest_name.Multiline = true;
            this.Tb_guest_name.Name = "Tb_guest_name";
            this.Tb_guest_name.Size = new System.Drawing.Size(168, 32);
            this.Tb_guest_name.TabIndex = 3;
            this.Tb_guest_name.Visible = false;
            // 
            // Tb_manager_name
            // 
            this.Tb_manager_name.BackColor = System.Drawing.Color.Salmon;
            this.Tb_manager_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_manager_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tb_manager_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_manager_name.Location = new System.Drawing.Point(508, 166);
            this.Tb_manager_name.Multiline = true;
            this.Tb_manager_name.Name = "Tb_manager_name";
            this.Tb_manager_name.Size = new System.Drawing.Size(168, 30);
            this.Tb_manager_name.TabIndex = 4;
            this.Tb_manager_name.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Salmon;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DisplayMember = "0";
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sign in",
            "Sign up"});
            this.comboBox1.Location = new System.Drawing.Point(508, 414);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 33);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "0";
            this.comboBox1.Visible = false;
            // 
            // Bt_User_login
            // 
            this.Bt_User_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_User_login.BackgroundImage")));
            this.Bt_User_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_User_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_User_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_User_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_User_login.Location = new System.Drawing.Point(732, 335);
            this.Bt_User_login.Name = "Bt_User_login";
            this.Bt_User_login.Size = new System.Drawing.Size(96, 46);
            this.Bt_User_login.TabIndex = 6;
            this.Bt_User_login.Text = "Login";
            this.Bt_User_login.UseVisualStyleBackColor = true;
            this.Bt_User_login.Visible = false;
            this.Bt_User_login.Click += new System.EventHandler(this.Bt_User_login_Click);
            // 
            // Bt_manager_login
            // 
            this.Bt_manager_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_manager_login.BackgroundImage")));
            this.Bt_manager_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_manager_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_manager_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_manager_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_manager_login.Location = new System.Drawing.Point(732, 166);
            this.Bt_manager_login.Name = "Bt_manager_login";
            this.Bt_manager_login.Size = new System.Drawing.Size(96, 46);
            this.Bt_manager_login.TabIndex = 7;
            this.Bt_manager_login.Text = "Login";
            this.Bt_manager_login.UseVisualStyleBackColor = true;
            this.Bt_manager_login.Visible = false;
            this.Bt_manager_login.Click += new System.EventHandler(this.Bt_manager_login_Click);
            // 
            // Bt_Guest_login
            // 
            this.Bt_Guest_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_Guest_login.BackgroundImage")));
            this.Bt_Guest_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_Guest_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Guest_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_Guest_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Guest_login.Location = new System.Drawing.Point(732, 521);
            this.Bt_Guest_login.Name = "Bt_Guest_login";
            this.Bt_Guest_login.Size = new System.Drawing.Size(96, 46);
            this.Bt_Guest_login.TabIndex = 8;
            this.Bt_Guest_login.Text = "Login";
            this.Bt_Guest_login.UseVisualStyleBackColor = true;
            this.Bt_Guest_login.Visible = false;
            this.Bt_Guest_login.Click += new System.EventHandler(this.Bt_Guest_login_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Beige;
            this.label9.Location = new System.Drawing.Point(372, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(508, 69);
            this.label9.TabIndex = 17;
            this.label9.Text = "GameNost Game";
            // 
            // lb_manager_name
            // 
            this.lb_manager_name.AutoSize = true;
            this.lb_manager_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_manager_name.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_manager_name.ForeColor = System.Drawing.Color.Beige;
            this.lb_manager_name.Location = new System.Drawing.Point(296, 166);
            this.lb_manager_name.Name = "lb_manager_name";
            this.lb_manager_name.Size = new System.Drawing.Size(174, 22);
            this.lb_manager_name.TabIndex = 20;
            this.lb_manager_name.Text = "Name (2-10 chars)";
            this.lb_manager_name.Visible = false;
            // 
            // lb_password_manager
            // 
            this.lb_password_manager.AutoSize = true;
            this.lb_password_manager.BackColor = System.Drawing.Color.Transparent;
            this.lb_password_manager.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password_manager.ForeColor = System.Drawing.Color.Beige;
            this.lb_password_manager.Location = new System.Drawing.Point(296, 210);
            this.lb_password_manager.Name = "lb_password_manager";
            this.lb_password_manager.Size = new System.Drawing.Size(180, 22);
            this.lb_password_manager.TabIndex = 21;
            this.lb_password_manager.Text = "Password (5 chars)";
            this.lb_password_manager.Visible = false;
            // 
            // lb_player_name
            // 
            this.lb_player_name.AutoSize = true;
            this.lb_player_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_player_name.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_player_name.ForeColor = System.Drawing.Color.Beige;
            this.lb_player_name.Location = new System.Drawing.Point(296, 322);
            this.lb_player_name.Name = "lb_player_name";
            this.lb_player_name.Size = new System.Drawing.Size(174, 22);
            this.lb_player_name.TabIndex = 23;
            this.lb_player_name.Text = "Name (2-10 chars)";
            this.lb_player_name.Visible = false;
            // 
            // Bt_credits
            // 
            this.Bt_credits.BackColor = System.Drawing.Color.Transparent;
            this.Bt_credits.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_credits.BackgroundImage")));
            this.Bt_credits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_credits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_credits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_credits.Location = new System.Drawing.Point(1033, 636);
            this.Bt_credits.Name = "Bt_credits";
            this.Bt_credits.Size = new System.Drawing.Size(137, 55);
            this.Bt_credits.TabIndex = 27;
            this.Bt_credits.UseVisualStyleBackColor = false;
            this.Bt_credits.Click += new System.EventHandler(this.Bt_credits_Click);
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
            this.CB_music.Location = new System.Drawing.Point(26, 13);
            this.CB_music.Margin = new System.Windows.Forms.Padding(4);
            this.CB_music.Name = "CB_music";
            this.CB_music.Size = new System.Drawing.Size(157, 53);
            this.CB_music.TabIndex = 28;
            this.CB_music.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_music.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CB_music.UseVisualStyleBackColor = false;
            this.CB_music.CheckedChanged += new System.EventHandler(this.CB_music_click);
            // 
            // Bt_MainForm_exit
            // 
            this.Bt_MainForm_exit.BackColor = System.Drawing.Color.Black;
            this.Bt_MainForm_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_MainForm_exit.BackgroundImage")));
            this.Bt_MainForm_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_MainForm_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_MainForm_exit.FlatAppearance.BorderSize = 0;
            this.Bt_MainForm_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Bt_MainForm_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Bt_MainForm_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_MainForm_exit.Location = new System.Drawing.Point(1070, 13);
            this.Bt_MainForm_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bt_MainForm_exit.Name = "Bt_MainForm_exit";
            this.Bt_MainForm_exit.Size = new System.Drawing.Size(100, 55);
            this.Bt_MainForm_exit.TabIndex = 29;
            this.Bt_MainForm_exit.UseVisualStyleBackColor = false;
            this.Bt_MainForm_exit.Click += new System.EventHandler(this.Bt_MainForm_exit_Click);
            // 
            // lb_password_player
            // 
            this.lb_password_player.AutoSize = true;
            this.lb_password_player.BackColor = System.Drawing.Color.Transparent;
            this.lb_password_player.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password_player.ForeColor = System.Drawing.Color.Beige;
            this.lb_password_player.Location = new System.Drawing.Point(296, 376);
            this.lb_password_player.Name = "lb_password_player";
            this.lb_password_player.Size = new System.Drawing.Size(180, 22);
            this.lb_password_player.TabIndex = 30;
            this.lb_password_player.Text = "Password (5 chars)";
            this.lb_password_player.Visible = false;
            // 
            // lb_guest_name
            // 
            this.lb_guest_name.AutoSize = true;
            this.lb_guest_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_guest_name.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_guest_name.ForeColor = System.Drawing.Color.Beige;
            this.lb_guest_name.Location = new System.Drawing.Point(296, 526);
            this.lb_guest_name.Name = "lb_guest_name";
            this.lb_guest_name.Size = new System.Drawing.Size(174, 22);
            this.lb_guest_name.TabIndex = 31;
            this.lb_guest_name.Text = "Name (2-10 chars)";
            this.lb_guest_name.Visible = false;
            // 
            // Bt_Continue_As_Manager
            // 
            this.Bt_Continue_As_Manager.BackColor = System.Drawing.Color.Transparent;
            this.Bt_Continue_As_Manager.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_Continue_As_Manager.BackgroundImage")));
            this.Bt_Continue_As_Manager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_Continue_As_Manager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Continue_As_Manager.FlatAppearance.BorderSize = 0;
            this.Bt_Continue_As_Manager.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_Continue_As_Manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Continue_As_Manager.Location = new System.Drawing.Point(88, 151);
            this.Bt_Continue_As_Manager.Name = "Bt_Continue_As_Manager";
            this.Bt_Continue_As_Manager.Size = new System.Drawing.Size(168, 89);
            this.Bt_Continue_As_Manager.TabIndex = 32;
            this.Bt_Continue_As_Manager.Text = "Continue As Manager";
            this.Bt_Continue_As_Manager.UseVisualStyleBackColor = false;
            this.Bt_Continue_As_Manager.Click += new System.EventHandler(this.Bt_Continue_As_Manager_Click);
            // 
            // Bt_Continue_As_Player
            // 
            this.Bt_Continue_As_Player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_Continue_As_Player.BackgroundImage")));
            this.Bt_Continue_As_Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_Continue_As_Player.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Continue_As_Player.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_Continue_As_Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Continue_As_Player.Location = new System.Drawing.Point(88, 322);
            this.Bt_Continue_As_Player.Name = "Bt_Continue_As_Player";
            this.Bt_Continue_As_Player.Size = new System.Drawing.Size(168, 90);
            this.Bt_Continue_As_Player.TabIndex = 33;
            this.Bt_Continue_As_Player.Text = "Continue As Player";
            this.Bt_Continue_As_Player.UseVisualStyleBackColor = true;
            this.Bt_Continue_As_Player.Click += new System.EventHandler(this.Bt_Continue_As_Player_Click);
            // 
            // Bt_Continue_As_Guest
            // 
            this.Bt_Continue_As_Guest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_Continue_As_Guest.BackgroundImage")));
            this.Bt_Continue_As_Guest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_Continue_As_Guest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Continue_As_Guest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_Continue_As_Guest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Continue_As_Guest.Location = new System.Drawing.Point(88, 499);
            this.Bt_Continue_As_Guest.Name = "Bt_Continue_As_Guest";
            this.Bt_Continue_As_Guest.Size = new System.Drawing.Size(168, 90);
            this.Bt_Continue_As_Guest.TabIndex = 34;
            this.Bt_Continue_As_Guest.Text = "Continue As Guest";
            this.Bt_Continue_As_Guest.UseVisualStyleBackColor = true;
            this.Bt_Continue_As_Guest.Click += new System.EventHandler(this.Bt_Continue_As_Guest_Click);
            // 
            // cob_players
            // 
            this.cob_players.BackColor = System.Drawing.Color.Salmon;
            this.cob_players.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cob_players.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cob_players.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_players.FormattingEnabled = true;
            this.cob_players.Items.AddRange(new object[] {
            "1 Player",
            "2 Players"});
            this.cob_players.Location = new System.Drawing.Point(508, 461);
            this.cob_players.Name = "cob_players";
            this.cob_players.Size = new System.Drawing.Size(168, 33);
            this.cob_players.TabIndex = 35;
            this.cob_players.Visible = false;
            // 
            // Bt_why_to_register
            // 
            this.Bt_why_to_register.BackColor = System.Drawing.Color.Transparent;
            this.Bt_why_to_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_why_to_register.FlatAppearance.BorderSize = 0;
            this.Bt_why_to_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_why_to_register.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_why_to_register.ForeColor = System.Drawing.Color.Beige;
            this.Bt_why_to_register.Location = new System.Drawing.Point(461, 570);
            this.Bt_why_to_register.Name = "Bt_why_to_register";
            this.Bt_why_to_register.Size = new System.Drawing.Size(258, 33);
            this.Bt_why_to_register.TabIndex = 36;
            this.Bt_why_to_register.Text = "Why should i register ?";
            this.Bt_why_to_register.UseVisualStyleBackColor = false;
            this.Bt_why_to_register.Visible = false;
            this.Bt_why_to_register.Click += new System.EventHandler(this.Bt_why_to_register_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.ControlBox = false;
            this.Controls.Add(this.Bt_why_to_register);
            this.Controls.Add(this.cob_players);
            this.Controls.Add(this.Bt_Continue_As_Guest);
            this.Controls.Add(this.Bt_Continue_As_Player);
            this.Controls.Add(this.Bt_Continue_As_Manager);
            this.Controls.Add(this.lb_guest_name);
            this.Controls.Add(this.lb_password_player);
            this.Controls.Add(this.Bt_MainForm_exit);
            this.Controls.Add(this.CB_music);
            this.Controls.Add(this.Bt_credits);
            this.Controls.Add(this.lb_player_name);
            this.Controls.Add(this.lb_password_manager);
            this.Controls.Add(this.lb_manager_name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Bt_Guest_login);
            this.Controls.Add(this.Bt_manager_login);
            this.Controls.Add(this.Bt_User_login);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Tb_manager_name);
            this.Controls.Add(this.Tb_guest_name);
            this.Controls.Add(this.Tb_user_name);
            this.Controls.Add(this.Tb_manager_password);
            this.Controls.Add(this.Tb_user_password);
            this.MaximumSize = new System.Drawing.Size(1200, 750);
            this.MinimumSize = new System.Drawing.Size(1031, 588);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_user_password;
        private System.Windows.Forms.TextBox Tb_manager_password;
        private System.Windows.Forms.TextBox Tb_user_name;
        private System.Windows.Forms.TextBox Tb_guest_name;
        private System.Windows.Forms.TextBox Tb_manager_name;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Bt_User_login;
        private System.Windows.Forms.Button Bt_manager_login;
        private System.Windows.Forms.Button Bt_Guest_login;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_manager_name;
        private System.Windows.Forms.Label lb_password_manager;
        private System.Windows.Forms.Label lb_player_name;
        private System.Windows.Forms.Button Bt_credits;
        public System.Windows.Forms.CheckBox CB_music;
        private System.Windows.Forms.Button Bt_MainForm_exit;
        private System.Windows.Forms.Label lb_password_player;
        private System.Windows.Forms.Label lb_guest_name;
        private System.Windows.Forms.Button Bt_Continue_As_Manager;
        private System.Windows.Forms.Button Bt_Continue_As_Player;
        private System.Windows.Forms.Button Bt_Continue_As_Guest;
        private System.Windows.Forms.ComboBox cob_players;
        private System.Windows.Forms.Button Bt_why_to_register;
    }
}