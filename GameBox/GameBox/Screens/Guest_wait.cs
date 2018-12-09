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
    public partial class Guest_wait : Form
    {
        Form return_back;
        public Guest_wait(Form form)
        {
            InitializeComponent();
            return_back = form;
            timer1.Start();
        }
        int duration = 4;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = duration.ToString();
            if (duration == 0)
            {
                timer1.Stop();
                Users_options uo = new Users_options(return_back);
                this.Hide();
                uo.Show();
            }
            duration--;
        }



        private void bt_exit_Click(object sender, EventArgs e)
        {
            Program.Exit();
        }

        private void Bt_back_Click(object sender, EventArgs e)
        {
            return_back.Show();
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

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
    }
}
