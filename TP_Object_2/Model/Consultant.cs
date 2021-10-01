using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Object_2.Model
{
    public class Consultant : Salarie
    {
        public Manager Manager { get; } // Un consultant ne peut modifier son manager
        public static int PERIODE_ESSAI_CONSULTANT { get; set; } = 3;

        public override void Pointer()
        {
            isHere = !isHere;
        }

        public Consultant(string nom, int age, double salaire, Manager manager) : base(nom, age, salaire)
        {
            Manager = manager;
        }

    }
}
