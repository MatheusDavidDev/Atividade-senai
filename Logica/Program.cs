using System;

namespace Logica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui vai o codigo

            //Console.WriteLine("Digite o seu nome:");
            //string nomeCompleto = Console.ReadLine();

           //Console.WriteLine("Bem vindo "+nomeCompleto);
        int valorUm;
        int valorDois;

                //entrada de dados
        Console.WriteLine("Soma de dois numeros");
        Console.WriteLine("--------------------");
        Console.Write("Digite o primeiro: ");
        valorUm = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        valorDois = int.Parse(Console.ReadLine());

                //processamento
        int soma = valorUm + valorDois;

                //exibir
        Console.WriteLine("A soma de "+valorUm+" + "+valorDois+" = "+soma);

        }
    }
}
