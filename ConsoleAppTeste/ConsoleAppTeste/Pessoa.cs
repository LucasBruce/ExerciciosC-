using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTeste
{
    public class Pessoa
    {
        private string nome { get; set; }
        private double peso { get; set; }
        private double altura { get; set; }

        public Pessoa(string nome, double peso, double altura)
        {
            this.nome = nome;   
            this.peso = peso;   
            this.altura = altura;   
        }

        public Pessoa()
        {

        }

        public override string ToString()
        {
            return "/n Nome: "+this.nome
                   +"/n Peso: "+this.peso
                   +"/n Altura: "+this.altura;   
        }
    }
}
