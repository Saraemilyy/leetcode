using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode;

public class Solution1060
{
    public static int ContarPositivos(double numero1, double numero2, double numero3, double numero4, double numero5, double numero6)
    {

        int valoresPositivos = 0;
        if (numero1 > 0)
        {
            valoresPositivos++;
        };
        if (numero2 > 0)
        {
            valoresPositivos++;
        };
        if (numero3 > 0)
        {
            valoresPositivos++;
        };
        if (numero4 > 0)
        {
            valoresPositivos++;
        };
        if (numero5 > 0)
        {
            valoresPositivos++;
        };

        if (numero6 > 0) { valoresPositivos++; };

        return valoresPositivos;
    }

}
