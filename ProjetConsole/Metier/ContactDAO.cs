using ProjetConsole.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole.Metier
{
    public class ContactDAO : IContact
    {
        public void Delete(Contact c)
        {
            //DELETE FROM Contact WHERE ID = ID
            throw new NotImplementedException();
        }

        public List<Contact> getAll()
        {
            //
            throw new NotImplementedException();
        }

        public Contact GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Contact c)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact c)
        {
            throw new NotImplementedException();
        }
    }
}
