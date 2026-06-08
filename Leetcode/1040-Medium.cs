
// Exemplo de Entrada	Exemplo de Saída
// 2.0 4.0 7.5 8.0
// 6.4

// Media: 5.4
// Aluno em exame.
// Nota do exame: 6.4
// Aluno aprovado.
// Media final: 5.9
class Program
{
 public static void Main(string[] args)
 {

  string[] entradaNotas = Console.ReadLine().Split(' ');
  double nota1 = double.Parse(entradaNotas[0]);
  double nota2 = double.Parse(entradaNotas[1]);
  double nota3 = double.Parse(entradaNotas[2]);
  double nota4 = double.Parse(entradaNotas[3]);
  double nota5 = double.Parse(entradaNotas[4]);
  CalcularMedia( nota1, nota2, nota3, nota4, nota5);

  string CalcularMedia (double nota1, double nota2, double nota3, double nota4, double nota5)
  {
   int peso1 = 2;
   int peso2 = 3;
   int peso3 = 4;
   int peso4 = 1;

   int totalPeso = peso1 + peso2 + peso3 + peso4;
   double mediaPonderada = (nota1 * peso1) + (nota2 * peso2) + (nota3 * peso3) + (nota4 * peso4) / totalPeso;

   if (mediaPonderada >= 7.00)
   {
    string resultado = $"Média: {mediaPonderada:0}\nAluno Aprovado";
    return resultado;
   }
   else if (mediaPonderada >= 0.00 && mediaPonderada <= 5.00)
   {
    string resultado = $"Média: {mediaPonderada:0}\nAluno Reprovado";
    return resultado;
   }
   else
   {
    double resultadoFinal = (mediaPonderada + nota5) /2;
    if (resultadoFinal >= 5.00)
    {
     string resultado = $"Média: {mediaPonderada:0}\nAluno em exame.\nNota do exame: {nota5}\nAluno Aprovado\nMédia FInal: {resultadoFinal}";
     return resultado;
    }else{
     string resultado = $"Média: {mediaPonderada:0}\nAluno em exame.\nNota do exame: {nota5}\nAluno Reprovado\nMédia Fnal: {resultadoFinal}";
     return resultado;
    }
   }
  }
 }
}