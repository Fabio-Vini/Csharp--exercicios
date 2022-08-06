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
           
           
           /*dentro do if é uma condição*/
           
           if(idade < 18)
            {
           	Console.WriteLine("É menor de idade");
             }
             
           /*aqui é outra condição caso o fator nao 
           esteja conforme foi colocado no if*/
           
           else
            {
           	Console.WriteLine("É maior de idade");
             }
           }
           
        }
    }
