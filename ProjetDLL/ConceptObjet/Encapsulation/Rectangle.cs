using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptObjet.Encapsulation
{
    public class Rectangle
    {
        /*private double largeur;
        private double longueur;
        private int age;


        public int GetAge()
        {
            return age;
        }

        public void SetAge(int value)
        {
            if (value >= 15 && value <= 60 )
            {
                age = value;
            }
            else
            {
                Console.WriteLine("L'age doit être compris entre 18 et 60");
            }
        }

        public double GetLargeur()
        {
            Console.WriteLine("Merci de fournir votremot de passe : ");
            string pass = Console.ReadLine();
            if (pass.Equals("admin"))
            {
            return largeur;
            }
            else
            {
                Console.WriteLine("Accès refusé");
                return 0;
            }
        }

        public void SetLargeur(double value)
        {
            if (value < 0)
            {
                Console.WriteLine("La largeur ne peut être negative");
            }
            else
            {
            largeur = value;
            }
        }

        public double GetLongueur()
        {
            return longueur;
        }

        public void SetLongueur(double value)
        {
            if (value < 0)
            {
                Console.WriteLine("La largeur ne peut être negative");
            }
            else
            {
                longueur = value;

            }

        }


        public double Surface()
        {
            return largeur * longueur;
        }*/


        //Propriété full - contient le champ privé plus la propriété (getters / setters)

        private double largeur;

        public double Largeur
        {
            get { return largeur; }
            set
            {
                if (value > 0 )
                {
                largeur = value;
                }
                else
                {
                    Console.WriteLine("Largeur ne peut être négative");
                }
            }
        }

        //propriété automatique

        public double Longueur { get; set; }

        //Si les attributs possède des contraintes on utilise une propriété full (champ privé + la propriété) 
        //Si les attributs ne contiennent pas de contraintes, on utilise une propriété automatique



    }
}
