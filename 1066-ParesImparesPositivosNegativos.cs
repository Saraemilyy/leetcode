using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode;

public class Solution1066
{

    public static void ValidarColecaoValores() { 
    int[] linhas = new int[5];
    int valoresPares = 0;
    int valoresImpares = 0;
    int valoresPositivos = 0;
    int valoresNegativos = 0;
        
        // Laço para ler e armazenar as 5 entradas
        for (int i = 0; i< 5; i++) {
        linhas[i] = int.Parse(Console.ReadLine());
        if (linhas[i] % 2 == 0)
        {
          valoresPares++;
        } 
        else
            {valoresImpares++;}
      
        if (linhas[i] > 0)
            { valoresPositivos++; }
        if (linhas[i] < 0)
            { valoresNegativos++; }
        
        
        }
       

    Console.WriteLine($"{valoresPares} valor(es) par(es)");
    Console.WriteLine($"{valoresImpares} valor(es) impar(es)");
    Console.WriteLine($"{valoresPositivos} valor(es) positivo(s)");
    Console.WriteLine($"{valoresNegativos} valor(es) negativo(s)");
    }
}
