using System;
using System.Collections.Generic;
using System.Linq;

namespace Ron
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SkipWhile LINQ
            // SkipWhile on LINQ meetod, mis võtab andmehulgast algses järjekorras elemente ja jätab need välja, kuni konkreetne tingimus on täidetud.
            // Seejärel võtab see kõik järgnevad elemendid, mis vastavad tingimusele.

            var list = new List<int> { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };

            //SkipWhile jaotab andmehulka ja jätab välja kõik elemendid, mis on väiksemad kui 14.
            var result = list.SkipWhile(x => x < 14);

            // Nüüd sisaldab result kõiki elemente alates 14-st.
            foreach (var item in result)
                Console.WriteLine(item);

            // Repeat LINQ
            // Repeat on LINQ meetod, mis luuakse andmehulgast kindlaksmääratud arv kordi.

            //Käesoleval näiteks luuakse andmehulgast 5 korda element 10.
            var result2 = Enumerable.Repeat(10, 5);

            // Nüüd sisaldab result2 viiteid 5 kordu 10-le.
            foreach (var item in result2)
                Console.WriteLine(item);

        }
    }
}
