using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Médias_de_alunos_dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, mediageral;
            string nome;
            int medias=0;

            do
            {



                Console.WriteLine("Olá professor(a), tudo bem? Bem vindo ao aplicativo de médias");
                Console.WriteLine("Digite o nome do aluno");
                nome = Console.ReadLine();
                Console.WriteLine("Digite a primeira nota do    " + nome);
                nota1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a segunda nota do    " + nome);
                nota2= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a terceira nota do    " + nome);
                nota3= Convert.ToInt32(Console.ReadLine());

                
                mediageral =(nota1 + nota2 + nota3) / 3;
                Console.WriteLine("A média geral do é:" + mediageral);
                Console.WriteLine("Pressione 1 para calcular novas médias ou 2 para sair");
                medias = Convert.ToInt32(Console.ReadLine());

                

            }
            while (medias == 1);
            Console.ReadKey();
        }
    }
}
