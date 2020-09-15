using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_SobrecargaDeConstrutor
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

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            anoNascimento = 0;
            idade = 0;
        }

        public Pessoa(string nome, string sobrenome, int anoNascimento)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.anoNascimento = anoNascimento;
            idade = Idade();
        }

        public int Idade()
        {
            return 2020 - anoNascimento;
        }
    }
}
