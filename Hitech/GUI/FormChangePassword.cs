using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hitech.GUI
{
    public partial class FormChangePassword : Form
    {
        HiTechDBEntities6 dbEntities = new HiTechDBEntities6();
        public FormChangePassword()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            
            FormLogin formChange = new FormLogin();
            formChange.ShowDialog();
            this.Close();

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxId.Clear();
            textBoxPassword.Clear();
            textBoxNewPass.Clear();            
            checkBoxShowHide.Checked = false;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            User cu = new User();
            int id = Convert.ToInt32(textBoxId.Text.Trim());
            string pass = textBoxPassword.Text;
            string aux2="";
            User us = dbEntities.Users.Find(id);
            var aux = from anU in dbEntities.Users
                      where anU.UserName == id
                      select anU;
            foreach (var item in aux)
            {
                aux2 = item.Password;
            }
            if (aux2 == pass)
            {
                User updatedPass = dbEntities.Users.Find(id);
                updatedPass.Password = textBoxNewPass.Text;
                dbEntities.SaveChanges();
                MessageBox.Show("Password updated successfully.", "Confirmation");
            }
            else
            {
                MessageBox.Show("Wrong data entered.\n" +
                    "Try again!", "Confirmation");
            }
            this.Close();
        }

        private void FormChangePassword_Load(object sender, EventArgs e)
        {
            checkBoxShowHide.Checked = true;
            checkBoxShowHide.Checked = false;
        }

        private void checkBoxShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowHide.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxNewPass.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxNewPass.UseSystemPasswordChar = true;
            }
        }
    }
}
