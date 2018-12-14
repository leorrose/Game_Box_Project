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
        int duration = 5;
        public Print_screen(string type)
        {
            InitializeComponent();
            timer1.Interval = 1000;
            if (type == "Tips")
            {
                Random index = new Random();
                string UserConectionString = Program.ConectionString("Tips");
                PB_Gifs.Image = Properties.Resources.tips;
                PB_Gifs.SizeMode = PictureBoxSizeMode.StretchImage;
                using (SqlConnection con = new SqlConnection(UserConectionString))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("SELECT Tip FROM Tips WHERE Number="+ index.Next(1,34).ToString() ,con);
                    SqlDataReader Read = sqlCommand.ExecuteReader();
                    Read.Read();
                    Lb_Print.Text = Read.GetString(0);
                    con.Close();
                }

            }
            else if (type == "Ads")
            {
                timer1.Start();
                Bt_ok.Visible = false;
                lb_time.Visible = true;
                Random index = new Random();
                int number = index.Next(1, 8);
                string UserConectionString = Program.ConectionString("Ads");
                using (SqlConnection con = new SqlConnection(UserConectionString))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("SELECT Ad FROM Ads WHERE Number=" + number.ToString(), con);
                    SqlDataReader Read = sqlCommand.ExecuteReader();
                    Read.Read();
                    Lb_Print.Text = Read.GetString(0);
                    con.Close();
                }

                switch(number)
                {
                    case 1:
                        PB_Gifs.Image = Properties.Resources.plumber;
                        PB_Gifs.SizeMode = PictureBoxSizeMode.StretchImage; 
                        break;
                    case 2:
                        PB_Gifs.Image = Properties.Resources.pizza;
                        PB_Gifs.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 3:
                        PB_Gifs.Image = Properties.Resources.burgerking;
                        PB_Gifs.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 4:
                        PB_Gifs.Image = Properties.Resources.Fanta;
                        PB_Gifs.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 5:
                        PB_Gifs.Image = Properties.Resources.mcdonalds;
                        PB_Gifs.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 6:
                        PB_Gifs.Image = Properties.Resources.ice_cream;
                        PB_Gifs.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 7:
                        PB_Gifs.Image = Properties.Resources.hapoel;
                        PB_Gifs.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;

                }
            }
        }

        private void Bt_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void timer1_Tick(object sender, EventArgs e)
        {
            Bt_ok.Visible = false;
            if (duration > 1)
            {
                duration--;
                lb_time.Text = duration.ToString();
            }
            else
            {
                lb_time.Visible = false;
                Bt_ok.Visible = true;
                timer1.Stop();
            }
               
        }
    }
}
