using System;

namespace ProjetoGit
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Digite um numero: ");
            double num = double.Parse(Console.ReadLine());

            if (num%2 ==0) 
            {
                Console.WriteLine("O numero digitado é par");
            }
            else
            {
                Console.WriteLine("O numero digitado é impar ");
            }
            Console.ReadKey();
        }
    }
}
