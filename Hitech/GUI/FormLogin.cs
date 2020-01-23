using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Hitech.Business;

namespace Hitech.GUI
{
    public partial class FormLogin : Form

    {
        HiTechDBEntities6 dbEntities = new HiTechDBEntities6();
        private int count = 0;
        public FormLogin()
        {
            InitializeComponent();
        }               

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelPasswordChange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormChangePassword formChange = new FormChangePassword();
            formChange.ShowDialog();
            this.Hide();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            checkBoxShowHide.Checked = true;
            checkBoxShowHide.Checked = false;
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }



        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Userr aUser = new Userr();
            aUser.UserName = Convert.ToInt32(textBoxId.Text);
            aUser.Password = textBoxPassword.Text;
            
            if (aUser.VerifyUser(aUser))
            {
                int id = Convert.ToInt32(textBoxId.Text);
                MessageBox.Show("Login Successfully!", "Success!");                
                dbEntities.Users.Find(id);
                var aux = from aEmp in dbEntities.Employees                               
                               where aEmp.EmployeeId == id
                               select aEmp.JobTitle;
                string aux2 = aux.FirstOrDefault();
                if ( aux2 == "Order Clerk")
                {
                    ClerkForm formChange = new ClerkForm();
                    formChange.ShowDialog();
                    //this.Hide();
                }
                if (aux2 == "Inventory Controller")
                {
                    InventoryForm formChange = new InventoryForm();
                    formChange.ShowDialog();
                }
                if (aux2 == "Sales Manager")
                {
                    ManagerForm formChange = new ManagerForm();
                    formChange.ShowDialog();
                }
                if (aux2 == "MIS Manager")
                {
                    MisForm formChange = new MisForm();
                    formChange.ShowDialog();
                }
            }
            else
            {
                count++;
                if (count >= 3)
                {
                    MessageBox.Show("Please contact the system administator.", "Error");
                    this.Hide();

                }
                MessageBox.Show("Username or Password is invalid!", "Denied!");

                MessageBox.Show(count.ToString());
            }
        }

        private void linkLabelChPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormChangePassword formChange = new FormChangePassword();
            formChange.ShowDialog();
            this.Close();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxId.Clear();
            textBoxPassword.Clear();
            checkBoxShowHide.Checked = false;
        }

        private void checkBoxShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowHide.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
