using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_ClassesSealed
{
    abstract class Veiculo
    {
        public abstract string Cor { get; set; }

        public string Marca { get; set; }

        public abstract void Acelerar();

        public virtual void Parar()
        {
            Console.WriteLine("Parou!");
        }
    }
}
