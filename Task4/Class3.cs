using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    //task 4
    //Question 13
    internal class Class3
    {
        public double calculate(double x, double y)
        {
            double costperkm = 2.5;
            double costperkg = 3.6;
            double temp  = x*costperkg + y*costperkm;
            return temp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance");
            double distance  = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the weight of the package");
            double weight = Convert.ToDouble(Console.ReadLine());
            Class3 cls3 = new Class3();
            double total = cls3.calculate(distance, weight);
            Console.WriteLine($"The total cost for the package to be delivered is {total} ");
        }
    }
}
