using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {

            Fraction theFirst = new Fraction(10, 15);
            Console.WriteLine("Första bråket är: " + theFirst.toString());

            if(theFirst.isNegative())
                Console.WriteLine("(Bråket är negativt)"); 

            Fraction theSecond = new Fraction(30, 5);
            Console.WriteLine("Andra bråket är: " + theSecond.toString());

            if (theSecond.isNegative())
                Console.WriteLine("(Bråket är negativt)"); 

            Fraction added = theFirst.add(theSecond);
            Console.WriteLine("Adderat är bråket: " + added.toString());

            Fraction multiplied = theFirst.multiply(theSecond);
            Console.WriteLine("Multiplicerat är bråket: " + multiplied.toString());

            if (theFirst.isEqualTo(theSecond))
            {
                Console.WriteLine("Första och andra är lika");
            }
            else
            {
                Console.WriteLine("Första och andra är inte lika");
            }

            Console.ReadLine();

        }
    }

    class Fraction
    {
        private int numerator = 0;
        private int denominator = 0;
        public Fraction(int Numerator, int Denominator)
        {
            numerator = Numerator;
            denominator = Denominator;

            if (denominator == 0)
                denominator = 1;

            if (numerator < 0 && denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }
        }

        public bool isNegative()
        {
            if ((numerator < 0 && denominator >= 0) || (denominator < 0 && numerator >= 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getNumerator()
        {
            return numerator;
        }

        public int getDenominator()
        {
            return denominator;
        }

        public Fraction add(Fraction toAdd)
        {

            int addedNumerator = (toAdd.getNumerator() *denominator) + (numerator * toAdd.getDenominator());
            int addedDenominator = toAdd.getDenominator() * denominator;

            for (int i = addedDenominator; i > 0; i--)
            {
                if(addedDenominator % i == 0 && addedNumerator % i == 0){
                    addedNumerator = addedNumerator / i;
                    addedDenominator = addedDenominator / i;
                }
            }

            Fraction sum = new Fraction(addedNumerator, addedDenominator);
            return sum;

        }

        public Fraction multiply(Fraction toMultiply)
        {

            int multipliedNumerator = toMultiply.getNumerator() * numerator;
            int multipliedDenominator = toMultiply.getDenominator() * denominator;

            for (int i = multipliedDenominator; i > 0; i--)
            {
                if (multipliedDenominator % i == 0 && multipliedNumerator % i == 0)
                {
                    multipliedNumerator = multipliedNumerator / i;
                    multipliedDenominator = multipliedDenominator / i;
                }
            }

            Fraction product = new Fraction(multipliedNumerator, multipliedDenominator);
            return product;

        }

        public bool isEqualTo(Fraction compare)
        {
            if (numerator == compare.getNumerator() && denominator == compare.getDenominator())
            {
                return true;
            }
            else return false;
        }

        public string toString(){
            string theString = numerator + "/" + denominator;
            return theString;
        }

    }
}
