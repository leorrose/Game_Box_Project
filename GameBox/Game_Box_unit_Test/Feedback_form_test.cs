using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameBox;

namespace Game_Box_unit_Test
{
    [TestClass]
    public class Feedback_form_test
    { 
        [TestMethod]
        public void Music_From_on_to_off_test()
        {
            Feedback_form Test = new Feedback_form(new System.Windows.Forms.Form());
            GameBox.Program.music_OnOff = true;

            Test.checkBox1_CheckedChanged(new System.Object(), EventArgs.Empty);

            Assert.AreEqual(Program.music_OnOff, false);
            Assert.AreNotEqual(Program.music_OnOff, true);
        }
        [TestMethod]
        public void Music_From_off_to_onn_test()
        {
            Feedback_form Test = new Feedback_form(new System.Windows.Forms.Form());
            GameBox.Program.music_OnOff = false;

            Test.checkBox1_CheckedChanged(new System.Object(), EventArgs.Empty);

            Assert.AreEqual(Program.music_OnOff, true);
            Assert.AreNotEqual(Program.music_OnOff, false);
        }

    }
}
