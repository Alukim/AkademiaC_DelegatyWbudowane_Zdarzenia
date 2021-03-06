﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaC_DelegatyWbudowane_Zdarzenia
{
    public class Funcs : IIntroducer
    {
        public delegate void ShowDelegate(string text);

        public delegate bool CalculateLeapYear(int year);

        public void Introduce()
        {
            var f = "";

            while (!(f == "1" || f == "2"))
            {
                Console.Clear();
                Console.WriteLine("Wybierz ukazanie tekstu");
                Console.WriteLine("1. Różowy");
                Console.WriteLine("2. Niebieski");
                f = Console.ReadKey().KeyChar.ToString();
            }
            Console.Clear();

            ShowDelegate showMethod;

            if (f == "1")
                showMethod = Methods.ShowPinkText;
            else
                showMethod = Methods.ShowBlueText;

            CalculateLeapYear calculateLeapYearMethod = (year) => DateTime.IsLeapYear(year);

            var cannotConvert = false;
            var userYear = 0;
            while (!cannotConvert)
            {
                Console.Clear();
                Console.Write("Podaj rok: ");
                f = Console.ReadLine();
                cannotConvert = int.TryParse(f, out userYear);
            }

            Console.Clear();

            CalculateAndWrite(
                showDelegate: showMethod,
                calculateLeapYear: calculateLeapYearMethod,
                year: userYear);
            Console.ReadKey();
        }

        public static void CalculateAndWrite(
            ShowDelegate showDelegate,
            CalculateLeapYear calculateLeapYear,
            int year)
        {
            if (calculateLeapYear(year))
                showDelegate("Is a leap year.");
            else
                showDelegate("Is not a leap year.");
        }
    }
}
