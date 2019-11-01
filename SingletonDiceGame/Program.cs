using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Length of array : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Minimum value : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Maximum value : ");
            int c = int.Parse(Console.ReadLine());
            createArray(a, b, c);

            foreach (int item in theArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Which value should we check for? ");
            int d = readInput(Console.ReadLine());
            int e = countNumbers(d);
            Console.WriteLine("The array has the value " + d.ToString() + " " + e.ToString() + " times");
            Console.ReadKey();
        }


        static int[] theArray;
        static void createArray(int count, int min, int max)
        {
            Random rng = new Random();
            theArray = new int[count];
            for (int i = 0; i < theArray.Length; i++)
            {
                theArray[i] = rng.Next(min, max-1);
            }
            Array.Sort(theArray);
        }

        static int readInput(string text)
        {
            int x = 0;

            Console.WriteLine(text);

            try
            {
                x = int.Parse(text);
            }
            catch (Exception)
            {

                Console.WriteLine("Sorry - thats not a valid number");
            }

            return x;
        }

        //Do optimized linear search: 
        //Linear search in sorted array for first occurance 
        //For each following occurance increment counter until number is no longer found
        //After that: break
        static int countNumbers(int number)
        {
            int counter = 0;
            int checksDone = 0;

            foreach (int item in theArray)
            {
                checksDone++;

                if (item == number)
                {
                    counter++;
                }

                if (item > number)
                {
                    Console.WriteLine("Checks: " + checksDone.ToString());
                    return counter;
                }
            }
            return counter;
        }
    }
}
