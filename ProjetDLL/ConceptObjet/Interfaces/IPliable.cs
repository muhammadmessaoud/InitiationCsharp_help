using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptObjet.Interfaces
{
    public interface IPliable
    {
        //Interface: une pseudo classe abstraite, qui ne peut contenir que des signatures de méthodes non implémenter (méthodes abstraites)

        void Plier();
        void Deplier();
    }
}
