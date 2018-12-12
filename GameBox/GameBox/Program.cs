using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib; 
using System.Windows.Forms;
using System.Data.SqlClient; 
using System.IO;  
using System.Reflection;


namespace GameBox
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string Url = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location); /* get exe path */
            for (int i = 0; i <= 8; i++)
                Url = Url.Remove(Url.Length - 1); /* remove unnecassery files */
            Url += "Resources\\PlayMusic.mp3";
            Program.Wmp.URL = Url;
            Program.Wmp.controls.play();
            Application.Run(new MainForm());

        }
        public static string user1 = "", user2 = "";
        public static string guest = "";
        public static Boolean TypeUser; // Guest=false, player=true 
        public static Boolean GameChoice; /* true = reversi, false = LAS */
        public static int cnt_players;  //1= 1 player , 2 = 2 players
        public static Boolean music_OnOff = true; //Music on = true , Music off == false
        public static Boolean ManagerConected; // true= manager,false = not manager 
        public static WindowsMediaPlayer Wmp = new WindowsMediaPlayer();  //background music

        public static void Exit() /* function to close all */
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit? ", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //dialog to user 
            if (res == DialogResult.Yes)
                Environment.Exit(0); /* close all */

        }

        public static Boolean Password_Check(string pass) /* function to check if password length is correct */
        {
            if (pass.Length == 5)
                return true;
            return false;
        }
        public static Boolean User_Check(string user) /* function to check if Name length is correct */
        {
            if (user.Length < 2 || user.Length > 10)
                return false;
            return true;
        }

        /* all database function */
        public static string ConectionString(string DBName) /* function to get database conection string */
        {
            try
            {
                string DBConectionString = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location); /* get exe path */
                for (int i = 0; i <= 8; i++)
                    DBConectionString = DBConectionString.Remove(DBConectionString.Length - 1); /* remove unnecassery files */
                DBConectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =" + DBConectionString  + "DataBase\\" + DBName + ".mdf" + ";Integrated Security = True"; /* create data path string */
                return DBConectionString; /* return path string */
            }
            catch(Exception e)
            {
                MessageBox.Show("Error accorred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0); /* close all */
                return "";
            }
            
         }

        public static int Check_NAME_exsist(string Name, string DataBaseName)  /* check if name exsist in database */
        {
            try
            {
                string UserConectionString = ConectionString(DataBaseName); /* creat conection string to database */
                using (SqlConnection con = new SqlConnection(UserConectionString)) /* open conection */
                {
                    con.Open(); /* open database */
                    SqlCommand sqlCommand = new SqlCommand("SELECT Name FROM " + DataBaseName + " WHERE Name= " + "'" + Name + "'", con); /* sql commmand */
                    SqlDataAdapter SqlService = new SqlDataAdapter(sqlCommand); /* create adaptar to datatable of sql command */
                    int countRows = SqlService.Fill(new DataTable()); /* crate data tabke with command */
                    con.Close(); /* close conection */
                    return countRows; /* return number of rows created by command */
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error accorred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0); /* close all */
                return -1;
            }
        }

        public static Boolean Check_Password_Is_correct(string Name, string Password, string DataBaseName) /* check if Password exsist in database */
        {
            try
            {
                string UserConectionString = ConectionString(DataBaseName); /* creat conection string to database */
                using (SqlConnection con = new SqlConnection(UserConectionString)) /* open conection */
                {
                    con.Open(); /* open database */
                    SqlCommand sqlCommand = new SqlCommand("SELECT Password FROM " + DataBaseName + " WHERE Name=" + "'" + Name + "'" + "AND Password='" + Password + "'", con); /* sql commmand */
                    SqlDataAdapter SqlService = new SqlDataAdapter(sqlCommand);/* create adaptar to datatable of sql command */
                    int countRows = SqlService.Fill(new DataTable());  /* crate data tabke with command */
                    con.Close(); /* close conection */
                    if (countRows > 0) /* check number of rows created by command */
                        return true; /* if there password was correct */
                    return false; /* if there password was wrong */

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error accorred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0); /* close all */
                return false;
            }
        }
        public static void DeleteUser(string Name, string DataBaseName) /* delete user by name */
        {
            try
            {
                string UserConectionString = ConectionString(DataBaseName); /* creat conection string to database */
                using (SqlConnection con = new SqlConnection(UserConectionString)) /* open conection */
                {
                    con.Open(); /* open database */
                    string cmd = "DELETE FROM " + DataBaseName + " WHERE Name='" + Name + "'"; /* sql commmand string */
                    SqlCommand cmd1 = new SqlCommand(cmd, con); /* sql commmand */
                    cmd1.ExecuteNonQuery(); /* use command on database */
                    con.Close(); /* close conection */
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error accorred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0); /* close all */
            }
        }

        /* functions on players database */
        public static Boolean Insert_User_PLayers(string Name, string Password) /* insert user to playes database */
        {
            try
            {
                if (Check_NAME_exsist(Name, "Players") == 0) /* check if name alredy exsist */
                {
                    string UserConectionString = ConectionString("Players"); /* creat conection string to database */
                    using (SqlConnection con = new SqlConnection(UserConectionString)) /* open conection */
                    {
                        con.Open(); /* open database */
                        string cmd = "INSERT INTO Players VALUES('" + Name + "','" + Password + "')"; /* sql commmand string */
                        SqlCommand cmd1 = new SqlCommand(cmd, con); /* sql commmand */
                        cmd1.ExecuteNonQuery(); /* use command on database */
                        con.Close(); /* close conection */
                    }
                    return true; /* if user inserted */
                }

                else /* if name exsist */
                    return false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error accorred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0); /* close all */
                return false;
            }
        }

        public static void Upadte_User_players(string Name, string Password, string NewName) /* update user info in database */
        {
            try
            {
                string UserConectionString = ConectionString("Players");  /* creat conection string to database */
                using (SqlConnection con = new SqlConnection(UserConectionString)) /* open conection */
                {
                    con.Open(); /* open database */
                    string cmd = "UPDATE Players SET Name='" + NewName + "',Password= '" + Password + "'WHERE Name='" + Name + "'"; /* sql commmand string */
                    SqlCommand cmd1 = new SqlCommand(cmd, con); /* sql commmand */
                    cmd1.ExecuteNonQuery(); /* use command on database */
                    con.Close(); /* close conection */
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error accorred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0); /* close all */
            }
        }
        /* functions on manager database */
        public static void InsertManager(string Name, string Password) /* insert manager to databse*/
        {
            try
            {
                string UserConectionString = ConectionString("Managers");/* creat conection string to database */
                using (SqlConnection con = new SqlConnection(UserConectionString))  /* open conection */
                {
                    con.Open(); /* open database */
                    string cmd = "INSERT INTO Managers VALUES('" + Name + "','" + Password + "')"; /* sql commmand string */
                    SqlCommand cmd1 = new SqlCommand(cmd, con); /* sql commmand */
                    cmd1.ExecuteNonQuery(); /*use command on database */
                    con.Close(); /* close conection */
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error accorred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0); /* close all */
            }
        }
        /* function on login database */
        public static void InsertLogin(string Name, string type) /* insert login to login Database */
        {
            try
            {
                string UserConectionString = ConectionString("Logins"); /* creat conection string to database */
                using (SqlConnection con = new SqlConnection(UserConectionString)) /* open conection */
                {
                    con.Open(); /* open database */
                    string cmd = "INSERT INTO Logins VALUES('" + Name + "','" + type + "','" + DateTime.Today.ToShortDateString() + "','" + DateTime.Now.ToLongTimeString() + "')"; /* sql commmand string */
                    SqlCommand cmd1 = new SqlCommand(cmd, con);/* sql commmand */
                    cmd1.ExecuteNonQuery();/* use command on database */
                    con.Close(); /* close conection */
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error accorred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0); /* close all */
            }
        }

        /* functions on scores database*/
        public static void Upadte_User_Scores(string Name, string NewName) /* function to update user in scores*/
        {
            try
            {
                string UserConectionString = ConectionString("Scores"); /* creat conection string to database */
                using (SqlConnection con = new SqlConnection(UserConectionString)) /* open conection */
                {
                    con.Open(); /* open database */
                    string cmd = "UPDATE Scores SET Name='" + NewName + "' WHERE Name='" + Name + "'"; /* sql commmand string */
                    SqlCommand cmd1 = new SqlCommand(cmd, con); /* sql commmand */
                    cmd1.ExecuteNonQuery(); /* use command on database */
                    con.Close(); /* close conection */
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error accorred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0); /* close all */
            }
        }
        public static void Insert_User__Scores(string Name) /* function to insurt user in scores*/
        {
            try
            {
                string ScoresConectionString = ConectionString("Scores"); /* creat conection string to database */
                using (SqlConnection con = new SqlConnection(ScoresConectionString)) /* open conection */
                {
                    con.Open(); /* open database */
                    string cmd = "INSERT INTO Scores (Name)  VALUES ('" + Name + "')"; /* sql commmand string */
                    SqlCommand cmd1 = new SqlCommand(cmd, con); /* sql commmand */
                    cmd1.ExecuteNonQuery(); /* use command on database */
                    con.Close(); /* close conection */
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error accorred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0); /* close all */
            }
        }
        public static void Update_Win_reversi(string Name)
        {

            string UserConectionString = ConectionString("Scores");
            using (SqlConnection con = new SqlConnection(UserConectionString))
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Scores WHERE Name='" + Name + "'", con);
                SqlDataReader Read = sqlCommand.ExecuteReader();
                Read.Read();
                int Wins = Convert.ToInt32(Read["wins"]);
                int Reversi_Wins = Convert.ToInt32(Read["Reversi Wins"]);
                int Game_Count = Convert.ToInt32(Read["Game Count"]);
                Read.Close();
                Wins++;
                Reversi_Wins++;
                Game_Count++;
                string cmd = "UPDATE Scores SET Wins='" + Wins +"',[Game Count]='"+ Game_Count + "',[Reversi Wins]='" + Reversi_Wins +"'WHERE Name='" + Name + "'";
                SqlCommand cmd1 = new SqlCommand(cmd, con);
                cmd1.ExecuteNonQuery();
                con.Close();
            }
        }
        public static void Update_Win_SAl(string Name)
        {

            string UserConectionString = ConectionString("Scores");
            using (SqlConnection con = new SqlConnection(UserConectionString))
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Scores WHERE Name='" + Name + "'", con);
                SqlDataReader Read = sqlCommand.ExecuteReader();
                Read.Read();
                int Wins = Convert.ToInt32(Read["wins"]);
                int SAL_Wins = Convert.ToInt32(Read["Snake And Ladders Wins"]);
                int Game_Count = Convert.ToInt32(Read["Game Count"]);
                Read.Close();
                Wins++;
                SAL_Wins++;
                Game_Count++;
                string cmd = "UPDATE Scores SET Wins='" + Wins + "',[Game Count]='" + Game_Count + "',[Snake And Ladders Wins]='" + SAL_Wins + "'WHERE Name='" + Name + "'";
                SqlCommand cmd1 = new SqlCommand(cmd, con);
                cmd1.ExecuteNonQuery();
                con.Close();
            }
        }
        public static void Update_Lose(string Name)
        {

            string UserConectionString = ConectionString("Scores");
            using (SqlConnection con = new SqlConnection(UserConectionString))
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Scores WHERE Name='" + Name + "'", con);
                SqlDataReader Read = sqlCommand.ExecuteReader();
                Read.Read();
                int Loses = Convert.ToInt32(Read["Loses"]);
                int Game_Count = Convert.ToInt32(Read["Game Count"]);
                Read.Close();
                Loses++;
                Game_Count++;
                string cmd = "UPDATE Scores SET Loses='" + Loses + "',[Game Count]='" + Game_Count + "'WHERE Name='" + Name + "'";
                SqlCommand cmd1 = new SqlCommand(cmd, con);
                cmd1.ExecuteNonQuery();
                con.Close();
            }
        }
        /* functions on Feedback Database */
        public static void Insert_Feedback(string Name, string Report)  /* function to insurt feedback in feedbacks database*/
        {
            try
            {
                string UserConectionString = ConectionString("FeedBacks"); /* creat conection string to database */
                using (SqlConnection con = new SqlConnection(UserConectionString)) /* open conection */
                {
                    con.Open(); /* open database */
                    string cmd = "INSERT INTO FeedBacks VALUES('" + Name + "','" + Report + "','" + DateTime.Today.ToShortDateString() + "')"; /* sql commmand string */
                    SqlCommand cmd1 = new SqlCommand(cmd, con); /* sql commmand */
                    cmd1.ExecuteNonQuery(); /* use command on database */
                    con.Close();/* close conection */
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error accorred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0); /* close all */
            }
        }
        public static void Music_on_off() /* turn Bt mussic on/off for all screens */
        {
            if (music_OnOff == false)
            {
                music_OnOff = true;
                Program.Wmp.controls.play();
            }
            else
            {
                music_OnOff = false;
                Program.Wmp.controls.pause();
            }
            foreach (Form f in Application.OpenForms)
            {

                if (f.GetType() == typeof(MainForm))
                {
                    MainForm Newform = (GameBox.MainForm)f;
                    if (music_OnOff == true)
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Music;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Mute;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else if (f.GetType() == typeof(GameChoice))
                {
                    GameChoice Newform = (GameBox.GameChoice)f;
                    if (music_OnOff == true)
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Music;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Mute;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else if (f.GetType() == typeof(Guest_wait))
                {
                    Guest_wait Newform = (GameBox.Guest_wait)f;
                    if (music_OnOff == true)
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Music;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Mute;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else if (f.GetType() == typeof(login_form))
                {
                    login_form Newform = (GameBox.login_form)f;
                    if (music_OnOff == true)
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Music;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Mute;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else if (f.GetType() == typeof(Managers_option))
                {
                    Managers_option Newform = (GameBox.Managers_option)f;
                    if (music_OnOff == true)
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Music;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Mute;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else if (f.GetType() == typeof(Manager_Managment))
                {
                    Manager_Managment Newform = (GameBox.Manager_Managment)f;
                    if (music_OnOff == true)
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Music;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Mute;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else if (f.GetType() == typeof(Reports))
                {
                    Reports Newform = (GameBox.Reports)f;
                    if (music_OnOff == true)
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Music;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Mute;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else if (f.GetType() == typeof(User_Managment))
                {
                    User_Managment Newform = (GameBox.User_Managment)f;
                    if (music_OnOff == true)
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Music;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Mute;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else if (f.GetType() == typeof(Users_options))
                {
                    Users_options Newform = (GameBox.Users_options)f;
                    if (music_OnOff == true)
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Music;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Mute;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else if (f.GetType() == typeof(Change_details))
                {
                    Change_details Newform = (GameBox.Change_details)f;
                    if (music_OnOff == true)
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Music;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Mute;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else if (f.GetType() == typeof(Feedback_form))
                {
                    Feedback_form Newform = (GameBox.Feedback_form)f;
                    if (music_OnOff == true)
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Music;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Mute;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else if (f.GetType() == typeof(Reversi))
                {
                    Reversi Newform = (GameBox.Reversi)f;
                    if (music_OnOff == false)
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Green_mute;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Green_music;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else if (f.GetType() == typeof(Snake_and_ladders))
                {
                    Snake_and_ladders Newform = (GameBox.Snake_and_ladders)f;
                    if (music_OnOff == false)
                    {
                        Newform.bt_music.BackgroundImage = Properties.Resources.Mute_red;
                        Newform.bt_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        Newform.bt_music.BackgroundImage = Properties.Resources.Music_red;
                        Newform.bt_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
            } 
        }
        public static void Update_music_bt() /* update Bt mussic on/off for all screens before opening */
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(MainForm))
                {
                    MainForm Newform = (GameBox.MainForm)f;
                    if (music_OnOff == false)
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Mute;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Music;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else if (f.GetType() == typeof(GameChoice))
                {
                    GameChoice Newform = (GameBox.GameChoice)f;
                    if (music_OnOff == false)
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Mute;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Music;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else if (f.GetType() == typeof(Guest_wait))
                {
                    Guest_wait Newform = (GameBox.Guest_wait)f;
                    if (music_OnOff == false)
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Mute;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Music;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else if (f.GetType() == typeof(login_form))
                {
                    login_form Newform = (GameBox.login_form)f;
                    if (music_OnOff == false)
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Mute;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Music;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else if (f.GetType() == typeof(Managers_option))
                {
                    Managers_option Newform = (GameBox.Managers_option)f;
                    if (music_OnOff == false)
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Mute;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Music;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else if (f.GetType() == typeof(Manager_Managment))
                {
                    Manager_Managment Newform = (GameBox.Manager_Managment)f;
                    if (music_OnOff == false)
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Mute;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Music;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else if (f.GetType() == typeof(Reports))
                {
                    Reports Newform = (GameBox.Reports)f;
                    if (music_OnOff == false)
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Mute;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Music;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else if (f.GetType() == typeof(User_Managment))
                {
                    User_Managment Newform = (GameBox.User_Managment)f;
                    if (music_OnOff == false)
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Mute;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Music;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else if (f.GetType() == typeof(Users_options))
                {
                    Users_options Newform = (GameBox.Users_options)f;
                    if (music_OnOff == false)
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Mute;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Music;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else if (f.GetType() == typeof(Change_details))
                {
                    Change_details Newform = (GameBox.Change_details)f;
                    if (music_OnOff == false)
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Mute;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Music;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else if (f.GetType() == typeof(Feedback_form))
                {
                    Feedback_form Newform = (GameBox.Feedback_form)f;
                    if (music_OnOff == false)
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Mute;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Music;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else if (f.GetType() == typeof(Reversi))
                {
                    Reversi Newform = (GameBox.Reversi)f;
                    if (music_OnOff == false)
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Green_mute;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        Newform.CB_music.BackgroundImage = Properties.Resources.Green_music;
                        Newform.CB_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else if (f.GetType() == typeof(Snake_and_ladders))
                {
                    Snake_and_ladders Newform = (GameBox.Snake_and_ladders)f;
                    if (music_OnOff == false)
                    {
                        Newform.bt_music.BackgroundImage = Properties.Resources.Mute_red;
                        Newform.bt_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        Newform.bt_music.BackgroundImage = Properties.Resources.Music_red;
                        Newform.bt_music.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
            }
        }
    }
}
