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

      

        private void Bt_back_Click(object sender, EventArgs e) /* function to go back */
        {
            return_back.Show(); /*show last screen */
            this.Close(); /* hide this screen */
        }

    

        private void bt_reversi_Click(object sender, EventArgs e)
        {

        }

        private void bt_snake_and_ladders_Click(object sender, EventArgs e)
        {

        }
    }
}
