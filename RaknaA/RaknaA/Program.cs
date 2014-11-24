using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaknaA
{
    class Program
    {
        static void Main(string[] args)
        {

            string inData = readString();
            Console.Write("Strängen som matades in var: ");
            Console.WriteLine(inData);
            countA(inData);


            Console.ReadLine(); //Stoppa consolfönstret från att stängas när programmet är kört
        }

        static string readString()
        {

            Console.WriteLine("Mata in textrad:");
            return Console.ReadLine();

        }

        static void countA(string stringWithA)
        {
            int countUpperCaseA = stringWithA.Split('A').Length - 1;
            int countLowerCaseA = stringWithA.Split('a').Length - 1;
            int countOther = stringWithA.Length - countUpperCaseA - countUpperCaseA;


            if (countOther == 0)
            {
                Console.WriteLine("Alla barn fick högsta betyget A. Antal a: " + countLowerCaseA + " Antal A: " + countUpperCaseA);
            }
            else Console.WriteLine("Inte alla barn fick högsta betyget. Antal a: " + countLowerCaseA + " Antal A: " + countUpperCaseA);

        }

    }
}
