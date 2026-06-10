
// Exemplo de Entrada	Exemplo de Saída
// 2.0 4.0 7.5 8.0
// 6.4

// Media: 5.4
// Aluno em exame.
// Nota do exame: 6.4
// Aluno aprovado.
// Media final: 5.9
namespace LeetCode;


class Solution1040
{


    //    double nota1 = double.Parse(entradaNotas[0]);
    //    double nota2 = double.Parse(entradaNotas[1]);
    //    double nota3 = double.Parse(entradaNotas[2]);
    //    double nota4 = double.Parse(entradaNotas[3]);

    //    double? nota5 = null;

    //if (entradaNotas.Length > 4)
    //{
    //    nota5 = double.Parse(entradaNotas[4]);
    //}


    //Console.WriteLine(
    //    CalcularMedia(
    //        nota1,
    //        nota2,
    //        nota3,
    //        nota4,
    //        nota5));
    //    }
    public static string CalcularMedia(double nota1, double nota2, double nota3, double nota4, double? nota5 = null)
    {
        int peso1 = 2;
        int peso2 = 3;
        int peso3 = 4;
        int peso4 = 1;

        int totalPeso = peso1 + peso2 + peso3 + peso4;
        double mediaPonderada = ((nota1 * peso1) + (nota2 * peso2) + (nota3 * peso3) + (nota4 * peso4)) / totalPeso;
        mediaPonderada = Math.Truncate(mediaPonderada * 10) / 10.0;
        if (mediaPonderada >= 7.00)
        {
            string resultado = $"Media: {mediaPonderada:f1}\nAluno aprovado.";
            return resultado;
        }
        else if (mediaPonderada >= 0.00 && mediaPonderada < 5.00)
        {
            string resultado = $"Media: {mediaPonderada:f1}\nAluno reprovado.";
            return resultado;
        }
        else
        {
            double notaExame = double.Parse(Console.ReadLine());

            double mediaFinal = (mediaPonderada + notaExame) / 2;

            if (mediaFinal >= 5.00)
            {
                string resultado = $"Media: {mediaPonderada:f1}\nAluno em exame.\nNota do exame: {notaExame:f1}\nAluno aprovado.\nMedia final: {mediaFinal:f1}";
                return resultado;
            }
            else
            {
                string resultado = $"Media: {mediaPonderada:f1}\nAluno em exame.\nNota do exame: {nota5:f1}\nAluno reprovado.\nMedia final: {mediaFinal:f1}";
                return resultado;
            }
        }
    }
}