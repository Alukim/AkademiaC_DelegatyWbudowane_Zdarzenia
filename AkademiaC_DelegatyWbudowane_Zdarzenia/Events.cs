using System;

namespace AkademiaC_DelegatyWbudowane_Zdarzenia
{
    public class Events : IIntroducer
    {
        private Reactor reactor;

        public void Introduce()
        {
            reactor = new Reactor();

            reactor.ReactorStarted += ReactorStartedEventHandler;
            reactor.ReactorOverHeated += ReactorOverHeatedEventHandler;
            reactor.Start();

            var rnd = new Random();

            for (int i = 0; i < int.MaxValue; i++)
            {
                var randomNumber = rnd.Next(0, 100);
                Console.WriteLine(randomNumber);
                if (randomNumber > 60 && randomNumber < 65)
                {
                    reactor.Overheat();
                    break;
                }
            }

            Console.ReadKey();
        }

        public void ReactorStartedEventHandler()
        {
            Console.WriteLine("INFO: Reaktor uruchomiony.");
        }

        public void ReactorOverHeatedEventHandler(int temperature)
        {
            Console.WriteLine("Reaktor się przegrzewa.");
            Console.WriteLine($"INFO: Temperatura reaktora: {temperature}");

            reactor.Cool();
        }
    }
}
