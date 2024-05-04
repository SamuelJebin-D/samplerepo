using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the password");
            int length = Convert.ToInt32(Console.ReadLine());
            const String chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-_";
            StringBuilder sb = new StringBuilder();
            Random r = new Random();
            for(int i = 0; i < length; i++)
            {
                sb.Append(chars[r.Next(chars.Length)]);
            }
            String temp = sb.ToString();
            Console.WriteLine(temp);
        }
    }
}
