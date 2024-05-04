using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AssignTask1
{
    internal class taskone
    {
        public void status()
        {
            String Status = "";
            Console.WriteLine("Enter the status of the order");
            Status = Console.ReadLine();
            if (Status == "Processing" ||  Status == "processing")
            {
                Console.WriteLine("Your order is still being processed");
            }
            else if(Status == "Delivered" || Status == "delivered")
            {
                Console.WriteLine("Your order is Delivered");
            }
            else if (Status == "Cancelled" || Status == "cancelled")
            {
                Console.WriteLine("Your order is Cancelled successfully");
            }
            else
            {
                Console.WriteLine("Invalid order Status");
            }

        }

        public void weight()
        {
            
            Console.WriteLine("Enter the weight of the order");
            double weight = double.Parse(Console.ReadLine());
            String category = "";
            switch (weight)
            {
                case double n when (n <= 10):
                    category = "Light";
                    break;
                case double n when (n > 10 && n <= 50):
                    category = "Medium";
                    break;
                case double n when (n > 50):
                    category = "Heavy";
                    break;
                default:
                    category = "Invalid";
                    break;
            }
            Console.WriteLine($"Parcel weight is {weight}kg is under {category}");
        } 

        public void userAuth()
        {
            String username = "Samueljebin";
            String password = "Sam1234";
            
            for(int attempt = 1;attempt<=3;attempt++)
            {
                Console.WriteLine("Enter the username");
                String tempuser = Console.ReadLine();
                Console.WriteLine("Enter the password");
                String temppw = Console.ReadLine() ;
                if (username == tempuser && password == temppw)
                {
                    Console.WriteLine($"Welcome {tempuser} you are log in is successfull");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Username or Password");
                    int rem = 3-attempt;
                    Console.WriteLine($"There is {rem} attempts remaining");
                    Console.WriteLine();
                }
                if (attempt == 3)
                {
                    Console.WriteLine("Maximum login attempt reached");
                }
            }

        }
    }
}
