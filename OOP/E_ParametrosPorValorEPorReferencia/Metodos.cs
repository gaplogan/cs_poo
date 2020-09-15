using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_ParametrosPorValorEPorReferencia
{
    class Metodos
    {
        // Pasagem de Parâmetro por Valor
        public void Aumentar(int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final por valor é " + valor);
        }

        // Pasagem de Parâmetro por Referência
        public void AumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final por referência é " + valor);
        }
    }
}
