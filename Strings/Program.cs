using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Muzaffer Senkal";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is MUZO";

            bool result3 = sentence.EndsWith("ğ"); //end with ğ
            bool result4 = sentence.StartsWith("My"); //startwith My.
            var result5 = sentence.IndexOf("name");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello,");
            var result9 = sentence.Substring(3,4); //3. karakterden itibaren 4 tane al.
            Console.WriteLine(result2);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            string result = city + city2;

            //Console.WriteLine(result);
            Console.WriteLine(String.Format("{0} {1}", city, city2));

            Console.ReadLine();
        }
    }
}
