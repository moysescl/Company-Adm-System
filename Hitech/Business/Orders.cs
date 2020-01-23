using Hitech.Business;
using Hitech.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hitech.Business
{
    public class Orders
    {
        private int orderId;
        private DateTime orderDate;
        private DateTime requiredDate;
        private DateTime shippingDate;
        private DateTime orderUpdated;
        private int customerId;
        private string customerName;
        private int employeeId;

        public int OrderId { get => orderId; set => orderId = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public DateTime RequiredDate { get => requiredDate; set => requiredDate = value; }
        public DateTime ShippingDate { get => shippingDate; set => shippingDate = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public DateTime OrderUpdated { get => orderUpdated; set => orderUpdated = value; }

        //public void SaveOrder(Orders order)
        //{
        //    OrdersDB.GenerateOrder(order);
        //}

    }
}
