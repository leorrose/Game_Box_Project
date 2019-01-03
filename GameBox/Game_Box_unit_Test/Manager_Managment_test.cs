using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameBox;

namespace Game_Box_unit_Test
{
    [TestClass]
    public class Manager_Managment_test
    {
        [TestMethod]
        public void Music_From_on_to_off_test()
        {
            Manager_Managment Test = new Manager_Managment(new System.Windows.Forms.Form());
            GameBox.Program.music_OnOff = true;

            Test.CB_music_click(new System.Object(), EventArgs.Empty);

            Assert.AreEqual(Program.music_OnOff, false);
            Assert.AreNotEqual(Program.music_OnOff, true);
        }
        [TestMethod]
        public void Music_From_off_to_onn_test()
        {
            Manager_Managment Test = new Manager_Managment(new System.Windows.Forms.Form());
            GameBox.Program.music_OnOff = false;

            Test.CB_music_click(new System.Object(), EventArgs.Empty);

            Assert.AreEqual(Program.music_OnOff, true);
            Assert.AreNotEqual(Program.music_OnOff, false);
        }
        [TestMethod]
        public void Add_Manager_show_click_test()
        {
            Manager_Managment Test = new Manager_Managment(new System.Windows.Forms.Form());
            Test.Show();
            Test.lb_add_name.Visible = true;
            Test.lb_add_password.Visible = true;
            Test.Tb_Manager_add_Name.Visible = true;
            Test.Tb_Manager_add_Password.Visible = true;
            Test.Bt_add_manager.Visible = true;
            Test.lb_remove_name.Visible = false;
            Test.Tb_Manager_remove_Name.Visible = false;
            Test.Bt_remove.Visible = false;

            Test.Add_Manager_show_click(new object(), new EventArgs());

            Assert.AreEqual(Test.lb_add_name.Visible , true);
            Assert.AreEqual(Test.lb_add_password.Visible , true);
            Assert.AreEqual(Test.Tb_Manager_add_Name.Visible ,true);
            Assert.AreEqual(Test.Tb_Manager_add_Password.Visible , true);
            Assert.AreEqual(Test.Bt_add_manager.Visible , true);
            Assert.AreEqual(Test.lb_remove_name.Visible , false);
            Assert.AreEqual(Test.Tb_Manager_remove_Name.Visible , false);
            Assert.AreEqual(Test.Bt_remove.Visible , false);
            Test.Close();
        }
        [TestMethod]
        public void Remove_Manager_show_click_test()
        {
            Manager_Managment Test = new Manager_Managment(new System.Windows.Forms.Form());
            Test.Show();
            Test.lb_add_name.Visible = true;
            Test.lb_add_password.Visible = true;
            Test.Tb_Manager_add_Name.Visible = true;
            Test.Tb_Manager_add_Password.Visible = true;
            Test.Bt_add_manager.Visible = true;
            Test.lb_remove_name.Visible = false;
            Test.Tb_Manager_remove_Name.Visible = false;
            Test.Bt_remove.Visible = false;

            Test.Remove_Manager_show_click(new object(), new EventArgs());

            Assert.AreEqual(Test.lb_add_name.Visible , false);
            Assert.AreEqual(Test.lb_add_password.Visible , false);
            Assert.AreEqual(Test.Tb_Manager_add_Name.Visible , false);
            Assert.AreEqual(Test.Tb_Manager_add_Password.Visible , false);
            Assert.AreEqual(Test.Bt_add_manager.Visible , false);
            Assert.AreEqual(Test.lb_remove_name.Visible , true);
            Assert.AreEqual(Test.Tb_Manager_remove_Name.Visible , true);
            Assert.AreEqual(Test.Bt_remove.Visible , true);
            Test.Close();
        }
    }
}
