using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W_Interfaces
{
    class CaixaEletronico : IConta
    {
        public string Usuario { get; set; }

        public void Depositar() { }

        public void Sacar() { }

        public void Saldo() { }

        public void PagarConta() { }
    }

    interface IConta
    {
        string Usuario { get; set; }
        void Depositar();
        void Sacar();
        void Saldo();
    }
}
