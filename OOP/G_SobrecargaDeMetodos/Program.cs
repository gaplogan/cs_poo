using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_SobrecargaDeMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();
            m.Cumprimentar();
            m.Cumprimentar("Gabriel");
            m.Cumprimentar("Gabriel", 18);

            Console.WriteLine(m.Comparar(25, 5 * 5));

            Console.ReadKey();
        }
    }
}
