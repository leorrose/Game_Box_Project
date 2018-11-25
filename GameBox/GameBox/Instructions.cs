using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace GameBox
{
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
            string Game;
            if (Program.GameChoice == false)
                Game = "Snakes and ladders";
            else
                Game = "Reversi";
            string UserConectionString = Program.ConectionString("Instructions");
            using (SqlConnection con = new SqlConnection(UserConectionString))
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT Instruction FROM Instructions WHERE GameName='"+ Game + "'",con);
                SqlDataReader Read = sqlCommand.ExecuteReader();
                Read.Read();
                label1.Text = Read.GetString(0);
            }
        }

        private void Bt_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
