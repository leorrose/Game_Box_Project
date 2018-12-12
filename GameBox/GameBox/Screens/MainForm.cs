using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBox
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Shown += MainForm_Shown;
            comboBox1.SelectedIndex = 0;
            cob_players.SelectedIndex = 0;
            Program.user1 = "";
            Program.cnt_players = 0;
            Program.ManagerConected = false;
            Program.TypeUser = false;
            Program.guest = "";
        }
        private void MainForm_Shown(Object sender, EventArgs e)
        {
            Program.Update_music_bt();
        }

        private void Bt_MainForm_exit_Click(object sender, EventArgs e) /* function to exit all program! */
        {
            Program.Exit();
        }

        private void Bt_manager_login_Click(object sender, EventArgs e) /* manager login */
        {
            if (GameBox.Program.User_Check(Tb_manager_name.Text) == false || GameBox.Program.Password_Check(Tb_manager_password.Text) == false) /* check if name and password a valid */
            {
                MessageBox.Show("Invalid input","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (GameBox.Program.Check_NAME_exsist(Tb_manager_name.Text,"Managers") == 0) /* check if name exisist in database */
            {
                MessageBox.Show("Invalid User Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (GameBox.Program.Check_Password_Is_correct(Tb_manager_name.Text, Tb_manager_password.Text, "Managers") == false) /* check if password is correct */
            {
                MessageBox.Show("Invalid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GameBox.Program.ManagerConected = true; 
            Managers_option man = new Managers_option(this);
            Tb_manager_name.Text = "";
            Tb_manager_password.Text = "";
            man.Show(); /* next screen */
            this.Hide(); /* hide this screen */
        }

        private void Bt_User_login_Click(object sender, EventArgs e) /* Player login */
        {
            if (GameBox.Program.User_Check(Tb_user_name.Text) == false || GameBox.Program.Password_Check(Tb_user_password.Text) == false) /* check if name and password a valid */
            {
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBox1.Text == "Sign in") /* if combo box is on login */
            {
                if (GameBox.Program.Check_NAME_exsist(Tb_user_name.Text,"Players") == 0) /* check if name exisist in database */
                {
                    MessageBox.Show("Invalid User Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (GameBox.Program.Check_Password_Is_correct(Tb_user_name.Text, Tb_user_password.Text, "Players") == false) /* check if password is correct */
                {
                    MessageBox.Show("Invalid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (comboBox1.Text == "Sign up") /* if combo box is on sign up */
            {
                if (GameBox.Program.Insert_User_PLayers(Tb_user_name.Text, Tb_user_password.Text) == false) /* insurt user to players database */
                {
                    MessageBox.Show("User Name alreay exsist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                GameBox.Program.Insert_User__Scores(Tb_user_name.Text); /*insurt user to score database */
                MessageBox.Show("User Created!", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            GameBox.Program.user1 = Tb_user_name.Text; /* save users name */
            GameBox.Program.TypeUser = true;
            GameBox.Program.InsertLogin(Tb_user_name.Text, "Player"); /* insert login time to login database*/
            Tb_user_name.Text = "";
            Tb_user_password.Text = "";
            if (cob_players.SelectedIndex == 0)
            {
                Program.cnt_players = 1; /* count players update */
                Users_options us = new Users_options(this);
                us.Show(); /* open nex screen */
                this.Hide(); /* hide this screen */
            }
            else
            {
                Program.cnt_players = 2;
                login_form log = new login_form(this);
                log.Show();
                this.Hide();
            }
           
           
        
        }

        private void Bt_Guest_login_Click(object sender, EventArgs e) /* guest login */
        {
            if (GameBox.Program.User_Check(Tb_guest_name.Text) == false)  /* check if name is valid */
            {
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GameBox.Program.TypeUser = false;
            Program.cnt_players = 1;
            GameBox.Program.guest = Tb_guest_name.Text;  /* save guests name */
            GameBox.Program.InsertLogin(Tb_guest_name.Text, "Guest"); /* insert guest login in database*/
            Guest_wait g = new Guest_wait(this);
            Tb_guest_name.Text = "";
            Program.GameChoice = false;
            g.Show(); /* open nex screen */
            this.Hide(); /* hide this screen */

        }


        private void Bt_Continue_As_Player_Click(object sender, EventArgs e) /* hide players buttons and lable */
        {
            lb_manager_name.Visible = false;
            lb_password_manager.Visible = false;
            Bt_manager_login.Visible = false;
            Tb_manager_name.Visible = false;
            Tb_manager_password.Visible = false;
            lb_guest_name.Visible = false;
            Bt_Guest_login.Visible = false;
            Tb_guest_name.Visible = false;
            lb_player_name.Visible = true;
            lb_password_player.Visible = true;
            Bt_User_login.Visible = true;
            Tb_user_name.Visible = true;
            Tb_user_password.Visible = true;
            comboBox1.Visible = true;
            cob_players.Visible = true;
        }

        private void Bt_Continue_As_Manager_Click(object sender, EventArgs e) /* hide managers buttons and lable */
        {
            lb_manager_name.Visible = true;
            lb_password_manager.Visible = true;
            Bt_manager_login.Visible = true;
            Tb_manager_name.Visible = true;
            Tb_manager_password.Visible = true;
            lb_guest_name.Visible = false;
            Bt_Guest_login.Visible = false;
            Tb_guest_name.Visible = false;
            lb_player_name.Visible = false;
            lb_password_player.Visible = false;
            Bt_User_login.Visible = false;
            Tb_user_name.Visible = false;
            Tb_user_password.Visible = false;
            comboBox1.Visible = false;
            cob_players.Visible = false;
        }

        private void Bt_Continue_As_Guest_Click(object sender, EventArgs e) /* hide guest buttons and lable */
        {
            lb_manager_name.Visible = false;
            lb_password_manager.Visible = false;
            Bt_manager_login.Visible = false;
            Tb_manager_name.Visible = false;
            Tb_manager_password.Visible = false;
            lb_guest_name.Visible = true;
            Bt_Guest_login.Visible = true;
            Tb_guest_name.Visible = true;
            lb_player_name.Visible = false;
            lb_password_player.Visible = false;
            Bt_User_login.Visible = false;
            Tb_user_name.Visible = false;
            Tb_user_password.Visible = false;
            comboBox1.Visible = false;
            cob_players.Visible = false;
        }

        private void Bt_credits_Click(object sender, EventArgs e) /* continue to credits screen */
        {
            Credits cr = new Credits();
            cr.ShowDialog();
        }

        private void CB_music_click(object sender, EventArgs e)
        {
            Program.Music_on_off();
        }
    }
}
