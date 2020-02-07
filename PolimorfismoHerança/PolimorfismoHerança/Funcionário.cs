using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoHerança
{
     class Funcionário:Pessoa
    {
        float salario;
        float salarionovo;

        public void SalarioCorrecao()
        {
            Console.WriteLine("Digite o seu lario atual");
            salario = float.Parse(Console.ReadLine());
            salarionovo = (salario * 5);
            Console.WriteLine("O seu salario corrigido é:  " + salarionovo);
        }
        public void CalcularIMC()
        {
            Console.WriteLine("Digite a sua altura em metros");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seu peso");
            peso = float.Parse(Console.ReadLine());
            float ResultadoIMC = peso/(altura * altura) ;
            Console.WriteLine("Seu IMC é:  " + ResultadoIMC);
        }
        public override int fourpeso()
            
        {
            float peso1=0;
            Console.WriteLine("O quadruplo do seu peso é:  " + peso1);
            peso1 = (peso * 2);
            return 0;
            
            
        }
    }
}
