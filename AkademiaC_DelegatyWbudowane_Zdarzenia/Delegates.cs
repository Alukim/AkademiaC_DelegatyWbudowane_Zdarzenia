using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaC_DelegatyWbudowane_Zdarzenia
{
    public class Delegates : IIntroducer
    {
        public delegate void ShowDelegate(string text);

        public delegate bool CalculateLeapDate(int year);

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

            ShowDelegate show;

            if (f == "1")
            {
                show = Methods.ShowPinkText;
            }
            else
            {
                show = Methods.ShowBlueText;
            }

            var cannotConvert = false;
            var userYear = 0;
            while (!cannotConvert)
            {
                Console.Clear();
                Console.Write("Podaj rok: ");
                f = Console.ReadLine();
                cannotConvert = int.TryParse(f, out userYear);
            }

            CalculateLeapDate calculateDate = (year) => DateTime.IsLeapYear(year); 

            Console.Clear();

            // Calculate and write
            CalculateAndWrite(
                show: show,
                calculateLeap: calculateDate,
                year: userYear);

            Console.ReadKey();
        }

        private void CalculateAndWrite(
            ShowDelegate show,
            CalculateLeapDate calculateLeap,
            int year)
        {
            if (calculateLeap(year))
                show("It's a leap year");
            else
                show("It's not a leap yaer");
        }
    }
}
