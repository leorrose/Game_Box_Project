namespace GameBox
{
    partial class Manager_Managment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_Managment));
            this.Add_Manager_show = new System.Windows.Forms.Button();
            this.Remove_Manager_show = new System.Windows.Forms.Button();
            this.Bt_User_Managment_exit = new System.Windows.Forms.Button();
            this.Bt_User_managment_back = new System.Windows.Forms.Button();
            this.lb_remove_name = new System.Windows.Forms.Label();
            this.lb_add_password = new System.Windows.Forms.Label();
            this.lb_add_name = new System.Windows.Forms.Label();
            this.Tb_Manager_remove_Name = new System.Windows.Forms.TextBox();
            this.Tb_Manager_add_Password = new System.Windows.Forms.TextBox();
            this.Tb_Manager_add_Name = new System.Windows.Forms.TextBox();
            this.Bt_remove = new System.Windows.Forms.Button();
            this.Bt_add_manager = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_music = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Add_Manager_show
            // 
            this.Add_Manager_show.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add_Manager_show.BackgroundImage")));
            this.Add_Manager_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Add_Manager_show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_Manager_show.Location = new System.Drawing.Point(769, 242);
            this.Add_Manager_show.Name = "Add_Manager_show";
            this.Add_Manager_show.Size = new System.Drawing.Size(161, 83);
            this.Add_Manager_show.TabIndex = 50;
            this.Add_Manager_show.Text = "Add Manager";
            this.Add_Manager_show.UseVisualStyleBackColor = true;
            this.Add_Manager_show.Click += new System.EventHandler(this.Add_Manager_show_click);
            // 
            // Remove_Manager_show
            // 
            this.Remove_Manager_show.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Remove_Manager_show.BackgroundImage")));
            this.Remove_Manager_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Remove_Manager_show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Remove_Manager_show.Location = new System.Drawing.Point(65, 242);
            this.Remove_Manager_show.Name = "Remove_Manager_show";
            this.Remove_Manager_show.Size = new System.Drawing.Size(161, 83);
            this.Remove_Manager_show.TabIndex = 49;
            this.Remove_Manager_show.Text = "Remove Manager";
            this.Remove_Manager_show.UseVisualStyleBackColor = true;
            this.Remove_Manager_show.Click += new System.EventHandler(this.Remove_Manager_show_click);
            // 
            // Bt_User_Managment_exit
            // 
            this.Bt_User_Managment_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_User_Managment_exit.BackgroundImage")));
            this.Bt_User_Managment_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_User_Managment_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_User_Managment_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_User_Managment_exit.Location = new System.Drawing.Point(916, 14);
            this.Bt_User_Managment_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bt_User_Managment_exit.Name = "Bt_User_Managment_exit";
            this.Bt_User_Managment_exit.Size = new System.Drawing.Size(72, 43);
            this.Bt_User_Managment_exit.TabIndex = 47;
            this.Bt_User_Managment_exit.UseVisualStyleBackColor = true;
            this.Bt_User_Managment_exit.Click += new System.EventHandler(this.Bt_Manager_Managment_exit_Click);
            // 
            // Bt_User_managment_back
            // 
            this.Bt_User_managment_back.BackColor = System.Drawing.Color.Black;
            this.Bt_User_managment_back.BackgroundImage = global::GameBox.Properties.Resources.Back;
            this.Bt_User_managment_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_User_managment_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_User_managment_back.Location = new System.Drawing.Point(835, 14);
            this.Bt_User_managment_back.Name = "Bt_User_managment_back";
            this.Bt_User_managment_back.Size = new System.Drawing.Size(75, 43);
            this.Bt_User_managment_back.TabIndex = 46;
            this.Bt_User_managment_back.UseVisualStyleBackColor = false;
            this.Bt_User_managment_back.Click += new System.EventHandler(this.Bt_Manager_managment_back_Click);
            // 
            // lb_remove_name
            // 
            this.lb_remove_name.AutoSize = true;
            this.lb_remove_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_remove_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_remove_name.ForeColor = System.Drawing.Color.Beige;
            this.lb_remove_name.Location = new System.Drawing.Point(3, 342);
            this.lb_remove_name.Name = "lb_remove_name";
            this.lb_remove_name.Size = new System.Drawing.Size(139, 17);
            this.lb_remove_name.TabIndex = 45;
            this.lb_remove_name.Text = "Name(2-10 chars)";
            this.lb_remove_name.Visible = false;
            // 
            // lb_add_password
            // 
            this.lb_add_password.AutoSize = true;
            this.lb_add_password.BackColor = System.Drawing.Color.Transparent;
            this.lb_add_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_add_password.ForeColor = System.Drawing.Color.Beige;
            this.lb_add_password.Location = new System.Drawing.Point(700, 374);
            this.lb_add_password.Name = "lb_add_password";
            this.lb_add_password.Size = new System.Drawing.Size(143, 17);
            this.lb_add_password.TabIndex = 44;
            this.lb_add_password.Text = "Password(5 chars)";
            this.lb_add_password.Visible = false;
            // 
            // lb_add_name
            // 
            this.lb_add_name.AutoSize = true;
            this.lb_add_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_add_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_add_name.ForeColor = System.Drawing.Color.Beige;
            this.lb_add_name.Location = new System.Drawing.Point(699, 344);
            this.lb_add_name.Name = "lb_add_name";
            this.lb_add_name.Size = new System.Drawing.Size(139, 17);
            this.lb_add_name.TabIndex = 43;
            this.lb_add_name.Text = "Name(2-10 chars)";
            this.lb_add_name.Visible = false;
            // 
            // Tb_Manager_remove_Name
            // 
            this.Tb_Manager_remove_Name.BackColor = System.Drawing.Color.SandyBrown;
            this.Tb_Manager_remove_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Manager_remove_Name.Location = new System.Drawing.Point(146, 341);
            this.Tb_Manager_remove_Name.Name = "Tb_Manager_remove_Name";
            this.Tb_Manager_remove_Name.Size = new System.Drawing.Size(126, 22);
            this.Tb_Manager_remove_Name.TabIndex = 42;
            this.Tb_Manager_remove_Name.Visible = false;
            // 
            // Tb_Manager_add_Password
            // 
            this.Tb_Manager_add_Password.BackColor = System.Drawing.Color.SandyBrown;
            this.Tb_Manager_add_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Manager_add_Password.Location = new System.Drawing.Point(851, 369);
            this.Tb_Manager_add_Password.Name = "Tb_Manager_add_Password";
            this.Tb_Manager_add_Password.PasswordChar = '*';
            this.Tb_Manager_add_Password.Size = new System.Drawing.Size(125, 22);
            this.Tb_Manager_add_Password.TabIndex = 41;
            this.Tb_Manager_add_Password.Visible = false;
            // 
            // Tb_Manager_add_Name
            // 
            this.Tb_Manager_add_Name.BackColor = System.Drawing.Color.SandyBrown;
            this.Tb_Manager_add_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Manager_add_Name.Location = new System.Drawing.Point(851, 341);
            this.Tb_Manager_add_Name.Name = "Tb_Manager_add_Name";
            this.Tb_Manager_add_Name.Size = new System.Drawing.Size(125, 22);
            this.Tb_Manager_add_Name.TabIndex = 40;
            this.Tb_Manager_add_Name.Visible = false;
            // 
            // Bt_remove
            // 
            this.Bt_remove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_remove.BackgroundImage")));
            this.Bt_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_remove.Location = new System.Drawing.Point(146, 407);
            this.Bt_remove.Name = "Bt_remove";
            this.Bt_remove.Size = new System.Drawing.Size(126, 30);
            this.Bt_remove.TabIndex = 39;
            this.Bt_remove.Text = "Remove Manager";
            this.Bt_remove.UseVisualStyleBackColor = true;
            this.Bt_remove.Visible = false;
            this.Bt_remove.Click += new System.EventHandler(this.Bt_remove_manager_click);
            // 
            // Bt_add_manager
            // 
            this.Bt_add_manager.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_add_manager.BackgroundImage")));
            this.Bt_add_manager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_add_manager.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_add_manager.Location = new System.Drawing.Point(851, 407);
            this.Bt_add_manager.Name = "Bt_add_manager";
            this.Bt_add_manager.Size = new System.Drawing.Size(125, 30);
            this.Bt_add_manager.TabIndex = 38;
            this.Bt_add_manager.Text = "Add Manager";
            this.Bt_add_manager.UseVisualStyleBackColor = true;
            this.Bt_add_manager.Visible = false;
            this.Bt_add_manager.Click += new System.EventHandler(this.Bt_add_manager_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(370, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 34);
            this.label2.TabIndex = 51;
            this.label2.Text = "Manage Managers";
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
            this.CB_music.Location = new System.Drawing.Point(13, 13);
            this.CB_music.Margin = new System.Windows.Forms.Padding(4);
            this.CB_music.Name = "CB_music";
            this.CB_music.Size = new System.Drawing.Size(68, 44);
            this.CB_music.TabIndex = 52;
            this.CB_music.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_music.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CB_music.UseVisualStyleBackColor = false;
            // 
            // Manager_Managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 562);
            this.ControlBox = false;
            this.Controls.Add(this.CB_music);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Add_Manager_show);
            this.Controls.Add(this.Remove_Manager_show);
            this.Controls.Add(this.Bt_User_Managment_exit);
            this.Controls.Add(this.Bt_User_managment_back);
            this.Controls.Add(this.lb_remove_name);
            this.Controls.Add(this.lb_add_password);
            this.Controls.Add(this.lb_add_name);
            this.Controls.Add(this.Tb_Manager_remove_Name);
            this.Controls.Add(this.Tb_Manager_add_Password);
            this.Controls.Add(this.Tb_Manager_add_Name);
            this.Controls.Add(this.Bt_remove);
            this.Controls.Add(this.Bt_add_manager);
            this.MaximumSize = new System.Drawing.Size(1016, 609);
            this.MinimumSize = new System.Drawing.Size(1016, 609);
            this.Name = "Manager_Managment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager_Managment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Manager_show;
        private System.Windows.Forms.Button Remove_Manager_show;
        private System.Windows.Forms.Button Bt_User_Managment_exit;
        private System.Windows.Forms.Button Bt_User_managment_back;
        private System.Windows.Forms.Label lb_remove_name;
        private System.Windows.Forms.Label lb_add_password;
        private System.Windows.Forms.Label lb_add_name;
        private System.Windows.Forms.TextBox Tb_Manager_remove_Name;
        private System.Windows.Forms.TextBox Tb_Manager_add_Password;
        private System.Windows.Forms.TextBox Tb_Manager_add_Name;
        private System.Windows.Forms.Button Bt_remove;
        private System.Windows.Forms.Button Bt_add_manager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CB_music;
    }
}