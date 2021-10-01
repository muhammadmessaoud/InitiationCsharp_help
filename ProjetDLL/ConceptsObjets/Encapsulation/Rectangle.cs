using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptsObjets.Encapsulation
{
    public class Rectangle
    {
        //private double largeur;
        //private double longueur;
        //private int age;

        //public int GetAge()
        //{
        //    return age;
        //}

        //public void SetAge(int value)
        //{
        //    if (value >= 18 && value <= 60)
        //    {
        //        age = value;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Age doit être compris entre 18 et 60");
        //    }
        //}

        //public double GetLargeur()
        //{
        //    Console.WriteLine("Merci de fournir votre mot de passe:");
        //    string pass = Console.ReadLine();
        //    if (pass.Equals("admin"))
        //    {
        //        return largeur;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Accés refusé");
        //        return 0;
        //    }

        //}

        //public void SetLargeur(double value)
        //{
        //    if (value < 0)
        //    {
        //        Console.WriteLine("La largeur ne peut être négative");
        //    }
        //    else
        //    {
        //        largeur = value;

        //    }
        //}

        //public double GetLongueur()
        //{
        //    return longueur;
        //}

        //public void SteLongueur(double value)
        //{
        //    longueur = value;
        //}

        //public double Surface()
        //{
        //    return largeur * longueur;
        //}


        //Propriété full - contient le champ privé + la propriété (Getteur/Setteur)

        private double largeur;

        public double Largeur
        {
            get { return largeur; }
            set {
                if (value > 0)
                {
                    largeur = value;

                }
                else
                {
                    Console.WriteLine("Largeur ne peut être négative");
                }
            }
        }

        //Propriété automatique

        public double Longueur { get; set; }

        //Si les attributs possèdent des contraintes on utilise une propriété full (champ privé + propriété)
        //Si les attributs ne contient de contraintes, on utilise une propriété automatique


    }
}
