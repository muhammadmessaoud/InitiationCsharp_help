using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_ConceptObjet2
{
    public class Manager : Salarie
    {
       

        public List<Salarie> Salaries { get; set; }

        public override void Pointer()
        {
            IsPresent = !IsPresent;
            //if (IsPresent)
            //{
            //    IsPresent = false;
            //}
            //else
            //{
            //    IsPresent = true;
            //}
        }

        public Manager(string nom, int age, double salaire) : base(nom, age, salaire)
        {
            Salaries = new List<Salarie>();
        }
    }
}
