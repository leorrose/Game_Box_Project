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
    public partial class Change_details : Form
    {
        Form return_back;
        public Change_details(Form form)
        {
            InitializeComponent();
            if (Program.music_OnOff == false)
            {
                CB_music.BackgroundImage = Properties.Resources.Mute;
                CB_music.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                CB_music.BackgroundImage = Properties.Resources.Music;
                CB_music.BackgroundImageLayout = ImageLayout.Stretch;
            }
            return_back = form;
        }

        private void Bt_Change_details_exit_Click(object sender, EventArgs e)
        {
            Program.Exit();
        }

        private void Bt_Update_Click(object sender, EventArgs e)
        {
            if (GameBox.Program.Check_NAME_exsist(Tb_Existing_Name.Text, "Players") == 0)
            {
                MessageBox.Show("Invalid Existing User Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (GameBox.Program.Check_Password_Is_correct(Tb_Existing_Name.Text, Tb_Existing_Password.Text, "Players") == false)
            {
                MessageBox.Show("Invalid Existing Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Program.User_Check(Tb_New_Name.Text) == false || Program.Password_Check(Tb_New_Password.Text) == false)
            {
                MessageBox.Show("Invalid New user input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (GameBox.Program.Check_NAME_exsist(Tb_New_Name.Text, "Players") > 1 )
            {
                MessageBox.Show("Invalid New User Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GameBox.Program.Upadte_User_players(Tb_Existing_Name.Text, Tb_New_Password.Text, Tb_New_Name.Text);
            GameBox.Program.Upadte_User_Scores(Tb_Existing_Name.Text, Tb_New_Name.Text);
            GameBox.Program.user1 = Tb_New_Name.Text;
            MessageBox.Show("user updated");
            Tb_Existing_Name.Text = "";
            Tb_Existing_Password.Text = "";
            Tb_New_Password.Text = "";
            Tb_New_Name.Text = "";

        }



        private void Bt_Change_Details_back_Click(object sender, EventArgs e)
        {
            return_back.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Program.music_OnOff == true)  //pause music
            {
                Program.music_OnOff = false;
                GameBox.Program.Wmp.controls.pause();
                CB_music.BackgroundImage = Properties.Resources.Mute;
                CB_music.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else     //play music
            {
                Program.music_OnOff = true;
                GameBox.Program.Wmp.controls.play();
                CB_music.BackgroundImage = Properties.Resources.Music;
                CB_music.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
    }
}
