using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib; // צריך להוסיף
using System.Data.SqlClient; //צריך להוסיף
using System.IO;  //צריך להוסיף
using System.Reflection; //צריך להוסיף

namespace GameBox
{
    public partial class login_form : Form
    {
        Form return_back;
        public login_form(Form form)
        {
            InitializeComponent();
            Shown += login_form_Shown;
            COB_user2.SelectedIndex = 0;
            return_back = form;
            Program.cnt_players = 1;
            Program.user2 = "";
        }
        private void login_form_Shown(Object sender, EventArgs e)
        {
            Program.Update_music_bt();
        }
        private void Bt_login_exit_Click(object sender, EventArgs e) /* function to exit */
        {
            Program.Exit();

        }

        private void Bt_Player2_continue_Click(object sender, EventArgs e) /* login player 2 */
        {
            if (Program.Test_Insert_Text(TB_user_name2.Text) == false || Program.Test_Insert_Text(TB_password2.Text) == false)
            {
                MessageBox.Show("Only english characters and numbers allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TB_user_name2.Text == Program.user1)
            {
                MessageBox.Show(Program.user1 + " is allready conected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (GameBox.Program.User_Check(TB_user_name2.Text) == false || GameBox.Program.Password_Check(TB_password2.Text) == false) /* check if name and password a valid */
            {
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (COB_user2.Text == "Sign in") /* if combo box is on login */
            {
                if (GameBox.Program.Check_NAME_exsist(TB_user_name2.Text, "Players") == 0) /* check if name exisist in database */
                {
                    MessageBox.Show("Invalid User Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (GameBox.Program.Check_Password_Is_correct(TB_user_name2.Text, TB_password2.Text, "Players") == false) /* check if password is correct */
                {
                    MessageBox.Show("Invalid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else if (COB_user2.Text == "Sign up") /* if conbo box is on sign up */
            {
                if (GameBox.Program.Insert_User_PLayers(TB_user_name2.Text, TB_password2.Text) == false) /* insurt user to players database */
                {
                    MessageBox.Show("User Name alreay exsist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                GameBox.Program.Insert_User__Scores(TB_user_name2.Text);  /*insurt user to score database */
                MessageBox.Show("User Created!", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            GameBox.Program.user2 = TB_user_name2.Text; /* save users name */
            GameBox.Program.cnt_players = 2; /* count players update */
            GameBox.Program.InsertLogin(TB_user_name2.Text, "Player"); /* insert login time to login database*/
            Users_options uo = new Users_options(this);
            TB_password2.Text = "";
            TB_user_name2.Text = "";
            this.Hide();  /* open nex screen */
            uo.Show(); /* hide this screen */
        }

        private void Bt_back_Click(object sender, EventArgs e) /* go back function*/
        {
            return_back.Show(); /* show last screen*/
            MessageBox.Show(Program.user1 + " disconected", "Sign out", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); /* hide this screen*/
        }


        private void Cb_music(object sender, EventArgs e)
        {
            Program.Music_on_off();
        }
    }
}
