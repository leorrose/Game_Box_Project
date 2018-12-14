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
    public partial class Logo : Form
    {
        public Logo()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
        }

        int duration = 5;

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
