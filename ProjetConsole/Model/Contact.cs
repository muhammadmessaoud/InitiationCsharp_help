using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole.Model
{
    public class Contact
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Contact(int id, string nom, string prenom)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
        }

        public Contact()
        {
        }
    }
}
