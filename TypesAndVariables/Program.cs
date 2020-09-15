using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            bool condition = false;
            byte number4 = 255; //0-255
            short number3 = 15;
            int number1 = 24242;
            long number2 = 353252;
            double number5 = 10.5;
            char character = 'A';

            var number7 = 10;
            number7 = 'A';
            number7 = "A"; //there is error, int variable cant take char value.

            Console.WriteLine("Number is {0} ",number1);
            Console.WriteLine("Number2 is {0} ", number2);
            Console.WriteLine("Number3 is {0} ", number3);
            Console.WriteLine("Character is {0} ", character);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
