using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_Common_Divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, greatestCommon;

            do
            {
                bool goodInput;
                do
                {
                    Console.Write("Enter first number (-1 To Exit): ");
                    goodInput = int.TryParse(Console.ReadLine(), out num1);
                } while (!goodInput);

                if (num1 == -1) { break; }

                do
                {
                    Console.Write("Enter second number: ");
                    goodInput = int.TryParse(Console.ReadLine(), out num2);
                } while (!goodInput);

                greatestCommon = GCD(num1, num2);

                Console.WriteLine("GCD is: " + greatestCommon + "\n");
            } while (num1 != -1);

            Console.WriteLine("Press any key to close the program.");
            Console.ReadKey();
        }

        static int GCD(int num1, int num2)
        {
            while (num1 != 0 && num2 != 0)
            {
                if (num1 > num2)
                    num1 %= num2;
                else
                    num2 %= num1;
            }

            return num1 == 0 ? num2 : num1;
        }
    }
}
