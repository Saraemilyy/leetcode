using System;

public class Solution1046
{
    public static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');

        int horaInicio = int.Parse(entrada[0]);
        int horaFim = int.Parse(entrada[1]);


        int horasJogo = (horaFim - horaInicio + 24) % 24;

        if (horasJogo == 0)
        {
            horasJogo = 24;
        }

        Console.WriteLine($"O JOGO DUROU {horasJogo} HORA(S)");
    }
}