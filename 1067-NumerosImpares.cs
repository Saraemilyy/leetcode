
namespace Leetcode;

public class Solution1067
{
    public static void NumerosImpares()
    {
        int entrada = int.Parse(Console.ReadLine());

        for (int i = 1; i <= entrada; i++)
        {
            if (i % 2 > 0)
            {
                Console.WriteLine(i);
            }
        }

    }
}
