using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameBox;
namespace Game_Box_unit_Test
{
    [TestClass]
    public class MainForm_test
    {
        [TestMethod]
        public void Music_From_on_to_off_test()
        {
            MainForm Test = new MainForm();
            GameBox.Program.music_OnOff = true;

            Test.CB_music_click(new System.Object(), EventArgs.Empty);

            Assert.AreEqual(Program.music_OnOff, false);
            Assert.AreNotEqual(Program.music_OnOff, true);
        }
        [TestMethod]
        public void Music_From_off_to_onn_test()
        {
            MainForm Test = new MainForm();
            GameBox.Program.music_OnOff = false;

            Test.CB_music_click(new System.Object(), EventArgs.Empty);

            Assert.AreEqual(Program.music_OnOff, true);
            Assert.AreNotEqual(Program.music_OnOff, false);
        }

        [TestMethod]
        public void Bt_Continue_As_Player_Click_test()
        {
            MainForm Test = new MainForm();
            Test.Show();
            Test.Tb_manager_name.Visible = true;
            Test.lb_password_manager.Visible = true;
            Test.Bt_manager_login.Visible = true;
            Test.Tb_manager_name.Visible = true;
            Test.Tb_manager_password.Visible = true;
            Test.lb_guest_name.Visible = true;
            Test.Bt_Guest_login.Visible = true;
            Test.LB_why_register.Visible = true;
            Test.Tb_guest_name.Visible = true;
            Test.lb_player_name.Visible = false;
            Test.lb_password_player.Visible = false;
            Test.Bt_User_login.Visible = false;
            Test.Tb_user_name.Visible = false;
            Test.Tb_user_password.Visible = false;
            Test.comboBox1.Visible = false;
            Test.cob_players.Visible = false;

            Test.Bt_Continue_As_Player_Click(new System.Object(), EventArgs.Empty);

            Assert.AreEqual(Test.Tb_manager_name.Visible, false);
            Assert.AreEqual(Test.Tb_manager_name.Visible , false);
            Assert.AreEqual(Test.lb_password_manager.Visible ,false);
            Assert.AreEqual(Test.Bt_manager_login.Visible ,false);
            Assert.AreEqual(Test.Tb_manager_name.Visible ,false);
            Assert.AreEqual(Test.Tb_manager_password.Visible , false);
            Assert.AreEqual(Test.lb_guest_name.Visible , false);
            Assert.AreEqual(Test.Bt_Guest_login.Visible , false);
            Assert.AreEqual(Test.LB_why_register.Visible , false);
            Assert.AreEqual(Test.Tb_guest_name.Visible , false);
            Assert.AreEqual(Test.lb_player_name.Visible , true);
            Assert.AreEqual(Test.lb_password_player.Visible , true);
            Assert.AreEqual(Test.Bt_User_login.Visible ,true);
            Assert.AreEqual(Test.Tb_user_name.Visible ,true);
            Assert.AreEqual(Test.Tb_user_password.Visible , true);
            Assert.AreEqual(Test.comboBox1.Visible ,true);
            Assert.AreEqual(Test.cob_players.Visible , true);
            Test.Close();
        }
        [TestMethod]
        public void Bt_Continue_As_Manager_Click_test()
        {
            MainForm Test = new MainForm();
            Test.Show();
            Test.Tb_manager_name.Visible = false;
            Test.lb_password_manager.Visible = false;
            Test.Bt_manager_login.Visible = false;
            Test.Tb_manager_name.Visible = false;
            Test.Tb_manager_password.Visible = false;
            Test.lb_guest_name.Visible = true;
            Test.Bt_Guest_login.Visible = true;
            Test.LB_why_register.Visible = true;
            Test.Tb_guest_name.Visible = true;
            Test.lb_player_name.Visible = true;
            Test.lb_password_player.Visible = true;
            Test.Bt_User_login.Visible = true;
            Test.Tb_user_name.Visible = true;
            Test.Tb_user_password.Visible = true;
            Test.comboBox1.Visible = true;
            Test.cob_players.Visible = true;

            Test.Bt_Continue_As_Manager_Click(new System.Object(), EventArgs.Empty);

            Assert.AreEqual(Test.Tb_manager_name.Visible, true);
            Assert.AreEqual(Test.Tb_manager_name.Visible, true);
            Assert.AreEqual(Test.lb_password_manager.Visible, true);
            Assert.AreEqual(Test.Bt_manager_login.Visible, true);
            Assert.AreEqual(Test.Tb_manager_name.Visible, true);
            Assert.AreEqual(Test.Tb_manager_password.Visible, true);
            Assert.AreEqual(Test.lb_guest_name.Visible, false);
            Assert.AreEqual(Test.Bt_Guest_login.Visible, false);
            Assert.AreEqual(Test.LB_why_register.Visible, false);
            Assert.AreEqual(Test.Tb_guest_name.Visible, false);
            Assert.AreEqual(Test.lb_player_name.Visible, false);
            Assert.AreEqual(Test.lb_password_player.Visible, false);
            Assert.AreEqual(Test.Bt_User_login.Visible, false);
            Assert.AreEqual(Test.Tb_user_name.Visible, false);
            Assert.AreEqual(Test.Tb_user_password.Visible, false);
            Assert.AreEqual(Test.comboBox1.Visible, false);
            Assert.AreEqual(Test.cob_players.Visible, false);
            Test.Close();
        }
        [TestMethod]
        public void Bt_Continue_As_Guest_Click_test()
        {
            MainForm Test = new MainForm();
            Test.Show();
            Test.Tb_manager_name.Visible = true;
            Test.lb_password_manager.Visible = true;
            Test.Bt_manager_login.Visible = true;
            Test.Tb_manager_name.Visible = true;
            Test.Tb_manager_password.Visible = true;
            Test.lb_guest_name.Visible = false;
            Test.Bt_Guest_login.Visible = false;
            Test.LB_why_register.Visible = false;
            Test.Tb_guest_name.Visible = false;
            Test.lb_player_name.Visible = true;
            Test.lb_password_player.Visible = true;
            Test.Bt_User_login.Visible = true;
            Test.Tb_user_name.Visible = true;
            Test.Tb_user_password.Visible = true;
            Test.comboBox1.Visible = true;
            Test.cob_players.Visible = true;

            Test.Bt_Continue_As_Guest_Click(new System.Object(), EventArgs.Empty);

            Assert.AreEqual(Test.Tb_manager_name.Visible, false);
            Assert.AreEqual(Test.Tb_manager_name.Visible, false);
            Assert.AreEqual(Test.lb_password_manager.Visible, false);
            Assert.AreEqual(Test.Bt_manager_login.Visible, false);
            Assert.AreEqual(Test.Tb_manager_name.Visible, false);
            Assert.AreEqual(Test.Tb_manager_password.Visible, false);
            Assert.AreEqual(Test.lb_guest_name.Visible, true);
            Assert.AreEqual(Test.Bt_Guest_login.Visible, true);
            Assert.AreEqual(Test.LB_why_register.Visible, true);
            Assert.AreEqual(Test.Tb_guest_name.Visible, true);
            Assert.AreEqual(Test.lb_player_name.Visible, false);
            Assert.AreEqual(Test.lb_password_player.Visible, false);
            Assert.AreEqual(Test.Bt_User_login.Visible, false);
            Assert.AreEqual(Test.Tb_user_name.Visible, false);
            Assert.AreEqual(Test.Tb_user_password.Visible, false);
            Assert.AreEqual(Test.comboBox1.Visible, false);
            Assert.AreEqual(Test.cob_players.Visible, false);
            Test.Close();
        }

    }
}
