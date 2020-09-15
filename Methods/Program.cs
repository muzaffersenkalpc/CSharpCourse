using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            Add();
            int number1 = 20;
            int number2 = 100;
            var result = Add2(20, 30);
            var result2 = Add3(ref number1, number2); //ref yollarsa, fonksiyon içinde ki değer olur.

            //burada out kullanılabilir. Tek fark, out değer istemiyorken, ref önceden değer ister.
            Console.WriteLine(result);
            Console.WriteLine("Result Add2 = {0}",result2);
            Console.WriteLine(number1);
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
            ;
        }

        static int Add2(int number1,int number2)
        {
            int result = number1 + number2;
            return result;
        }
        static int Add3(ref int  number1, int number2)
        {
            number1 = 30;
            int result = number1 + number2;
            return result;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2*number3;
        } //Aynı isimde method olabilir, farklı parametre kullanılabilir. buna overloading denir.

        static int Add4(params int[] numbers)
        {
            return numbers.Sum(); //istediğimiz kadar int değer yollayabiliriz.
        }
    }

}
