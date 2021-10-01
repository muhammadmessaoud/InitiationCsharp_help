using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole.Model
{
    public abstract class Employee
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public DateTime DateEntre { get; set; }

        public Employee(string nom, string prenom, int age, DateTime dateEntre)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
            DateEntre = dateEntre;
        }

        public Employee()
        {
        }

        public string GetNom(Employee e)
        {
            return $"L'employé : {Nom} {Prenom}";
        }

        public override string ToString()
        {
            return $"L'employé: {Nom}  {Prenom}";
        }


        public abstract void CalculerSalaire();

    }
}
