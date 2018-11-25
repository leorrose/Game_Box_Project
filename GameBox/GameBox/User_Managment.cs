using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBox
{
    public partial class User_Managment : Form
    {
        Form Return_back;
        public User_Managment(Form form)
        {
            InitializeComponent();
            Return_back = form;
        }

        private void Bt_Remove_user(object sender, EventArgs e)
        {
            if (GameBox.Program.User_Check(Tb_User_remove_Name.Text) == false)/* check if name and password a valid */
            {
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (GameBox.Program.Check_NAME_exsist(Tb_User_remove_Name.Text, "Players") > 0)
            {
                GameBox.Program.DeleteUser(Tb_User_remove_Name.Text, "Players");
                GameBox.Program.DeleteUser(Tb_User_remove_Name.Text, "Scores");
                MessageBox.Show("User Removed!");
            }
            else
                MessageBox.Show("user dose not exsist!");
        }

        private void Bt_Add_user(object sender, EventArgs e) /* function to add user to database */
        {
            if (GameBox.Program.User_Check(Tb_User_add_Name.Text) == false || GameBox.Program.Password_Check(Tb_User_add_Password.Text) == false) /* check if name and password a valid */
            {
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (GameBox.Program.Insert_User_PLayers(Tb_User_add_Name.Text, Tb_User_add_Password.Text) == false) /* insurt user to players database */
                {
                    MessageBox.Show("User Name alreay exsist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                GameBox.Program.Insert_User__Scores(Tb_User_add_Name.Text); /*insurt user to score database */
                MessageBox.Show("User Created!", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Bt_User_Managment_exit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit? ", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //dialog to user 
            if (res == DialogResult.Yes)
                Environment.Exit(0); /* close all */
        }

        private void Bt_User_managment_back_Click(object sender, EventArgs e)
        {
            Return_back.Show();
            this.Close();
        }

        private void Add_user_show_Click(object sender, EventArgs e)
        {
            lb_add_name.Visible = true;
            lb_add_password.Visible = true;
            Tb_User_add_Name.Visible = true;
            Tb_User_add_Password.Visible = true;
            Bt_add.Visible = true; ;
            Lb_remove_name.Visible = false;
            Tb_User_remove_Name.Visible = false;
            Bt_remove.Visible = false;
        }

        private void Remove_user_show_Click(object sender, EventArgs e)
        {
            lb_add_name.Visible = false;
            lb_add_password.Visible = false;
            Tb_User_add_Name.Visible = false;
            Tb_User_add_Password.Visible = false;
            Bt_add.Visible = false; ;
            Lb_remove_name.Visible = true;
            Tb_User_remove_Name.Visible = true;
            Bt_remove.Visible = true;
        }
    }
}
