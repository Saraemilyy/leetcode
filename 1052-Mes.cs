
namespace Leetcode;

public class Solution1052
{
    // Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

        //Console.WriteLine(VerificarMes(Console.ReadLine()));


    public static string VerificarMes(string numeroMes)
    {

        switch (numeroMes)
        {
            case "1": return "January";
            case "2": return "February";
            case "3": return "March";
            case "4": return "April";
            case "5": return "May";
            case "6": return "June";
            case "7": return "July";
            case "8": return "August";
            case "9": return "September";
            case "10": return "October";
            case "11": return "November";
            case "12": return "December";
            default: return "Opção inválida.";
        }
        ;

    }


}

