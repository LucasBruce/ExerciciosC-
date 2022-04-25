using Banco.Busca;
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
    public partial class FormCadastroConta : Form
    {
        private ICollection<string> devedores;

        private Dictionary<string, Conta> dicionario;

 
        private List<Conta> contas = new List<Conta>();

        public FormCadastroConta()
        {
            InitializeComponent();

            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeraList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titular = textoTitulo.Text;
            bool ehDevedor = false;
            for (int i = 0; i < 30000; i++)
            {
                ehDevedor = this.devedores.Contains(titular);
            }
            if (!ehDevedor)
            {
                Conta novaConta = (Conta) comboTipoConta.SelectedItem;
                novaConta.Titular = new Cliente(textoTitulo.Text);
                string saldo = textoSaldo.Text;
                novaConta.Saldo = Double.Parse(saldo);  
                AdicionaConta(novaConta);
            }
            else
            {
                MessageBox.Show("devedor");
            }
            
        }

        public void AdicionaConta(Conta conta)
        {
            this.contas.Add(conta);
            comboConta.Items.Add(conta.Titular.Nome);
            this.dicionario.Add(conta.Titular.Nome, conta);
        }

        private void comboTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            ContaCorrente contaCorrente = new ContaCorrente();
            ContaPoupanca contaPoupanca = new ContaPoupanca();
            comboTipoConta.Items.Add(contaCorrente);
            comboTipoConta.Items.Add(contaPoupanca);
            textoNumero.Text = Convert.ToString(Conta.ProximoNumero());
            this.dicionario = new Dictionary<string, Conta>();

            Conta poupanca = new ContaPoupanca(2, new Cliente("lucas"));
            Console.Write(Serializer.AsXml(poupanca));
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBusca_Click(object sender, EventArgs e)
        {
            string nome = textBusca.Text.ToString();

            try
            {
                var conta = dicionario[nome];
           
                //var conta = this.contas.Find(delegate (Conta c) { return c.Titular.Nome.Equals(nome);});
                textoNumero.Text = conta.Numero.ToString();
                textoTitulo.Text = conta.Titular.Nome;
                comboConta.SelectedItem = conta.Titular.Nome;    

            }
            catch (Exception ex)
            {
                throw new Exception("Conta não encontrada");
            }
            
        }

        private void textoNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorios formRelatorios = new FormRelatorios(this.contas);
            formRelatorios.ShowDialog();
        }
    }
}
