using System;
using System.Collections.Generic;

public class Solution1050
{
    public static string ValidarDDD(int ddd) { 
    {


        int entrada = int.Parse(Console.ReadLine());

        Dictionary<int, string> numberss = new Dictionary<int, string>{
            { 61, "Brasilia" },
            { 71, "Salvador" },
            { 11, "Sao Paulo" },
            { 21, "Rio de Janeiro" },
            { 32, "Juiz de Fora" },
            { 19, "Campinas" },
            { 27, "Vitoria" },
            { 31, "Belo Horizonte" }

        };

        if (numberss.TryGetValue(entrada, out string estado))
        {
                return ($"{estado}");

        }
        else
        {
            return("DDD nao cadastrado");
        }

        }
    }
}