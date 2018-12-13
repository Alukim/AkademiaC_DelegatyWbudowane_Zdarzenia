using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaC_DelegatyWbudowane_Zdarzenia
{
    public class Comparision : IIntroducer
    {
        public void Introduce()
        {
            var list = new List<int>
            {
                202,270,310,910,18,43,150
            };

            list.Sort(Compare);

            Methods.ShowList(list);
            Console.ReadKey();
        }

        public int Compare(int t1, int t2)
        {
            return t1.ToString().CompareTo(t2.ToString());
        }
    }
}
