using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_ConceptObjet2
{
    public class Dev : Salarie
    {
       

        public Manager Manager { get; }
        public static int PERIODE_ESSAI_DEV { get; set; } = 2;

        public override void Pointer()
        {
            IsPresent = !IsPresent;
        }
        public Dev(string nom, int age, double salaire, Manager manager) : base(nom, age, salaire)
        {
            Manager = manager;
        }
    }
}
