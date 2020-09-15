using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_ClassesAbstratas
{
    class Bicicleta : Veiculo
    {
        public override string Cor { get; set; } // Abstrato, é obrigatório implementar

        public void Pedalar()
        {
            Console.WriteLine("Pedalando!");
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
