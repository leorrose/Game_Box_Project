using System;
using System.Data;
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
            Shown += Reports_Shown;
            Return_back = form;
            Print = PrintType;
            Choose_print();
            lb_title.Text = PrintType + ":";
            
        }
        private void Reports_Shown(Object sender, EventArgs e) => Program.Update_music_bt();
        private void Bt_Reports_Exit_click(object sender, EventArgs e) => Program.Exit();
        public  void CB_music_click(object sender, EventArgs e) => Program.Music_on_off();
        private void Bt_reports_Back_click(object sender, EventArgs e)
        {
            Return_back.Show();
            this.Close();
        }
        private void Choose_print()
        {
            switch (Print)
            {
                case "Top Players" :
                    Print_table("SELECT Top (10) * FROM Scores ORDER BY Wins DESC", "Scores");
                    break;
                case "Personal Scores":
                    if(Program.cnt_players==2)
                        Print_table("SELECT * FROM Scores WHERE Name='"+Program.user1 + "' OR Name ='" + Program.user2 +"'", "Scores");
                    else
                        Print_table("SELECT * FROM Scores WHERE Name='" + Program.user1 + "'", "Scores");
                    break;
                case "Logins":
                    Print_table("SELECT * FROM Logins ORDER BY convert(datetime, Date, 103) DESC, convert(time, Time) DESC", "Logins");
                    break;
                case "High Scores":
                    Print_table("SELECT * FROM Scores ORDER BY Wins DESC", "Scores");
                    break;
                case "FeedBacks":
                    Print_table("SELECT * FROM Feedbacks ORDER BY convert(datetime, Date, 103) DESC", "Feedbacks");
                    break;
                default:
                    break;
            }
        }
        private void Print_table(string SqlCommand,string DataBaseName)
        {
            try
            {
                string UserConectionString = Program.ConectionString(DataBaseName);
                using (SqlConnection con = new SqlConnection(UserConectionString))
                {
                    con.Open();
                    SqlDataAdapter SqlService = new SqlDataAdapter(SqlCommand, con);
                    DataTable Table = new DataTable();
                    SqlService.Fill(Table);
                    dataGridView1.DataSource = Table;
                    if (DataBaseName == "Feedbacks")
                    {
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                        dataGridView1.Columns[1].Width = 430;
                    }
                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error accorred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0); /* close all */
            }
        }
    }
}