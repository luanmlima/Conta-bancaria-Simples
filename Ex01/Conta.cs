using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Ex01
{
    class Conta
    {
        private string _titular;
        public int nConta { get; private set; }
        public double vDeposito { get; private set; }

        public Conta(string titular, int conta)
        {
            this._titular = titular;
            this.nConta = conta;
        }

        public Conta(string titular, int conta, double Deposito) : this(titular, conta)
        {
            adicionarValor(Deposito);
        }

        public string Nome
        {
            get { return _titular; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _titular = Nome;
                }

            }
        }

        public void adicionarValor(double deposito)
        {
            vDeposito += deposito;
        }

        public void fazerSaque(double saque)
        {
            vDeposito -= (saque + 5.00);
        }

        public override string ToString()
        {
            return "Dados da conta:\n" +
                "Conta " + nConta +
                ", Titular: " + _titular +
                ", Saldo: $ " + vDeposito.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
