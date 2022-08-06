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
		/*As maçãs custam	R$0,30 cada se forem compradas menos do que	uma	
		dúzia, e R$0,25 se forem compradas pelo menos doze.Escreva um	programa que leia o	 
		número de maçãs compradas, calcule e escreva o valor	total	da	compra.*/
    
    		double menor, maior;
    
    		Console.WriteLine("Digite a quantidade de maçãs que quer comprar:");
    		double qtd = double.Parse(Console.ReadLine());

    		maior = 0.30 * qtd;
    		menor = 0.25 * qtd;

    		if(qtd < 12)
    		{
        		Console.WriteLine("Total: R$"+maior);  
   		}
    		else
   		{
        		Console.WriteLine("Total: R$"+menor);  
    		}
    		Console.ReadKey();
        }
    }
}