using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_MetodosComParametros
{
    class Metodos
    {
        // Métodos com parâmetros
        public void Somar(int num1, int num2)
        {
            int resulatdo = num1 + num2;
            Console.WriteLine("A soma dos valors é " + resulatdo);
        }

        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine("Meu nome é " + nome + " e tenho " + idade + " anos.");
        }        
    }
}
