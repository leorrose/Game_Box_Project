using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameBox;

namespace Game_Box_unit_Test
{
    [TestClass]
    public class Snake_and_ladders_test
    {
        [TestMethod]
        public void Music_From_on_to_off_test()
        {
            Snake_and_ladders Test = new Snake_and_ladders(new System.Windows.Forms.Form(), new System.Windows.Forms.Form());
            GameBox.Program.music_OnOff = true;

            Test.bt_music_Click(new System.Object(), EventArgs.Empty);

            Assert.AreEqual(Program.music_OnOff, false);
            Assert.AreNotEqual(Program.music_OnOff, true);
        }
        [TestMethod]
        public void Music_From_off_to_onn_test()
        {
            Snake_and_ladders Test = new Snake_and_ladders(new System.Windows.Forms.Form(), new System.Windows.Forms.Form());
            GameBox.Program.music_OnOff = false;

            Test.bt_music_Click(new System.Object(), EventArgs.Empty);

            Assert.AreEqual(Program.music_OnOff, true);
            Assert.AreNotEqual(Program.music_OnOff, false);
        }
    }
}
