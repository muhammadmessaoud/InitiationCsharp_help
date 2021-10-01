using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_ConceptObjets
{
    public class Manutentionnaire : Employe
    {
        

        public double Heures { get; set; }
        public static double TAUX_HORAIRE { get; set; } = 65;

        public override double CalculerSalaire()
        {
            return Heures * TAUX_HORAIRE;
        }
        public Manutentionnaire(string nom, string prenom, int age, string dateEntree, double heures) : base(nom, prenom, age, dateEntree)
        {
            Heures = heures;
        }

        public override string GetNom()
        {
            return $"Le manutentionnaire {Prenom} {Nom}";
        }
    }
}
