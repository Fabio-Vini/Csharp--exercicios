using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {
        	/*2 Escreva um programa para ler o ano de nascimento 
        	de uma pessoa e escrever uma mensagem que diga se ela 
        	poderá ou não votar este ano (não é necessário considerar
        	o mês em que ela nasceu).*/
        	
           Console.WriteLine("Digite seu ano de nascimento: ");
           int idade = int.Parse(Console.ReadLine());
           
           if(idade <= 2002)
           {
           	Console.WriteLine("Voce pode votar este ano!");
           }
           else
           {
           	Console.WriteLine("Voce não pode votar este ano!");
           }
        }
    }
}