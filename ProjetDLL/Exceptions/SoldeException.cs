using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Exceptions
{
    /*Pour créer ses propres exceptions:
     * 1- Hériter de la classe Exception
     * 2- Appeler le constructeur de la classe Exception
     * 
     */
    public class SoldeException : Exception
    {
        public SoldeException(string message) : base(message)
        {

        }
    }
}
