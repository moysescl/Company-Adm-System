using Hitech.Business;
using System;
using Hitech.DataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitech.Business
{
    public class Customers
    {
        private int customerId;
        private string customerName;        
        private string street;
        private string city;
        private string postalCode;
        private string phoneNumber;
        private string faxNumber;
        private float creditLimit;

        
        
        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string FaxNumber { get => faxNumber; set => faxNumber = value; }
        public float CreditLimit { get => creditLimit; set => creditLimit = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public string CustomerName { get => customerName; set => customerName = value; }


        //save client to txt file
        public static void SaveClients(Customers ee)
        {
            CustomerDB.SaveClients(ee);
        }

        public List<Customers> ListCustomersDB()
        {
            return CustomerDB.GetCustomerList();
        }

        //public static List<Customers> ReadAllClients()
        //{
        //    return ClientsDA.ReadAllClients();
        //}

        //public void UpdateClients(Customers cli)
        //{
        //    ClientsDA.UpdateClients(cli);
        //}
    }
}
