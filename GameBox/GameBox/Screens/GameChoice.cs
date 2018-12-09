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
            if (Program.cnt_players != 2)
                bt_reversi.Enabled = false;
            return_back = form;
        }

       private void Bt_Exit_Click(object sender, EventArgs e)  //exit the program
        {
            Program.Exit();
        }


        private void Bt_back_Click(object sender, EventArgs e) /* function to go back */
        {
            return_back.Show(); /*show last screen */
            this.Close(); /* hide this screen */
        }

    

        private void Bt_reversi_Click(object sender, EventArgs e)
        {
            Reversi NewGame = new Reversi(this,return_back);
            this.Hide();
            NewGame.Show();
        }

        private void Bt_snake_and_ladders_Click(object sender, EventArgs e)
        {
            this.Hide();
            Snake_and_ladders game = new Snake_and_ladders(this, return_back);
            game.Show();
        }

        private void CB_music_click(object sender, EventArgs e)
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

        private void reversi_insruction_Click(object sender, EventArgs e)
        {
            Program.GameChoice = true;
            Print_instructions ins = new Print_instructions();
            ins.Show();
        }

        private void SAl_instruction_Click(object sender, EventArgs e)
        {
            Program.GameChoice = false;
            Print_instructions ins = new Print_instructions();
            ins.Show();
        }
    }
}
