using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        /*Escreva um	programa para	ler o ano de nascimento de	
         uma	pessoa e escrever uma mensagem que diga	se ela	poderá ou 
         não votar este ano (não é necessário considerar o mês
         em que ela nasceu).*/
         
            Console.WriteLine("Digite o ano de seu nascimento, confira se pode votar ou não: ");

            int ano = int.Parse(Console.ReadLine());

            if(ano <= 2004)
            {
                Console.WriteLine("Você pode votar!");
            }
            else
            {
                Console.WriteLine("Não tem idade suficiente!");
            }
            Console.ReadKey();
        }
    }
}
