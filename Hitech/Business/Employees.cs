using Hitech.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitech.Business
{
    public class Employees
    {
        private int employeeId;
        private string firstName;
        private string lastName;
        private string jobTitle;
        private string email;

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
        public string Email { get => email; set => email = value; }

        public void SaveEmployee(Employees emp)
        {
            EmployeeDB.SaveRecord(emp);
        }             

        
        public static List<Employees> ReadAllRecord()
        {
            return EmployeeDA.ReadAllRecord();
        }
        public void UpdateEmployee(Employees emp)
        {
            EmployeeDB.UpdateRecord(emp);
        }
        public void DeleteEmployee(int id)
        {
            EmployeeDB.DeleteRecord(id);
        }

        public int CreateId()
        {
            return EmployeeDB.GetEmployeeId();
        }

        public List<Employees> ListEmployees()
        {
            return EmployeeDB.GetEmployeeList();
        }

        public Employees SearchEmployeeId(int id)
        {
            return EmployeeDB.SearchRecordId(id);
        }

        public Employees SearchEmployeeFn(string fn)
        {
            return EmployeeDB.SearchRecordFn(fn);
        }

        



    }
}
