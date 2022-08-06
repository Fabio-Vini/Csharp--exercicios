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
           Console.WriteLine("");
           inicio:
           Console.WriteLine("");
           
           Console.WriteLine("Escolha uma opção:");
           Console.WriteLine("");
           Console.WriteLine("1-Decimal para Hexadecimal");
           Console.WriteLine("2-Hexadecimal para Decimal");
           Console.WriteLine("3-Decimal para Octal");
           Console.WriteLine("4-Octal para Decimal");
           Console.WriteLine("5-Encerra");
           
           double op = double.Parse(Console.ReadLine());
           
           double hex;
           double dec;
           double oct;
   
           
           if(op == 1)
           {
           	Console.WriteLine("Digite um valor Decimal para converter");
           	double v1 = double.Parse(Console.ReadLine());
           	
          
           	
           	Console.WriteLine("O valor em Hexadecimal é: ");
           	goto inicio;
           }
         
           else if(op == 2)
           {
           	Console.WriteLine("Digite um valor Hexadecimal para converter");
           	double v2 = double.Parse(Console.ReadLine());
           	
           	
           	
           	goto inicio;
           }
         
           else if(op == 3)
           {
           	Console.WriteLine("Digite um valor Decimal para converter");
           	double v3 = double.Parse(Console.ReadLine());
           	
           	
           	
           	goto inicio;
           }
       
           else if(op == 4)
           {
           	Console.WriteLine("Digite um valor Octal para converter");
           	double v4 = double.Parse(Console.ReadLine());
           	
           	
           	
           	goto inicio;
           }
         
           else if(op == 5)
           {
           	Console.WriteLine(" ");
           }
       
           else
           {
           	Console.WriteLine("Opção inválida!");
           	goto inicio;
           }
           
        }
    }
}