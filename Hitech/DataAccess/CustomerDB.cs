using Hitech.Business;
using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hitech.GUI;
using System.Data.SqlClient;

namespace Hitech.DataAccess
{
    public static class CustomerDB
    {
        //static string filePath = Application.StartupPath + @"\Clients.txt";
        //static string filePath2 = Application.StartupPath + @"\Temp.txt";
        //static string filePathPass = Application.StartupPath + @"\Password.txt";
        public static void SaveClients(Customers ee)
        {


            MessageBox.Show("Client saved successfully!");
            //using (StreamWriter swp = new StreamWriter(filePathPass, true))
            //{
            //    swp.WriteLine(ee.EmployeeId + "," + ee.Password);
            //}
            //MessageBox.Show("Save a new employee success!", "Message");
        }
        //public static List<Customers> ReadAllClients()
        //{
        //    List<Customers> xxClients = new List<Customers>();
        //    if (File.Exists(filePath))
        //    {
        //        StreamReader sr = new StreamReader(filePath);
        //        string line = sr.ReadLine();
        //        while (line != null)
        //        {
        //            string[] index = line.Split(',');
        //            Customers xx = new Customers();
        //            xx.ClientName = index[0];
        //            xx.ClientAddress = index[1];
        //            xx.ClientCity = index[2];
        //            xx.PostalCode = index[3];
        //            xx.ClientPhone = index[4];
        //            xx.ClientCredit = Convert.ToInt32(index[5]);
        //            xxClients.Add(xx);
        //            line = sr.ReadLine();
        //        }
        //        sr.Close();
        //    }
        //    if (xxClients.Count() <= 0)
        //        MessageBox.Show("Employee not found!", "Error");
        //    return xxClients;
        //}

        //public static void UpdateClients(Customers cli)
        //{
        //    StreamReader sr = new StreamReader(filePath);
        //    StreamWriter sw = new StreamWriter(filePath2);
        //    string line = sr.ReadLine();
        //    while (line != null)
        //    {
        //        string[] field = line.Split(',');
        //        if (cli.ClientName != field[0])
        //        {
        //            sw.WriteLine(field[0] + "," + field[1] + "," + field[2] + "," + field[3] + "," + field[4] + "," + field[5]);

        //        }
        //        line = sr.ReadLine();
        //    }
        //    sw.WriteLine(cli.ClientName + "," + cli.ClientAddress + "," + cli.ClientCity + "," + cli.PostalCode + "," + cli.ClientPhone + "," + cli.ClientCredit);
        //    sw.Close();
        //    sr.Close();
        //    File.Delete(filePath);
        //    File.Move(filePath2, filePath);
        //    MessageBox.Show("Update successfully!");

        //}

        public static List<Customers> GetCustomerList()
        {
            List<Customers> listCu = new List<Customers>();
            // Connect and open database
            SqlConnection connDB = UtilityDB.ConnectDB();
            // Perform insert statement
            //create an object of type SqlCommand
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "SELECT * FROM Customers";
            SqlDataReader sqlReader = cmd.ExecuteReader();
            Customers cu;
            while (sqlReader.Read())
            {
                cu = new Customers();
                cu.CustomerId = Convert.ToInt32(sqlReader["CustomerId"]);
                cu.CustomerName = sqlReader["CustomerName"].ToString();
                cu.Street = sqlReader["Street"].ToString();
                cu.City = sqlReader["City"].ToString();
                cu.PostalCode = sqlReader["PostalCode"].ToString();
                cu.PhoneNumber = sqlReader["PhoneNumber"].ToString();
                cu.FaxNumber = sqlReader["FaxNumber"].ToString();
                cu.CreditLimit = float.Parse(sqlReader["CreditLimit"].ToString());
                listCu.Add(cu);
            }
            // close database
            connDB.Close();
            return listCu;
        }
    }
}
