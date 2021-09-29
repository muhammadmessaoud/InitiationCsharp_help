using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Calculatrice
{
    public class Module2
    {
        public static string Choix()
        {
            string choix = "";
            do
            {
                Console.WriteLine("Faites votre choix:");
                choix = Console.ReadLine();
                if (choix == "a" || choix == "s" || choix == "m" || choix == "d")
                {
                    break;
                }
            } while (true);

            return choix;
        }
    }
}
