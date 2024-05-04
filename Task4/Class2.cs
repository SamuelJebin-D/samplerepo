using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Class2
    {
        //public Class2()
        //{

        //}

        public string emailgen(String customerName, int orderNum, String deliveryAdd, DateTime expecteddate)
        {
            string email = $"Dear {customerName},\n" +
            $"Thank you for your order. Your order number is {orderNum}.\n" +
            $"Delivery Address: {deliveryAdd}\n" +
            $"Your order is expected to be delivered on {expecteddate.ToShortDateString()}.\n" +
            "Please let us know if you have any questions or concerns.\n" +
            "Best regards,\n" +
            "Sam online orders";
            return email;
        }
        static void Main (String[] args)
        {
            String customerName = "Samuel Jebin";
            int orderNum = 101;
            String deliveryAdd = "123 Hello Street Coimbatore";
            DateTime expecteddate = DateTime.Now.AddDays(5);
            Class2 cls = new Class2();
            String temp = cls.emailgen(customerName, orderNum, deliveryAdd, expecteddate);
            Console.WriteLine(temp);
        }
    }
}
