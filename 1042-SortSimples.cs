using System.Globalization;

namespace Leetcode;

public class Solution1042
{
    public static void SortSimples(string[] entradas)
    {
        //string entrada = Console.ReadLine();

        int[] numeros = Array.ConvertAll(entrada.Split(' '), int.Parse);

        int[] ordenados = (int[])numeros.Clone();

        Array.Sort(ordenados);

        foreach (int numero in ordenados)
        {
            Console.WriteLine(numero);
        }

        Console.WriteLine();

        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}