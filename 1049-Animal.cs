using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode;

public class Solution1049
{
    public static string ValidarEspecie(string tipo1, string tipo2, string tipo3)
    {

        string animal = "nenhum";
        if (tipo1 == "vertebrado")
        {
            if (tipo2 == "ave")
            {
                if (tipo3 == "carnivoro")
                {
                    animal = "aguia";
                }
                if (tipo3 == "onivoro")
                {
                    animal = "pomba";
                }
            }
            if (tipo2 == "mamifero")
            {
                if (tipo3 == "herbivoro")
                {
                    animal = "vaca";
                }
                if (tipo3 == "onivoro")
                {
                    animal = "homem";
                }
            }
        }
        else
        {
            if (tipo2 == "inseto")
            {

                if (tipo3 == "hematofago")
                {
                    animal = "pulga";
                }
                if (tipo3 == "herbivoro")
                {
                    animal = "lagarta";
                }
            }
            if (tipo2 == "anelideo")
            {

                if (tipo3 == "hematofago")
                {
                    animal = "sanguessuga";
                }

                if (tipo3 == "onivoro")
                {
                    animal = "minhoca";
                }
            }
        }

        return animal;
    }
}
