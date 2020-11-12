using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui vai o codigo do nosso progama
            //C# e uma linguagem case sensitive ->
            //Console.WriteLine("Hello World!");

            //Usamos int como uma variavel para numeros
            //int idade;
            //Usamos string como uma variavel para escrita 
            //string nomeCompleto;

            //Exibe o primeiro nome
            //nomeCompleto = "Matheus Vinicius David";
            //Console.WriteLine(nomeCompleto);

            //Exibe o segundo nome
            //nomeCompleto = "Afonso silva pereira";
            //Console.WriteLine(nomeCompleto);

            float nota1, nota2, nota3, media;
            String nomeCompleto;

            //entrada de dados
            Console.WriteLine("Digite o nome do aluno");
            nomeCompleto = Console.ReadLine();

            Console.Write("Digite a primeira nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("Digite a terceita nota: ");
            nota3 = float.Parse(Console.ReadLine());

            //processamento
            media = (nota1+nota2+nota3)/3;

            //Exibir resultado

            if(media>5){
                //valor verdadeiro
                Console.WriteLine("O Aluno "+nomeCompleto+" esta aprovado com a media de: "+media);
            }

            else{
                //valor falso
                Console.WriteLine("O Aluno "+nomeCompleto+" esta REPROVADO com a media de:"+media);
            }
        }

    }
}
