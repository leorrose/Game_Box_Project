using System;
using System.Windows.Forms;

namespace GameBox
{
    public partial class Logo : Form
    {
        int duration = 5;
        public Logo()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (duration > 0)
                duration--;
            else
            {
                timer1.Stop();
                MainForm mf = new MainForm();
                mf.Show();
                this.Hide();
            }
        }
    }
}
