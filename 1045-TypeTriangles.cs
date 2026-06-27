using System;
using System.Globalization;
using System.Linq;

namespace Leetcode
{
    public class Solution1045
    {
        public static string ValidarTriangulo(string[] valores)
        {
            double[] lados = valores
                .Select(v => double.Parse(v, CultureInfo.InvariantCulture))
                .ToArray();

            Array.Sort(lados);
            Array.Reverse(lados);

            double A = lados[0];
            double B = lados[1];
            double C = lados[2];

            double Aquadrado = A * A;
            double Bquadrado = B * B;
            double Cquadrado = C * C;

            string retorno = "";

            if (A >= B + C)
            {
                return "NAO FORMA TRIANGULO";
            }

            if (Aquadrado == Bquadrado + Cquadrado)
            {
                retorno += "TRIANGULO RETANGULO";
            }
            else if (Aquadrado > Bquadrado + Cquadrado)
            {
                retorno += "TRIANGULO OBTUSANGULO";
            }
            else
            {
                retorno += "TRIANGULO ACUTANGULO";
            }

            if (A == B && B == C)
            {
                retorno += "\nTRIANGULO EQUILATERO";
            }
            else if (A == B || B == C || A == C)
            {
                retorno += "\nTRIANGULO ISOSCELES";
            }

            return retorno;
        }
    }
}