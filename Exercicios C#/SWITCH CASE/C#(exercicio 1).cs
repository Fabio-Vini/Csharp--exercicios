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
        	inicio:
          Console.WriteLine("Digite o primeiro valor: ");
          double x = double.Parse(Console.ReadLine());
          
          Console.WriteLine("Digite segundo valor: ");
          double y = double.Parse(Console.ReadLine());
          
          Console.WriteLine("Escolha uma das opcões digitando o numero da opção escolhida:");
          Console.WriteLine("1-Somar");
          Console.WriteLine("2-Subtrair");
          Console.WriteLine("3-Dividir");
          Console.WriteLine("4-Multiplicar");
          double op = double.Parse(Console.ReadLine());
          
          double soma, sub, div, mult;
          
          soma = x + y;
          sub = x - y;
          div = x / y;
          mult = x * y;
          
          
          switch(op)
          {
          	case 1:
          	Console.WriteLine("A soma é: "+soma);
          	break;
          	
          	case 2:
          	Console.WriteLine("A subtração é: "+sub);
          	break;
          	
          	case 3:
          	Console.WriteLine("A divisão é: "+div);
          	break;
          	
          	case 4:
          	Console.WriteLine("A multiplicação é: "+mult);
          	break;
          	
          	default:
          	Console.WriteLine("Opção inválida: ");
          	break;
          }
          goto inicio;
        }
    }
}