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
    public partial class Print_screen : Form
    {
        public Print_screen(string type)
        {
            InitializeComponent();
            string Game;
            if (type == "Tips")
            {
                Random index = new Random();
                string UserConectionString = Program.ConectionString("Tips");
                using (SqlConnection con = new SqlConnection(UserConectionString))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("SELECT Tip FROM Tips WHERE Number="+ index.Next(1,34).ToString() ,con);
                    SqlDataReader Read = sqlCommand.ExecuteReader();
                    Read.Read();
                    label1.Text = Read.GetString(0);
                    con.Close();
                }

            }
            else if (type == "Ads")
            {
                Random index = new Random();
                string UserConectionString = Program.ConectionString("Ads");
                using (SqlConnection con = new SqlConnection(UserConectionString))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("SELECT Ad FROM Ads WHERE Number=" + index.Next(1,6).ToString(), con);
                    SqlDataReader Read = sqlCommand.ExecuteReader();
                    Read.Read();
                    label1.Text = Read.GetString(0);
                    con.Close();
                }

            }
        }

        private void Bt_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
