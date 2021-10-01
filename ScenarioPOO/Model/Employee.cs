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
        public string Date { get; set; }

        public Employee(string nom, string prenom, int age, string date)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
            Date = date;
        }

        public Employee()
        {
        }

        public virtual string GetNom()
        {
            return "L'employé : " + Nom + " " + Prenom + " ";
        }


        public abstract double CalculerSalaire();                            

    }
}
