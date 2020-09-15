using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_MetodosComParametros
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();
            m.Apresentar("Gabriel", 35);
            m.Somar(100, 50);

            Console.ReadKey();
        }
    }
}
