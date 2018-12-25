using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameBox;
using System.Windows.Forms;

namespace Game_Box_unit_Test
{
    [TestClass]
    public class Reversi_unit_test
    {
        [TestMethod]
        public void Music_From_on_to_off_test()
        {
            Reversi Test = new Reversi(new System.Windows.Forms.Form(), new System.Windows.Forms.Form());
            GameBox.Program.music_OnOff = true;

            Test.Bt_reversi_music(new System.Object(), EventArgs.Empty);

            Assert.AreEqual(Program.music_OnOff, false);
            Assert.AreNotEqual(Program.music_OnOff, true);
        }
        [TestMethod]
        public void Music_From_off_to_onn_test()
        {
            Reversi Test = new Reversi(new System.Windows.Forms.Form(), new System.Windows.Forms.Form());
            GameBox.Program.music_OnOff = false;

            Test.Bt_reversi_music(new System.Object(), EventArgs.Empty);

            Assert.AreEqual(Program.music_OnOff, true);
            Assert.AreNotEqual(Program.music_OnOff, false);
        }
        [TestMethod]
        public void Turn_picture_box_Black_test()
        {
            Reversi Test = new Reversi(new Form(), new Form());
            PictureBox Help = new PictureBox();
            System.Drawing.Bitmap BlackImage = (System.Drawing.Bitmap)GameBox.Properties.Resources.Black_piece;
            System.Drawing.Bitmap WhiteImage = (System.Drawing.Bitmap)GameBox.Properties.Resources.white_piece;
            Help.BackgroundImage = GameBox.Properties.Resources.white_piece;

            Test.Turn_picture_box_Black(Help);
            System.Drawing.Bitmap HelpImage = (System.Drawing.Bitmap)Help.BackgroundImage;

            Assert.AreEqual(HelpImage.Flags.ToString(), BlackImage.Flags.ToString());
            Assert.AreNotEqual(HelpImage.Flags.ToString(), WhiteImage.Flags.ToString());
            Test.Close();

        }
        [TestMethod]
        public void Turn_picture_box_Black_no_change_test()
        {
            Reversi Test = new Reversi(new Form(), new Form());
            PictureBox Help = new PictureBox();
            System.Drawing.Bitmap BlackImage = (System.Drawing.Bitmap)GameBox.Properties.Resources.Black_piece;
            System.Drawing.Bitmap WhiteImage = (System.Drawing.Bitmap)GameBox.Properties.Resources.white_piece;
            Help.BackgroundImage = GameBox.Properties.Resources.Black_piece;

            Test.Turn_picture_box_Black(Help);
            System.Drawing.Bitmap HelpImage = (System.Drawing.Bitmap)Help.BackgroundImage;

            Assert.AreEqual(HelpImage.Flags.ToString(), BlackImage.Flags.ToString());
            Assert.AreNotEqual(HelpImage.Flags.ToString(), WhiteImage.Flags.ToString());
            Test.Close();

        }
        [TestMethod]
        public void Turn_picture_box_White_test()
        {
            Reversi Test = new Reversi(new Form(), new Form());
            PictureBox Help = new PictureBox();

            System.Drawing.Bitmap BlackImage = (System.Drawing.Bitmap)GameBox.Properties.Resources.Black_piece;
            System.Drawing.Bitmap WhiteImage = (System.Drawing.Bitmap)GameBox.Properties.Resources.white_piece;
            Help.BackgroundImage = GameBox.Properties.Resources.Black_piece;

            Test.Turn_picture_box_White(Help);
            System.Drawing.Bitmap HelpImage = (System.Drawing.Bitmap)Help.BackgroundImage;

            Assert.AreEqual(HelpImage.Flags.ToString(), WhiteImage.Flags.ToString());
            Assert.AreNotEqual(HelpImage.Flags.ToString(), BlackImage.Flags.ToString());
            Test.Close();

        }
        public void Turn_picture_box_no_change_White_test()
        {
            Reversi Test = new Reversi(new Form(), new Form());
            PictureBox Help = new PictureBox();

            System.Drawing.Bitmap BlackImage = (System.Drawing.Bitmap)GameBox.Properties.Resources.Black_piece;
            System.Drawing.Bitmap WhiteImage = (System.Drawing.Bitmap)GameBox.Properties.Resources.white_piece;
            Help.BackgroundImage = GameBox.Properties.Resources.white_piece;

            Test.Turn_picture_box_White(Help);
            System.Drawing.Bitmap HelpImage = (System.Drawing.Bitmap)Help.BackgroundImage;

            Assert.AreEqual(HelpImage.Flags.ToString(), WhiteImage.Flags.ToString());
            Assert.AreNotEqual(HelpImage.Flags.ToString(), BlackImage.Flags.ToString());
            Test.Close();

        }
        [TestMethod]
        public void sum_empty_arr_test()
        {
            Reversi Test = new Reversi(new Form(), new Form());

            Test.sum();

            Assert.AreEqual(Test.Lb_Score1.Text.ToString(),"2");
            Assert.AreEqual(Test.Lb_Score2.Text.ToString(), "2");
            Assert.AreNotEqual(Test.Lb_Score1.Text.ToString(), "3");
            Assert.AreNotEqual(Test.Lb_Score2.Text.ToString(), "3");
            Test.Close();


        }
        [TestMethod]
        public void sum_Player_one_Score_one_test()
        {
            Reversi Test = new Reversi(new Form(), new Form());
            Test.arr[0, 0] = 1;

            Test.sum();

            Assert.AreEqual(Test.Lb_Score1.Text, "3");
            Assert.AreEqual(Test.Lb_Score2.Text, "2");
            Assert.AreNotEqual(Test.Lb_Score1.Text, "2");
            Assert.AreNotEqual(Test.Lb_Score2.Text, "3");
            Test.Close();


        }
        [TestMethod]
        public void sum_Player_two_Score_one_test()
        {
            Reversi Test = new Reversi(new Form(), new Form());
            Test.arr[0, 0] = 2;

            Test.sum();

            Assert.AreEqual(Test.Lb_Score1.Text, "2");
            Assert.AreEqual(Test.Lb_Score2.Text, "3");
            Assert.AreNotEqual(Test.Lb_Score1.Text, "3");
            Assert.AreNotEqual(Test.Lb_Score2.Text, "2");
            Test.Close();


        }
        [TestMethod]
        public void Up_col_check_change_test()
        {
            Reversi Test = new Reversi(new Form(), new Form());
            Test.arr[0, 0] = 2;
            Test.arr[1, 0] = 1;
            Test.arr[2, 0] = 2;

            Test.Up_col_check(2,0,2);

            Assert.AreEqual(Test.arr[1,0], 2);
            Assert.AreNotEqual(Test.arr[1, 0], 1);
            Test.Close();

        }
        [TestMethod]
        public void Up_col_check_no_change_test()
        {
            Reversi Test = new Reversi(new Form(), new Form());
            Test.arr[0, 0] = 2;
            Test.arr[2, 0] = 2;

            Test.Up_col_check(2, 0, 2);

            Assert.AreEqual(Test.arr[1, 0], 0);
            Assert.AreNotEqual(Test.arr[1, 0], 2);
            Test.Close();

        }
        [TestMethod]
        public void Up_Down_check_change_test()
        {
            Reversi Test = new Reversi(new Form(), new Form());
            Test.arr[0, 0] = 2;
            Test.arr[1, 0] = 1;
            Test.arr[2, 0] = 2;

            Test.Down_col_check(0, 0, 2);

            Assert.AreEqual(Test.arr[1, 0], 2);
            Assert.AreNotEqual(Test.arr[1, 0], 1);
            Test.Close();

        }
        [TestMethod]
        public void Up_Down_check_no_change_test()
        {
            Reversi Test = new Reversi(new Form(), new Form());
            Test.arr[0, 0] = 2;
            Test.arr[2, 0] = 2;

            Test.Down_col_check(0, 0, 2);

            Assert.AreEqual(Test.arr[1, 0], 0);
            Assert.AreNotEqual(Test.arr[1, 0], 2);
            Test.Close();

        }
        [TestMethod]
        public void right_row_check_change_test()
        {
            Reversi Test = new Reversi(new Form(), new Form());
            Test.arr[0, 0] = 2;
            Test.arr[0, 1] = 1;
            Test.arr[0, 2] = 2;

            Test.right_row_check(0, 0, 2);

            Assert.AreEqual(Test.arr[0, 1], 2);
            Assert.AreNotEqual(Test.arr[0, 1], 1);
            Test.Close();

        }
        [TestMethod]
        public void right_row_check_no_change_test()
        {
            Reversi Test = new Reversi(new Form(), new Form());
            Test.arr[0, 0] = 2;
            Test.arr[0, 2] = 2;

            Test.right_row_check(0, 0, 2);

            Assert.AreEqual(Test.arr[0, 1], 0);
            Assert.AreNotEqual(Test.arr[0, 1], 2);
            Test.Close();

        }
        [TestMethod]
        public void Left_row_check_change_test()
        {
            Reversi Test = new Reversi(new Form(), new Form());
            Test.arr[0, 0] = 2;
            Test.arr[0, 1] = 1;
            Test.arr[0, 2] = 2;

            Test.Left_row_check(0, 2, 2);

            Assert.AreEqual(Test.arr[0, 1], 2);
            Assert.AreNotEqual(Test.arr[0, 1], 1);
            Test.Close();

        }
        [TestMethod]
        public void Left_row_check_no_change_test()
        {
            Reversi Test = new Reversi(new Form(), new Form());
            Test.arr[0, 0] = 2;
            Test.arr[0, 2] = 2;

            Test.Left_row_check(0, 2, 2);

            Assert.AreEqual(Test.arr[0, 1], 0);
            Assert.AreNotEqual(Test.arr[0, 1], 2);
            Test.Close();

        }
        [TestMethod]
        public void Left_Up_slant_change_test()
        {
            Reversi Test = new Reversi(new Form(), new Form());
            Test.arr[0, 0] = 2;
            Test.arr[1, 1] = 1;
            Test.arr[2, 2] = 2;

            Test.Left_Up_slant_check(2, 2, 2);

            Assert.AreEqual(Test.arr[1, 1], 2);
            Assert.AreNotEqual(Test.arr[1, 1], 1);
            Test.Close();

        }
        [TestMethod]
        public void Left_Up_slant_no_change_test()
        {
            Reversi Test = new Reversi(new Form(), new Form());
            Test.arr[0, 0] = 2;
            Test.arr[2, 2] = 2;

            Test.Left_Up_slant_check(2, 2, 2);

            Assert.AreEqual(Test.arr[1, 1], 0);
            Assert.AreNotEqual(Test.arr[1, 1], 2);
            Test.Close();

        }
        [TestMethod]
        public void Left_Down_slant_change_test()
        {
            Reversi Test = new Reversi(new Form(), new Form());

            Test.arr[0, 2] = 2;
            Test.arr[1, 1] = 1;
            Test.arr[2, 0] = 2;

            Test.left_Down_slant_check(0, 2, 2);

            Assert.AreEqual(Test.arr[1, 1], 2);
            Assert.AreNotEqual(Test.arr[1, 1], 1);
            Test.Close();

        }
        [TestMethod]
        public void Left_Down_slant_no_change_test()
        {
            Reversi Test = new Reversi(new Form(), new Form());
            Test.arr[0,2] = 2;
            Test.arr[2,0] = 2;

            Test.left_Down_slant_check(0, 2, 2);

            Assert.AreEqual(Test.arr[1, 1], 0);
            Assert.AreNotEqual(Test.arr[1, 1], 2);
            Test.Close();

        }
        [TestMethod]
        public void Right_Down_slant_change_test()
        {

            Reversi Test = new Reversi(new Form(), new Form());
            Test.arr[0, 0] = 2;
            Test.arr[1, 1] = 1;
            Test.arr[2, 2] = 2;

            Test.Right_Down_slant_check(0, 0, 2);

            Assert.AreEqual(Test.arr[1, 1], 2);
            Assert.AreNotEqual(Test.arr[1, 1], 0);
            Test.Close();

        }
        [TestMethod]
        public void Right_Down_slant_no_change_test()
        {
            Reversi Test = new Reversi(new Form(), new Form());
            Test.arr[0, 0] = 2;
            Test.arr[2, 2] = 2;

            Test.Right_Down_slant_check(0, 0, 2);

            Assert.AreEqual(Test.arr[1, 1], 0);
            Assert.AreNotEqual(Test.arr[1, 1], 2);
            Test.Close();

        }
        [TestMethod]
        public void Right_Up_slant_change_test()
        {
            Reversi Test = new Reversi(new Form(), new Form());
            Test.arr[0, 2] = 2;
            Test.arr[1, 1] = 1;
            Test.arr[2, 0] = 2;

            Test.Right_Up_slant_check(2, 0, 2);

            Assert.AreEqual(Test.arr[1, 1], 2);
            Assert.AreNotEqual(Test.arr[1, 1], 0);
            Test.Close();

        }
        [TestMethod]
        public void Right_Up_slant_no_change_test()
        {
            Reversi Test = new Reversi(new Form(), new Form());
            Test.arr[0, 2] = 2;
            Test.arr[2, 0] = 2;

            Test.Right_Up_slant_check(2, 0, 2);

            Assert.AreEqual(Test.arr[1, 1], 0);
            Assert.AreNotEqual(Test.arr[1, 1], 2);
            Test.Close();

        }
    }

}
