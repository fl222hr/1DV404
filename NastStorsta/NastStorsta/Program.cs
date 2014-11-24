using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NastStorsta
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInts = 10;
            
            Console.WriteLine("=======================================");
            Console.WriteLine(readIntegers(numberOfInts));


            Console.ReadLine(); //Stoppa consolfönstret från att stängas när programmet är kört
        }

        static int readIntegers(int numberOfInts)
        {

            int inputInt = 0;
            int largest = 0;
            int nextLargest = 0;



            for (int i = 0; i < numberOfInts; i++)
            {
                Console.Write("Mata in Heltal:");
                inputInt = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    largest = inputInt;
                    nextLargest = inputInt;
                }

                if (inputInt > largest)
                {
                    nextLargest = largest;
                    largest = inputInt;
                }



   
                
            }

            Console.WriteLine("=======================================");
            Console.Write("Näst största talet var: ");
            return nextLargest;

        }

    }
}
