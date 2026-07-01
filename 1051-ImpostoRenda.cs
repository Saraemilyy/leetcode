using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode;

public class Solution1051
{

    public  static void ValidarImpostoRenda() { 

        double salarioEntrada = double.Parse(Console.ReadLine());

        if (salarioEntrada >= 0 && salarioEntrada <= 2000)
        {
            Console.WriteLine("Isento");
        }
        else if (salarioEntrada >= 2000.01 && salarioEntrada <= 3000)
        {
            double salarioImpostoFinal = ((salarioEntrada - 2000) * 8) / 100;
            Console.WriteLine($"R${salarioImpostoFinal}");


        }
        else if (salarioEntrada >= 3000.01 && salarioEntrada <= 4500)
        {
            if (salarioEntrada - 2000 > 1000)
            {
                double salarioImpostoCom8 = ((salarioEntrada - 2000 - (1000 - (salarioEntrada - 2000))) * 8) / 100;

                double salarioImpostoCom18 = (salarioEntrada - 3000);

                double resultadoFinal = salarioImpostoCom8 + salarioImpostoCom18;

                Console.WriteLine($"R${resultadoFinal}");
                Console.WriteLine($"R${salarioImpostoCom18}");
                Console.WriteLine($"R${salarioImpostoCom8}");
                Console.WriteLine($"R${salarioEntrada}");

            }

            else
            {
                double salarioImpostoFinal = ((salarioEntrada - 2000) * 8) / 100;
                Console.WriteLine($"R${salarioImpostoFinal}");
            }

        }
        else
        {
            //acima de 4500
            //Console.WriteLine($"R${valorImposto}");
        }

    }
}
