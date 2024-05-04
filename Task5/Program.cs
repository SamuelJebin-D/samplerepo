using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        public class User
        {
            public int UserID { get; set; }
            public string UserName { get; set; }
            public string Email { get; set; }
            private string password;
            public string ContactNumber { get; set; }
            public string Address { get; set; }

            public User() 
            { }

            public User(int userID, string userName, string email, string password, string contactNumber, string address)
            {
                UserID = userID;
                UserName = userName;
                Email = email;
                Password = password;
                ContactNumber = contactNumber;
                Address = address;
            }
            public string Password
            {
                get { return password; }
                set { password = value; }
            }
            
        }

        public class Courier
        {
            public int CourierID { get; set; }
            public string SenderName { get; set; }
            public string SenderAddress { get; set; }
            public string ReceiverName { get; set; }
            public string ReceiverAddress { get; set; }
            public double Weight { get; set; }
            public string Status { get; set; }
            public string TrackingNumber { get; set; }
            public DateTime DeliveryDate { get; set; }
            public int UserID { get; set; }
            
        }

        public class Employee
        {
            public int EmployeeID { get; set; }
            public string EmployeeName { get; set; }
            public string Email { get; set; }
            public string ContactNumber { get; set; }
            public string Role { get; set; }
            public double Salary { get; set; }

           
        }

        public class Location
        {
            public int LocationID { get; set; }
            public string LocationName { get; set; }
            public string Address { get; set; }

           
        }

        public class CourierCompany
        {
            public string CompanyName { get; set; }
            public List<Courier> CourierDetails { get; set; }
            public List<Employee> EmployeeDetails { get; set; }
            public List<Location> LocationDetails { get; set; }

           
        }

        public class Payment
        {
            public long PaymentID { get; set; }
            public long CourierID { get; set; }
            public double Amount { get; set; }
            public DateTime PaymentDate { get; set; }

            
        }
        static void Main(string[] args)
        {

        }
    }
}
