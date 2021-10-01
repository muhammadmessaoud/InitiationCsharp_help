using ProjetDLL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjetDLL.ConceptsObjets.Encapsulation
{
    [DataContract] // cette annotation informe le compilateur que les objets de type CompteBancaire sont sérializable en json
    [Serializable]//cette annotation informe le compilateur que les objets de type CompteBancaire sont sérializables en binaire
    public class CompteBancaire : Object
    {
        #region Champs- Propriétés
        //Les propriété sont appelées aussi variables de classe - possédent des valeurs par defaut
        //Propriétés de type numerique: valeur par defaut = 0
        //Propriétés Boolean: valeur par defaut = false
        //Propriétés de type objet(classe) valeur par defaut = null
        //Les variables utilisées dans les méthodes sont appelées variables locales - doivent être initialisées

        [DataMember] // champ sérializable en json
        public string Numero { get; set; }
        //[XmlIgnore] permet d'ignorer ce champ pour la sérialisation xml
        //[NonSerialized] permet d'ignorer ce champ pourla sérialisation binaire
        [DataMember] 
        public double Solde { get; set; }

        //Attribut global
        public static string Banque { get; set; } = "BNP";
        public static int Compteur { get; set; } = 0;

        #endregion

        #region Constructeurs
        //Un constructeur est une méthode public qui porte le nom de la classe et dont le rôle est d'initialiser
        //les attributs de l'objet

        //Un constructeur d'une classe peut appelé un autre constructeur de la même classe en utilisant me mot clé this()

        public CompteBancaire(string numero, double solde) : this(numero)
        {
           
            Solde = solde;
            
        }

        public CompteBancaire(string numero) : this() //this() appel le constructeur sans paramétres
        {
            
            Numero = numero;
            
        }


        public CompteBancaire()
        {
            Compteur++;
        }


        #endregion

        #region Méthodes

        public void Depot(double montant)
        {
            Solde += montant;
        }


        /// <summary>
        /// Si le solde est inférieur au montant, la méthode génére une exception de type SoldeException
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
                //Console.WriteLine("Solde insuffisant");
                throw new SoldeException($"Solde insuffisant pour effectuer un retrait de {montant}");
            }
        }



        //Méthode ToString: permet de personnaliser l'affichage des objets
        //Override: redéfinition
        public override string ToString()
        {
            return $"Numéro: {Numero} - Solde: {Solde}";
        }

        //2 comptes bancaires sont egaux s'ils ont le même numéro
        public override bool Equals(object obj)
        {
            //return obj is CompteBancaire bancaire &&
            //       Numero == bancaire.Numero;

            CompteBancaire cpt = (CompteBancaire)obj;

            return Numero == cpt.Numero;

        }



        #endregion


    }
}
