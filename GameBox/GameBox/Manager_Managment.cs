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
    public partial class Manager_Managment : Form
    {
        Form Return_back;
        public Manager_Managment(Form form)
        {
            InitializeComponent();
            Return_back = form;
        }

        private void Add_Manager_show_click(object sender, EventArgs e)
        {
            lb_add_name.Visible = true;
            lb_add_password.Visible = true;
            Tb_Manager_add_Name.Visible = true;
            Tb_Manager_add_Password.Visible = true;
            Bt_add_manager.Visible = true;
            lb_remove_name.Visible = false;
            Tb_Manager_remove_Name.Visible = false;
            Bt_remove.Visible = false;
        }

        private void Remove_Manager_show_click(object sender, EventArgs e)
        {
            lb_add_name.Visible = false;
            lb_add_password.Visible = false;
            Tb_Manager_add_Name.Visible = false;
            Tb_Manager_add_Password.Visible = false;
            Bt_add_manager.Visible = false;
            lb_remove_name.Visible = true;
            Tb_Manager_remove_Name.Visible = true;
            Bt_remove.Visible = true;
        }

        private void Bt_add_manager_click(object sender, EventArgs e)
        {
            if (GameBox.Program.User_Check(Tb_Manager_add_Name.Text) == false || GameBox.Program.Password_Check(Tb_Manager_add_Password.Text) == false) /* check if name and password a valid */
            {
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (GameBox.Program.Check_NAME_exsist(Tb_Manager_add_Name.Text, "Managers") > 0 ) /* insurt user to players database */
                {
                    MessageBox.Show("Manager Name alreay exsist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                GameBox.Program.InsertManager(Tb_Manager_add_Name.Text,Tb_Manager_add_Password.Text); /*insurt user to score database */
                MessageBox.Show("Manager Created!", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Bt_remove_manager_click(object sender, EventArgs e)
        {
            if (GameBox.Program.User_Check(Tb_Manager_remove_Name.Text) == false)/* check if name and password a valid */
            {
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (GameBox.Program.Check_NAME_exsist(Tb_Manager_remove_Name.Text, "Managers") > 0)
            {
                GameBox.Program.DeleteUser(Tb_Manager_remove_Name.Text, "Managers");
                MessageBox.Show("User Removed!");
            }
            else
                MessageBox.Show("Manager dose not exsist!");

        }

        private void Bt_Manager_managment_back_Click(object sender, EventArgs e)
        {
            Return_back.Show();
            this.Close();
        }

        private void Bt_Manager_Managment_exit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit? ", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //dialog to user 
            if (res == DialogResult.Yes)
                Environment.Exit(0); /* close all */
        }
    }
}
