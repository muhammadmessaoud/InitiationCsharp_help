using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_ConceptObjet2
{
    public abstract class Salarie
    {
        public string Nom { get; set; }
        public bool IsPresent { get; set; }
        private int age;

        public int Age
        {
            get { return age; }
            set {
                if (value >= 18 && value <= 62)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age doit être compris entre 18 et 62 ans");
                }
                
            }
        }

        private double salaire;

        public double Salaire
        {
            get { return salaire; }
            private set {
                if (value >= 2000)
                {
                    salaire = value;
                }
                else
                {
                    Console.WriteLine("Le salaire minimum est de 2000 euros");
                }
                
            }
        }

        public abstract void Pointer();

        public override bool Equals(object obj)
        {
            return obj is Salarie salarie &&
                   Nom == salarie.Nom;
        }

        protected Salarie(string nom, int age, double salaire)
        {
            Nom = nom;
            Age = age;
            Salaire = salaire;
        }

        public void ModifierSalaire(double nouveauSalaire, Salarie salarie)
        {
            //Seul un Manager peut modifier le salaire
            if (this.GetType() == typeof(Manager))
            {
                salarie.salaire = nouveauSalaire;
                Console.WriteLine("Salaire mis à jours");
            }
            else
            {
                Console.WriteLine("Vous n'être autorisé à executer cette action");
            }
        }
    }
}
