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
           incio:
           Console.WriteLine("Digite o valor total da compra: ");
           double valor = double.Parse(Console.ReadLine());
         
           Console.WriteLine("Você pertence a que classe?(digite o numero da opção)");
           Console.WriteLine("1-Vip");
           Console.WriteLine("2-Funcionário");
           
           double fun;
           double vip;
           
           double op = double.Parse(Console.ReadLine());
           
           fun = valor -(valor * 0.1);
           vip = valor - (valor * 0.05);
           
           switch (op)
        {
        	case 1:
        	Console.WriteLine("O valor da sua compra com desconto é: "+fun);
        	break;
        	
        	case 2:
        	Console.WriteLine("O valor da sua compra com desconto é: "+vip);
        	break;
        	
        	default:
        	Console.WriteLine("Opção inválida!");
        	break;
        }
        goto incio;
        }
    }
}