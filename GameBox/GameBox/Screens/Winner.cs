using System;
using System.Windows.Forms;

namespace GameBox
{
    public partial class Winner : Form
    {
        Form return_back, GameEnd ,GameBack;
        public Winner(string name,Form Back , Form Game, Form BackGame)
        {
            InitializeComponent();
            Lb_winner.Text = name;
            return_back = Back;
            GameEnd = Game;
            GameBack = BackGame;
        }
        private void BT_New_game_Click(object sender, EventArgs e)
        {
            if (Program.GameChoice == true)
            {
                Reversi NewGame = new Reversi(GameBack, return_back);
                NewGame.Show();
            }
            else
            {
                Snake_and_ladders NewGame = new Snake_and_ladders(GameBack, return_back);
                NewGame.Show();
            }
            GameEnd.Close();
            this.Close();
        }
        private void Bt_continue_Click(object sender, EventArgs e)
        {
            GameEnd.Close();
            this.Close();
            return_back.Show();
        }
    }
}
