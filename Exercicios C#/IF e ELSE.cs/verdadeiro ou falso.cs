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
            bool senha;
           
            string veri;
        	
           Console.WriteLine("Digite a senha correta: ");
           veri = Console.ReadLine();
           
           
           if(veri == "1234")
           {
           	senha = true;
           	Console.WriteLine("ACESSO PERMITIDO!");
           }
           else
           {
           	senha = false;
           	Console.WriteLine("ACESSO NEGADO!");
           }
        }
    }
}