using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Calculatrice
{
    public class Module3
    {
        public static double Valeur()
        {
            Console.WriteLine("Donnez valeur:");
            double valeur = Convert.ToDouble(Console.ReadLine());
            return valeur;
        }
    }
}
