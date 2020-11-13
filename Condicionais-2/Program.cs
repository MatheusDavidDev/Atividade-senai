using System;

namespace Condicionais_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua idade");
            int idade = int.Parse(Console.ReadLine());


            if(idade >= 18){
                Console.WriteLine("você gostaria de partcipar do time de CS GO - Sim ou Não");
                string resposta = Console.ReadLine();
                if(resposta == "sim"){
                    Console.WriteLine("Compareça a secretaria - Falar com a sara");
                }else{
                    Console.WriteLine("Blz! Passar bem");
                }
            }else{
                Console.WriteLine("Você gostaria de participar do time de lol? Sim ou Não");
                string resposta = Console.ReadLine();
                if(resposta == "sim"){
                Console.WriteLine("Compareça a secretaria falar com Jucelino");

                }else{
                    Console.WriteLine("Muito obrigado");
                }
            }

         
         



            //int idade =1;

            //bool resposta = false;

            //if(!resposta){
               // Console.WriteLine("valor verdadeiro");

            //}else if(idade <16){
            
                //Console.WriteLine("Idade não permidita");
           // }else{
                //Console.WriteLine("valor falso");

           // }


        }
    }
}
