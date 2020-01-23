using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitech.Business
{
    public class OrderLine
    {
        private int orderId;
        private string isbn;
        private int quantity;

        public int OrderId { get => orderId; set => orderId = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
