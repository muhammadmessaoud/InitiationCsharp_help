using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Object_2.Model
{
    public class Dev : Salarie
    {
        public Manager Manager { get; } // Un dev ne peut modifier son manager
        public static int PERIODE_ESSAI_DEV { get; set; } = 2;


        public override void Pointer()
        {
            isHere = !isHere;
        }

        public Dev(string nom, int age, double salaire, Manager manager) : base(nom, age, salaire)
        {
            Manager = manager;
        }
    }
}
