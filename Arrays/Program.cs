﻿using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3]{"Muzo", "İrem", "Birem"};
            string[] students2 = {"Muzo", "İrem", "Birem"};
            //students2[3] = "XX";
            foreach (var student in students)
            {
                Console.WriteLine(student);   
            }


            string[,] regions = new string[5, 3]
            {
                {"İstanbul", "İzmit", "Balıkesir"},
                {"Ankara", "Yozgat", "Kırıkkale"},
                {"Antalya", "Adana", "Mersin"},
                {"Rize", "Trabzon", "Samsun"},
                {"İzmir", "Muğla", "Manisa"}
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("**************");
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
