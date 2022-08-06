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
           
           Console.WriteLine("Digite o numero de habitantes: ");
           double hab = double.Parse(Console.ReadLine());
           
           Console.WriteLine("Voce quer calcular:");
           Console.WriteLine("1-Taxa de natalidade");
           Console.WriteLine("2-Taxa de mortalidade");
           
           double nat;
           double mort;
           
           double op = double.Parse(Console.ReadLine());
           
           switch (op)
           {
           	case 1:
           	Console.WriteLine("Digite o numero de crianças nascidas: ");
           	double cn = double.Parse(Console.ReadLine());
           	
           	nat = (cn * 1000)/hab;
           	
           	Console.WriteLine("A taxa de natalidade é: "+nat);
           	break;
           	
           	case 2:
           	Console.WriteLine("Digite o numero de óbitos:");
           	double o = double.Parse(Console.ReadLine());
           	
           	mort = (o * 1000)/hab;
           	
           	Console.WriteLine("A taxa de mortalidade é: "+mort);
           	break;
           	
           	default:
           	Console.WriteLine("Opção inválida!");
           	break;
           }
           goto inicio;
        }
    }
}