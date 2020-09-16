using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForEach();

            //int number = 11;
            //IsPrime(number);
            if (IsPrimeNumber(5))
            {
                Console.WriteLine("This is a PrimeNumber");
            }
            else
            {
                {
                    Console.WriteLine("This is NOTPrimeNumber");
                }
            }


        }
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }

            }

            return result;
        }
        private static void IsPrime(int number)
        {
            int i = 2;
            int sayac = 0;
            for (; i < number; i++)
            {
                if (number % i == 0)
                {
                    sayac++;
                    Console.WriteLine("Not Prime.");
                    break;
                }
                else if (sayac == 0)
                {
                    Console.WriteLine("Prime.");
                    break;
                }
            }
        }

        private static void ForEach()
        {
            string[] students = new string[3] { "Muzo", "Muzo2", "Muzo3" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.ReadLine();
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number != 1);

            Console.ReadLine();
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number != 0)
            {
                Console.WriteLine(number);
                number--;
            }

            Console.ReadLine();
        }

        private static void ForLoop()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }


    }


}
