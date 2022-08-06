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
           
           Console.WriteLine("Digite o valor da compra: ");
           double valor = double.Parse(Console.ReadLine());
           
           
           Console.WriteLine("De que forma voce deseja pagar:");
           Console.WriteLine("1-À vista");
           Console.WriteLine("2-À prazo");
           
           double desconto;
           double norm;
           double op = double.Parse(Console.ReadLine());
           
           desconto = valor - (valor * 0.10);
           norm = valor;
          
           switch (op)
        {
        	case 1:
        	Console.WriteLine("O valor da sua compra é: "+desconto);
        	break;
        	
        	case 2:
        	Console.WriteLine("O valor da sua compra é: "+norm);
        	break;
        	
        	default:
        	Console.WriteLine("Opção inválida!");
        	break;
        }
            goto inicio;
        }
    }
}