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
    public partial class Snake_and_ladders : Form
    {
        int dice_value;
        Random ran = new Random();
        int x, y, p1 = 1, p2 = 1, start_x, start_y;

        public Snake_and_ladders()
        {
            InitializeComponent();
            start_x = pb_player1.Location.X;
            start_y = pb_player1.Location.Y;
            x = start_x;
            y = start_y;

        }

        private void bt_roll_Click(object sender, EventArgs e)
        {
            dice_value = ran.Next(1, 7);
            pb_dice.Image = Image.FromFile(@"C:\Users\Ori\Desktop\game project\Poject_Yesodot_Group_6\GameBox\GameBox\Resources\" + dice_value.ToString() + ".png");
            pb_dice.SizeMode = PictureBoxSizeMode.StretchImage;

            move(ref x, ref y, ref p1, pb_player1, dice_value);
            snakes_ladders(ref x, ref y, ref p1, pb_player1);

        }

       

        private void move(ref int x, ref int y, ref int pos, PictureBox pb, int dice)
        {
            if (pos + dice > 100)
            {
                pos = 100;
                x = 742;
                y = 16;
                pb.Location = new Point(x, y);
                MessageBox.Show("win");

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
