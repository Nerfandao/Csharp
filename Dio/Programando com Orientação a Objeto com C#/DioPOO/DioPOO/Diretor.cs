using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DioPOO
{
    public class Diretor : Professor
    {
        public virtual void Apresentar()
        {
            Console.WriteLine($"Diretor");
        }
    }
}
