using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DioPOO
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, sou um professor e ganho {Salario}");
        }
    }
}
