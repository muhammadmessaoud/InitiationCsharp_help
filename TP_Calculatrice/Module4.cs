using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Calculatrice
{
    public class Module4
    {
        public static void BoucleSwicth(string choix, double valeur1, double valeur2)
        {
            switch (choix)
            {
                case "a":
                    Console.WriteLine(valeur1 + "+" + valeur2 + "=" + (valeur1 + valeur2));
                    break;
                case "s":
                    Console.WriteLine(valeur1 + "-" + valeur2 + "=" + (valeur1 - valeur2));
                    break;
                case "m":
                    Console.WriteLine(valeur1 + "x" + valeur2 + "=" + (valeur1 * valeur2));
                    break;
                case "d":
                    Console.WriteLine(valeur1 + "/" + valeur2 + "=" + (valeur1 / valeur2));
                    break;

            }
        }
    }
}
