
using System;
using System.Globalization;
using System.Collections.Generic;

public class Solution1038
{
 public static void Main(string[] args)
 {
  string[] entrada = Console.ReadLine().Split(' ');

  int codigo = int.Parse(entrada[0]);
  int quantidade = int.Parse(entrada[1]);

  Dictionary<int, double> cardapio = new()
        {
            {1, 4.00},
            {2, 4.50},
            {3, 5.00},
            {4, 2.00},
            {5, 1.50}
        };

  double total = cardapio[codigo] * quantidade;

  Console.WriteLine(
      $"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}"
  );
 }
}