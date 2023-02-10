/* Author: Maria del Carmen Perez-Soto de Paiva
 * Date: 02/09/2023
 * Description: Create a C# Console application that uses two methods following specific criteria
 */
using System;

namespace Deliverable_5
{
    class Program
    {
        // Creating a method to generate random numbers in the array
        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for ( int i = 0; i < array_len; i++ )
            {
                MyArray[i] = random.Next(10,50);
            }
            return MyArray;
        }

        // Creating a method to sum all values in the array
        static int sum(int[] array)
        {
            int sum = 0; 
            foreach ( int item in array ) 
            {
                sum = sum + item;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            // Creating a try-catch block to only allow integer numbers
            try
            {
                Console.WriteLine("Please enter an integer between 5 and 15!");
                int input = int.Parse(Console.ReadLine());

                // Creating a conditional statement to only allow inputs between 5 and 15
                if(input>=5 && input<=15)
                {
                    int[] sampleArray = random_array(input);

                    // Displaying array elements 
                    Console.WriteLine("The elements of the random array are: ");
                    foreach (int element in sampleArray)
                    {
                        Console.Write(element + " ");
                    }

                    // Display sum of elements
                    Console.WriteLine(" ");
                    Console.WriteLine("The sum is: " + sum(sampleArray));
                }
                else
                {
                    Console.WriteLine("Please enter a numeric integer value between 5 and 15.");
                }
            }
            catch
            {
                Console.WriteLine("Please enter a numeric integer value between 5 and 15.");
            }
        }
    }
}