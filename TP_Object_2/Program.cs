using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Object_2.Model;

namespace TP_Object_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Salarie dev = new Dev("dev", 25, 2500, null);

            Salarie manager = new Manager("manager", 25, 4000 );

            manager.ModifierSalaire(3500, dev);

            Console.WriteLine(dev.Salaire);

            Console.ReadLine();

        }
    }
}
