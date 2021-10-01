using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_ConceptObjet2
{
    class Program
    {
        static void Main(string[] args)
        {
            Salarie dev = new Dev("dev", 25, 2500, null);
            //dev.Salaire = 4000;

            dev.ModifierSalaire(10000, dev);
            
            

            Salarie manager = new Manager("manager", 30, 4000);

            manager.ModifierSalaire(3500, dev);

            Console.WriteLine(dev.Salaire);

            Console.ReadLine();
        }
    }
}
