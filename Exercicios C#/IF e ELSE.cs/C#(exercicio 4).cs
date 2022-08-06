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
           bool peso;
           string sexo;
           
           double result;
           double resulta;
        	
           Console.WriteLine("Digite sua altura: ");
           double altura = double.Parse(Console.ReadLine());
           
           Console.WriteLine("Tecle 1 para masculino ou 2 para feminino:");
           sexo = Console.ReadLine();
           
           

            result = (72.7 * altura) - 58;
            resulta = (62.1 * altura) - 44.7;
            
           
           if(sexo == "1")
           {
           	peso = true;
           	Console.WriteLine("Seu peso ideal é: "+result);
           }
           else
           {
           	peso = false;
           	Console.WriteLine("Seu peso ideal é: "+resulta);
           }
        }
    }
}