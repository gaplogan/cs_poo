using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_ClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Veiculo v = new Veiculo(); Classe abstrata, não pode instanciar objeto, só pode ser herdada
            Carro c = new Carro();
            Bicicleta b = new Bicicleta();
        }
    }
}
