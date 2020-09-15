using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J_MetodoConstrutorDaClasse
{
    class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int anoNascimento;
        public int idade;

        public Pessoa()
        {
            nome = "Desconhecido";
            sobrenome = "Indigente";
            anoNascimento = 0;
            idade = 0;
        }
    }
}
