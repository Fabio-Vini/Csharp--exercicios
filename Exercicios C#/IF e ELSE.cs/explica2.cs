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
           Console.WriteLine("Digite sua idade");
           
           int idade = int.Parse(Console.ReadLine());
           
           if(idade < 2)
            {
           	Console.WriteLine("É um bebe");
             }
           else if(idade < 10)
            {
           	Console.WriteLine("É uma criança");
             }
             else if(idade < 18)
             {
             	Console.WriteLine("É um adolescente");
             }
             else if (idade < 60)
             {
             	Console.WriteLine("É um adulto");
             }
             else
             {
             	Console.WriteLine("É um idoso");
             }
        }
    }
}