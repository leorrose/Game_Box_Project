using System;
using System.Windows.Forms;

namespace GameBox
{
    public partial class Manager_Managment : Form
    {
        Form Return_back;
        public Manager_Managment(Form form)
        {
            InitializeComponent();
            Shown += Manager_Managment_Shown;
            Return_back = form;
        }
        private void Manager_Managment_Shown(Object sender, EventArgs e) => Program.Update_music_bt();
        private void Bt_Manager_Managment_exit_Click(object sender, EventArgs e) => Program.Exit();
        public void CB_music_click(object sender, EventArgs e) => Program.Music_on_off();
        private void Bt_Manager_managment_back_Click(object sender, EventArgs e)
        {
            Return_back.Show();
            this.Close();
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
            if (Program.Test_Insert_Text(Tb_Manager_add_Name.Text) == false || Program.Test_Insert_Text(Tb_Manager_add_Password.Text) == false)
            {
                MessageBox.Show("Only english characters and numbers allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            Tb_Manager_add_Name.Text = "";
            Tb_Manager_add_Password.Text = "";
        }
        private void Bt_remove_manager_click(object sender, EventArgs e)
        {
            if (Program.Test_Insert_Text(Tb_Manager_remove_Name.Text) == false)
            {
                MessageBox.Show("Only english characters and numbers allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (GameBox.Program.User_Check(Tb_Manager_remove_Name.Text) == false)/* check if name and password a valid */
            {
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (GameBox.Program.Check_NAME_exsist(Tb_Manager_remove_Name.Text, "Managers") > 0)
            {
                GameBox.Program.DeleteUser(Tb_Manager_remove_Name.Text, "Managers");
                MessageBox.Show("Manager Removed!");
            }
            else
                MessageBox.Show("Manager dose not exsist!");
            Tb_Manager_remove_Name.Text = "";
        }

        private void Bt_remove_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Bt_remove_manager_click(new object(), new EventArgs());
        }

        private void Bt_add_manager_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Bt_add_manager_click(new object(), new EventArgs());
        }
    }
}
