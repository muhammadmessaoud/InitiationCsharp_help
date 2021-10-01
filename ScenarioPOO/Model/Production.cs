using ProjetConsole.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScenarioPOO.Model
{
    public class Production : Employee
    {
        private double PrixUnite = 5;
        private int Unites;

        public Production(string nom , string prenom , int age , string date, int unites) : base (nom,prenom,age,date)
        {
            Unites = unites;
        }

        
        public override double CalculerSalaire()
        {
            return PrixUnite * Unites;
        }

        public override string GetNom()
        {
            return "Le producteur : " + Nom + " " + Prenom + " ";
        }

    }
}
