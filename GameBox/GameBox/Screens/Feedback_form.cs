﻿using System;
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
        private void Feedback_form_Shown(Object sender, EventArgs e) => Program.Update_music_bt();
        public  void checkBox1_CheckedChanged(object sender, EventArgs e) => Program.Music_on_off();
        private void Bt_Feedback_exit_click(object sender, EventArgs e) => Program.Exit();
        private void Bt_Feedback_back_click(object sender, EventArgs e)
        {
            return_back.Show();
            this.Close();
        }
        private void Bt_Insert_feedback_click(object sender, EventArgs e)
        {
            if (Program.User_Check(Tb_feedback_name.Text) == false)
            {
                MessageBox.Show("Invalid Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Program.Test_Insert_Text(Tb_Feedback.Text) == false || Program.Test_Insert_Text(Tb_feedback_name.Text) == false)
            {
                MessageBox.Show("Only english characters and numbers allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Tb_feedback_name.Text != GameBox.Program.user1 && Tb_feedback_name.Text != GameBox.Program.user2 && Tb_feedback_name.Text != Program.guest)
            {
                MessageBox.Show("Invalid Name!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Tb_feedback_name.Text = "";
        }

        private void Bt_insert_feedback_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Bt_Insert_feedback_click(new object(), new EventArgs());
        }
    }
}
