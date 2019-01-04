using System;
using System.Windows.Forms;

namespace GameBox
{
    public partial class Managers_option : Form
    {
        Form return_back;
        public Managers_option(Form form)
        {
            InitializeComponent();
            Shown += Managers_option_Shown;
            return_back = form;
        }
        private void Managers_option_Shown(Object sender, EventArgs e) => Program.Update_music_bt();
        private void Bt_login_exit_Click(object sender, EventArgs e) => Program.Exit();
        public  void CB_music_CheckedChanged(object sender, EventArgs e) => Program.Music_on_off();
        private void Bt_back_Click(object sender, EventArgs e) /* go back screen */
        {
            return_back.Show(); /*upon last screen */
            MessageBox.Show("Manager Disconected ", "Sign Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); /* close this screen */
        }
        private void Bt_logins_report(object sender, EventArgs e) /* function to show logins report*/
        {
            Reports rep = new Reports(this,"Logins");
            this.Hide();
            rep.Show();
        }
        private void Bt_add_remove_user(object sender, EventArgs e) /* function to remove or add user to database */
        {
            this.Hide();
            User_Managment Um = new User_Managment(this);
            Um.Show();
        }
        private void Bt_add_remove_manager(object sender, EventArgs e) /* function to remove or add manager to database */
        {
            this.Hide();
            Manager_Managment Mm = new Manager_Managment(this);
            Mm.Show();
        }
        private void Bt_scores_report(object sender, EventArgs e) /* function to show scores report*/
        {
            Reports rep = new Reports(this, "High Scores");
            this.Hide();
            rep.Show();
        }
        private void Bt_FeedBack_report(object sender, EventArgs e) /* function to show Feedbacks report*/
        {
            Reports rep = new Reports(this, "FeedBacks");
            this.Hide();
            rep.Show();
        }
        private void Bt_get_tips_Click(object sender, EventArgs e)
        {
            Print_screen ins = new Print_screen("Tips");
            ins.ShowDialog();
        }
    }
}
