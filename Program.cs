using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a +ive number: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (IsPrime(number))
            {
                Console.WriteLine(number + " is a prime number");
            }
            else
            {
                Console.WriteLine(number + " is not a prime number");
            }
        }

        private static bool IsPrime(int number)
        {
            if (number < 2)
            
                return false;

            //To accurately determine if a number is prime, you need to check its divisibility by all numbers from 2
            // to the square root of the number.
            //Using the square root condition reduces the number of iterations required
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }


            return true;
        }
    }
}
