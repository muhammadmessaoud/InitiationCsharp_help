using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScenarioPOO.Model
{
    internal class ProdRisque : Production
    {
        int Prime = 200;
        public ProdRisque(string nom, string prenom, int age, string date, int unites) : base(nom, prenom, age, date, unites)
        {
        }

        public override double CalculerSalaire()
        {
            return base.CalculerSalaire() + Prime;
        }

        public override string GetNom()
        {
            return "Le producteur à risque : " + Nom + " " + Prenom + " ";
        }

    }
}
