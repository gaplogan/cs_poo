using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();

            c.cliente = "João";
            //c.saldo = 100;

            //===== Operação de Deposito ==================

            c.Depositar(500);

            //===== Operação de Saque =====================

            //c.saldo -= 10; // Taxa saque (Encapsular)
            c.Sacar(200);

            //===== Resultado Saldo Atual =================

            Console.WriteLine("Cliente: " + c.cliente);
            Console.WriteLine("Saldo: " + c.getSaldo());

            Console.ReadKey();
        }
    }
}
