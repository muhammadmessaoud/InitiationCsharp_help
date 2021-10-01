using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_ConceptObjets
{
    public class Personnel
    {
        public List<Employe> Employes { get; set; }

        //Tous les attributs de type collections : list, tableau, dictionnaire.........
        //Bonne pratique: les initialiser dans le constructeur par defaut

        public Personnel()
        {
            Employes = new List<Employe>();
        }

        public void ajouterEmploye(Employe e)
        {
            Employes.Add(e);
        }

        public void calculerSalaires()
        {
            foreach (Employe employe in Employes)
            {
                Console.WriteLine(employe.GetNom()+" à pour salaire "+employe.CalculerSalaire());
            }
        }

        public double salaireMoyen()
        {
            double somme = 0;
            foreach (Employe employe in Employes)
            {
                somme += employe.CalculerSalaire();
            }

            return somme / Employes.Count;
        }
    }
}
