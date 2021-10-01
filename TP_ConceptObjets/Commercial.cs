using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_ConceptObjets
{
    public abstract class Commercial : Employe
    {
       
        public double ChiffreAffaire { get; set; }
        protected Commercial(string nom, string prenom, int age, string dateEntree, double chiffreAffaire) : base(nom, prenom, age, dateEntree)
        {
            ChiffreAffaire = chiffreAffaire;
        }

    }
}
