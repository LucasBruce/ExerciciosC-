using Banco.Contas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Formulario : Form
    {
        private Conta[] contas;
        private Conta contaLucas;
        private TotalizadorDeContas totalizador;
        public Formulario()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Formulario_Load(object sender, EventArgs e)
        {

            Cliente lucas = new Cliente("Lucas");

            this.contaLucas = new ContaPoupanca()
            {
                Titular = lucas,
                Numero = 1
            };

            contas = new Conta[3];

            this.contas[0] = new ContaCorrente();
            this.contas[0].Titular = new Cliente("victor");
            this.contas[0].Numero = 1;

            this.contas[1] = new ContaPoupanca();
            this.contas[1].Titular = new Cliente("mauricio");
            this.contas[1].Numero = 2;

            this.contas[2] = new ContaCorrente();
            this.contas[2].Titular = new Cliente("osni");
            this.contas[2].Numero = 3;

            foreach (Conta conta in contas)
            {
                comboContas.Items.Add(conta.Titular.Nome);
            }
            foreach (Conta conta in contas)
            {
                comboTransferencia.Items.Add(conta.Titular.Nome);
            }

        }

        private void btn_exibir(object sender, EventArgs e)
        { 
            textoTitular.Text = contaLucas.Titular.toString();
            textoNumero.Text = contaLucas.Numero.ToString();
            textoSaldo.Text = contaLucas.Saldo.ToString();
            totalizador = new TotalizadorDeContas();
            totalizador.Soma(contaLucas);
            textTotal.Text = totalizador.SaldoTotal.ToString();
        }

        private void btn_depositar(object sender, EventArgs e)
        {
            //int indice = Convert.ToInt32(textoIndice.Text);
            //Conta selecionada = this.contas[indice];
            //double valor1 = Convert.ToDouble(textoValor.Text);
            //selecionada.Deposita(valor1);
            //textoSaldo.Text = Convert.ToString(selecionada.Saldo);

            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            double valor1 = Convert.ToDouble(textoValor.Text);
            selecionada.Deposita(valor1);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);

            string deposito = textoValor.Text;
            double valor = Convert.ToDouble(deposito);
            contaLucas.Deposita(valor);
            MessageBox.Show("Saldo: "+contaLucas.Saldo);
        }

        private void btn_saque(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(textoIndice.Text);
            Conta selecionada = contas[indice];
            string saque = textoValor.Text;
            double valor = Convert.ToDouble(saque);
            selecionada.saque(valor);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);

            contaLucas.saque(valor);
            MessageBox.Show("Saldo: " + contaLucas.Saldo);
        }

        private void textoValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoTitular_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conta[] contas = new Conta[2];
            contas[0] = new ContaPoupanca();
            contas[1] = new ContaCorrente();    

            for(int i = 0; i < contas.Length; i++)
            {
                MessageBox.Show("Saldo = "+contas[i]);
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(textoIndice.Text);
            Conta selecionada = this.contas[indice];
            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void textoSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex; 
            Conta selecionada = contas[indice];
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoNumero.Text = Convert.ToString(selecionada.Numero);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int indice = comboTransferencia.SelectedIndex;
            int indice1 = comboContas.SelectedIndex;
            Conta selecionada = contas[indice]; 
            Conta selecionada1 = contas[indice1];
            selecionada1.Deposita(selecionada.Saldo);
        }

        private void textoIndice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
