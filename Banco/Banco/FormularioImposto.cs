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
    public partial class FormularioImposto : Form
    {
        public FormularioImposto()
        {
            InitializeComponent();
        }

        private void botaoImpostos_Click(object sender, EventArgs e)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Deposita(200.0);

            MessageBox.Show("imposto da conta corrente = "+conta.CalculaTributo());
            ITributavel t = conta;

            MessageBox.Show("imposto da conta pela interface = "+t.CalculaTributo());
            
            SeguroDeVida sv = new SeguroDeVida();
            MessageBox.Show("imposto do seguro = "+sv.CalculaTributo());

            t = sv;
            MessageBox.Show("imposto do seguro pela interface = "+t.CalculaTributo());

        }

        private void FormularioImposto_Load(object sender, EventArgs e)
        {

        }

        private void botaoImposto_Click(object sender, EventArgs e)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Deposita(200.0);

            SeguroDeVida sv = new SeguroDeVida();

            TotalizadorDeTributos totalizador = new TotalizadorDeTributos();
            totalizador.Acumula(conta);

            MessageBox.Show("Total: "+ totalizador.Total);

            totalizador.Acumula(sv);
            MessageBox.Show("Total: "+ totalizador.Total);

        }
    }
}
