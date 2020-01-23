using Hitech.Business;
using Hitech.DataAccess;
using Hitech.Validation;
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
    public partial class InventoryForm : Form
    {
        HiTechDBEntities6 dbEntities = new HiTechDBEntities6();
        public InventoryForm()
        {
            InitializeComponent();
        }

        

        private void buttonList_Click(object sender, EventArgs e)
        {
            
        }
        

        private void dateTimePickerPubDate_ValueChanged(object sender, EventArgs e)
        {
        }



        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //Books ab = new Books();
            //ab.Isbn = Convert.ToInt32(textBoxIsbn.Text);
            //ab.Title = textBoxTitle.Text;
            //ab.Price = Convert.ToInt32(textBoxPrice.Text);
            //ab.Published = Convert.ToDateTime(dateTimePickerPubDate.Text);
            //ab.Qoh = Convert.ToInt32(textBoxQoh.Text);            
            //ab.UpdateBooks(ab);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            
            if (listBoxAuthor.SelectedItems.Count >= 1)
            {
                Book newBook = new Book();
                //Check duplicate Book ID
                string searchIsbn = maskedTextBoxIsbn.Text.Trim();
                Book bo = dbEntities.Books.Find(searchIsbn);

                if (bo != null)

                {
                    MessageBox.Show("Duplicate Book ISBN!", "Error");
                    maskedTextBoxIsbn.Clear();
                    maskedTextBoxIsbn.Focus();
                    return;
                }
                else
                {
                    newBook.Isbn = maskedTextBoxIsbn.Text.Trim();
                    newBook.BookTitle = textBoxTitle.Text.Trim();
                    newBook.UnitPrice = Convert.ToDouble(textBoxUnitPrice.Text.Trim());
                    newBook.Qoh = Convert.ToInt32(textBoxQoh.Text.Trim());
                    newBook.YearPublished = Convert.ToInt32(textBoxPubYear.Text.Trim());
                    var p = from pu in dbEntities.Publishers
                            where pu.PublisherName == comboBoxPublisher.Text
                            select pu;

                    foreach (var emp in p)
                    {
                        newBook.PublisherId = emp.PublisherId;
                    }
                    AuthorBook ab = new AuthorBook();

                    dbEntities.Books.Add(newBook);
                    dbEntities.SaveChanges();
                }

                //=====================================
                //Poulating AuthorBook table
                //=====================================
                foreach (var item in listBoxAuthor.SelectedItems)
                {
                    AuthorBook au = new AuthorBook();
                    int aux = Convert.ToInt32(item);
                    au.Isbn = maskedTextBoxIsbn.Text.Trim();
                    au.AuthorId = aux;
                    dbEntities.AuthorBooks.Add(au);
                    dbEntities.SaveChanges();
                    
                }
                MessageBox.Show("Book saved successfully", "Confirmation");
            }
            else
            {
                MessageBox.Show("Please, select at least one author.", "Confirmation");
            }
            
                    
                              
        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            int isbn = Convert.ToInt32(maskedTextBoxIsbn.Text.Trim());
            Book updatedBook = dbEntities.Books.Find(isbn);
            updatedBook.BookTitle = textBoxTitle.Text.Trim();
            updatedBook.UnitPrice = Convert.ToDouble(textBoxUnitPrice.Text);
            updatedBook.Qoh = Convert.ToInt32(textBoxQoh.Text);
            updatedBook.YearPublished = Convert.ToInt32(textBoxPubYear);
            var p = from pu in dbEntities.Publishers
                    where pu.PublisherName == comboBoxPublisher.Text
                    select pu;

            foreach (var pub in p)
            {
                updatedBook.PublisherId = pub.PublisherId;
            }
            dbEntities.SaveChanges();
            MessageBox.Show("Order updated successfully.", "Confirmation");
        }

        private void buttonList_Click_1(object sender, EventArgs e)
        {
            var bookList = from bk in dbEntities.Books select bk;
            listViewInventory.Items.Clear();
            foreach (var index in bookList)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(index.Isbn));
                
                item.SubItems.Add(Convert.ToString(index.BookTitle));
                item.SubItems.Add(Convert.ToString(index.UnitPrice));
                item.SubItems.Add(Convert.ToString(index.YearPublished));
                item.SubItems.Add(Convert.ToString(index.Qoh));               

                var pu = from pub in dbEntities.Publishers
                         where pub.PublisherId == index.PublisherId
                         select pub;
                foreach (var emp in pu)
                {
                    item.SubItems.Add(Convert.ToString(emp.PublisherName));                    
                }
                listViewInventory.Items.Add(item);
            }

            
        }

        private void listViewInventory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listViewInventory.SelectedItems.Count > 0)
            {
                //==================================================
                //Populate from listViewInventory
                //==================================================
                ListViewItem item = listViewInventory.SelectedItems[0];
                maskedTextBoxIsbn.Text = item.SubItems[0].Text;
                textBoxTitle.Text = item.SubItems[1].Text;
                textBoxUnitPrice.Text = item.SubItems[2].Text;
                textBoxPubYear.Text = item.SubItems[3].Text;
                textBoxQoh.Text = item.SubItems[4].Text;
                comboBoxPublisher.Text = item.SubItems[5].Text;

                //==================================================
                //Poulating listViewRelAuthor
                //==================================================
                listViewRelAuthor.Items.Clear();                
                string c = maskedTextBoxIsbn.Text;
                var nameList = from aEmp in dbEntities.Authors
                               join b in dbEntities.AuthorBooks on aEmp.AuthorId equals b.AuthorId
                               where (b.Isbn == c)
                               select new { aEmp.FirstName, aEmp.LastName};

                foreach (var sEmp in nameList)
                {
                    ListViewItem item2 = new ListViewItem(sEmp.FirstName+" "+sEmp.LastName);

                    listViewRelAuthor.Items.Add(item2);

                }


            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            var listAuthor = from au in dbEntities.Authors select au;
            foreach (var au in listAuthor)
            {
                listBoxAuthor.Items.Add(au.AuthorId);
            }

            var listPub = from pu in dbEntities.Publishers select pu;
            foreach (var pu in listPub)
            {
                comboBoxPublisher.Items.Add(pu.PublisherName);
            }
            //List<string> MyList = new List<string>();
            //MyList.Add("HELLO");
            //MyList.Add("WORLD");
            //MyList.Add("sdsds");
            //MyList.Add("hghgh");
            //MyList.Add("ytyty");
            //MyList.Add("iuiui");
            //MyList.Add("ewewe");
            //MyList.Add("xzxzx");
            //MyList.Add("mnmnm");

            //listBoxAuthor.DataSource = MyList;
        }

        private void textBoxAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDeleteAuthor_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Whould you realy like to permanent delete this author?", "Some Title",
                MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                //var check = from ca in dbEntities. select emp;

                int id = Convert.ToInt32(textBoxAuthorId.Text);
                var anAuthor = dbEntities.Orders.Find(id);

                //Delete it from memory
                dbEntities.Orders.Remove(anAuthor);
                //Save to database
                dbEntities.SaveChanges();

                MessageBox.Show("Author Deleted successfully.", "Confirmation");
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            Author newAuthor = new Author();
            //Check duplicate Author ID
            int searchId = Convert.ToInt32(textBoxAuthorId.Text.Trim());
            Author au = dbEntities.Authors.Find(searchId);

            if (au != null)
            
            {
                MessageBox.Show("Duplicate Author ID!", "Error");
                textBoxAuthorId.Clear();
                textBoxAuthorId.Focus();
                return;
            }
            else
            {
                newAuthor.AuthorId = Convert.ToInt32(textBoxAuthorId.Text.Trim());
            }
            newAuthor.FirstName = textBoxAuthorFirstName.Text.Trim();
            newAuthor.LastName = textBoxAuthorLastName.Text.Trim();            
            dbEntities.Authors.Add(newAuthor);
            dbEntities.SaveChanges();

            

            MessageBox.Show("Author saved successfully", "Comformation");
        }

        private void textBoxAuthorId_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdateAuthor_Click(object sender, EventArgs e)
        {
            int authorId = Convert.ToInt32(textBoxAuthorId.Text.Trim());
            Author updatedAuthor = dbEntities.Authors.Find(authorId);
            updatedAuthor.FirstName = textBoxAuthorFirstName.Text.Trim();
            updatedAuthor.LastName = textBoxAuthorLastName.Text.Trim();            
            dbEntities.SaveChanges();
            MessageBox.Show("Order updated successfully.", "Confirmation");
        }

        private void buttonListAuthor_Click(object sender, EventArgs e)
        {
            var auList = from author in dbEntities.Authors select author;
            listViewAuthor.Items.Clear();
            foreach (var index in auList)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(index.AuthorId));
                item.SubItems.Add(Convert.ToString(index.FirstName));
                item.SubItems.Add(Convert.ToString(index.LastName));
                listViewAuthor.Items.Add(item);
            }
        }

        private void listViewAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAuthor.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewAuthor.SelectedItems[0];
                textBoxAuthorId.Text = item.SubItems[0].Text;
                textBoxAuthorFirstName.Text = item.SubItems[1].Text;
                textBoxAuthorLastName.Text = item.SubItems[2].Text;
            }
            
        }

        private void buttonAddPublisher_Click(object sender, EventArgs e)
        {
            Publisher newPub = new Publisher();
            //Check duplicate Publisher ID
            int searchId = Convert.ToInt32(textBoxPublisherId.Text.Trim());
            Publisher pu = dbEntities.Publishers.Find(searchId);

            if (pu != null)

            {
                MessageBox.Show("Duplicate Publisher ID!", "Error");
                textBoxPublisherId.Clear();
                textBoxPublisherId.Focus();
                return;
            }
            else
            {
                newPub.PublisherId = Convert.ToInt32(textBoxPublisherId.Text.Trim());
            }
            newPub.PublisherName = textBoxAuthorFirstName.Text.Trim();
            newPub.WebSite = textBoxWebSite.Text.Trim();
            dbEntities.Publishers.Add(newPub);
            dbEntities.SaveChanges();

            MessageBox.Show("Publisher saved successfully", "Comformation");
        }

        private void buttonUpdatePublisher_Click(object sender, EventArgs e)
        {
            int pubId = Convert.ToInt32(textBoxPublisherId.Text.Trim());
            Publisher updatedPub = dbEntities.Publishers.Find(pubId);
            updatedPub.PublisherName = textBoxPublisherName.Text.Trim();
            updatedPub.WebSite = textBoxWebSite.Text.Trim();
            dbEntities.SaveChanges();
            MessageBox.Show("Publisher updated successfully.", "Confirmation");
        }

        private void buttonDeletePublisher_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Whould you realy like to permanent delete this publisher?", "Some Title",
               MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                //var check = from ca in dbEntities. select emp;

                int id = Convert.ToInt32(textBoxPublisherId.Text);
                var anPub = dbEntities.Publishers.Find(id);

                //Delete it from memory
                dbEntities.Publishers.Remove(anPub);
                //Save to database
                dbEntities.SaveChanges();

                MessageBox.Show("Publisher Deleted successfully.", "Confirmation");
            }
        }

        private void buttonListPublisher_Click(object sender, EventArgs e)
        {
            var puList = from pub in dbEntities.Publishers select pub;
            listViewPublisher.Items.Clear();
            foreach (var index in puList)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(index.PublisherId));
                item.SubItems.Add(Convert.ToString(index.PublisherName));
                item.SubItems.Add(Convert.ToString(index.WebSite));
                listViewPublisher.Items.Add(item);
            }
        }

        private void listViewPublisher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPublisher.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewPublisher.SelectedItems[0];
                textBoxPublisherId.Text = item.SubItems[0].Text;
                textBoxPublisherName.Text = item.SubItems[1].Text;
                textBoxWebSite.Text = item.SubItems[2].Text;
            }
        }

        private void textBoxUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Whould you realy like to permanent delete this Book?", "Warning!",
                MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                string id = maskedTextBoxIsbn.Text;
                var anBook = dbEntities.Books.Find(id);
                var anAB = from aux in dbEntities.AuthorBooks
                           where aux.Isbn == id
                           select aux;
                dbEntities.AuthorBooks.RemoveRange(anAB);
                dbEntities.Books.Remove(anBook);
                //Save to database
                dbEntities.SaveChanges();

                MessageBox.Show("Book Deleted successfully.", "Confirmation");
            }
        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            maskedTextBoxIsbn.Clear();
            textBoxTitle.Clear();
            textBoxUnitPrice.Clear();
            textBoxQoh.Clear();
            textBoxPubYear.Clear();
            listBoxAuthor.SelectedItems.Clear();
            comboBoxPublisher.Text = null;
            textBoxSearch.Clear();
            comboBoxSearch.Text = null;
            listViewInventory.Items.Clear();
            listViewRelAuthor.Items.Clear();
            textBoxAuthorId.Clear();
            textBoxAuthorFirstName.Clear();
            textBoxAuthorLastName.Clear();
            listViewAuthor.Items.Clear();
            comboBoxSearchAuthor.Text = null;
            textBoxAuthorInfo.Clear();




        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
