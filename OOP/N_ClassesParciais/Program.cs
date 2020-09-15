using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_ClassesParciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa.maioridade = 21;

            Pessoa p1 = new Pessoa();
            p1.nome = "Gabriel";
            p1.idade = Pessoa.CalcularIdade(1985);

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);

            Console.ReadKey();
        }
    }
}
