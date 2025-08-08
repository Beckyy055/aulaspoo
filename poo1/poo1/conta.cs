using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo1
{
    public class Conta
    {
        private double saldo;
        public double Deposito(double valor)
        {
            if (valor > 0)
            {
                saldo = valor + saldo;
            }
            return saldo;
        }
++
        public double Saque(double valor)
        {
            if (valor > 0 && saldo >= valor)
            {
                saldo = saldo - valor;
            }
            return saldo;
        }

    }
}
