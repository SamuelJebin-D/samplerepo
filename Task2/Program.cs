using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int startLocation = 0;
            int endLocation = 250;
            while (startLocation < endLocation)
            {
                startLocation += 10;
                Console.WriteLine($"Couriers current location : {startLocation}");

            }
            Console.WriteLine("The courier has reached its location");
        }
    }
}
