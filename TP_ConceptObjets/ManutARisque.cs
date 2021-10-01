using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_ConceptObjets
{
    public class ManutARisque : Manutentionnaire
    {
        public ManutARisque(string nom, string prenom, int age, string dateEntree, double heures) : base(nom, prenom, age, dateEntree, heures)
        {
        }

        public static double PRIME { get; set; } = 200;

        public override double CalculerSalaire()
        {
            return base.CalculerSalaire() + PRIME;
        }
    }
}
