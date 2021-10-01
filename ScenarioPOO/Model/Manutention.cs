using ProjetConsole.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScenarioPOO.Model
{
    public class Manutention : Employee
    {
        private double HoraireSalary = 65;
        public int Heures;

        public Manutention(string nom , string prenom , int age , string date, int heures) : base (nom,prenom,age,date)
        {
            Heures = heures;
        }

        public override double CalculerSalaire()
        {
            return HoraireSalary* Heures;
        }

        public override string GetNom()
        {
            return "Le Manutentionnaire : " + Nom + " " + Prenom + " ";
        }

    }
}
