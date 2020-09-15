using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_MetodosComRetorno
{
    class Metodos
    {
        // Métodos com retorno de valores
        public string MontaNome(string nome, string sobrenome)
        {
            return nome + " " + sobrenome;
        }

        public int CodigoChar(char caractere)
        {
            return caractere; // Não precisou converter, porque a conversão e implícita.
        }
    }
}
