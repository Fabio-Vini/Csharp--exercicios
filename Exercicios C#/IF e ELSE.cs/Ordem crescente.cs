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
        	int aux;
        	
           Console.WriteLine("Digite um valor:");
           int v1 = Convert.ToInt32(Console.ReadLine());
           
           Console.WriteLine("Digite um valor:");
           int v2 = Convert.ToInt32(Console.ReadLine());
           
           Console.WriteLine("Digite um valor:");
           int v3 = Convert.ToInt32(Console.ReadLine());
           
           if(v1 > v2)
           {
           	aux = v1;
           	v1 = v2;
           	v2 = aux;
           }
           if(v1 > v3)
           {
           	aux = v1;
           	v1 = v3;
           	v3 = aux;
           }
           if(v2 > v3)
           {
           	aux = v2;
           	v2 = v3;
           	v3 = aux;
           }
           
           Console.WriteLine("Ordem Crescente: " + v1 + ", " + v2 + ", " + v3);
        }
    }
}