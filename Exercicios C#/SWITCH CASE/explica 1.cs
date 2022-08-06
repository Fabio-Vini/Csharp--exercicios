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
           Console.WriteLine("Escolha uma das opções a seguir: ");
           Console.WriteLine("1-Criar ficheiro");
           Console.WriteLine("2-Abrir ficheiro");
           Console.WriteLine("3-Gravar ficheiro");
           Console.WriteLine("0-Sair");
           int op = int.Parse(Console.ReadLine());
           
           switch(op)
           {
           	case 1:
           	    Console.WriteLine("Escolheu a opção 1 - criar ficheiro");
           	    break;
           	    
            case 2:
           	    Console.WriteLine("Escolheu a opção 2 - abrir ficheiro");
           	    break;
           	    
            case 3:
           	    Console.WriteLine("Escolheu a opção 3 - gravar ficheiro");
           	    break;
           	    
            case 0:
           	    break;
           	default:
           	    Console.WriteLine("Opção inválida");
           	    break;
           }
           /*Fazendo a mesma coisa com if e else*/
           
           if(op==1)
           {
           	Console.WriteLine("Escolheu a opção 1 - criar ficheiro");
           }
           else if(op==2)
           {
           	Console.WriteLine("Escolheu a opção 2 - abrir ficheiro");
           }
           else if (op==3)
           {
           	Console.WriteLine("Escolheu a opção 3 - gravar ficheiro");
           }
           else if(op==0)
           {
           	return;
           }
           else
           {
           	Console.WriteLine("Opção inválida");
           }
        }
    }
}