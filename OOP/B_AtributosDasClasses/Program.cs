using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_AtributosDasClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.nome = "Gabriel";
            p1.sobrenome = "Artigas";
            p1.anoNascimento = 1985;

            Pessoa p2 = new Pessoa()
            {
                nome = "Arthur",
                sobrenome = "Maciel",
                anoNascimento = 2011
            };

            Console.WriteLine("Pessoa 1: " + p1.nome);
            Console.WriteLine("Pessoa 1: " + p1.sobrenome);
            Console.WriteLine("Pessoa 1: " + p1.anoNascimento);
            Console.WriteLine();
            Console.WriteLine("Pessoa 2: " + p2.nome);
            Console.WriteLine("Pessoa 2: " + p2.sobrenome);
            Console.WriteLine("Pessoa 2: " + p2.anoNascimento);

            Console.ReadKey();
        }
    }
}
