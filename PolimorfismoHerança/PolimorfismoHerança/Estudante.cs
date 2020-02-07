using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoHerança
{
      class Estudante:Pessoa
      {
        

        public void CalcularIMC()
        {
            Console.WriteLine("Digite a sua altura em metros");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seu peso");
            peso = float.Parse(Console.ReadLine());
            float ResultadoIMC = peso/(altura * altura);
            Console.WriteLine("Seu IMC é:  "+ResultadoIMC);

            
        }

        //isso é um polimorfismo (originalmente era so o dobro, porem decidi fazer o quadruplo)
        public override void Alturadobro()
        {
            alturadois = altura * 4;
        }
        public override int fourpeso()
        {
            float peso1 = 0;
            Console.WriteLine("O quadruplo do seu peso é:  " + peso1);
            peso1 = (peso * 2);
            return 0;
        }
    }
}
