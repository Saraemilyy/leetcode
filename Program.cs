
using System;
using Leetcode;

class URI
{

    static void Main(string[] args)
    {

        string[] pares = Solution1059.NumerosPares();

        foreach (string numero in pares)
        {
            Console.WriteLine(numero);
        }

    }

}