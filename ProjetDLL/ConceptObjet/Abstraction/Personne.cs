using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptObjet.Abstraction
{
    public abstract class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Personne(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        public Personne()
        {
        }

        public override string ToString()
        {
            return $"Nom: {Nom} - Prenom : {Prenom}";
        }

        public virtual void Afficher()
        {

        }

        //Methode abstraite -  traitement que toutes les classes enfants doivent implémenter;
        public abstract void Identite();

    }
}
