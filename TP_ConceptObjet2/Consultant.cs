using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_ConceptObjet2
{
    public class Consultant : Salarie
    {
      
        public Manager Manager { get; } //Un consultant ne peut modifier son Manager
        public static int PERIODE_ESSAI_CONSULTANT { get; set; } = 3;

        public override void Pointer()
        {
            IsPresent = !IsPresent;
        }
        public Consultant(string nom, int age, double salaire, Manager manager) : base(nom, age, salaire)
        {
            Manager = manager;
        }
    }
}
