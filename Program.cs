// Henrique Correa
// ISM4300.901S20

using System;

namespace ClassProject3_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Manage errors
            try
            {
                // Display primary to the user. 
                Console.WriteLine("Let us populate an array with 25 integers. Please, press any key.");
                Console.WriteLine();
                Console.ReadKey(true);
                Console.WriteLine("But first, we need to iterate through the each of the 25 elements in the array. Press any key one more time.");
                Console.WriteLine("_________________________________________");
                Console.ReadKey(true);

                // Declare and initialize the array 
                int[] x = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 22, 23, 24, 25};              

                // Loop iterates through the array.
                foreach (int ia in x)
                {
                    // Display the array value.
                    Console.WriteLine("Element value = " + ia);                  
                }
                Console.WriteLine("_________________________________________");
                // Display message after each element values has been shown 
                Console.WriteLine();
                Console.ReadKey(true);
                Console.WriteLine("Congratulations! You have just seen how C# arrays work!");

                // Display message to tell the user how to exit the program.
                Console.WriteLine();
                Console.WriteLine("Press any key to exit the console.");
                Console.ReadKey(true);

                // Pause the program and wait.
                Console.ReadKey(true);
            }
            catch
            {
                // Pause the program and wait.
                Console.ReadKey(true);
            }
        }
    }
}
