using System;
using System.Windows.Forms;

namespace GameBox
{
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }
        private void Bt_ok_Click(object sender, EventArgs e) =>this.Close();
    }
}
