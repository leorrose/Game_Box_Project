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
        int x, y, p1=1, p2=1,start_x,start_y;

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
            dice_value = ran.Next(1, 6);
            move(ref x,ref y, ref p1, pb_player1);
            pb_player1.Visible = true;

        }

        








        private void move(ref int x ,ref int y ,ref int pos , PictureBox pb)
        {
            if (pos == 10 || pos == 20 || pos == 30 || pos == 40 || pos == 50 || pos == 60 || pos == 70 || pos == 80 || pos == 90)
            {
                pos++;
                x =start_x;
                y -= 64;
            }
            //-----------------------------------snakes------------------------------------------------
            //else if (pos == 25)
            //{
            //    pos = 5;
            //    x = 30;
            //    y = 735;

            //}

            //else if (pos == 34)
            //{
            //    pos = 1;
            //    x = 30;
            //    y = 735;

            //}

            //else if (pos == 47)
            //{
            //    pos = 19;
            //    x = 672;
            //    y = 655;
            //}

            //else if (pos == 65)
            //{
            //    pos = 52;
            //    x = 147;
            //    y = 335;
            //}

            //else if (pos == 91)
            //{
            //    pos = 61;
            //    x = 30;
            //    y = 255;
            //}

            //else if (pos == 87)
            //{
            //    pos = 57;
            //    x = 672;
            //    y = 335;
            //}

            //else if (pos == 99)
            //{
            //    pos = 69;
            //    x = 886;
            //    y = 255;
            //}
            ////---------------------laddars--------------------------------
            //else if (pos == 3)
            //{
            //    pos = 51;
            //    x = 30;
            //    y = 335;
            //}
            //else if (pos == 6)
            //{
            //    pos = 27;
            //    x = 672;
            //    y = 575;
            //}
            //else if (pos == 20)
            //{
            //    pos = 70;
            //    x = 993;
            //    y = 255;
            //}
            //else if (pos == 36)
            //{
            //    pos = 55;
            //    x = 458;
            //    y = 335;
            //}
            //else if (pos == 63)
            //{
            //    pos = 95;
            //    x = 458;
            //    y = 15;
            //}
            //else if (pos == 68)
            //{
            //    pos = 98;
            //    x = 779;
            //    y = 15;
            //}

            else
            {
                x += 80;
                pos++;
            }

            pb.Location = new Point(x, y);

        }



        private void bt_Exit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit? Any unsaved data will be lost ", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //dialog to user 
            if (res == DialogResult.Yes)
                this.Close(); /* close all */
        }

        
    }
}
