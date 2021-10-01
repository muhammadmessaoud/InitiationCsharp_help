using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_ConceptObjets
{
    class Program
    {
        static void Main(string[] args)
        {
            Personnel p = new Personnel();
            p.ajouterEmploye(new Vendeur("Pierre", "Business", 45, "1995", 30000));
            p.ajouterEmploye(new Representant("Léon", "Vendtout", 25, "2001", 20000));
            p.ajouterEmploye(new Technicien("Yves", "Bosseur", 28, "1998", 1000));
            p.ajouterEmploye(new Manutentionnaire("Jeanne", "Stocketout", 32, "1998", 45));
            p.ajouterEmploye(new TechnARisque("Jean", "Flippe", 28, "2000", 1000));
            p.ajouterEmploye(new ManutARisque("Al", "Abordage", 30, "2001", 45));
            p.calculerSalaires();
            Console.WriteLine("Le salaire moyen dans l'entreprise est de " + p.salaireMoyen() + " Euros.");
            //garder la console ouverte (en attendant d'appuyer sur une touche)
            Console.ReadKey();

        }
    }
}
