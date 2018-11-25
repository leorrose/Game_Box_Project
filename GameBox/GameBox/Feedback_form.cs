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
            return_back = form;
        }

        private void Bt_Insert_feedback(object sender, EventArgs e)
        {
            if(Tb_feedback_name.Text != GameBox.Program.user1 && Tb_feedback_name.Text != GameBox.Program.user2)
            {
                MessageBox.Show("Invalid Name!");
                return;
            }

            else if (Tb_Feedback.ToString().Length > 0)
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

        private void Bt_Feedback_exit(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit? ", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //dialog to user 
            if (res == DialogResult.Yes)
                Environment.Exit(0);
        }

        private void Bt_Feedback_back(object sender, EventArgs e)
        { 
            return_back.Show();
            this.Close();
        }
    }
}
