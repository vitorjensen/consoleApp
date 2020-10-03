using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        //escrever um sequência numérica (fibonacci) usando recursividade
        static void Main(string[] args)
        {
            int cont = 1, max = 0;
            Console.WriteLine("Digite uma quantia de números:");
            max = int.Parse(Console.ReadLine());



            while(cont <= max)
            {
                //escrita na tela
                Console.Write(" " + sequencia(cont));
                //escrita em arquivo
                System.IO.File.AppendAllText(@"sequencia.txt", 
                    sequencia(cont) + " ");
                cont++;
            }
            Console.ReadKey();
        }

        //método da recursividade
        public static int sequencia(int n)
        {
            if (n == 1)
                return 1;   
            else if (n == 2)
                return 1;
            else
                return sequencia(n - 1) + sequencia(n - 2);//recursividade
        }
    }
}

/*
class Program
    {
        //escrever um sequência numérica (fibonacci) usando recursividade
        static void Main(string[] args)
        {
            int cont = 1, max = 0, v_inicial = 0;
            Console.WriteLine("Digite uma quantia de números:");
            max = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor inicial:");
            v_inicial = int.Parse(Console.ReadLine());

            while(cont <= max)
            {
                Console.Write(" " + sequencia(cont,v_inicial));
                cont++;
            }
            Console.ReadKey();
        }

        //método da recursividade
        public static int sequencia(int n, int valorInicial)
        {
            if (n == 1)
                return valorInicial;   // 1 2 3 4 5 6 .. 1000
            else
                return sequencia(n - 1,valorInicial) + 1;//recursividade
        }
    }
*/
