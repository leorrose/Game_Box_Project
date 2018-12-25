using System;
using System.Windows.Forms;

namespace GameBox
{
    public partial class GameChoice : Form
    {
        Form return_back;
        public GameChoice(Form form)
        {
            InitializeComponent();
            Shown += GameChoice_Shown;
            Program.Update_music_bt();
            return_back = form;
        }
        private void GameChoice_Shown(Object sender, EventArgs e)
        {
            Program.Update_music_bt();
            if (Program.cnt_players != 2)
            {
                bt_reversi.Enabled = false;
                bt_reversi.Cursor = Cursors.No;
            }
        }
        private void Bt_Exit_Click(object sender, EventArgs e) => Program.Exit();
        public  void CB_music_click(object sender, EventArgs e) => Program.Music_on_off();
        private void Bt_back_Click(object sender, EventArgs e) /* function to go back */
        {
            return_back.Show(); /*show last screen */
            this.Close(); /* hide this screen */
        }
        private void Bt_reversi_Click(object sender, EventArgs e)
        {
            Reversi NewGame = new Reversi(this,return_back);
            Program.GameChoice = true;
            this.Hide();
            NewGame.Show();
        }
        private void Bt_snake_and_ladders_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.GameChoice = false;
            Snake_and_ladders game = new Snake_and_ladders(this, return_back);
            game.Show();
        }
        private void reversi_insruction_Click(object sender, EventArgs e)
        {
            Program.GameChoice = true;
            Print_instructions ins = new Print_instructions();
            ins.ShowDialog();
        }
        private void SAl_instruction_Click(object sender, EventArgs e)
        {
            Program.GameChoice = false;
            Print_instructions ins = new Print_instructions();
            ins.ShowDialog();
        }
    }
}
