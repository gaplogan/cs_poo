using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_MetodosComRetorno
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();

            string nomeCompleto = m.MontaNome("Gabriel", "Artigas");
            double codigo = m.CodigoChar('A');

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(codigo);

            Console.ReadKey();
        }
    }
}
