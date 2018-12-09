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
    public partial class Users_options : Form
    {
        Form return_back;
        public Users_options(Form form)
        {
            InitializeComponent();
            if(Program.music_OnOff == false)
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
            if(Program.TypeUser==false)
            {
                Bt_Continue_change_details.Enabled = false;
                button4.Enabled = false;
                button3.Enabled = false;
                Bt_Givefeedback.Enabled = false;
            }
        }

        private void Bt_UserOptions_exit_Click(object sender, EventArgs e) /*exit function */
        {
            Program.Exit();
        }

        private void Bt_Change_Details(object sender, EventArgs e) /* function to change user deatails */
        {
            Change_details temp = new Change_details(this);
            temp.Show();
            this.Hide();
        }

        private void Bt_UserOPtions_Back(object sender, EventArgs e)/* function to go back */
        {
            return_back.Show();
            if (Program.TypeUser == false)
                this.Close();
            else if (Program.cnt_players == 2)
                MessageBox.Show(Program.user2 + " disconected ", "Sign Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(Program.user1 + " disconected ", "Sign Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Program.user2 = "";
            this.Close();
        }

        private void Bt_Give_feedback(object sender, EventArgs e) /*function to give feedback */
        {
            Feedback_form FF = new Feedback_form(this);
            FF.Show();
            this.Hide();
        }

        private void Bt_Personal_scores(object sender, EventArgs e) /* function to show user scores info */
        {
            Reports rep = new Reports(this, "Personal scores");
            this.Hide();
            rep.Show();
        }

        private void Bt_Top_Players(object sender, EventArgs e) /* function to shpw top users by  score */
        {
            Reports rep = new Reports(this, "Top Players");
            this.Hide();
            rep.Show();
        }

        private void Bt_Play_game(object sender, EventArgs e) /* function to continue to game  */
        {
            if (Program.TypeUser == false )
            {
                Print_screen ins = new Print_screen("Ads");
                ins.ShowDialog();
            }
            GameChoice ga = new GameChoice(this);
            this.Hide();
            ga.Show();
        }



        private void Bt_get_tip(object sender, EventArgs e)
        {
            Print_screen ins = new Print_screen("Tips");
            ins.ShowDialog();
        }

        private void Bt_Instructions(object sender, EventArgs e)
        {
            Print_instructions ins = new Print_instructions();
            ins.ShowDialog();
        }

        private void CB_music_CheckedChanged(object sender, EventArgs e)
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
