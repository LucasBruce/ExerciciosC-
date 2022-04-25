using Banco.Contas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private List<Conta> listaContas;
        private Dictionary<string, Conta> dicionario;
        private int numeroDeContas;
        private int verificaLoad = 0;
        public Form1(Conta conta)
        {
            InitializeComponent();

        }

        public Form1()
        {

        }

        public void AdicionaConta(Conta conta)
        {
            this.listaContas.Add(conta);
            this.numeroDeContas++;
            comboContas.Items.Add(conta);
            comboContas.DisplayMember = "Numero";
            this.dicionario.Add(conta.Titular.Nome, conta);
        }

        public List<Conta> getAll()
        {
            return this.listaContas;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dicionario = new Dictionary<string, Conta>();
            this.verificaLoad++;
            listaContas = new List<Conta>();
            //this.conta = new Conta();
            //this.conta.Numero = 1;
            //Cliente cliente = new Cliente("lucas");
            //this.conta.Titular = cliente;

            //this.contas = new Conta[10];           

            //Conta c1 = new Conta();
            //c1.Titular = new Cliente("victor");
            //c1.Numero = 1;
            //this.AdicionaConta(c1);

            //Conta c2 = new ContaCorrente();
            //c2.Titular = new Cliente("mauricio");
            //AdicionaConta(c2);

            //Conta c3 = new ContaPoupanca();
            //c3.Titular = new Cliente("osni");
            //AdicionaConta(c3);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioDeCadastro = new FormCadastroConta();
            formularioDeCadastro.ShowDialog();
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            Object conta = comboContas.SelectedItem;
            double valor = Convert.ToDouble(textoValor.Text.ToLower());
            Conta selecionada = (Conta)conta;
            try
            {
                selecionada.saque(valor);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Dinheiro Liberado");
            }
            catch (SaldoInsuficienteException ex)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Não é possível sacar um valor negativo");
            }
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            MessageBox.Show("Dinheiro Liberado");
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            Object conta = comboContas.SelectedItem;
            double valor = Convert.ToDouble(textoValor.Text.ToLower());
            Conta selecionada = (Conta)conta;
            try
            {
                selecionada.Deposita(valor);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Dinheiro Liberado");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Não é possível depositar um valor negativo");
            }

            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            MessageBox.Show("Dinheiro Liberado");
        }

    }
}

