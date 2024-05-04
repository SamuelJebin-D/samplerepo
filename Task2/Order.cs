using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Order
    {
        private string customerName;
        private int orderNumber;
        private string product;
        private int quantity;
        public Order(string customerName, int orderNumber, string product, int quantity)
        {
            this.customerName = customerName;
            this.orderNumber = orderNumber;
            this.product = product;
            this.quantity = quantity;
        }
        public string GetCustomerName()
        {
            return customerName;
        }

        public int GetOrderNumber()
        {
            return orderNumber;
        }

        public string GetProduct()
        {
            return product;
        }
        public int GetQuantity()
        {
            return quantity;
        }
    }

    class Programm
    {
        static void Main(string[] args)
        {
            Order[] orders = new Order[]
            {
            new Order("Customer1", 1001, "ProductA", 2),
            new Order("Customer2", 1002, "ProductB", 3),
            new Order("Customer1", 1003, "ProductC", 1),
            new Order("Customer1", 1004, "ProductD", 5),
            new Order("Customer3", 1005, "ProductE", 2),
            };
            Console.WriteLine("Enter the Customer to be searched");
            string customerName = Console.ReadLine();
            Console.WriteLine($"Orders for customer '{customerName}':");
            for (int i = 0; i < orders.Length; i++)
            {
                if (orders[i].GetCustomerName() == customerName)
                {
                    Console.WriteLine($"Order Number: {orders[i].GetOrderNumber()}, Product: {orders[i].GetProduct()}, Quantity: {orders[i].GetQuantity()}");
                }
            }
        }
    }
}
