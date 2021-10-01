using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Object_2.Model
{
    public class Manager : Salarie
    {
        public List<Salarie> Salaries { get; set; }

        public override void Pointer()
        {
            isHere = !isHere;
           /* if (isHere)
            {
                isHere = false;
            }
            else
            {
                isHere = true;
            }*/
        }

        public Manager(string nom , int age , double salaire ) : base (nom,age,salaire)
        {
            Salaries = new List<Salarie>();
        }
    }
}
