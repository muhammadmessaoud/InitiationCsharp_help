using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScenarioPOO.Model
{
    public class ManutRisque : Manutention
    {
        private int Prime = 200;
        public ManutRisque(string nom, string prenom, int age, string date, int heures) : base(nom, prenom, age, date, heures)
        {
        }

        public override double CalculerSalaire()
        {
            return base.CalculerSalaire() + Prime;
        }

        public override string GetNom()
        {
            return "Le Manutentionnaire à risque  : " + Nom + " " + Prenom + " " ;
        }

    }
}
