using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace GameBox
{
    
    public partial class GameChoice : Form
    {
        Form return_back;
        public GameChoice(Form form)
        {
            InitializeComponent();
            GameBox.Program.Wmp.URL = "music.mp3";
            return_back = form;
            Program.GameChoice = false;
        }

       private void Bt_Exit_Click(object sender, EventArgs e)  //exit the program
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit? ", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //dialog to user 
            if (res == DialogResult.Yes)
                Environment.Exit(0); /* close all */
        }

        private void CB_music_CheckedChanged(object sender, EventArgs e) //music buttons
        {
            if(!CB_music.Checked)  //pause music
            {
                CB_music.Text = "Music off";
                GameBox.Program.music_OnOff = false;
                GameBox.Program.Wmp.controls.pause();
            }
            else     //play music
            {
                CB_music.Text = "Music on";
                GameBox.Program.music_OnOff = true;
                GameBox.Program.Wmp.controls.play();
            }
        }

        private void NextScreen (Boolean gamechoise)  //move to next screen
        {
            GameBox.Program.GameChoice = gamechoise;    //update choosen game
            login_form login = new login_form(this);  //open next screen
            this.Hide();               //hide current screen and show next screen.
            login.Show();
        }

        private void Bt_back_Click(object sender, EventArgs e) /* function to go back */
        {
            return_back.Show(); /*show last screen */
            MessageBox.Show(Program.user1 +" Disconected ", "Sign Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); /* hide this screen */
        }

        private void Bt_reversi_show_click(object sender, EventArgs e)
        {
            Bt_One_players_SAL.Visible = false;
            Bt_Two_players_SAL.Visible = false;
            Bt_Two_players_Reversi.Visible = true;

        }

        private void Bt_SAL_show_Click(object sender, EventArgs e)
        {
            Bt_One_players_SAL.Visible = true;
            Bt_Two_players_SAL.Visible = true;
            Bt_Two_players_Reversi.Visible = false;
        }

        private void Two_players_reversi_click(object sender, EventArgs e)  /* function to continue 2 playes to reversi */
        {
            NextScreen(true);
        }

        private void One_Player_SAL_click(object sender, EventArgs e)  /* function to continue 1 player to snake and laders */
        {
            Users_options uo = new Users_options(this);
            Program.GameChoice = false;
            this.Hide();
            uo.Show();
        }

        private void Two_Players_SAL_Click(object sender, EventArgs e) /* function to continue 2 players to snake and laders */
        {
            NextScreen(false);
        }
    }
}
