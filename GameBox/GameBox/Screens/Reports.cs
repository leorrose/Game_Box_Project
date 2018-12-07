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
    public partial class Reports : Form
    {
        Form Return_back;
        string Print;
        public Reports(Form form,string PrintType)
        {
            InitializeComponent();
            Return_back = form;
            Print = PrintType;
            Choose_print();
            lb_title.Text = PrintType + " :";
            
        }

        private void Choose_print()
        {

            switch (Print)
            {
                case "Top Players" :

                    Print_table("SELECT Top (10) * FROM Scores ORDER BY Wins DESC", "Scores");
                    break;
                case "Personal scores":
                    if(Program.cnt_players==2)
                        Print_table("SELECT * FROM Scores WHERE Name='"+Program.user1 + "' OR Name ='" + Program.user2 +"'", "Scores");
                    else
                        Print_table("SELECT * FROM Scores WHERE Name='" + Program.user1 + "'", "Scores");
                    break;
                case "Logins":
                    Print_table("SELECT * FROM Logins ORDER BY Date", "Logins");
                    break;
                case "High Scores":
                    Print_table("SELECT * FROM Scores ORDER BY Wins DESC", "Scores");
                    break;
                case "FeedBacks":
                    Print_table("SELECT * FROM Feedbacks ORDER BY Date", "Feedbacks");
                    break;
                default:
                    break;

            }

        }
        private void Print_table(string SqlCommand,string DataBaseName)
        {
            string UserConectionString = Program.ConectionString(DataBaseName);
            using (SqlConnection con = new SqlConnection(UserConectionString))
            {
                con.Open();
                SqlDataAdapter SqlService = new SqlDataAdapter(SqlCommand,con);
                DataTable Table = new DataTable();
                SqlService.Fill(Table);
                dataGridView1.DataSource = Table;
                con.Close();
            }
        }

        private void Bt_Reports_Exit_click(object sender, EventArgs e)
        {
            Program.Exit();
        }

        private void Bt_reports_Back_click(object sender, EventArgs e)
        {
            Return_back.Show();
            this.Close();
        }



    }
}