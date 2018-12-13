using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaC_DelegatyWbudowane_Zdarzenia
{
    public class Reactor
    {
        public event Action ReactorStarted;
        public event Action<int> ReactorOverHeated;

        private int Temperature;

        public Reactor()
        {
            this.Temperature = 1000;
        }

        public void Start()
        {
            Console.WriteLine("Uruchamiam reaktor atomowy Czarnobyl");
            Console.WriteLine("Włączam zabezpieczenia.");



            if (ReactorStarted != null)
                ReactorStarted();
        }

        public void Overheat()
        {
            Console.WriteLine("Reaktor się przegrzewa.");


            ReactorOverHeated?.Invoke(Temperature);
        }

        public void Cool()
        {
            Console.WriteLine("Dorzucam lodu.");
            Temperature = 80;

        }
    }
}
