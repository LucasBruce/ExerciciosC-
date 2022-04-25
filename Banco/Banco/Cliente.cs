namespace Banco
{
    public class Cliente
    {
        public string Nome { get; set; }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public Cliente()
        {

        }

        public string toString()
        {
            return this.Nome;
        }
    }
}