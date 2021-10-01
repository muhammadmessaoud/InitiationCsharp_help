using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScenarioPOO.Model
{
    public class Representant : Salaire
    {
        private double PourcentageRepresentant = 0.2;
        private double BonusRepresentant = 800;

        public Representant(string nom , string prenom , int age , string date, double chiffreAffaire) : base (nom,prenom,age,date,chiffreAffaire)
        {
        }

       /* public double CalculerSalaire()
        {
            return (PourcentageRepresentant * getChiffreAffaire()) + BonusRepresentant;
        }*/

        public override double CalculerSalaire()
        {
            return (PourcentageRepresentant * getChiffreAffaire()) + BonusRepresentant;
        }

        public override string GetNom()
        {
            return "Le Representant : " + Nom + " " + Prenom + " ";
        }

    }
}
