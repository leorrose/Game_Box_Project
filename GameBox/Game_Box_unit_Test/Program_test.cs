using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameBox;

namespace Game_Box_unit_Test
{
    [TestClass]
    public class Program_test
    {
        [TestMethod]
        public void Password_check_function_correct_input_test()
        {
            Boolean result = GameBox.Program.Password_Check("12345");
            Assert.AreEqual(result, true);
            Assert.AreNotEqual(result, false);
        }
 
        [TestMethod]
        public void Password_check_function_incorrect_input_test()
        {
            Boolean result = GameBox.Program.Password_Check("123");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void User_check_function_correct_input_test()
        {
            Boolean result = GameBox.Program.User_Check("leor");
            Assert.AreEqual(result, true);
            Assert.AreNotEqual(result, false);
        }
        [TestMethod]
        public void User_check_function_incorrect_input_test()
        {
            Boolean result = GameBox.Program.User_Check("l");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Inert_text_check_function_correct_input_numbers_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text("123456789");
            Assert.AreEqual(result, true);
            Assert.AreNotEqual(result, false);
        }
        [TestMethod]
        public void Inert_text_check_function_correct_input_english_chars_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text("AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz");
            Assert.AreEqual(result, true);
            Assert.AreNotEqual(result, false);
        }
        [TestMethod]
        public void Inert_text_check_function_correct_input_allowed_chars_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text(".! ");
            Assert.AreEqual(result, true);
            Assert.AreNotEqual(result, false);
        }
        [TestMethod]
        public void Inert_text_function_incorrect_input_not_english_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text("לא חוקי");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Inert_text_function_incorrect_input_not_allowed_char1_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text("#");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Inert_text_function_incorrect_input_not_allowed_char2_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text("@");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Inert_text_function_incorrect_input_not_allowed_char3_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text("$");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Inert_text_function_incorrect_input_not_allowed_char4_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text("%");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Inert_text_function_incorrect_input_not_allowed_char5_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text("^");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Inert_text_function_incorrect_input_not_allowed_char6_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text("&");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Inert_text_function_incorrect_input_not_allowed_char7_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text("(");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Inert_text_function_incorrect_input_not_allowed_char8_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text(")");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Inert_text_function_incorrect_input_not_allowed_char9_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text("-");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Inert_text_function_incorrect_input_not_allowed_char10_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text("_");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Inert_text_function_incorrect_input_not_allowed_char11_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text("+");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Inert_text_function_incorrect_input_not_allowed_char12_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text("=");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Inert_text_function_incorrect_input_not_allowed_char13_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text("/");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Inert_text_function_incorrect_input_not_allowed_char14_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text("\\");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Inert_text_function_incorrect_input_not_allowed_char15_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text("[");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Inert_text_function_incorrect_input_not_allowed_char16_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text("]");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Inert_text_function_incorrect_input_not_allowed_char17_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text(('"').ToString());
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Inert_text_function_incorrect_input_not_allowed_char18_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text("'");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Inert_text_function_incorrect_input_not_allowed_char19_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text(";");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Inert_text_function_incorrect_input_not_allowed_char20_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text(":");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Inert_text_function_incorrect_input_not_allowed_char21_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text("?");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Inert_text_function_incorrect_input_not_allowed_char22_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text("|");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Inert_text_function_incorrect_input_not_allowed_char23_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text("`");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Inert_text_function_incorrect_input_not_allowed_char24_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text("~");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Inert_text_function_incorrect_input_not_allowed_char25_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text(">");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Inert_text_function_incorrect_input_not_allowed_char26_test()
        {
            Boolean result = GameBox.Program.Test_Insert_Text("<");
            Assert.AreEqual(result, false);
            Assert.AreNotEqual(result, true);
        }
        [TestMethod]
        public void Music_on_off_check_function_from_true_to_false_test()
        {
            GameBox.Program.music_OnOff = true;
            GameBox.Program.Music_on_off();
            Assert.AreEqual(Program.music_OnOff,false);
            Assert.AreNotEqual(Program.music_OnOff, true);
        }
        [TestMethod]
        public void Music_on_off_function_from_false_to_true_test()
        {
            GameBox.Program.music_OnOff = false;
            GameBox.Program.Music_on_off();
            Assert.AreEqual(Program.music_OnOff,true);
            Assert.AreNotEqual(Program.music_OnOff, false);
        }
    }
}
