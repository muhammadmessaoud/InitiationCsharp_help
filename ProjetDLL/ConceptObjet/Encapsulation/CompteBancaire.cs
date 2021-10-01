using ProjetDLL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptObjet.Encapsulation
{
    public class CompteBancaire : Object
    {
        #region Champs - Propriétés

        //Les propriéres sont appéelés ausis varibles de classe - possède des valeurs par défaut 
        //Propriété de type numériques: valeur par défaut = 0
        //Propriété boolean: valeur par défaut = false
        //Propriété de type objet (classe) valeur par défaut = null
        //Les variables utilisé dans les méthodes sont appelés variable local - doivent être initialisées

        public string Numero { get;  set; }
        public double Solde { get;  set; }

        //Attribut global 
        public static string Banque { get; set; } = "BNP";

        public static int Compteur { get; set; } = 0;


        #endregion

        #region Constructeurs
        //un constructeur est une méthode public qui porte le nom de la classe et dont le rôle est d'initialisé les attributs d'un objet


        //Un constructeur d'une classe peut appeler un autre constructeur de la même classe en utilisant le mot clef - this() / this(params)
        public CompteBancaire(string numero ,double solde) : this(numero)
        {
            Solde = solde;
        }

        public CompteBancaire(string numero) : this() // this() appel,le constructeur sans paramètre
        {
            Numero = numero;
        }

        public CompteBancaire()
        {
            Compteur++;
        }




        #endregion

        #region Methodes

        public void Depot(double montant)
        {
            Solde += montant;
        }

        /// <summary>
        /// Si le solde est inférieur au montant, la méthode renvoie une exception de type SoldeException
        /// </summary>
        /// <param name="montant"></param>
        public void Retrait(double montant)
        {
            if (Solde >= montant)
            {
               Solde -= montant;
            }
            else
            {
                throw new SoldeException($"Solde insuffisant pour effectuer un retrait de {montant}");
            }
        }


        //Methode toString() permet de personnaliser l'affichage des objets
        //Override : redéfinition
        public override string ToString()
        {
            return $"Numéro : {Numero} - Solde : {Solde}";
        }


        //Deux comptes bancaires sont égaux si ils ont le même numéro
        public override bool Equals(object obj)
        {
            /*return obj is CompteBancaire bancaire &&
                   Numero == bancaire.Numero;*/


            //Same as generated Equals()
            CompteBancaire cpt = (CompteBancaire)obj;

            return Numero == cpt.Numero;
        }




        #endregion


    }
}
