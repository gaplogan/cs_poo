using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_ClassesAbstratas
{
    class Carro : Veiculo
    {
        public override string Cor { get; set; } // Abstrato, é obrigatório implementar

        public int VelocidadeMaxima { get; set; }

        public void LigarMotor()
        {
            Console.WriteLine("Ligou o motor do carro!");
        }

        public override void Acelerar() // Abstrato, é obrigatório implementar
        {
            Console.WriteLine("Acelerou o carro!");
        }

        public override void Parar() // Virtual, não é obrigatório implementar
        {
            Console.WriteLine("O Carro parou!");
        }
    }
}
