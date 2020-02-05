using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolhaElementodaLista
{
    class Program
    {
       
        public static void EscolheItem()
        {
            ArrayList nomes = new ArrayList();
            Console.WriteLine("Digite quantos itens você deseja na lista:");
            int itens = int.Parse(Console.ReadLine());
            for (int i = 1; i <= itens; i++)
            {
                Console.WriteLine("Digite o " + i + "º nome");
                nomes.Add(Console.ReadLine());

            }
            Console.WriteLine("Os nomes digitados foram: \n");
            foreach (object lista in nomes)
            {
                Console.WriteLine(lista);
            }
            int index;
            index = new Random().Next(nomes.Count);
            Console.WriteLine("O escolhido foi: \n");
            Console.WriteLine(nomes[index]);
            nomes.RemoveAt(index);
            Console.WriteLine(nomes[index]);
            nomes.RemoveAt(index);
            


            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            EscolheItem();
        }
    }
}
