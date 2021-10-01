using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_ConceptObjets
{
    public class Technicien : Employe
    {
       

        public double Unites { get; set; }
        public static double PRIX_UNITE { get; set; } = 5;

        public override double CalculerSalaire()
        {
            return Unites * PRIX_UNITE;
        }
        public Technicien(string nom, string prenom, int age, string dateEntree, double unites) : base(nom, prenom, age, dateEntree)
        {
            Unites = unites;
        }

        public override string GetNom()
        {
            return $"Le technicien {Prenom} {Nom}";
        }
    }
}
