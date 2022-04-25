using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Contas
{
    public class ContaPoupanca : Conta, ITributavel
    {
        //public int Numero { get; set; }
        //public double Saldo { get; private set; }
        //public Cliente Titular { get; set; }

        public double CalculaTributo()
        {
            return this.Saldo - 0.05;
        }

        public ContaPoupanca(int numero, Cliente cliente) : base()
        {
            this.Numero = numero;
            this.Titular = cliente;   
        }

        public ContaPoupanca()
        {

        }

        public override void saque(double valor)
        {
            if(valor < 0.0)
            {
                throw new ArgumentException();
            }
            if (valor + 0.10 > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                this.Saldo -= (valor + 0.10);
            }
        }

        public override void Deposita(double valor)
        {
            if(valor < 0.0)
            {
                throw new ArgumentException();  
            }
            this.Saldo += valor;
        }

        public override string ToString()
        {
            return "ContaPoupanca";
        }
    }
}
