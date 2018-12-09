namespace GameBox
{
    partial class User_Managment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Managment));
            this.Bt_add = new System.Windows.Forms.Button();
            this.Bt_remove = new System.Windows.Forms.Button();
            this.Tb_User_add_Name = new System.Windows.Forms.TextBox();
            this.Tb_User_add_Password = new System.Windows.Forms.TextBox();
            this.Tb_User_remove_Name = new System.Windows.Forms.TextBox();
            this.lb_add_name = new System.Windows.Forms.Label();
            this.lb_add_password = new System.Windows.Forms.Label();
            this.Lb_remove_name = new System.Windows.Forms.Label();
            this.Bt_User_managment_back = new System.Windows.Forms.Button();
            this.Bt_User_Managment_exit = new System.Windows.Forms.Button();
            this.Remove_user_show = new System.Windows.Forms.Button();
            this.Add_user_show = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_music = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Bt_add
            // 
            this.Bt_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_add.BackgroundImage")));
            this.Bt_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_add.Location = new System.Drawing.Point(842, 396);
            this.Bt_add.Name = "Bt_add";
            this.Bt_add.Size = new System.Drawing.Size(126, 30);
            this.Bt_add.TabIndex = 0;
            this.Bt_add.Text = "Add User";
            this.Bt_add.UseVisualStyleBackColor = true;
            this.Bt_add.Visible = false;
            this.Bt_add.Click += new System.EventHandler(this.Bt_Add_user);
            // 
            // Bt_remove
            // 
            this.Bt_remove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_remove.BackgroundImage")));
            this.Bt_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_remove.Location = new System.Drawing.Point(153, 396);
            this.Bt_remove.Name = "Bt_remove";
            this.Bt_remove.Size = new System.Drawing.Size(126, 30);
            this.Bt_remove.TabIndex = 1;
            this.Bt_remove.Text = "Remove User";
            this.Bt_remove.UseVisualStyleBackColor = true;
            this.Bt_remove.Visible = false;
            this.Bt_remove.Click += new System.EventHandler(this.Bt_Remove_user);
            // 
            // Tb_User_add_Name
            // 
            this.Tb_User_add_Name.BackColor = System.Drawing.Color.Salmon;
            this.Tb_User_add_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_User_add_Name.Location = new System.Drawing.Point(842, 331);
            this.Tb_User_add_Name.Name = "Tb_User_add_Name";
            this.Tb_User_add_Name.Size = new System.Drawing.Size(126, 22);
            this.Tb_User_add_Name.TabIndex = 2;
            this.Tb_User_add_Name.Visible = false;
            // 
            // Tb_User_add_Password
            // 
            this.Tb_User_add_Password.BackColor = System.Drawing.Color.Salmon;
            this.Tb_User_add_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_User_add_Password.Location = new System.Drawing.Point(842, 359);
            this.Tb_User_add_Password.Name = "Tb_User_add_Password";
            this.Tb_User_add_Password.PasswordChar = '*';
            this.Tb_User_add_Password.Size = new System.Drawing.Size(126, 22);
            this.Tb_User_add_Password.TabIndex = 3;
            this.Tb_User_add_Password.Visible = false;
            // 
            // Tb_User_remove_Name
            // 
            this.Tb_User_remove_Name.BackColor = System.Drawing.Color.Salmon;
            this.Tb_User_remove_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_User_remove_Name.Location = new System.Drawing.Point(153, 332);
            this.Tb_User_remove_Name.Name = "Tb_User_remove_Name";
            this.Tb_User_remove_Name.Size = new System.Drawing.Size(126, 22);
            this.Tb_User_remove_Name.TabIndex = 4;
            this.Tb_User_remove_Name.Visible = false;
            // 
            // lb_add_name
            // 
            this.lb_add_name.AutoSize = true;
            this.lb_add_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_add_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_add_name.ForeColor = System.Drawing.Color.Beige;
            this.lb_add_name.Location = new System.Drawing.Point(694, 336);
            this.lb_add_name.Name = "lb_add_name";
            this.lb_add_name.Size = new System.Drawing.Size(139, 17);
            this.lb_add_name.TabIndex = 21;
            this.lb_add_name.Text = "Name(2-10 chars)";
            this.lb_add_name.Visible = false;
            // 
            // lb_add_password
            // 
            this.lb_add_password.AutoSize = true;
            this.lb_add_password.BackColor = System.Drawing.Color.Transparent;
            this.lb_add_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_add_password.ForeColor = System.Drawing.Color.Beige;
            this.lb_add_password.Location = new System.Drawing.Point(694, 364);
            this.lb_add_password.Name = "lb_add_password";
            this.lb_add_password.Size = new System.Drawing.Size(143, 17);
            this.lb_add_password.TabIndex = 31;
            this.lb_add_password.Text = "Password(5 chars)";
            this.lb_add_password.Visible = false;
            // 
            // Lb_remove_name
            // 
            this.Lb_remove_name.AutoSize = true;
            this.Lb_remove_name.BackColor = System.Drawing.Color.Transparent;
            this.Lb_remove_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Lb_remove_name.ForeColor = System.Drawing.Color.Beige;
            this.Lb_remove_name.Location = new System.Drawing.Point(6, 336);
            this.Lb_remove_name.Name = "Lb_remove_name";
            this.Lb_remove_name.Size = new System.Drawing.Size(139, 17);
            this.Lb_remove_name.TabIndex = 32;
            this.Lb_remove_name.Text = "Name(2-10 chars)";
            this.Lb_remove_name.Visible = false;
            // 
            // Bt_User_managment_back
            // 
            this.Bt_User_managment_back.BackColor = System.Drawing.Color.Transparent;
            this.Bt_User_managment_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_User_managment_back.BackgroundImage")));
            this.Bt_User_managment_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_User_managment_back.FlatAppearance.BorderSize = 0;
            this.Bt_User_managment_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_User_managment_back.Location = new System.Drawing.Point(780, 12);
            this.Bt_User_managment_back.Name = "Bt_User_managment_back";
            this.Bt_User_managment_back.Size = new System.Drawing.Size(100, 55);
            this.Bt_User_managment_back.TabIndex = 33;
            this.Bt_User_managment_back.UseVisualStyleBackColor = false;
            this.Bt_User_managment_back.Click += new System.EventHandler(this.Bt_User_managment_back_Click);
            // 
            // Bt_User_Managment_exit
            // 
            this.Bt_User_Managment_exit.BackColor = System.Drawing.Color.Transparent;
            this.Bt_User_Managment_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_User_Managment_exit.BackgroundImage")));
            this.Bt_User_Managment_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_User_Managment_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_User_Managment_exit.FlatAppearance.BorderSize = 0;
            this.Bt_User_Managment_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_User_Managment_exit.Location = new System.Drawing.Point(886, 12);
            this.Bt_User_Managment_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bt_User_Managment_exit.Name = "Bt_User_Managment_exit";
            this.Bt_User_Managment_exit.Size = new System.Drawing.Size(100, 55);
            this.Bt_User_Managment_exit.TabIndex = 34;
            this.Bt_User_Managment_exit.UseVisualStyleBackColor = false;
            this.Bt_User_Managment_exit.Click += new System.EventHandler(this.Bt_User_Managment_exit_Click);
            // 
            // Remove_user_show
            // 
            this.Remove_user_show.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Remove_user_show.BackgroundImage")));
            this.Remove_user_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Remove_user_show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Remove_user_show.Location = new System.Drawing.Point(65, 229);
            this.Remove_user_show.Name = "Remove_user_show";
            this.Remove_user_show.Size = new System.Drawing.Size(161, 83);
            this.Remove_user_show.TabIndex = 36;
            this.Remove_user_show.Text = "Remove User";
            this.Remove_user_show.UseVisualStyleBackColor = true;
            this.Remove_user_show.Click += new System.EventHandler(this.Remove_user_show_Click);
            // 
            // Add_user_show
            // 
            this.Add_user_show.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add_user_show.BackgroundImage")));
            this.Add_user_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Add_user_show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_user_show.Location = new System.Drawing.Point(774, 229);
            this.Add_user_show.Name = "Add_user_show";
            this.Add_user_show.Size = new System.Drawing.Size(161, 83);
            this.Add_user_show.TabIndex = 37;
            this.Add_user_show.Text = "Add User";
            this.Add_user_show.UseVisualStyleBackColor = true;
            this.Add_user_show.Click += new System.EventHandler(this.Add_user_show_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Beige;
            this.label2.Location = new System.Drawing.Point(377, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 34);
            this.label2.TabIndex = 38;
            this.label2.Text = "Manage Players";
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
            this.CB_music.Location = new System.Drawing.Point(9, 14);
            this.CB_music.Margin = new System.Windows.Forms.Padding(4);
            this.CB_music.Name = "CB_music";
            this.CB_music.Size = new System.Drawing.Size(157, 53);
            this.CB_music.TabIndex = 39;
            this.CB_music.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_music.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CB_music.UseVisualStyleBackColor = false;
            this.CB_music.CheckedChanged += new System.EventHandler(this.CB_music_click);
            // 
            // User_Managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 562);
            this.ControlBox = false;
            this.Controls.Add(this.CB_music);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Add_user_show);
            this.Controls.Add(this.Remove_user_show);
            this.Controls.Add(this.Bt_User_Managment_exit);
            this.Controls.Add(this.Bt_User_managment_back);
            this.Controls.Add(this.Lb_remove_name);
            this.Controls.Add(this.lb_add_password);
            this.Controls.Add(this.lb_add_name);
            this.Controls.Add(this.Tb_User_remove_Name);
            this.Controls.Add(this.Tb_User_add_Password);
            this.Controls.Add(this.Tb_User_add_Name);
            this.Controls.Add(this.Bt_remove);
            this.Controls.Add(this.Bt_add);
            this.MaximumSize = new System.Drawing.Size(1016, 609);
            this.MinimumSize = new System.Drawing.Size(1016, 609);
            this.Name = "User_Managment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_Managment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_add;
        private System.Windows.Forms.Button Bt_remove;
        private System.Windows.Forms.TextBox Tb_User_add_Name;
        private System.Windows.Forms.TextBox Tb_User_add_Password;
        private System.Windows.Forms.TextBox Tb_User_remove_Name;
        private System.Windows.Forms.Label lb_add_name;
        private System.Windows.Forms.Label lb_add_password;
        private System.Windows.Forms.Label Lb_remove_name;
        private System.Windows.Forms.Button Bt_User_managment_back;
        private System.Windows.Forms.Button Bt_User_Managment_exit;
        private System.Windows.Forms.Button Remove_user_show;
        private System.Windows.Forms.Button Add_user_show;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CB_music;
    }
}