using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_Encapsulamento
{
    class Conta
    {
        public string cliente;
        private double saldo;

        public void Sacar(double valor)
        {
            saldo -= 10; // Taxa saque (Encapsulado)
            saldo -= valor;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public double getSaldo()
        {
            return saldo;
        }
    }
}
