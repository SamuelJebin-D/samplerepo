using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task7;


//Task 7
//Question 2
//. InvalidEmployeeIdException throw this exception when id entered for the employee not existing in 
//the system
namespace Task7
{
    class InvalidEmployeeIdException : Exception
    {
        public InvalidEmployeeIdException(string message) : base(message)
        {
        }
    }
    class EmployeeSystem
    {
        private static readonly string[] employeeIds = { "E001", "E002", "E003" };
        public bool IsEmployeeIdValid(string id)
        {
            foreach (string employeeId in employeeIds)
            {
                if (employeeId.Equals(id))
                {
                    return true;
                }
            }
            return false;
        }
        public void ProcessEmployeeData(string employeeId)
        {

            if (!IsEmployeeIdValid(employeeId))
            {
                throw new InvalidEmployeeIdException("Invalid employee ID: " + employeeId);
            }
            Console.WriteLine("Processing data for employee ID: " + employeeId);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
            {
            Console.WriteLine("Enter the employee number ");
            String temp = Console.ReadLine();
            EmployeeSystem employeeSystem = new EmployeeSystem();
            try
            {
                employeeSystem.ProcessEmployeeData(temp);
            }
            catch (InvalidEmployeeIdException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
