using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    //task 3
    //Question 8
    // Implement a method to find the nearest available courier for a new order using an array of couriers. 
    public class Courier
    {
        public String Name { get; set; }
        public int currentLocation { get; set; }
        public Courier(String name, int CurrentLocation)
        {
            Name = name;
            currentLocation = CurrentLocation;
        }
    }
         class programmm{
       
            static void Main(string[] args)
            {
                Courier[] cour = new Courier[]
                {
                    new Courier("Courier1",10),
                    new Courier("Courier2",50),
                    new Courier("Courier3",20),
                    new Courier("Courier4",40),
                };
                int targetLocation = 35;
                int mindistance = int.MaxValue;
                String nearcourier = null;
                int i = 0;
                foreach (var co in cour) 
                {
                    int distance = Math.Abs(targetLocation - cour[i].currentLocation);
                    if(distance < mindistance)
                    {
                        mindistance = distance;
                        nearcourier = co.ToString();
                    }
                    i++;
                }
                Console.WriteLine(nearcourier);
                

            }
        }
    
}
