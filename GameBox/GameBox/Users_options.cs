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
    public partial class Users_options : Form
    {
        Form return_back;
        public Users_options(Form form)
        {
            InitializeComponent();
            return_back = form;
            if (Program.GameChoice == false)
                Lb_title.Text = "Snake And Ladders :";
            else
                Lb_title.Text = "Reversi :";
        }

        private void Bt_UserOptions_exit_Click(object sender, EventArgs e) /*exit function */
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit? ", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //dialog to user 
            if (res == DialogResult.Yes)
                Environment.Exit(0); /* close all */
        }

        private void Bt_Change_Details(object sender, EventArgs e) /* function to change user deatails */
        {
            Change_details temp = new Change_details(this);
            temp.Show();
            this.Hide();
        }

        private void Bt_UserOPtions_Back(object sender, EventArgs e)/* function to go back */
        {
            return_back.Show();
            this.Close();
        }

        private void Bt_Give_feedback(object sender, EventArgs e) /*function to give feedback */
        {
            Feedback_form FF = new Feedback_form(this);
            FF.Show();
            this.Hide();
        }

        private void Bt_Personal_scores(object sender, EventArgs e) /* function to show user scores info */
        {
            Reports rep = new Reports(this, "Personal scores");
            this.Hide();
            rep.Show();
        }

        private void Bt_Top_Players(object sender, EventArgs e) /* function to shpw top users by  score */
        {
            Reports rep = new Reports(this, "Top Players");
            this.Hide();
            rep.Show();
        }

        private void Bt_Play_game(object sender, EventArgs e) /* function to continue to game  */
        {

        }



        private void Bt_get_tip(object sender, EventArgs e)
        {

        }

        private void Bt_Instructions(object sender, EventArgs e)
        {
            Instructions ins = new Instructions();
            ins.ShowDialog();
        }
    }
}
