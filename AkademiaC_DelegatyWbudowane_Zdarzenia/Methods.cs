using System;
using System.Collections.Generic;

namespace AkademiaC_DelegatyWbudowane_Zdarzenia
{
    public class Methods
    {
        public static void ShowPinkText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void ShowBlueText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void ShowList<T>(List<T> list)
            => list?.ForEach(x => Console.WriteLine(x));

        public static List<Person> GenerateListOfPerson()
        {
            return new List<Person>
            {
                new Person(){ Name = "Tomek", Age = 23},
                new Person(){ Name = "Franko", Age = 21},
                new Person(){ Name = "Doman", Age = 18},
                new Person(){ Name = "Alicja", Age = 19},
            };
        }
    }
}
