using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaC_DelegatyWbudowane_Zdarzenia
{
    public class Converter : IIntroducer
    {
        public void Introduce()
        {
            var list = Methods.GenerateListOfPerson();

            var newList = new List<string>();

            Methods.ShowList(newList);
        }

    }
}
