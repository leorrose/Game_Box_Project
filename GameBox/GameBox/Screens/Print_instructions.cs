using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GameBox
{
    public partial class Print_instructions : Form
    {
        public Print_instructions()
        {
            InitializeComponent();
            string Game;
            if (Program.GameChoice == false)
                Game = "Snakes and ladders";
            else
                Game = "Reversi";
            try
            {
                string UserConectionString = Program.ConectionString("Instructions");
                using (SqlConnection con = new SqlConnection(UserConectionString))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("SELECT Instruction FROM Instructions WHERE GameName='" + Game + "'", con);
                    SqlDataReader Read = sqlCommand.ExecuteReader();
                    Read.Read();
                    label1.Text = Read.GetString(0);
                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error accorred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0); /* close all */
            }
        }
        private void Bt_ok_Click(object sender, EventArgs e) => this.Close();
    }
}
