using ProjetConsole.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScenarioPOO.Model
{
    public abstract class Salaire : Employee
    {
        public double ChiffreAffaire { get; set; }

        protected Salaire(string nom , string prenom, int age, string date , double chiffreAffaire) : base (nom , prenom , age , date )
        {
            ChiffreAffaire = chiffreAffaire;
        }

        public double getChiffreAffaire()
        {
            return ChiffreAffaire;
        }

    }
}
