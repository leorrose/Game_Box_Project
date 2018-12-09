using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GameBox
{
    public partial class Snake_and_ladders : Form
    {
        Random ran = new Random();
        int x1, y1,x2,y2, p1 = 1, p2 = 1, start_x, start_y, seconds1 = 0, seconds2 = 0, dice_value;

     

        bool turn = true; // true= player1 turn, false = player2/comuter turn;
        Form return_back, return_end;
        public Snake_and_ladders(Form back,Form EndGame)
        {
            InitializeComponent();
            if (Program.music_OnOff == false)
            {
                bt_music.BackgroundImage = Properties.Resources.Mute_red;
                bt_music.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                bt_music.BackgroundImage = Properties.Resources.Music_red;
                bt_music.BackgroundImageLayout = ImageLayout.Stretch;
            }
            return_back = back;
            return_end = EndGame;
        }

        private void bt_instraction_Click(object sender, EventArgs e)
        {
            Program.GameChoice = false;
            Print_instructions ins = new Print_instructions();
            ins.ShowDialog();
        }

        private void bt_music_Click(object sender, EventArgs e)
        {
            if (Program.music_OnOff == true)  //pause music
            {
                Program.music_OnOff = false;
                GameBox.Program.Wmp.controls.pause();
                bt_music.BackgroundImage = Properties.Resources.Mute;
                bt_music.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else     //play music
            {
                Program.music_OnOff = true;
                GameBox.Program.Wmp.controls.play();
                bt_music.BackgroundImage = Properties.Resources.Music;
                bt_music.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void Bt_SAL_back_Click(object sender, EventArgs e)
        {
            this.Close();
            return_back.Show();
        }

        private void Snake_and_ladders_Load(object sender, EventArgs e)
        {
            start_x = pb_player1.Location.X ;
            start_y = pb_player1.Location.Y;
            x1 = start_x;
            y1 = start_y;
            x2 = start_x ;
            y2 = start_y ;
            timer1.Interval = 100;
            timer2.Interval = 1000;
            timer3.Interval = 500;
            timer1.Stop();
            bt_roll.Text = Program.user1 + " ROLL!";
            labels();
         
        }

        private void labels()
        {
            if (Program.TypeUser) // if the player is a user.
            {
                lb_player1_name.Text = Program.user1 + " position: " + p1.ToString();
                if (Program.cnt_players == 2)
                    lb_player2_name.Text = Program.user2 + " position: " + p2.ToString();
                else
                    lb_player2_name.Text = "Computer position: " + p2.ToString();
                  
            }
            else  // if the player is a guest.
            {
                lb_player1_name.Text = Program.guest + " position: " + p1.ToString();
                lb_player2_name.Text = "Com position: " + p2.ToString();
            }
        }

            private void timer1_Tick(object sender, EventArgs e)
        {
            int num;
            seconds1 += 1;
            Random ran = new Random();
            num = ran.Next(1, 7);
            if (seconds1 <= 10)
                shuffle_dice(num, pb_dice, turn);
            else
            {
                timer1.Stop();
                    shuffle_dice(dice_value, pb_dice, turn);
                pb_dice.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            bt_roll.Visible = false;
            if (seconds2 >= 0)
                seconds2--;
            else
            {
                timer2.Stop();
                timer1.Start();
                dice_value = ran.Next(1, 7);
                move(ref x2, ref y2, ref p2, pb_player2, dice_value);
                snakes_ladders(ref x2, ref y2, ref p2, pb_player2);
                bt_roll.Visible = true;
                seconds1 = 0;
                turn = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void bt_roll_Click(object sender, EventArgs e)
        {
            bt_roll.Visible = false;
            dice_value = ran.Next(1, 7);
            timer1.Start();       //shuffle dice and show the correct number on last iteration.
            if (turn)
            {
                move(ref x1, ref y1, ref p1, pb_player1, dice_value);
                snakes_ladders(ref x1, ref y1, ref p1, pb_player1);
                seconds1 = 0;
                
                turn = false;
                if (Program.cnt_players == 2)
                {
                    bt_roll.BackColor = Color.Yellow;
                    bt_roll.Visible = true;
                }
            }
            else if(Program.cnt_players == 2 && !turn)
            {
                bt_roll.BackColor = Color.Red;
                move(ref x2, ref y2, ref p2, pb_player2, dice_value);
                snakes_ladders(ref x2, ref y2, ref p2, pb_player2);
                seconds1 = 0;
                turn = true;
                bt_roll.Visible = true;
            }
            if (Program.cnt_players == 1 && !turn)
            {
                seconds1 = 0;
                seconds2 = 3;
                timer2.Start();
                seconds2 = 0;
            }
            labels();
           
        }

        private void shuffle_dice(int num , PictureBox pb , bool turn)
        {
            switch(num)
            {
                case 1:
                    if(turn)  // player 1 turn, dice should be red
                        pb.Image = Properties.Resources._1y;
                    else
                        pb.Image = Properties.Resources._1r;
                    pb_dice.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 2:
                    if (turn)  // player 1 turn, dice should be red
                        pb.Image = Properties.Resources._2y;
                    else
                        pb.Image = Properties.Resources._2r;
                    pb_dice.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 3:
                    if (turn)  // player 1 turn, dice should be red
                        pb.Image = Properties.Resources._3y;
                    else
                        pb.Image = Properties.Resources._3r;
                    pb_dice.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 4:
                    if (turn)  // player 1 turn, dice should be red
                        pb.Image = Properties.Resources._4y;
                    else
                        pb.Image = Properties.Resources._4r;
                    pb_dice.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 5:
                    if (turn)  // player 1 turn, dice should be red
                        pb.Image = Properties.Resources._5y;
                    else
                        pb.Image = Properties.Resources._5r;
                    pb_dice.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 6:
                    if (turn)  // player 1 turn, dice should be red
                        pb.Image = Properties.Resources._6y;
                    else
                        pb.Image = Properties.Resources._6r;
                    pb_dice.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }

        }
       

        private void move(ref int x, ref int y, ref int pos, PictureBox pb, int dice)
        {
            if (pos + dice >= 100)
            {
                pos = 100;
                x = 742;
                y = 16;
                pb.Location = new Point(x, y);
                if(turn)
                    MessageBox.Show("player 1 win");
                else
                    MessageBox.Show("player 2 win");
            }
            else
            {
                for (int i = 0; i < dice; i++)
                {

                    if (pos == 10 || pos == 20 || pos == 30 || pos == 40 || pos == 50 || pos == 60 || pos == 70 || pos == 80 || pos == 90)
                    {
                        pos++;
                        x = start_x;
                        y -= 64;
                    }
                    else
                    {
                        x += 80;
                        pos++;
                    }


                    pb.Location = new Point(x, y);
                }

            }

        }

        private void snakes_ladders(ref int x,ref int y,ref int pos, PictureBox pb)
        {
            //--------------------------snakes-------------------------------
              if (pos == 25)
            {
                pos = 5;
                x = 342;
                y = start_y;

            }

            else if (pos == 34)
            {
                pos = 1;
                x = start_x;
                y = start_y;

            }

            else if (pos == 47)
            {
                pos = 19;
                x = 662;
                y = 533;
            }

            else if (pos == 65)
            {
                pos = 52;
                x = 102;
                y = 277;
            }

            else if (pos == 91)
            {
                pos = 61;
                x = start_x;
                y = 213;
            }

            else if (pos == 87)
            {
                pos = 57;
                y = 277;
            }

            else if (pos == 99)
            {
                pos = 69;
                y = 213;
            }
            //---------------------laddars--------------------------------
            else if (pos == 3)
            {
                pos = 51;
                x = start_x;
                y = 277;
            }
            else if (pos == 6)
            {
                pos = 27;
                x = 502;
                y = 464;
            }
            else if (pos == 20)
            {
                pos = 70;
                y = 208;
            }
            else if (pos == 36)
            {
                pos = 55;
                x = 342;
                y = 277;
            }
            else if (pos == 63)
            {
                pos = 95;
                x = 342;
                y = 16;
            }
            else if (pos == 68)
            {
                pos = 98;
                y = 16;
            }

            pb.Location = new Point(x, y);
        }
    
      


        private void bt_Exit_Click(object sender, EventArgs e)
        {
            Program.Exit();
        }

        
    }
}
