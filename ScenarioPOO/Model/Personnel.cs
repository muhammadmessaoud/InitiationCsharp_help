using ProjetConsole.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScenarioPOO.Model
{
    public class Personnel
    {
        //Correction Mourad
        //public List<Employee> Employes { get; set; } = new List<Employe>(); ou l'initialisé dans le constructeur
        //Tous les attributs de type dictionnaire....
        //Bonne pratique les initialisé dans le constructeur par défault

        public Employee[] personnel;

        private int NbrEmployee;
        
        public Personnel()
        {
            personnel = new Employee[100];
            NbrEmployee = 0;
        }

        /*public void ajouter(Employee e)
        {
            Employee.Add(e);
        }
        */

        public void ajouterEmployee(Employee e)
        {
            NbrEmployee++;
            if (NbrEmployee <= 100)
            {
                personnel[NbrEmployee - 1] = e;
            }
        }

        public double salaireMoyen()
        {
            double total = 0;
            /*
             * foreach (Employe in Employes)
             * {
             * cw (employe.GetNom()+"a pour salaire" +employe.CalculerSalaire());
             * }
             */
            for (int i = 0; i < NbrEmployee; i++)
            {
                total += personnel[i].CalculerSalaire();
            }
            return total / NbrEmployee;
        }

        public void calculerSalaire()
        {

            /* double somme = 0; 
             * foreach (Employee employee in Employes)
            {
                somme += e.CalculerSalaire(); 
            }
            return somme / Employes;
             */

            for (int i = 0; i < NbrEmployee; i++)
            {
                Console.WriteLine(personnel[i].GetNom() + "gagne " + personnel[i].CalculerSalaire() + "euros");
            }
        }

    }
}
