using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_ClassesEObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            MinhaClasse objeto1 = new MinhaClasse();
            OutraClasse objeto2;

            // objeto1 é do tipo MinhaClasse
            // objeto2 é do tipo OutraClasse

            objeto1 = null;
            objeto2 = new OutraClasse();
        }
    }

    class OutraClasse
    {
        // Alteração de Teste GIT
    }
}
