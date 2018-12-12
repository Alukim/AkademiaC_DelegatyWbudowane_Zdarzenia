using System;
using System.Runtime.CompilerServices;

namespace AkademiaC_DelegatyWbudowane_Zdarzenia
{
    class Program
    {
        static void Main(string[] args)
        {
            IIntroducer introducer;

            var f = "";

            while (!(f == "1" || f == "2" || f == "3" || f == "4" || f == "5" || f == "6"))
            {
                Console.Clear();
                Console.WriteLine("Wybierz pokaz");
                Console.WriteLine("1. Delegaty");
                Console.WriteLine("2. Func");
                Console.WriteLine("3. Action");
                Console.WriteLine("4. Predicate");
                Console.WriteLine("5. Converter");
                Console.WriteLine("6. Comparision");
                Console.WriteLine("7. Zdarzenia");
                f = Console.ReadKey().KeyChar.ToString();
            }
            Console.Clear();

            switch (f)
            {
                case "1":
                    introducer = new Delegates();
                    break;
                case "2":
                    introducer = new Funcs();
                    break;
                case "3":
                    introducer = new Actions();
                    break;
                case "4":
                    introducer = new Predicates();
                    break;
                case "5":
                    introducer = new Converter();
                    break;
                case "6":
                    introducer = new Delegates();
                    break;
                case "7":
                    introducer = new Delegates();
                    break;
                default:
                    introducer = new Delegates();
                    break;
            }

            introducer.Introduce();

            Action Make = () => { Console.WriteLine(123); };
            Action<int> Make2 = (x) => { Console.WriteLine(x); };
        }
    }
}
