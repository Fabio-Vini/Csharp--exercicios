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
           
           Console.WriteLine("Qual genêro você se identifica: ");
           Console.WriteLine("1-M");
           Console.WriteLine("2-F");
           
           double op = double.Parse(Console.ReadLine());
           
           switch(op)
           {
           	case 1:
           	Console.WriteLine("Gênero masculino");
           	break;
           	
           	case 2:
           	Console.WriteLine("Gênero feminino");
           	break;
           	
           	default:
           	Console.WriteLine("Gênero não identificado");
           	break;
           }
           goto inicio;
        }
    }
}