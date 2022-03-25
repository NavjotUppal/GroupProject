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
            
            
            int item;
           // n = array.Length;
            bool flag = false;
            Console.WriteLine("\nEnter item to be searched: ");
            Int32.TryParse(Console.ReadLine(), out item); // Taking input from user
            int lowerBound = 0;
            int upperBound = arrayLength- 1;
            while (!flag) // loop will execute when flag is false
            {
                if (upperBound < lowerBound)
                {
                    Console.WriteLine("Exit if");
                    flag = true;
                }
                int midPoint = (upperBound + lowerBound) / 2; // calculating mid point for the comparison
                //if the number at mid pointg in array is less than x, the search will occur on left part
                if (array[midPoint] < item)
                {
                    lowerBound = midPoint + 1;

                }
                // if the number at mid point in array is greater than x, the search will occur on right side                
                else if (array[midPoint] > item)
                {
                    upperBound = midPoint - 1;
                }
                else if (array[midPoint] == item)
                {
                    Console.WriteLine("hello, the element is at " + (midPoint + 1) + " position");
                    flag = true;
                }
            }
            Console.ReadLine();

        }

    }
}
