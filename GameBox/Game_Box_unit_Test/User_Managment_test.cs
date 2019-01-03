using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameBox;

namespace Game_Box_unit_Test
{
    [TestClass]
    public class User_Managment_test
    {
        [TestMethod]
        public void Music_From_on_to_off_test()
        {
            User_Managment Test = new User_Managment(new System.Windows.Forms.Form());
            GameBox.Program.music_OnOff = true;

            Test.CB_music_click(new System.Object(), EventArgs.Empty);

            Assert.AreEqual(Program.music_OnOff, false);
            Assert.AreNotEqual(Program.music_OnOff, true);
        }
        [TestMethod]
        public void Music_From_off_to_onn_test()
        {
            User_Managment Test = new User_Managment(new System.Windows.Forms.Form());
            GameBox.Program.music_OnOff = false;

            Test.CB_music_click(new System.Object(), EventArgs.Empty);

            Assert.AreEqual(Program.music_OnOff, true);
            Assert.AreNotEqual(Program.music_OnOff, false);
        }
        [TestMethod]
        public void Add_user_show_Click_test()
        {
            User_Managment Test = new User_Managment(new System.Windows.Forms.Form());
            Test.Show();
            Test.lb_add_name.Visible = false;
            Test.lb_add_password.Visible = false;
            Test.Tb_User_add_Name.Visible = false;
            Test.Tb_User_add_Password.Visible = false;
            Test.Bt_add.Visible = false; ;
            Test.Lb_remove_name.Visible = true;
            Test.Tb_User_remove_Name.Visible = true;
            Test.Bt_remove.Visible = true;

            Test.Add_user_show_Click(new object(), new EventArgs());

            Assert.AreEqual(Test.lb_add_name.Visible , true);
            Assert.AreEqual(Test.lb_add_password.Visible , true);
            Assert.AreEqual(Test.Tb_User_add_Name.Visible , true);
            Assert.AreEqual(Test.Tb_User_add_Password.Visible , true);
            Assert.AreEqual(Test.Bt_add.Visible ,true);
            Assert.AreEqual(Test.Lb_remove_name.Visible , false);
            Assert.AreEqual(Test.Tb_User_remove_Name.Visible , false);
            Assert.AreEqual(Test.Bt_remove.Visible , false);
            Test.Close();
        }
        [TestMethod]
        public void Remove_user_show_Click_test()
        {
            User_Managment Test = new User_Managment(new System.Windows.Forms.Form());
            Test.Show();
            Test.lb_add_name.Visible = true;
            Test.lb_add_password.Visible = true;
            Test.Tb_User_add_Name.Visible = true;
            Test.Tb_User_add_Password.Visible = true;
            Test.Bt_add.Visible = true; ;
            Test.Lb_remove_name.Visible = false;
            Test.Tb_User_remove_Name.Visible = false;
            Test.Bt_remove.Visible = false;

            Test.Remove_user_show_Click(new object(), new EventArgs());

            Assert.AreEqual(Test.lb_add_name.Visible, false);
            Assert.AreEqual(Test.lb_add_password.Visible, false);
            Assert.AreEqual(Test.Tb_User_add_Name.Visible, false);
            Assert.AreEqual(Test.Tb_User_add_Password.Visible, false);
            Assert.AreEqual(Test.Bt_add.Visible, false);
            Assert.AreEqual(Test.Lb_remove_name.Visible, true);
            Assert.AreEqual(Test.Tb_User_remove_Name.Visible, true);
            Assert.AreEqual(Test.Bt_remove.Visible, true);
            Test.Close();
        }
    }
}
