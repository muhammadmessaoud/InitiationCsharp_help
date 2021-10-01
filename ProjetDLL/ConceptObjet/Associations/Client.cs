using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptObjet.Associations
{
    public class Client
    {
        public string Nom { get; set; }
        public Adresse Adresse { get; set; } //Association: un objet de type Adresse qui fait parti des attributs d'un objet client
    }
}
