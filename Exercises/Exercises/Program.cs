using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int result1 =  Exercises.Week4.Exercise6(1, 2, 4);
             int result2= Exercises.Week4.Exercise6(84,54,1008);


             Console.WriteLine(result1);
             Console.WriteLine(result2);

             Exercises.Week4.Exercise7();
             Exercises.Week4.Exercise8();
         */
            /*Exercises.Week4.Exercise9();
            Exercises.Week4.Exercise10();*/
            //Exercises.Week4.Exercise11();
            //Exercises.Week4.Exercise13();
            //Exercises.Week4.Exercise14(-5, 5);
            //Exercises.Week4.Exercise39();

            //Exercises.Week6.Exercise1();


            //Exercises.Week6.Exercise9(new int[] { 3, -2, 1, 1, 8 });
            // Exercises.Week7A.Exercise1
            // ();
            Exercises.Week8.Print(Exercises.Week8.Populate(10, 100));

            // Create an array of strings of length 4
            string[] names = new string[4];

            // Populate the array with names
            names[0] = "Alice";
            names[1] = "Bob";
            names[2] = "Charlie";
            names[3] = "David";

            // Call PrintArray method to print the array
            Exercises.Week8.PrintArray(names);

            // Swap elements at index 1 and 2
            Exercises.Week8.Swap(names, 1, 2);

            // Call PrintArray method to print the array again
            Exercises.Week8.PrintArray(names);

        }
    }
}
