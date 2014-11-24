using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {

            string inData = readString();
            Console.Write("Strängen som matades in var: ");
            Console.WriteLine(inData);
            if (isPalindrom(inData)) 
            {
                Console.WriteLine("Strängen är ett palindrom");
            }
            else { 
                Console.Write("Strängen är inte ett palindrom");
            }

            Console.ReadLine(); //Stoppa consolfönstret från att stängas när programmet är kört
        }

        static string readString()
        {

            Console.WriteLine("Mata in textrad:");
            return Console.ReadLine();

        }

        static bool isPalindrom(string potentialPalindrom)
        {
            potentialPalindrom = potentialPalindrom.ToLower(); //Ser till att strängen är lowercase när den testas

            char[] reverseLetters = new char[potentialPalindrom.Length];
            char[] palindromLetters = potentialPalindrom.ToCharArray();
          
            for (int i = 0; i < palindromLetters.Length; i++) //Loopar igenom bokstäverna och vänder på strängen
            {
                reverseLetters[i] = palindromLetters[palindromLetters.Length - i -1];
            }
            string reverseString = new String(reverseLetters);

            if (reverseString == potentialPalindrom) //Jämför om den omvända strängen är lika med den vanliga (= ett palindrom)
            {
                return true;
            }
            else return false;
        }
    }
}
