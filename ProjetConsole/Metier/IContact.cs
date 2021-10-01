using ProjetConsole.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole.Metier
{
    public interface IContact
    {
        List<Contact> getAll();
        void Insert(Contact c);
        void Delete(Contact c);
        void Update(Contact c);
        Contact GetById(int id);
    }
}
