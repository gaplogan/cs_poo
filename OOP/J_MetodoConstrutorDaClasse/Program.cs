﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J_MetodoConstrutorDaClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.sobrenome);
            Console.WriteLine(p1.anoNascimento);
            Console.WriteLine(p1.idade);

            Console.WriteLine();

            p1.nome = "Lucas";
            Console.WriteLine(p1.nome);

            Console.ReadKey();
        }
    }
}
