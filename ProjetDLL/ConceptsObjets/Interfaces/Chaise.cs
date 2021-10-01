using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptsObjets.Interfaces
{
    public class Chaise : IPliable
    {
        public void Deplier()
        {
            Console.WriteLine("Déplier");
        }

        public void Plier()
        {
            Console.WriteLine("Plier");
        }
    }
}
