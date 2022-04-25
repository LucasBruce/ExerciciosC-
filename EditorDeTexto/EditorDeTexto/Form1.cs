using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorDeTexto
{
    public partial class Form1 : Form
    {
             private static readonly string pastaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
             private readonly string caminhoArquivo = Path.Combine(pastaDocumentos, "texto.txt");
             private string busca;
             private int resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(caminhoArquivo))
            {
                    
                using (Stream entrada = File.Open(caminhoArquivo, FileMode.Open))
                using (TextReader leitor = new StreamReader(entrada))
                {
                    string linha = leitor.ReadToEnd();
                    textoConteudo.Text = linha;
                }
            }
        }

        private void botaoGravar_Click(object sender, EventArgs e)
        {
            Stream saida = File.Open(caminhoArquivo, FileMode.Create);
            StreamWriter escritor = new StreamWriter(saida);
            escritor.Write(textoConteudo.Text);
            escritor.Close();
            saida.Close();
        }

        private void botaoFind_Click(object sender, EventArgs e)
        {
            busca = textoFind.Text;
            string textoDoEditor = textoConteudo.Text;
            resultado = textoDoEditor.IndexOf(busca);
            if (resultado >= 0)
            {
                MessageBox.Show("achei o texto " + busca);
            }
            else
            {
                MessageBox.Show("não achei");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int inicioSelecao = textoConteudo.SelectionStart;
            int tamanhoSelecao = textoConteudo.SelectionLength;

            // agora vamos utilizar o Substring para pegar o texto selecionado
            string textoSelecionado = textoConteudo.Text
                             .Substring(inicioSelecao, tamanhoSelecao);

            // além do texto selecionado, precisamos do texto antes da seleção:
            string antes = textoConteudo.Text
                                .Substring(0, inicioSelecao);

            // e também do texto depois
            string depois = textoConteudo.Text
                                .Substring(inicioSelecao + tamanhoSelecao);

            // E agora só precisamos redefinir campo texto
            textoConteudo.Text = antes + textoSelecionado.ToUpper() + depois;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int inicioSelecao = textoConteudo.SelectionStart;
            int tamanhoSelecao = textoConteudo.SelectionLength;

            // agora vamos utilizar o Substring para pegar o texto selecionado
            string textoSelecionado = textoConteudo.Text
                             .Substring(inicioSelecao, tamanhoSelecao);

            // além do texto selecionado, precisamos do texto antes da seleção:
            string antes = textoConteudo.Text
                                .Substring(0, inicioSelecao);

            // e também do texto depois
            string depois = textoConteudo.Text
                                .Substring(inicioSelecao + tamanhoSelecao);

            // E agora só precisamos redefinir campo texto
            textoConteudo.Text = antes + textoSelecionado.ToLower() + depois;
        }

        private void botaoReplace_Click(object sender, EventArgs e)
        {
            string palavraSub = textoReplace.Text;
            string palavra = textoConteudo.Text;
            string novaPalavra = palavra.Replace(busca, palavraSub);
            textoConteudo.Text = novaPalavra;
        }
    }
}
