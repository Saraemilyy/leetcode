using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode;

public class Solution1048
{

    //    double salarioEntrada = double.Parse(Console.ReadLine());
    //    Console.WriteLine(NovoSalario(salarioEntrada));

    public static string NovoSalario(double salarioAtual)
    {
        if (salarioAtual >= 0 && salarioAtual <= 400.00)
        {
            double novoSalario = salarioAtual + ((salarioAtual * 15.0) / 100);
            double reajuste = novoSalario - salarioAtual;
            return ($"Novo salario: {novoSalario:f2}\nReajuste ganho: {reajuste:f2}\nEm percentual: 15 %");
        }
        else if (salarioAtual >= 400.01 && salarioAtual <= 800.00)
        {

            double novoSalario = salarioAtual + ((salarioAtual * 12.0) / 100);
            double reajuste = novoSalario - salarioAtual;
            return ($"Novo salario: {novoSalario:f2}\nReajuste ganho: {reajuste:f2}\nEm percentual: 12 %");
        }
        else if (salarioAtual >= 800.01 && salarioAtual <= 1200.00)
        {

            double novoSalario = salarioAtual + ((salarioAtual * 10.0) / 100);
            double reajuste = novoSalario - salarioAtual;
            return ($"Novo salario: {novoSalario:f2}\nReajuste ganho: {reajuste:f2}\nEm percentual: 10 %");
        }
        else if (salarioAtual >= 1200.01 && salarioAtual <= 2000.00)
        {

            double novoSalario = salarioAtual + ((salarioAtual * 7.0) / 100);
            double reajuste = novoSalario - salarioAtual;
            return ($"Novo salario: {novoSalario:f2}\nReajuste ganho: {reajuste:f2}\nEm percentual: 7 %");
        }
        else
        {
            double novoSalario = salarioAtual + ((salarioAtual * 4.0) / 100);
            double reajuste = novoSalario - salarioAtual;
            return ($"Novo salario: {novoSalario:f2}\nReajuste ganho: {reajuste:f2}\nEm percentual: 4 %");
        }
    }
}

