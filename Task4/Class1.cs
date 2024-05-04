using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task4
{
    //Task 4
    //Question 10
    internal class Class1
    {
        public void detailformat(String data,String details)
        {
            bool isValid = false;
            switch (details)
            {
                case "Name":
                    isValid = Regex.IsMatch(data, @"^[A-Za-z\s]+$");
                    break;
                case "Address":
                    isValid = !Regex.IsMatch(data, @"[^a-zA-Z0-9\s]");
                    break;
                case "Phone Number":
                    isValid = Regex.IsMatch(data, @"^\d{3}-\d{3}-\d{4}$");
                    break;
                default:
                    Console.WriteLine($"Validation for {details} not implemented.");
                    return;
            }
            if (isValid)
            {
                Console.WriteLine($"{details} '{data}' is valid.");
            }
            else
            {
                Console.WriteLine($"{details} '{data}' is invalid.");
            }
        }
        static void Main(string[] args)
        {
            String name = "Samuel Jebin";
            String address = "123 Hello Street";
            String phone = "555-123-4567";
            Class1 cl = new Class1();
            cl.detailformat(name, "Name");
            cl.detailformat(address, "Address");
            cl.detailformat(phone, "Phone");
        }
    }
}
