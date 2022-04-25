using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Contas
{
    public class ContaCorrente : Conta, ITributavel
    {

        public ContaCorrente() : base() 
        {
        }

       

        public double CalculaTributo()
        {
            return this.Saldo - 0.05;
        }

        public override void Deposita(double valor)
        {
            this.Saldo += (valor - 0.10);
        }

        public override void saque(double valor)
        {
            if (valor < 0.0)
            {
                throw new ArgumentException();
            }
            if(valor > this.Saldo)
            {
                throw new SaldoInsuficienteException(); 
            }
            else
            {
                this.Saldo -= (valor + 0.05);
            }
        }

        public override string ToString()
        {
            return "ContaCorrente";
        }
    }
}
