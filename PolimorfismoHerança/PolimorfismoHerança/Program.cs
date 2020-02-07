using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoHerança
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                int escolha;

                Console.WriteLine("Bem vindo ao aplicativo de testes do Polimorfismo e Herança" +
                    "\nPara iniciar, informe 1 se for estudante e 2 se for funcionário");
                escolha = int.Parse(Console.ReadLine());

                Estudante student = new Estudante();
                Funcionário worker = new Funcionário();

                if (escolha == 1)
                {
                    student.CalcularIMC();
                    student.Alturadobro();
                    student.fourpeso();

                }
                else if (escolha == 2)
                {
                    worker.CalcularIMC();
                    worker.SalarioCorrecao();
                    worker.Alturadobro();
                }
                Console.WriteLine("Para sair, digite 0 ou 1 para continuar");
                opcao = int.Parse(Console.ReadLine());
            }
            while (opcao == 1);

            
        }
    }
}
