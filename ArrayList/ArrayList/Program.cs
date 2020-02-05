using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploArrayList
{
    class Program
    {   
        static void Main(string[] args)
        {
            ArrayList SaboresPizza = new ArrayList();
            SaboresPizza.Add("Calabresa");
            SaboresPizza.Add("Canadense");
            Console.WriteLine("Count Temos os sabores: {0}", SaboresPizza.Count);
            Console.WriteLine("Capacadidade Temos os sabores: {0}", SaboresPizza.Capacity);

            ArrayList NovosSabores = new ArrayList();
            NovosSabores.Add("Prestígio");
            NovosSabores.Add("Banana");
            NovosSabores.AddRange(new object[] { "teste", "teste1" });

            SaboresPizza.AddRange(NovosSabores);
            ArrayList range = NovosSabores.GetRange(1, 3);
            foreach (string saboresTotal in range)
            {
                Console.WriteLine("\n" + saboresTotal);
            }

            Console.ReadKey();
        }
    }
}
