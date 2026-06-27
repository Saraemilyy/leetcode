using System.Globalization;

namespace Leetcode;

public class Solution1042
{
    public static string SortSimples(string[] entradas)
    {
        string resultado = "";

        int[] entrada = entradas
            .Select(v => int.Parse(v, CultureInfo.InvariantCulture))
            .ToArray();

        int[] ordenado = (int[])entrada.Clone();

        Array.Sort(ordenado);

        for (int i = 0; i < ordenado.Length; i++)
        {
            resultado += ordenado[i] + "\n";
        }

        resultado += "\n";

        for (int i = 0; i < entrada.Length; i++)
        {
            resultado += entrada[i] + "\n";
        }

        return resultado;
    }
}