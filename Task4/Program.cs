using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    //Task 4
    //Question 9
//9. Parcel Tracking: Create a program that allows users to input a parcel tracking number.Store the
//tracking number and Status in 2d String Array. Initialize the array with values.Then, simulate the
//tracking process by displaying messages like "Parcel in transit," "Parcel out for delivery," or "Parcel 
//delivered" based on the tracking number's status.

    internal class Program
    {
         
        static void Main(string[] args)
        {
            string[,] trackArray =
            {
                {"TI001" , "In transit" },
                {"TI002" , "Out for delivery" },
                {"TI003" , "Parcel delivered"}
            };
            Console.WriteLine("Enter the TrackId to get the details");
            String trackId = Console.ReadLine();
            String status = null;
            for (int i = 0; i < trackArray.GetLength(0); i++)
            {
                if (trackArray[i,0] == trackId)
                {
                     status = trackArray[i,1];
                }

            }
            if(status != null)
            {
                Console.WriteLine($"The status of the given trackID is {status}");
            }
            else
            {
                Console.WriteLine("Invalid trackID");
            }
            
        }
    }
}
