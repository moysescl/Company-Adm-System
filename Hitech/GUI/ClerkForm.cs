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


namespace Hitech.GUI
{
    public partial class ClerkForm : Form
    {
        HiTechDBEntities6 dbEntities = new HiTechDBEntities6();        
        public ClerkForm()
        {
            InitializeComponent();
        }

        private void ClerkForm_Load(object sender, EventArgs e)
        {
            var listOrder = from ord in dbEntities.Customers select ord;            
            foreach (var or in listOrder)
            {
                comboBoxCustomerId.Items.Add(or.CustomerId);
            }

            var listOrderId = from ordId in dbEntities.Orders select ordId;            
            foreach (var ordId in listOrderId)
            {
                comboBoxOrderId.Items.Add(ordId.OrderId);
            }

            var listIsbn = from isbn in dbEntities.Books select isbn;            
            foreach (var isbn in listIsbn)
            {
                comboBoxIsbn.Items.Add(isbn.Isbn);
            }
        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonGenerateOrder_Click(object sender, EventArgs e)
        {
            Order newOrder = new Order();
            //Check duplicate Emloyee ID
            int searchId = Convert.ToInt32(textBoxOrderId.Text.Trim());
            Order or = dbEntities.Orders.Find(searchId);
            
            if (or != null)
            // if (emp.EmployeeId == searchId)
            {
                MessageBox.Show("Duplicate Order ID!", "Error");
                textBoxOrderId.Clear();
                textBoxOrderId.Focus();
                return;
            }
            else
            {
                newOrder.OrderId = Convert.ToInt32(textBoxOrderId.Text.Trim());
            }            
            newOrder.CustomerId = Convert.ToInt32(comboBoxCustomerId.Text.Trim());
            //Just for test, 
            newOrder.EmployeeId = 1003;
            newOrder.RequiredDate = Convert.ToDateTime(dateTimePickerRequiredDate.Text);
            newOrder.ShippingDate = newOrder.RequiredDate.AddDays(-3);
            newOrder.OrderDate = DateTime.Today;
            dbEntities.Orders.Add(newOrder);
            dbEntities.SaveChanges();

            //Refreshing Order Id in Order Line
            comboBoxOrderId.Items.Clear();
            var listOrderId = from emp in dbEntities.Orders select emp;
            
            foreach (var emp in listOrderId)
            {
                comboBoxOrderId.Items.Add(emp.OrderId);
            }

            MessageBox.Show("Order generated successfully", "Comformation");           
      

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateOrder_Click(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(textBoxOrderId.Text.Trim());
            Order updatedOrder = dbEntities.Orders.Find(orderId);
            updatedOrder.CustomerId = Convert.ToInt32(comboBoxCustomerId.Text.Trim());
            updatedOrder.RequiredDate = Convert.ToDateTime(dateTimePickerRequiredDate.Text);
            updatedOrder.ShippingDate = updatedOrder.RequiredDate.AddDays(-3);
            updatedOrder.OrderUpdated = DateTime.Today;
            //updatedOrder.EmployeeId = 1001;
            dbEntities.SaveChanges();
            MessageBox.Show("Order updated successfully.", "Confirmation");
        }

        private void comboBoxOrderId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonList_Click(object sender, EventArgs e)
        {

        }

        private void buttonListOrder_Click(object sender, EventArgs e)
        {
            var ordList = from order in dbEntities.Orders select order;
            listViewOrder.Items.Clear();
            foreach (var index in ordList)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(index.OrderId));
                item.SubItems.Add(Convert.ToString(index.CustomerId));
                item.SubItems.Add(Convert.ToString(index.EmployeeId));
                item.SubItems.Add(index.OrderDate.ToString("yyyy/MM/dd"));          
                item.SubItems.Add(index.OrderUpdated.ToString("yyyy/MM/dd"));
                item.SubItems.Add(index.RequiredDate.ToString("yyyy/MM/dd"));
                item.SubItems.Add(index.ShippingDate.ToString("yyyy/MM/dd"));

                listViewOrder.Items.Add(item);
            }
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            orderLine newOrderLine = new orderLine();
            //Check duplicate Emloyee ID
            int orId = Convert.ToInt32(textBoxOrderId.Text.Trim());
            string isbn = comboBoxIsbn.Text.Trim();
            orderLine or = dbEntities.orderLines.Find(orId,isbn);

            if (or != null)
            
            {
                MessageBox.Show("This Book already is in the order !\nYou are allowed to update the quantity only.\n" +
                    "Otherwise delete the current Order Line and create a new one.", "Error");
                comboBoxIsbn = null;
                
                return;
            }
            else
            {
                newOrderLine.OrderId = Convert.ToInt32(comboBoxOrderId.Text.Trim());
                
            }

                        
            
            newOrderLine.Isbn = comboBoxIsbn.Text.Trim();
            newOrderLine.Quantity = Convert.ToInt32(textBoxQuantity.Text.Trim());            
            dbEntities.orderLines.Add(newOrderLine);
            dbEntities.SaveChanges();
            MessageBox.Show("Order Line saved successfully", "Comformation");
        }

        private void listViewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrder.SelectedItems.Count > 0)
            {
                //==================================================
                //Populate listViewOrder
                //==================================================
                ListViewItem item = listViewOrder.SelectedItems[0];
                textBoxOrderId.Text = item.SubItems[0].Text;
                comboBoxCustomerId.Text = item.SubItems[1].Text;
                dateTimePickerRequiredDate.Text = item.SubItems[5].Text;
                //==================================================
                //Populate listviewOrderLine 
                //==================================================
                listViewOrderLine.Items.Clear();
                comboBoxOrderId.Text = null;
                comboBoxIsbn.Text = null;
                textBoxQuantity.Clear();                
                int c = Convert.ToInt32(textBoxOrderId.Text);
                var nameList = from aEmp in dbEntities.orderLines
                               join b in dbEntities.Books on aEmp.Isbn equals b.Isbn
                               where (aEmp.OrderId == c)
                               select new { aEmp.Isbn, b.BookTitle, aEmp.Quantity };             
                                                  
                    foreach (var sEmp in nameList)
                    {
                        ListViewItem item2 = new ListViewItem(sEmp.Isbn);
                        item2.SubItems.Add(sEmp.BookTitle);
                        item2.SubItems.Add(Convert.ToString(sEmp.Quantity));
                        listViewOrderLine.Items.Add(item2);

                    }                  
                                             
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Whould you realy like to permanent delete this order?", "Some Title", 
                MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(textBoxOrderId.Text);
                var anOrder = dbEntities.Orders.Find(id);
                var anOL = from aux in dbEntities.orderLines
                           where aux.OrderId == id
                           select aux;
                dbEntities.orderLines.RemoveRange(anOL);
                dbEntities.Orders.Remove(anOrder);
                //Save to database
                dbEntities.SaveChanges();

                MessageBox.Show("Order Deleted successfully.", "Confirmation");
            }
                        
        }

        private void buttonUpdateItem_Click(object sender, EventArgs e)
        {
            //=====================================================
            //Update Item by Entities Framework
            //=====================================================
            int orderId = Convert.ToInt32(comboBoxOrderId.Text.Trim());
            string isbn = comboBoxIsbn.Text;

            orderLine updatedOrderLine = dbEntities.orderLines.Find(orderId,isbn);
            if (updatedOrderLine!=null)
            {
                Order updatedOrder = dbEntities.Orders.Find(orderId);
                updatedOrderLine.Quantity = Convert.ToInt32(textBoxQuantity.Text.Trim());
                updatedOrder.OrderUpdated = DateTime.Today;
                dbEntities.SaveChanges();
                MessageBox.Show("Order updated successfully.", "Confirmation");
            }
            else
            {
                MessageBox.Show("You are allowed to update quantity only.\n" +
                    "Otherwise Delete the Order Line and create a new one.", "Error");
            }
                      
                      
        }

        private void button1_Click(object sender, EventArgs e)
        {
                      
            int c = Convert.ToInt32(comboBoxOrderId.Text);            
            var nameList = from aEmp in dbEntities.orderLines
                           join b in dbEntities.Books on aEmp.Isbn equals b.Isbn
                           where (aEmp.OrderId == c)                         
                           select new { aEmp.Isbn, b.BookTitle, aEmp.Quantity};            
            listViewOrderLine.Items.Clear();
            foreach (var sEmp in nameList)
            {
                ListViewItem item = new ListViewItem(sEmp.Isbn);
                item.SubItems.Add(sEmp.BookTitle);
                item.SubItems.Add(Convert.ToString(sEmp.Quantity));
                listViewOrderLine.Items.Add(item);              
                
            }
        }

        private void listViewOrderLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listViewOrderLine.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewOrderLine.SelectedItems[0];
                comboBoxOrderId.Text = item.SubItems[0].Text;
                string c = item.SubItems[1].Text; 
                var a = from aEmp in dbEntities.Books
                        join b in dbEntities.orderLines on aEmp.Isbn equals b.Isbn
                        where (aEmp.BookTitle == c)                          
                        select new {aEmp.Isbn};                
                foreach (var sEmp in a)
                {                    
                    comboBoxIsbn.Text = sEmp.Isbn;                    
                }
                textBoxQuantity.Text = item.SubItems[2].Text;
                comboBoxOrderId.Text = textBoxOrderId.Text;                             

            }
        }

        private void buttonDelLine_Click(object sender, EventArgs e)
        {
            orderLine newOrderLine = new orderLine();            
            int orId = Convert.ToInt32(comboBoxOrderId.Text.Trim());
            comboBoxIsbn.Refresh();
            string isbn = comboBoxIsbn.Text;
            orderLine or = dbEntities.orderLines.Find(orId, isbn);

            if (or != null)

            {
                
                DialogResult dialogResult = MessageBox.Show("Whould you realy like to permanent delete this Order Line?", "Some Title",
                 MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {

                    var anOrderLine = dbEntities.orderLines.Find(orId, isbn);
                    dbEntities.orderLines.Remove(anOrderLine);
                    dbEntities.SaveChanges();

                    MessageBox.Show("Order Line Deleted successfully.", "Confirmation");
                }

                
            }
            else
            {
                MessageBox.Show("The selected book, is not in the current order.\n" +
                    "In this case, there is nothing to delete.", "Error");
                

                return;
            }
                                    
        }
    }
}
