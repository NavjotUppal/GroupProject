using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Add a change.
            int[] array = new int[24];
            int arrayLength = array.Length;

            // Calls the 'Random' class.
            // Establish 'min' 'max' constraints between '10' and '99'.
            int min = 10;
            int max = 99;
            Random element = new Random();

            // Replaces each element in the array with a randomly generated value.
            for (int j = 0; j < arrayLength; j++)
            {
                // Each iteration 'j' has an new number,
                // and each spot in the array is overwritten.
                array[j] = element.Next(min, max);
            }

            Console.Write("Your random numbers are: ");
            foreach (int num in array)
            {
                Console.Write(num.ToString() + " ");
            }

            // Sorts array in accending order.
            for (int i = 0; i < (arrayLength - 1); i++)
            {
                for (int j = 0; j < (arrayLength - 1); j++)
                {
                    if (array[j + 1] < array[j])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            Console.Write("\nYour sorted numbers are: ");
            foreach (int num in array)
            {
                Console.Write(num.ToString() + " ");
            }

            Console.ReadLine();
        }
    }
}
