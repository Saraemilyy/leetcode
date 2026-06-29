using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode;

public class Solution1041
{
    string entrada = Console.ReadLine();
    //string[] entradaArray = entrada.Split(' ');

    //double coordenadaX = double.Parse(entradaArray[0]);
    //double coordenadaY = double.Parse(entradaArray[1]);


    public static void VerificarCoordenadas(coordenadaX , coordenadaY)
    {
        if (coordenadaX == 0.0 && coordenadaY == 0.0)
        {
            Console.WriteLine("Origem");
        }
        else if (coordenadaX == 0.0)
        {
            Console.WriteLine("Eixo Y");
        }
        else if (coordenadaY == 0.0)
        {
            Console.WriteLine("Eixo X");
        }
        else if (coordenadaX > 0.0 && coordenadaY > 0.0)
        {
            Console.WriteLine("Q1");
        }
        else if (coordenadaX < 0.0 && coordenadaY > 0.0)
        {
            Console.WriteLine("Q2");
        }
        else if (coordenadaX < 0.0 && coordenadaY < 0.0)
        {
            Console.WriteLine("Q3");
        }
        else
        {
            Console.WriteLine("Q4");
        }
    }
}
