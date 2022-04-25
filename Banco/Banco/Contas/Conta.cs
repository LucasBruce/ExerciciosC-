using System;

namespace Banco.Contas
{
    public abstract class Conta
    {
        private static int numeroDeContas;
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public Cliente Titular { get; set; }
        public int Tipo { get; set; }

        public Conta()
        {
            Conta.numeroDeContas++;
            this.Numero = Conta.numeroDeContas; 
        }
     

        public static int ProximoNumero()
        {
            return numeroDeContas + 1;
        }

        public abstract void Deposita(double valor);

        public abstract void saque(double valor);


        public override String ToString()
        {
            return "Titular: "+this.Titular;
        }
    }
}