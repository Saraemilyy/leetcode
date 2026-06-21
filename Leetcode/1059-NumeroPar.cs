using System.Collections.Generic;

namespace Leetcode;

class Solution1059
{
    public static string[] NumerosPares()
    {
        List<string> pares = new();

        for (int i = 1; i < 100; i++)
        {
            if (i % 2 == 0)
            {
                pares.Add(i.ToString());
            }
        }

        return pares.ToArray();
    }
}