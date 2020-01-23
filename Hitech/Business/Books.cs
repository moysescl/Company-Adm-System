using Hitech.Business;
using System;
using Hitech.DataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitech.Business
{
    public class Books
    {
        private string isbn;
        private string bookTitle;
        private double unitPrice;
        private int yearPublished;
        private int qoh;
        private int publisherId;

        public string Isbn { get => isbn; set => isbn = value; }
        public string BookTitle { get => bookTitle; set => bookTitle = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        public int YearPublished { get => yearPublished; set => yearPublished = value; }
        public int Qoh { get => qoh; set => qoh = value; }
        public int PublisherId { get => publisherId; set => publisherId = value; }





        //save Books to txt file
        //public static void SaveBooks(Books bb)
        //{
        //    BooksDA.SaveBooks(bb);
        //}

        //public static List<Books> ReadAllBooks()
        //{
        //    return BooksDA.ReadAllBooks();
        //}

        //public void UpdateBooks(Books ab)
        //{
        //    BooksDA.UpdateBooks(ab);
        //}

        //public void DeleteBooks(Books del)
        //{
        //    BooksDA.DeleteBooks(del);
        //}
    }
}
