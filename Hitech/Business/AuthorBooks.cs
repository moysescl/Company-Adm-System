using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitech.Business
{
    public class AuthorBooks
    {
        private string isbn;
        private int authorId;

        public string Isbn { get => isbn; set => isbn = value; }
        public int AuthorId { get => authorId; set => authorId = value; }
    }
}
