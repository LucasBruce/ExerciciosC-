using System;
using System.IO;

namespace ConsoleAppTeste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Digite uma frase:");
            //TextReader leitor = Console.In;
            //string linha = leitor.ReadLine();

            //while (linha != null)
            //{                 
            //    Console.WriteLine(linha = leitor.ReadLine());

            //}
            Pessoa pessoa = new Pessoa("lucas", 65.0, 1.68);
            Console.WriteLine(Serializer.AsXml(pessoa));
        }
    }
}
