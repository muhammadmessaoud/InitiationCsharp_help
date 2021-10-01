using ProjetConsole.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScenarioPOO.Model
{
    public class Vendeur : Salaire
    {
        //public static double POURCENT_VENDEUR { get; set; } = 0.2;
        //public static double BONUS_VENDEUR { get; set; } = 400;
        private double PourcentageVendeur = 0.2;
        private double BonusVendeur = 400;

        public Vendeur(string nom , string prenom , int age , string date, double chiffreAffaire) : base (nom,prenom,age,date,chiffreAffaire)
        {
        }

        public override double CalculerSalaire()
        {
            return (PourcentageVendeur * getChiffreAffaire()) + BonusVendeur;
        }

        public override string GetNom()
        {
            return "Le Vendeur : " + Nom + " " + Prenom + " ";
        }
    }
}
