using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Delegates
{
    class Program
    {
        delegate void Operacao(int num1, int num2);

        static void Main(string[] args)
        {
            Matematica m = new Matematica();

            Operacao conta = null;

            conta += m.Somar;
            conta += m.Subtrair;
            conta += m.Dividir;
            conta += m.Multiplicar;

            conta(10, 2);

            Console.WriteLine();

            conta -= m.Dividir;
            conta -= m.Somar;

            conta(15, 3);

            Console.ReadKey();
        }
    }
}
