/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

namespace ContarPalavrasJoaopedrozucoli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

           
            string[] palavras = frase.Split(' ');

            
            int numeroDePalavras = palavras.Length;

            Console.WriteLine($"A frase tem {numeroDePalavras} palavras.");
        }
    }
}