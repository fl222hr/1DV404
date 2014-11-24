using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaknaSiffror
{
    class Program
    {
        static void Main(string[] args)
        {

            string inData = readInteger().ToString();
            Console.Write("Heltalet som matades in var: ");
            Console.WriteLine(inData);
            countNumbers(inData);


            Console.ReadLine(); //Stoppa consolfönstret från att stängas när programmet är kört
        }

        static int readInteger()
        {

            Console.WriteLine("Mata in Heltal:");
            return  int.Parse(Console.ReadLine());

        }

        static void countNumbers(string stringIntegers)
        {
            int countEven = stringIntegers.Split('2').Length - 1;
            countEven = countEven + stringIntegers.Split('4').Length - 1;
            countEven = countEven + stringIntegers.Split('6').Length - 1;
            countEven = countEven + stringIntegers.Split('8').Length - 1;

            int countOdd = stringIntegers.Split('1').Length - 1;
            countOdd = countOdd + stringIntegers.Split('3').Length - 1;
            countOdd = countOdd + stringIntegers.Split('5').Length - 1;
            countOdd = countOdd + stringIntegers.Split('7').Length - 1;
            countOdd = countOdd + stringIntegers.Split('9').Length - 1;

            int countZero = stringIntegers.Split('0').Length - 1;

            Console.WriteLine("Nollor: " + countZero + " Udda: " + countOdd + " Jämna: " + countEven);

        }
    }
}
