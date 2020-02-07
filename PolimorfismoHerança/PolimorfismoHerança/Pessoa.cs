using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoHerança
{
    public abstract class Pessoa
    {
        public int idade = 0;
        public string nome;
        public float peso;
        public float altura;
        public float alturadois;

        public virtual void Alturadobro()
        {
            alturadois = altura * altura;
        }
        public abstract int fourpeso();
    }
}
