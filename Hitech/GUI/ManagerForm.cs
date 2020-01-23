using Hitech.Business;
using Hitech.DataAccess;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Hitech.GUI
{
    public partial class ManagerForm : Form
    {
        SqlDataAdapter da;
        DataSet dsHiTechDB;
        DataTable dtCustomers;

        SqlCommandBuilder sqlBuilder;
        Customers aCustomer = new Customers();

        public ManagerForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
                                  
            aCustomer.CustomerId = Convert.ToInt32(textBoxCustomerId.Text.Trim());
            aCustomer.CustomerName = textBoxCustomerName.Text.Trim();
            aCustomer.Street = textBoxStreet.Text.Trim();
            aCustomer.City = textBoxCity.Text.Trim();
            aCustomer.PostalCode = maskedTextBoxPostalCode.Text.Trim();
            aCustomer.PhoneNumber = maskedTextBoxPhoneNumber.Text.Trim();
            aCustomer.FaxNumber = maskedTextBoxFaxNumber.Text.Trim();
            aCustomer.CreditLimit = Convert.ToInt32(textBoxCreditLimit.Text.Trim());
            dtCustomers.Rows.Add(aCustomer.CustomerId, aCustomer.CustomerName, aCustomer.Street, aCustomer.City,
                aCustomer.PostalCode, aCustomer.PhoneNumber, aCustomer.FaxNumber, aCustomer.CreditLimit);
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            dsHiTechDB = new DataSet("HiTechDS");
            dtCustomers = new DataTable("Customers");
            dtCustomers.Columns.Add("CustomerId", typeof(Int32));
            dtCustomers.Columns.Add("CustomerName", typeof(string));
            dtCustomers.Columns.Add("Street", typeof(string));
            dtCustomers.Columns.Add("City", typeof(string));
            dtCustomers.Columns.Add("PostalCode", typeof(string));
            dtCustomers.Columns.Add("PhoneNumber", typeof(string));
            dtCustomers.Columns.Add("FaxNumber", typeof(string));
            dtCustomers.Columns.Add("CreditLimit", typeof(float));
            dtCustomers.PrimaryKey = new DataColumn[] { dtCustomers.Columns["CustomerId"] };
            dsHiTechDB.Tables.Add(dtCustomers);
            //MessageBox.Show(dsHiTechDB.Tables.Count.ToString());
            //MessageBox.Show(dsHiTechDB.Tables["Students"].ToString());
            da = new SqlDataAdapter("SELECT * FROM Customers", UtilityDB.ConnectDB());
            da.Fill(dsHiTechDB.Tables["Customers"]);
            //dataGridViewStudent.DataSource = dsHiTechDB.Tables["Students"];
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            Customers cu = new Customers();
            List<Customers> listCuDB = cu.ListCustomersDB();


            listViewCustomers.Items.Clear();
            foreach (Customers aCu in listCuDB)
            {
                ListViewItem item = new ListViewItem(aCu.CustomerId.ToString());
                item.SubItems.Add(aCu.CustomerName);
                item.SubItems.Add(aCu.Street);
                item.SubItems.Add(aCu.City);
                item.SubItems.Add(aCu.PostalCode);
                item.SubItems.Add(aCu.PhoneNumber);
                item.SubItems.Add(aCu.FaxNumber);
                item.SubItems.Add(aCu.CreditLimit.ToString());
                listViewCustomers.Items.Add(item);
            }

        }
        private void ClientsListView(List<Customers> collection)
        {
            if (collection == null || collection.Count() <= 0)
            {
                //MessageBox.Show("Can not find this employee!", "Message");
                return;
            }

            listViewCustomers.Items.Clear();
            
            foreach (var cc in collection)
            {
                ListViewItem item = new ListViewItem();
                item.Text = cc.CustomerName;//.ToString();
                item.SubItems.Add(cc.Street);
                item.SubItems.Add(cc.City);
                item.SubItems.Add(cc.PostalCode);
                item.SubItems.Add(cc.PhoneNumber);
                item.SubItems.Add(cc.FaxNumber);                
                item.SubItems.Add(Convert.ToString(cc.CreditLimit));
                listViewCustomers.Items.Add(item);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            sqlBuilder = new SqlCommandBuilder(da);
            da.Update(dsHiTechDB.Tables["Customers"]);
            MessageBox.Show("Database has been updated successfully.", "Update Operation");
        }

        private void listViewClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCustomers.SelectedItems.Count > 0)
            {
                //ListViewItem item = new ListViewItem();
                ListViewItem item = listViewCustomers.SelectedItems[0];
                textBoxCustomerId.Text = item.SubItems[0].Text;
                textBoxCustomerName.Text = item.SubItems[1].Text;
                textBoxStreet.Text = item.SubItems[2].Text;
                textBoxCity.Text = item.SubItems[3].Text;
                maskedTextBoxPostalCode.Text = item.SubItems[4].Text;
                maskedTextBoxPhoneNumber.Text = item.SubItems[5].Text;
                maskedTextBoxFaxNumber.Text = item.SubItems[6].Text;
                textBoxCreditLimit.Text = item.SubItems[7].Text;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DataRow drStudent = dtCustomers.Rows.Find(Convert.ToInt32(textBoxCustomerId.Text));
            drStudent.Delete();

            

            MessageBox.Show(drStudent.RowState.ToString());

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxCustomerId.Clear();
            textBoxCustomerName.Clear();
            textBoxStreet.Clear();
            textBoxCity.Clear();
            maskedTextBoxPostalCode.Clear();
            maskedTextBoxPhoneNumber.Clear();
            textBoxCreditLimit.Clear();            
            listViewCustomers.Items.Clear();
            
        }

        private void labelPostalCode_Click(object sender, EventArgs e)
        {

        }

        private void buttonListCustomerDS_Click(object sender, EventArgs e)
        {
            listViewCustomers.Items.Clear();

            listViewCustomers.FullRowSelect = true;

            foreach (DataRow row in dtCustomers.Rows)
            {
                ListViewItem item = new ListViewItem(row["CustomerId"].ToString());
                item.SubItems.Add(row["CustomerName"].ToString());
                item.SubItems.Add(row["Street"].ToString());
                item.SubItems.Add(row["City"].ToString());
                item.SubItems.Add(row["PostalCode"].ToString());
                item.SubItems.Add(row["PhoneNumber"].ToString());
                item.SubItems.Add(row["FaxNumber"].ToString());
                item.SubItems.Add(row["CreditLimit"].ToString());
                listViewCustomers.Items.Add(item); //Add this row to the ListView
            }
        }
    }
}
