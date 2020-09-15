using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_ClassesSealed
{
    sealed class Bicicleta : Veiculo // Calsses Seladas / Lacradas não podem ser herdadas
    {
        public override string Cor { get; set; } // Abstrato, é obrigatório implementar

        public void Pedalar()
        {
            Console.WriteLine("Ligou o motor do carro!");
        }

        public override void Acelerar() // Abstrato, é obrigatório implementar
        {
            Console.WriteLine("Acelerou a bicicleta!");
        }

        public override void Parar() // Virtual, não é obrigatório implementar
        {
            base.Parar();

            Console.WriteLine("Pode descer da bike.");
        }
    }
}
