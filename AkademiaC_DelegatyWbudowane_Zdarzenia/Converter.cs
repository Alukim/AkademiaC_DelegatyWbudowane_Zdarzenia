using System;

namespace AkademiaC_DelegatyWbudowane_Zdarzenia
{
    public class Converter : IIntroducer
    {
        public void Introduce()
        {
            var list = Methods.GenerateListOfPerson();

            Converter<Person, string> converter = Convert;

            var newList = list.ConvertAll(converter);

            Methods.ShowList(newList);

            Console.ReadKey();
        }

        public string Convert(Person person)
        {
            return $"{person.Name} : {person.Age}";
        }

    }
}
