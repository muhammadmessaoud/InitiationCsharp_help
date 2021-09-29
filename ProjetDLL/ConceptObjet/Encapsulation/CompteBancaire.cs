using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptObjet.Encapsulation
{
    public class CompteBancaire
    {
        #region Champs - Propriétés

        //Les propriéres sont appéelés ausis varibles de classe - possède des valeurs par défaut 
        //Propriété de type numériques: valeur par défaut = 0
        //Propriété boolean: valeur par défaut = false
        //Propriété de type objet (classe) valeur par défaut = null
        //Les variables utilisé dans les méthodes sont appelés variable local - doivent être initialisées

        public string Numero { get;  set; }
        public double Solde { get;  set; }




        #endregion

        #region Constructeurs
        //un constructeur est une méthode public qui porte le nom de la classe et dont le rôle est d'initialisé les attributs d'un objet

        public CompteBancaire(string numero, double solde)
        {
            Numero = numero;
            Solde = solde;
        }

        public CompteBancaire()
        {
        }




        #endregion

        #region Methodes

        public void Depot(double montant)
        {
            Solde += montant;
        }

        public void Retrait(double montant)
        {
            if (Solde >= montant)
            {
               Solde -= montant;
            }
            else
            {
                Console.WriteLine("Solde insuffisant");
            }
        }


        //Methode toString() permet de personnaliser l'affichage des objets
        //Override : redéfinition
        public override string ToString()
        {
            return $"Numéro : {Numero} - Solde : {Solde}";
        }



        #endregion


    }
}
