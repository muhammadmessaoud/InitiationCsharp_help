using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_ConceptObjets
{
    public class TechnARisque : Technicien
    {
        public TechnARisque(string nom, string prenom, int age, string dateEntree, double unites) : base(nom, prenom, age, dateEntree, unites)
        {
        }

        public static double PRIME { get; set; } = 200;

        public override double CalculerSalaire()
        {
            return base.CalculerSalaire() + PRIME;
        }
    }
}
