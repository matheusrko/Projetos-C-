using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoFuncional
{
    class Program
    {

        public static void Tabuada()
        {
            Console.WriteLine("========================Calculo de Tabuada============================" +
                "\nDigite o numero para a tabuada desejada");
            int numero = int.Parse(Console.ReadLine());
            for(int i=0; i <= 10; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + numero*i);
            }
            Console.WriteLine("======================================================================");
            
        }
        public static void MediaAluno()
        {
            Console.WriteLine("========================Média do Aluno============================" +
                "\nDigite o nome do aluno");
            string nome = Console.ReadLine();
            Console.WriteLine("Agora digite quantas notas há no bimestre");
            Double notasInformadas = Double.Parse(Console.ReadLine());
            double resultado = 0;
            double total = 0;
            for (int i = 1; i <= notasInformadas; i++)
            {
                Console.WriteLine("Digite a " + i + " nota");
                double nota = double.Parse(Console.ReadLine());
                total += nota;
                resultado = total / notasInformadas;
            }
            Console.WriteLine("A média do " + nome + " é: " + resultado);
            Console.WriteLine("======================================================================");
        }
        public const int SAIDA_PROGRAMA = 1;
        public const int TABUADA = 2;
        public const int MEDIA_ALUNO = 3;

        static void Main(string[] args)
        {
            while (true)
            {
                string mensagem = "Seja bem vindo ao aplicativo funcional de Tabuada e Média de Alunos" +
                    "\n\n\nPara a opção desejada, digite os numeros de acordo com o que segue" +
                    "  \n\n 1 para Sair" +
                    "  \n 2 para Tabuada" +
                    "  \n 3 para Media do Aluno";
                Console.WriteLine(mensagem);
                int opcao = int.Parse(Console.ReadLine());

                if(opcao == SAIDA_PROGRAMA)
                {
                    break;
                }
                else if(opcao == TABUADA)
                {
                    Tabuada();
                }
                else if( opcao == MEDIA_ALUNO)
                {
                    MediaAluno();
                }
                else
                {
                    Console.WriteLine("Digite uma opção válida\n");
                }
            }
        }
    }
}
