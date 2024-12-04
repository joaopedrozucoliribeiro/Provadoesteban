/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
using System.Globalization;

class Program
{
    static void Main()
    {
      
        CultureInfo culturaBrasileira = new CultureInfo("pt-BR");

        
        Console.WriteLine("Digite a primeira data (formato: dd/MM/yyyy):");
        string dataEntrada1 = Console.ReadLine();

        
        Console.WriteLine("Digite a segunda data (formato: dd/MM/yyyy):");
        string dataEntrada2 = Console.ReadLine();

        
        DateTime data1, data2;
        bool data1Valida = DateTime.TryParseExact(dataEntrada1, "dd/MM/yyyy", culturaBrasileira, DateTimeStyles.None, out data1);
        bool data2Valida = DateTime.TryParseExact(dataEntrada2, "dd/MM/yyyy", culturaBrasileira, DateTimeStyles.None, out data2);

        
        if (data1Valida && data2Valida)
        {
            
            TimeSpan diferenca = data2 - data1;
            int totalDias = Math.Abs(diferenca.Days);

            
            Console.WriteLine($"A diferença entre as datas é de {totalDias} dias.");
        }
        else
        {
            
            Console.WriteLine("Uma ou ambas as datas são inválidas. Por favor, insira as datas no formato correto (dd/MM/yyyy).");
        }
    }
}
