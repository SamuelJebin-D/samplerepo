using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        //task 3
        //Question 7
        // Create an array to store the tracking history of a parcel, where each entry represents a location update.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of records to be entered");
            int n = Convert.ToInt32(Console.ReadLine());
            String[] s = new String[n];
            for (int i=0; i<s.Length; i++)
            {
                s[i] = Console.ReadLine();  
            }
            Console.WriteLine($"There are {s.Length} present");
            Console.WriteLine("The tracking history is ");
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(s[i]);
                }
            }
        }
    }
}
