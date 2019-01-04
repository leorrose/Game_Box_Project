using System;
using System.Windows.Forms;

namespace GameBox
{
    public partial class Guest_wait : Form
    {
        Form return_back;
        int duration = 19;
        public Guest_wait(Form form)
        {
            InitializeComponent();
            Shown += Guest_wait_Shown;
            Program.Update_music_bt();
            return_back = form;
            timer1.Start();
        }
        private void Guest_wait_Shown(Object sender, EventArgs e) => Program.Update_music_bt();
        public  void CB_music_click(object sender, EventArgs e) => Program.Music_on_off();
        private void bt_exit_Click(object sender, EventArgs e) => Program.Exit();
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = duration.ToString();
            if (duration == 0)
            {
                timer1.Stop();
                Users_options uo = new Users_options(return_back);
                this.Hide();
                uo.Show();
            }
            duration--;
        }
        private void Bt_back_Click(object sender, EventArgs e)
        {
            return_back.Show();
            this.Close();
        }
    }
}
