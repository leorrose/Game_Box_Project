using System;
using System.Windows.Forms;

namespace GameBox
{
    public partial class Reversi : Form
    {
        Form ReturnForm;
        Form options;
        public int[,] arr = new int[8,8];
        public int playerTurn =0;
        public Reversi(Form form , Form End )
        {
            InitializeComponent();
            Shown += Reversi_Shown;
            Lb_Player_turn.Text = Program.user1;
            Lb_player1.Text = Program.user1;
            Lb_player2.Text = Program.user2;
            ReturnForm = form;
            options = End;
            for(int i=0; i<8; ++i)
            {
                for(int j=0; j<8; ++j)
                {
                   arr [i, j] = 0;
                }
            }
            arr[3, 3] = 2;
            arr[3, 4] = 1;
            arr[4, 3] = 1;
            arr[4, 4] = 2;
        }
        private void Reversi_Shown(Object sender, EventArgs e)
        {
            Program.Update_music_bt();
            Turn_picture_box_Black(pictureBox_D4);
            Turn_picture_box_Black(pictureBox_E5);
            Turn_picture_box_White(pictureBox_D5);
            Turn_picture_box_White(pictureBox_E4);
        }
        public void Bt_reversi_music(object sender, EventArgs e) => Program.Music_on_off();
        private void Bt_Reversi_back_click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure? Any unsaved data will be lost", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
                ReturnForm.Show();
            }
        }

        private void Bt_Reversi_Exit_click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure? Any unsaved data will be lost", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
                Environment.Exit(0);
        }
        private void Bt_reversi_instuctions_Click(object sender, EventArgs e)
        {
            Program.GameChoice = true;
            Print_instructions ins = new Print_instructions();
            ins.ShowDialog();
        }
        public void Turn_picture_box_Black(PictureBox pic)
        {
            pic.BackgroundImage = Properties.Resources.Black_piece;
            pic.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public void Turn_picture_box_White(PictureBox pic)
        {
            pic.BackgroundImage = Properties.Resources.white_piece;
            pic.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void Picture_box_clicked(int i, int j,PictureBox pic)
        {
            pic.Enabled = false;
            if (playerTurn % 2 == 0)
            {
                Lb_Player_turn.Text = Program.user2;
                arr[i, j] = 1; //white
                FixArr(i, j, 1);
            }
            else
            {
                Lb_Player_turn.Text = Program.user1;
                arr[i, j] = 2; //black
                FixArr(i, j, 2);
            }
            playerTurn += 1;
            Print_table();
            EndGame();
        }
        public void sum()
        {
            int Sum1 = 0, Sum2 = 0;
            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    if (arr[i, j] == 1)
                        Sum1 += 1;
                    else if (arr[i, j] == 2)
                        Sum2 += 1;
                }
            }
            Lb_Score1.Text = Sum1.ToString();
            Lb_Score2.Text = Sum2.ToString();
        }
        private void FixArr(int i, int j, int player)
        {
            Up_col_check(i, j, player);
            Down_col_check(i, j, player);
            right_row_check(i, j, player);
            Left_row_check(i, j, player);
            Left_Up_slant_check(i, j, player);
            Right_Up_slant_check(i, j, player);
            left_Down_slant_check(i, j, player);
            Right_Down_slant_check(i, j, player);

        }
        public void Up_col_check(int i, int j, int player)
        {
            int index = -1, flag = 0;
            for (int k = i - 1; k >= 0; --k)
            {
                if (arr[k, j] == player && flag != 1)
                {
                    index = k;
                    flag = 1;
                }
                else if (arr[k, j] == 0 && flag != 1)
                {
                    index = -1;
                    flag = 1;
                }
            }
            if (index != -1)
            {
                for (int k = index; k < i; ++k)
                {
                    arr[k, j] = player;
                }
            }
        }
        public void Down_col_check(int i, int j, int player)
        {
            int index = -1, flag = 0;
            for (int k = i + 1; k <= 7; ++k)
            {
                if (arr[k, j] == player && flag != 1)
                {
                    index = k;
                    flag = 1;
                }
                else if (arr[k, j] == 0 && flag != 1)
                {
                    index = -1;
                    flag = 1;
                }
            }
            if (index != -1)
            {
                for (int k = index; k > i; --k)
                {
                    arr[k, j] = player;
                }
            }
        }
        public void right_row_check(int i, int j, int player)
        {
            int index = -1, flag = 0;
            for (int k = j + 1; k <= 7; ++k)
            {
                if (arr[i, k] == player && flag != 1)
                {
                    index = k;
                    flag = 1;
                }
                else if (arr[i, k] == 0 && flag != 1)
                {
                    index = -1;
                    flag = 1;
                }
            }
            if (index != -1)
            {
                for (int k = index; k > j; --k)
                {
                    arr[i, k] = player;
                }
            }
        }
        public void Left_row_check(int i, int j, int player)
        {
            int index = -1, flag = 0;
            for (int k = j - 1; k >= 0; --k)
            {
                if (arr[i, k] == player && flag != 1)
                {
                    index = k;
                    flag = 1;
                }
                else if (arr[i, k] == 0 && flag != 1)
                {
                    index = -1;
                    flag = 1;
                }
            }
            if (index != -1)
            {
                for (int k = index; k < j; ++k)
                {
                    arr[i, k] = player;
                }
            }
        }
        public void Left_Up_slant_check(int i, int j, int player)
        {
            int indexX = -1, indexY = -1, flag = 0;
            for (int k = i - 1, z = j - 1; k >= 0 && z >= 0; --k, --z)
            {
                if (arr[k, z] == player && flag != 1)
                {
                    indexX = k;
                    indexY = z;
                    flag = 1;
                }
                else if (arr[k, z] == 0 && flag != 1)
                {
                    indexX = -1;
                    indexY = -1;
                    flag = 1;
                }
            }
            if (indexX != -1 && indexY != -1)
            {
                for (int k = indexX, z = indexY; k < i && z < j; ++k, ++z)
                {
                    arr[k, z] = player;
                }
            }
        }
        public void Right_Up_slant_check(int i, int j, int player)
        {
            int indexX = -1, indexY = -1, flag = 0;
            for (int k = i - 1, z = j + 1; k >= 0 && z <= 7; --k, ++z)
            {
                if (arr[k, z] == player && flag != 1)
                {
                    indexX = k;
                    indexY = z;
                    flag = 1;
                }
                else if (arr[k, z] == 0 && flag != 1)
                {
                    indexX = -1;
                    indexY = -1;
                    flag = 1;
                }
            }
            if (indexX != -1 && indexY != -1)
            {
                for (int k = indexX, z = indexY; k < i && z > j; ++k, --z)
                {
                    arr[k, z] = player;
                }
            }
        }
        public void left_Down_slant_check(int i, int j, int player)
        {
            int indexX = -1, indexY = -1, flag = 0;
            for (int k = i + 1, z = j - 1; k <= 7 && z >= 0; ++k, --z)
            {
                if (arr[k, z] == player && flag != 1)
                {
                    indexX = k;
                    indexY = z;
                    flag = 1;
                }
                else if (arr[k, z] == 0 && flag != 1)
                {
                    indexX = -1;
                    indexY = -1;
                    flag = 1;
                }
            }
            if (indexX != -1 && indexY != -1)
            {
                for (int k = indexX, z = indexY; k > i && z < j; --k, ++z)
                {
                    arr[k, z] = player;
                }
            }
        }
        public void Right_Down_slant_check(int i, int j, int player)
        {
            int indexX = -1, indexY = -1, flag = 0;
            for (int k = i + 1, z = j + 1; k <= 7 && z <= 7; ++k, ++z)
            {
                if (arr[k, z] == player && flag != 1)
                {
                    indexX = k;
                    indexY = z;
                    flag = 1;
                }
                else if (arr[k, z] == 0 && flag != 1)
                {
                    indexX = -1;
                    indexY = -1;
                    flag = 1;
                }
            }
            if (indexX != -1 && indexY != -1)
            {
                for (int k = indexX, z = indexY; k > i && z > j; --k, --z)
                {
                    arr[k, z] = player;
                }
            }
        }
        private void EndGame()
        {
            int Sum1 = 0, Sum2 = 0, flag = 0;
            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    if (arr[i, j] == 1)
                        Sum1 += 1;
                    else if (arr[i, j] == 2)
                        Sum2 += 1;
                    else
                        flag = 1;

                }
            }
            if (flag == 0)
            {
                if (Sum1 > Sum2)
                {
                    Winner Win = new Winner(Program.user1, options, this, ReturnForm);
                    Win.Show();
                    Program.Update_Win_reversi(Program.user1);
                    Program.Update_Lose(Program.user2);
                }
                else if (Sum2 > Sum1)
                {
                    Winner Win = new Winner(Program.user2, options, this, ReturnForm);
                    Win.Show();
                    Program.Update_Win_reversi(Program.user2);
                    Program.Update_Lose(Program.user1);
                }
                else
                {
                    Winner Win = new Winner("Its a tie!!", options, this, ReturnForm);
                    Win.Show();
                    Program.Update_Win_reversi(Program.user1);
                    Program.Update_Win_reversi(Program.user2);
                }
            }
        }
        private void Print_table()
        {
            for (int i =1; i<= 64; ++i)
            {
                switch (i)
                {
                    case 1:
                        if (arr[0, 0] == 1)
                            Turn_picture_box_White(pictureBox_A1);
                        else if (arr[0, 0] == 2)
                            Turn_picture_box_Black(pictureBox_A1);
                        break;
                    case 2:
                        if (arr[1, 0] == 1)
                            Turn_picture_box_White(pictureBox_A2);
                        else if (arr[1, 0] == 2)
                            Turn_picture_box_Black(pictureBox_A2);
                        break;
                    case 3:
                        if (arr[2, 0] == 1)
                            Turn_picture_box_White(pictureBox_A3);
                        else if (arr[2, 0] == 2)
                            Turn_picture_box_Black(pictureBox_A3);
                        break;
                    case 4:
                        if (arr[3, 0] == 1)
                            Turn_picture_box_White(pictureBox_A4);
                        else if (arr[3, 0] == 2)
                            Turn_picture_box_Black(pictureBox_A4);
                        break;
                    case 5:
                        if (arr[4, 0] == 1)
                            Turn_picture_box_White(pictureBox_A5);
                        else if (arr[4, 0] == 2)
                            Turn_picture_box_Black(pictureBox_A5);
                        break;
                    case 6:
                        if (arr[5, 0] == 1)
                            Turn_picture_box_White(pictureBox_A6);
                        else if (arr[5, 0] == 2)
                            Turn_picture_box_Black(pictureBox_A6);
                        break;
                    case 7:
                        if (arr[6, 0] == 1)
                            Turn_picture_box_White(pictureBox_A7);
                        else if (arr[6, 0] == 2)
                            Turn_picture_box_Black(pictureBox_A7);
                        break;
                    case 8:
                        if (arr[7, 0] == 1)
                            Turn_picture_box_White(pictureBox_A8);
                        else if (arr[7, 0] == 2)
                            Turn_picture_box_Black(pictureBox_A8);
                        break;
                    case 9:
                        if (arr[0, 1] == 1)
                            Turn_picture_box_White(pictureBox_B1);
                        else if (arr[0, 1] == 2)
                            Turn_picture_box_Black(pictureBox_B1);
                        break;
                    case 10:
                        if (arr[1, 1] == 1)
                            Turn_picture_box_White(pictureBox_B2);
                        else if (arr[1, 1] == 2)
                            Turn_picture_box_Black(pictureBox_B2);
                        break;
                    case 11:
                        if (arr[2, 1] == 1)
                            Turn_picture_box_White(pictureBox_B3);
                        else if (arr[2, 1] == 2)
                            Turn_picture_box_Black(pictureBox_B3);
                        break;
                    case 12:
                        if (arr[3, 1] == 1)
                            Turn_picture_box_White(pictureBox_B4);
                        else if (arr[3, 1] == 2)
                            Turn_picture_box_Black(pictureBox_B4);
                        break;
                    case 13:
                        if (arr[4, 1] == 1)
                            Turn_picture_box_White(pictureBox_B5);
                        else if (arr[4, 1] == 2)
                            Turn_picture_box_Black(pictureBox_B5);
                        break;
                    case 14:
                        if (arr[5, 1] == 1)
                            Turn_picture_box_White(pictureBox_B6);
                        else if (arr[5, 1] == 2)
                            Turn_picture_box_Black(pictureBox_B6);
                        break;
                    case 15:
                        if (arr[6,1] == 1)
                            Turn_picture_box_White(pictureBox_B7);
                        else if (arr[6,1] == 2)
                            Turn_picture_box_Black(pictureBox_B7);
                        break;
                    case 16:
                        if (arr[7, 1] == 1)
                            Turn_picture_box_White(pictureBox_B8);
                        else if (arr[7, 1] == 2)
                            Turn_picture_box_Black(pictureBox_B8);
                        break;
                    case 17:
                        if (arr[0, 2] == 1)
                            Turn_picture_box_White(pictureBox_C1);
                        else if (arr[0, 2] == 2)
                            Turn_picture_box_Black(pictureBox_C1);
                        break;
                    case 18:
                        if (arr[1, 2] == 1)
                            Turn_picture_box_White(pictureBox_C2);
                        else if (arr[1, 2] == 2)
                            Turn_picture_box_Black(pictureBox_C2);
                        break;
                    case 19:
                        if (arr[2, 2] == 1)
                            Turn_picture_box_White(pictureBox_C3);
                        else if (arr[2, 2] == 2)
                            Turn_picture_box_Black(pictureBox_C3);
                        break;
                    case 20:
                        if (arr[3, 2] == 1)
                            Turn_picture_box_White(pictureBox_C4);
                        else if (arr[3, 2] == 2)
                            Turn_picture_box_Black(pictureBox_C4);
                        break;
                    case 21:
                        if (arr[4, 2] == 1)
                            Turn_picture_box_White(pictureBox_C5);
                        else if (arr[4, 2] == 2)
                            Turn_picture_box_Black(pictureBox_C5);
                        break;
                    case 22:
                        if (arr[5, 2] == 1)
                            Turn_picture_box_White(pictureBox_C6);
                        else if (arr[5,2] == 2)
                            Turn_picture_box_Black(pictureBox_C6);
                        break;
                    case 23:
                        if (arr[6, 2] == 1)
                            Turn_picture_box_White(pictureBox_C7);
                        else if (arr[6, 2] == 2)
                            Turn_picture_box_Black(pictureBox_C7);
                        break;
                    case 24:
                        if (arr[7, 2] == 1)
                            Turn_picture_box_White(pictureBox_C8);
                        else if (arr[7, 2] == 2)
                            Turn_picture_box_Black(pictureBox_C8);
                        break;
                    case 25:
                        if (arr[0, 3] == 1)
                            Turn_picture_box_White(pictureBox_D1);
                        else if (arr[0, 3] == 2)
                            Turn_picture_box_Black(pictureBox_D1);
                        break;
                    case 26:
                        if (arr[1,3] == 1)
                            Turn_picture_box_White(pictureBox_D2);
                        else if (arr[1, 3] == 2)
                            Turn_picture_box_Black(pictureBox_D2);
                        break;
                    case 27:
                        if (arr[2, 3] == 1)
                            Turn_picture_box_White(pictureBox_D3);
                        else if (arr[2, 3] == 2)
                            Turn_picture_box_Black(pictureBox_D3);
                        break;
                    case 28:
                        if (arr[3, 3] == 1)
                            Turn_picture_box_White(pictureBox_D4);
                        else if (arr[3, 3] == 2)
                            Turn_picture_box_Black(pictureBox_D4);
                        break;
                    case 29:
                        if (arr[4, 3] == 1)
                            Turn_picture_box_White(pictureBox_D5);
                        else if (arr[4, 3] == 2)
                            Turn_picture_box_Black(pictureBox_D5);
                        break;
                    case 30:
                        if (arr[5, 3] == 1)
                            Turn_picture_box_White(pictureBox_D6);
                        else if (arr[5, 3] == 2)
                            Turn_picture_box_Black(pictureBox_D6);
                        break;
                    case 31:
                        if (arr[6, 3] == 1)
                            Turn_picture_box_White(pictureBox_D7);
                        else if (arr[6, 3] == 2)
                            Turn_picture_box_Black(pictureBox_D7);
                        break;
                    case 32:
                        if (arr[7, 3] == 1)
                            Turn_picture_box_White(pictureBox_D8);
                        else if (arr[7, 3] == 2)
                            Turn_picture_box_Black(pictureBox_D8);
                        break;
                    case 33:
                        if (arr[0, 4] == 1)
                            Turn_picture_box_White(pictureBox_E1);
                        else if (arr[0, 4] == 2)
                            Turn_picture_box_Black(pictureBox_E1);
                        break;
                    case 34:
                        if (arr[1, 4] == 1)
                            Turn_picture_box_White(pictureBox_E2);
                        else if (arr[1, 4] == 2)
                            Turn_picture_box_Black(pictureBox_E2);
                        break;
                    case 35:
                        if (arr[2, 4] == 1)
                            Turn_picture_box_White(pictureBox_E3);
                        else if (arr[2, 4] == 2)
                            Turn_picture_box_Black(pictureBox_E3);
                        break;
                    case 36:
                        if (arr[3, 4] == 1)
                            Turn_picture_box_White(pictureBox_E4);
                        else if (arr[3, 4] == 2)
                            Turn_picture_box_Black(pictureBox_E4);
                        break;
                    case 37:
                        if (arr[4, 4] == 1)
                            Turn_picture_box_White(pictureBox_E5);
                        else if (arr[4, 4] == 2)
                            Turn_picture_box_Black(pictureBox_E5);
                        break;
                    case 38:
                        if (arr[5, 4] == 1)
                            Turn_picture_box_White(pictureBox_E6);
                        else if (arr[5, 4] == 2)
                            Turn_picture_box_Black(pictureBox_E6);
                        break;
                    case 39:
                        if (arr[6, 4] == 1)
                            Turn_picture_box_White(pictureBox_E7);
                        else if (arr[6, 4] == 2)
                            Turn_picture_box_Black(pictureBox_E7);
                        break;
                    case 40:
                        if (arr[7, 4] == 1)
                            Turn_picture_box_White(pictureBox_E8);
                        else if (arr[7, 4] == 2)
                            Turn_picture_box_Black(pictureBox_E8);
                        break;
                    case 41:
                        if (arr[0, 5] == 1)
                            Turn_picture_box_White(pictureBox_F1);
                        else if (arr[0, 5] == 2)
                            Turn_picture_box_Black(pictureBox_F1);
                        break;
                    case 42:
                        if (arr[1, 5] == 1)
                            Turn_picture_box_White(pictureBox_F2);
                        else if (arr[1, 5] == 2)
                            Turn_picture_box_Black(pictureBox_F2);
                        break;
                    case 43:
                        if (arr[2, 5] == 1)
                            Turn_picture_box_White(pictureBox_F3);
                        else if (arr[2, 5] == 2)
                            Turn_picture_box_Black(pictureBox_F3);
                        break;
                    case 44:
                        if (arr[3, 5] == 1)
                            Turn_picture_box_White(pictureBox_F4);
                        else if (arr[3, 5] == 2)
                            Turn_picture_box_Black(pictureBox_F4);
                        break;

                    case 45:
                        if (arr[4, 5] == 1)
                            Turn_picture_box_White(pictureBox_F5);
                        else if (arr[4, 5] == 2)
                            Turn_picture_box_Black(pictureBox_F5);
                        break;
                    case 46:
                        if (arr[5, 5] == 1)
                            Turn_picture_box_White(pictureBox_F6);
                        else if (arr[5, 5] == 2)
                            Turn_picture_box_Black(pictureBox_F6);
                        break;
                    case 47:
                        if (arr[6, 5] == 1)
                            Turn_picture_box_White(pictureBox_F7);
                        else if (arr[6, 5] == 2)
                            Turn_picture_box_Black(pictureBox_F7);
                        break;
                    case 48:
                        if (arr[7, 5] == 1)
                            Turn_picture_box_White(pictureBox_F8);
                        else if (arr[7, 5] == 2)
                            Turn_picture_box_Black(pictureBox_F8);
                        break;
                    case 49:
                        if (arr[0, 6] == 1)
                            Turn_picture_box_White(pictureBox_G1);
                        else if (arr[0, 6] == 2)
                            Turn_picture_box_Black(pictureBox_G1);
                        break;
                    case 50:
                        if (arr[1, 6] == 1)
                            Turn_picture_box_White(pictureBox_G2);
                        else if (arr[1, 6] == 2)
                            Turn_picture_box_Black(pictureBox_G2);
                        break;
                    case 51:
                        if (arr[2, 6] == 1)
                            Turn_picture_box_White(pictureBox_G3);
                        else if (arr[2, 6] == 2)
                            Turn_picture_box_Black(pictureBox_G3);
                        break;
                    case 52:
                        if (arr[3, 6] == 1)
                            Turn_picture_box_White(pictureBox_G4);
                        else if (arr[3, 6] == 2)
                            Turn_picture_box_Black(pictureBox_G4);
                        break;
                    case 53:
                        if (arr[4, 6] == 1)
                            Turn_picture_box_White(pictureBox_G5);
                        else if (arr[4, 6] == 2)
                            Turn_picture_box_Black(pictureBox_G5);
                        break;
                    case 54:
                        if (arr[5, 6] == 1)
                            Turn_picture_box_White(pictureBox_G6);
                        else if (arr[5, 6] == 2)
                            Turn_picture_box_Black(pictureBox_G6);
                        break;
                    case 55:
                        if (arr[6, 6] == 1)
                            Turn_picture_box_White(pictureBox_G7);
                        else if (arr[6, 6] == 2)
                            Turn_picture_box_Black(pictureBox_G7);
                        break;
                    case 56:
                        if (arr[7, 6] == 1)
                            Turn_picture_box_White(pictureBox_G8);
                        else if (arr[7, 6] == 2)
                            Turn_picture_box_Black(pictureBox_G8);
                        break;
                    case 57:
                        if (arr[0, 7] == 1)
                            Turn_picture_box_White(pictureBox_H1);
                        else if (arr[0, 7] == 2)
                            Turn_picture_box_Black(pictureBox_H1);
                        break;
                    case 58:
                        if (arr[1, 7] == 1)
                            Turn_picture_box_White(pictureBox_H2);
                        else if (arr[1, 7] == 2)
                            Turn_picture_box_Black(pictureBox_H2);
                        break;
                    case 59:
                        if (arr[2, 7] == 1)
                            Turn_picture_box_White(pictureBox_H3);
                        else if (arr[2, 7] == 2)
                            Turn_picture_box_Black(pictureBox_H3);
                        break;
                    case 60:
                        if (arr[3, 7] == 1)
                            Turn_picture_box_White(pictureBox_H4);
                        else if (arr[3, 7] == 2)
                            Turn_picture_box_Black(pictureBox_H4);
                        break;
                    case 61:
                        if (arr[4, 7] == 1)
                            Turn_picture_box_White(pictureBox_H5);
                        else if (arr[4, 7] == 2)
                            Turn_picture_box_Black(pictureBox_H5);
                        break;
                    case 62:
                        if (arr[5, 7] == 1)
                            Turn_picture_box_White(pictureBox_H6);
                        else if (arr[5, 7] == 2)
                            Turn_picture_box_Black(pictureBox_H6);
                        break;
                    case 63:
                        if (arr[6, 7] == 1)
                            Turn_picture_box_White(pictureBox_H7);
                        else if (arr[6, 7] == 2)
                            Turn_picture_box_Black(pictureBox_H7);
                        break;
                    case 64:
                        if (arr[7, 7] == 1)
                            Turn_picture_box_White(pictureBox_H8);
                        else if (arr[7, 7] == 2)
                            Turn_picture_box_Black(pictureBox_H8);
                        break;
                }
            }
            sum();
        }
        private void pictureBox_G8_Click(object sender, EventArgs e) => Picture_box_clicked(7, 6, pictureBox_G8);
        private void pictureBox_G7_Click(object sender, EventArgs e) => Picture_box_clicked(6, 6, pictureBox_G7);
        private void pictureBox_G6_Click(object sender, EventArgs e) => Picture_box_clicked(5, 6, pictureBox_G6);
        private void pictureBox_G5_Click(object sender, EventArgs e) => Picture_box_clicked(4, 6, pictureBox_G5);
        private void pictureBox_G4_Click(object sender, EventArgs e) => Picture_box_clicked(3, 6, pictureBox_G4);
        private void pictureBox_G3_Click(object sender, EventArgs e) => Picture_box_clicked(2, 6, pictureBox_G3);
        private void pictureBox_G2_Click(object sender, EventArgs e) => Picture_box_clicked(1, 6, pictureBox_G2);
        private void pictureBox_G1_Click(object sender, EventArgs e) => Picture_box_clicked(6, 6, pictureBox_G1);
        private void pictureBox_H8_Click(object sender, EventArgs e) => Picture_box_clicked(7, 7, pictureBox_H8);
        private void pictureBox_H7_Click(object sender, EventArgs e) => Picture_box_clicked(6, 7, pictureBox_H7);
        private void pictureBox_H6_Click(object sender, EventArgs e) => Picture_box_clicked(5, 7, pictureBox_H6);
        private void pictureBox_H5_Click(object sender, EventArgs e) => Picture_box_clicked(4, 7, pictureBox_H5);
        private void pictureBox_H4_Click(object sender, EventArgs e) => Picture_box_clicked(3, 7, pictureBox_H4);
        private void pictureBox_H3_Click(object sender, EventArgs e) => Picture_box_clicked(2, 7, pictureBox_H3);
        private void pictureBox_H2_Click(object sender, EventArgs e) => Picture_box_clicked(1, 7, pictureBox_H2);
        private void pictureBox_H1_Click(object sender, EventArgs e) => Picture_box_clicked(0, 7, pictureBox_H1);
        private void pictureBox_F8_Click(object sender, EventArgs e) => Picture_box_clicked(7, 5, pictureBox_F8);
        private void pictureBox_F7_Click(object sender, EventArgs e) => Picture_box_clicked(6, 5, pictureBox_F7);
        private void pictureBox_F6_Click(object sender, EventArgs e) => Picture_box_clicked(5, 5, pictureBox_F6);
        private void pictureBox_F5_Click(object sender, EventArgs e) => Picture_box_clicked(4, 5, pictureBox_F5);
        private void pictureBox_F4_Click(object sender, EventArgs e) => Picture_box_clicked(3, 5, pictureBox_F4);
        private void pictureBox_F3_Click(object sender, EventArgs e) => Picture_box_clicked(2, 5, pictureBox_F3);
        private void pictureBox_F2_Click(object sender, EventArgs e) => Picture_box_clicked(1, 5, pictureBox_F2);
        private void pictureBox_F1_Click(object sender, EventArgs e) => Picture_box_clicked(0, 5, pictureBox_F1);
        private void pictureBox_E8_Click(object sender, EventArgs e) => Picture_box_clicked(7, 4, pictureBox_E8);
        private void pictureBox_E7_Click(object sender, EventArgs e) => Picture_box_clicked(6, 4, pictureBox_E7);
        private void pictureBox_E6_Click(object sender, EventArgs e) => Picture_box_clicked(5, 4, pictureBox_E6);
        private void pictureBox_E3_Click(object sender, EventArgs e) => Picture_box_clicked(2, 4, pictureBox_E3);
        private void pictureBox_E2_Click(object sender, EventArgs e) => Picture_box_clicked(1, 4, pictureBox_E2);
        private void pictureBox_E1_Click(object sender, EventArgs e) => Picture_box_clicked(0, 4, pictureBox_E1);
        private void pictureBox_D8_Click(object sender, EventArgs e) => Picture_box_clicked(7, 3, pictureBox_D8);
        private void pictureBox_D7_Click(object sender, EventArgs e) => Picture_box_clicked(6, 3, pictureBox_D7);
        private void pictureBox_D6_Click(object sender, EventArgs e) => Picture_box_clicked(5, 3, pictureBox_D6);
        private void pictureBox_D3_Click(object sender, EventArgs e) => Picture_box_clicked(2, 3, pictureBox_D3);
        private void pictureBox_D2_Click(object sender, EventArgs e) => Picture_box_clicked(1, 3, pictureBox_D2);
        private void pictureBox_D1_Click(object sender, EventArgs e) => Picture_box_clicked(0, 3, pictureBox_D1);
        private void picture_C8_Click(object sender, EventArgs e) => Picture_box_clicked(7, 2, pictureBox_C8);
        private void picture_C7_Click(object sender, EventArgs e) => Picture_box_clicked(6, 2, pictureBox_C7);
        private void picture_C6_Click(object sender, EventArgs e) => Picture_box_clicked(5, 2, pictureBox_C6);
        private void picture_C5_Click(object sender, EventArgs e) => Picture_box_clicked(4, 2, pictureBox_C5);
        private void picture_C4_Click(object sender, EventArgs e) => Picture_box_clicked(3, 2, pictureBox_C4);
        private void picture_C3_Click(object sender, EventArgs e) => Picture_box_clicked(2, 2, pictureBox_C3);
        private void picture_C2_Click(object sender, EventArgs e) => Picture_box_clicked(1, 2, pictureBox_C2);
        private void picture_C1_Click(object sender, EventArgs e) => Picture_box_clicked(0, 2, pictureBox_C1);
        private void picture_B8_Click(object sender, EventArgs e) => Picture_box_clicked(7, 1, pictureBox_B8);
        private void picture_B7_Click(object sender, EventArgs e) => Picture_box_clicked(6, 1, pictureBox_B7);
        private void picture_B6_Click(object sender, EventArgs e) => Picture_box_clicked(5, 1, pictureBox_B6);
        private void picture_B5_Click(object sender, EventArgs e) => Picture_box_clicked(4, 1, pictureBox_B5);
        private void picture_B4_Click(object sender, EventArgs e) => Picture_box_clicked(3, 1, pictureBox_B4);
        private void picture_B3_Click(object sender, EventArgs e) => Picture_box_clicked(2, 1, pictureBox_B3);
        private void picture_B2_Click(object sender, EventArgs e) => Picture_box_clicked(1, 1, pictureBox_B2);
        private void picture_B1_Click(object sender, EventArgs e) => Picture_box_clicked(0, 1, pictureBox_B1);
        private void picture_A8_Click(object sender, EventArgs e) => Picture_box_clicked(7, 0, pictureBox_A8);
        private void picture_A7_Click(object sender, EventArgs e) => Picture_box_clicked(6, 0, pictureBox_A7);
        private void picture_A6_Click(object sender, EventArgs e) => Picture_box_clicked(5, 0, pictureBox_A6);
        private void picture_A5_Click(object sender, EventArgs e) => Picture_box_clicked(4, 0, pictureBox_A5);
        private void picture_A4_Click(object sender, EventArgs e) => Picture_box_clicked(3, 0, pictureBox_A4);
        private void picture_A3_Click(object sender, EventArgs e) => Picture_box_clicked(2, 0, pictureBox_A3);
        private void picture_A2_Click(object sender, EventArgs e) => Picture_box_clicked(1, 0, pictureBox_A2);
        private void picture_A1_Click(object sender, EventArgs e) => Picture_box_clicked(0, 0, pictureBox_A1);
    }
}
