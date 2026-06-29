using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode;

public class Solution1044
{
    public static void VerificarMultiplos() { 

    string entrada = Console.ReadLine();

    int[] numeros = Array.ConvertAll(entrada.Split(' '), int.Parse);
    int numero1 = numeros[0];
    int numero2 = numeros[1];
    int calculo = numero2 % numero1; 

   if (numero1 % numero2 == 0 || numero2 % numero1 == 0)
        {
            Console.WriteLine("Sao Multiplos");
        }
    else
        {
            Console.WriteLine("Nao sao Multiplos");
        }
    }
}
