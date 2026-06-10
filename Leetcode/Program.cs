
using System;
using LeetCode;

class URI
{

    static void Main(string[] args)
    {

        string[] entradaNotas = Console.ReadLine().Split(' ');

        double nota1 = double.Parse(entradaNotas[0]);
        double nota2 = double.Parse(entradaNotas[1]);
        double nota3 = double.Parse(entradaNotas[2]);
        double nota4 = double.Parse(entradaNotas[3]);

        double? nota5 = null;

        if (entradaNotas.Length > 4)
        {
            nota5 = double.Parse(entradaNotas[4]);
        }
;

        Console.WriteLine(
            Solution1040.CalcularMedia(
                nota1,
                nota2,
                nota3,
                nota4,
                nota5));
        Console.ReadKey();

    }

}