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
    public partial class Feedback_form : Form
    {
       Form return_back;
        public Feedback_form(Form form)
        {
            InitializeComponent();
            Shown += Feedback_form_Shown;
            Program.Update_music_bt();
            return_back = form;
        }
        private void Feedback_form_Shown(Object sender, EventArgs e)
        {
            Program.Update_music_bt();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Program.Music_on_off();
        }

        private void Bt_Feedback_back_click(object sender, EventArgs e)
        {
            return_back.Show();
            this.Close();
        }

        private void Bt_Feedback_exit_click(object sender, EventArgs e)
        {
            Program.Exit();
        }

        private void Bt_Insert_feedback_click(object sender, EventArgs e)
        {
            if (Tb_feedback_name.Text != GameBox.Program.user1 && Tb_feedback_name.Text != GameBox.Program.user2)
            {
                MessageBox.Show("Invalid Name!");
                return;
            }

            else if (Tb_Feedback.Text.ToString().Length > 0)
            {
                GameBox.Program.Insert_Feedback(Tb_feedback_name.Text, Tb_Feedback.Text);
                MessageBox.Show("Thank you for your feedback!");

            }
            else
            {
                MessageBox.Show("No Text Inserted!");
                return;
            }
            Tb_Feedback.Text = "";
        }
    }
}
