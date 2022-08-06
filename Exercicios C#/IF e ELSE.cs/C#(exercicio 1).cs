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
        	
        	/*1. Escreva um programa para ler 2 valores 
        	(considere que não serão informados valores 
        	iguais) e escrever o maior deles.*/
        	
           Console.WriteLine("Digite o primeiro valor: ");
           double v1 = double.Parse(Console.ReadLine());
           
           Console.WriteLine("Digite o segundo valor: ");
           double v2 = double.Parse(Console.ReadLine());
           
           if(v1 > v2)
           {
           	Console.WriteLine("O primeiro valor é maior");
           }
           else
           {
           	Console.WriteLine("O segundo  valor é maior");
           }
        }
    }
}