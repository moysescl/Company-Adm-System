using Hitech.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

//==========================================================
//Connected Mode
//==========================================================

namespace Hitech.GUI
{
    public partial class MisForm : Form
    {
        
        public MisForm()
        {
            InitializeComponent();
        }
        public static void ValidateDigit(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show(" Must be a digit only  \n Message from ValidateDigit operation..");
                //e.KeyChar = ' ';
                e.Handled = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
                Employees emp = new Employees();
                emp.EmployeeId = Convert.ToInt32(textBoxEmployeeId.Text);
                emp.FirstName = textBoxFirstName.Text;
                emp.LastName = textBoxLastName.Text;
                emp.JobTitle = comboBoxJobTitle.Text;
                emp.Email = textBoxEmail.Text;            
                emp.SaveEmployee(emp);

            Userr au = new Userr();
            au.UserName = Convert.ToInt32(textBoxEmployeeId.Text);
            au.Password = textBoxPass.Text;
            au.SaPass(au);
                          
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxJobTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        private void MisForm_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees();
            List<Employees> listEmp = emp.ListEmployees();


            listViewEmp.Items.Clear();
            foreach (Employees anEmp in listEmp)
            {
                ListViewItem item = new ListViewItem(anEmp.EmployeeId.ToString());
                item.SubItems.Add(anEmp.FirstName);
                item.SubItems.Add(anEmp.LastName);
                item.SubItems.Add(anEmp.JobTitle);                
                item.SubItems.Add(anEmp.Email);
                listViewEmp.Items.Add(item);
            }
        }

        private void DisplayListView(List<Employees> list)
        {
            if (list == null || list.Count() <= 0)
            {
                //MessageBox.Show("Can not find this employee!", "Message");
                return;
            }

            listViewEmp.Items.Clear();
            foreach (var ee in list)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ee.EmployeeId.ToString();
                item.SubItems.Add(ee.FirstName);
                item.SubItems.Add(ee.LastName);
                item.SubItems.Add(ee.JobTitle);                
                item.SubItems.Add(ee.Email);
                listViewEmp.Items.Add(item);
            }
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }



        private void listViewEmp_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewEmp.SelectedItems.Count > 0)
            {
                //ListViewItem item = new ListViewItem();
                ListViewItem item = listViewEmp.SelectedItems[0];
                textBoxEmployeeId.Text = item.SubItems[0].Text;
                textBoxFirstName.Text = item.SubItems[1].Text;
                textBoxLastName.Text = item.SubItems[2].Text;
                comboBoxJobTitle.Text = item.SubItems[3].Text;                
                textBoxEmail.Text = item.SubItems[4].Text;
            }                     
           
           
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees();
            emp.EmployeeId = Convert.ToInt32(textBoxEmployeeId.Text.Trim());
            emp.FirstName = textBoxFirstName.Text.Trim();
            emp.LastName = textBoxLastName.Text.Trim();
            emp.JobTitle = comboBoxJobTitle.Text.Trim();
            emp.Email = textBoxEmail.Text.Trim();            
            DialogResult answer = MessageBox.Show("Do you really want to update this employee info ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                emp.UpdateEmployee(emp);
            }
            else
            {
                return;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e/*, string splitter, ListView lv*/)
        {
            int deleteId = Convert.ToInt32(textBoxEmployeeId.Text);
            Employees emp = new Employees();
            DialogResult answer = MessageBox.Show("Do you really want to permanent delete this employee info ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                emp.DeleteEmployee(deleteId);
                Employees empl = new Employees();
                List<Employees> listEmpl = empl.ListEmployees();


                listViewEmp.Items.Clear();
                foreach (Employees anEmpl in listEmpl)
                {
                    ListViewItem item = new ListViewItem(anEmpl.EmployeeId.ToString());
                    item.SubItems.Add(anEmpl.FirstName);
                    item.SubItems.Add(anEmpl.LastName);
                    item.SubItems.Add(anEmpl.JobTitle);
                    item.SubItems.Add(anEmpl.Email);                    
                    listViewEmp.Items.Add(item);
                }
            }
            else
            {
                return;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxEmployeeId.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            comboBoxJobTitle.Text = null;
            textBoxEmail.Text = "";
            textBoxPass.Text = "";
            listViewEmp.Items.Clear();
            textBoxSearch.Text=null;

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxSearch.SelectedItem == null)
            {
                MessageBox.Show("Please, you must select one option in 'Search by'");
            }
            else if (comboBoxSearch.SelectedItem.ToString() == "Employee Id")
            {
                Employees emp = new Employees();
                int id;
                id = Convert.ToInt32(textBoxSearch.Text);

                emp = emp.SearchEmployeeId(id);
                if (emp != null)
                {
                    textBoxEmployeeId.Text = Convert.ToString(emp.EmployeeId);
                    textBoxFirstName.Text = emp.FirstName;
                    textBoxLastName.Text = emp.LastName;
                    comboBoxJobTitle.Text = emp.JobTitle;
                    textBoxEmail.Text = emp.Email;

                }
                else
                {
                    MessageBox.Show("Employee not found", "Information");
                }
            }
            else if (comboBoxSearch.SelectedItem.ToString() == "First Name")
            {
                Employees emp = new Employees();
                string fn;
                fn = textBoxSearch.Text.Trim();

                emp = emp.SearchEmployeeFn(fn);
                if (emp != null)
                {
                    textBoxEmployeeId.Text = Convert.ToString(emp.EmployeeId);
                    textBoxFirstName.Text = emp.FirstName;
                    textBoxLastName.Text = emp.LastName;
                    comboBoxJobTitle.Text = emp.JobTitle;
                    textBoxEmail.Text = emp.Email;

                }
                else
                {
                    MessageBox.Show("Employee not found", "Information");
                }
            }
           

            
        }
        //private void textBoxSearch      

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxSearch.SelectedItem!=null)
            {
                if (comboBoxSearch.SelectedItem.ToString() == "Employee Id")
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(textBoxSearch.Text.Trim(), "[^0-9]"))
                    {
                        MessageBox.Show("Please enter only numbers.");
                        textBoxSearch.Clear();
                    }
                }
                
            }

            if (comboBoxSearch.SelectedItem == null &&
                (System.Text.RegularExpressions.Regex.IsMatch(textBoxSearch.Text.Trim(), "[^0-9]")) &&
                (System.Text.RegularExpressions.Regex.IsMatch(textBoxSearch.Text.Trim(), "^[a-zA-Z ]")))
            {
                MessageBox.Show("Please firstly, select one option in 'Search by'.");
                textBoxSearch.Clear();
                comboBoxSearch.Focus();
            }



        }



    }
}
