﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Object_2.Model
{
    public abstract class Salarie
    {
        public string Nom { get; set; }
        public bool isHere { get; set; }

        private int age;
        public int Age
        {
            get { return age; }
            set {
                if (value >= 18 && value <= 62)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age ndoit être compris entre 18 et 62 ans");
                }
            }
        }

        private double salaire;
        public double Salaire
        {
            get { return salaire; }
            private set {
                if (value >= 2000)
                {
                    salaire = value;
                }
                else
                {
                    Console.WriteLine("Salaire minimum de 2000€ ");
                }
            }
        }

        public abstract void Pointer();

        public override bool Equals(object obj)
        {
            return obj is Salarie salarie &&
                   Nom == salarie.Nom;
        }

        protected Salarie(string nom, int age, double salaire)
        {
            Nom = nom;
            Age = age;
            Salaire = salaire;
        }

        public void ModifierSalaire(double newSalary, Salarie s)
        {
            //Seul un manager peut modifier le salaire
            if (this.GetType() == typeof(Manager))
            {
                s.salaire = newSalary;
                Console.WriteLine("Salaire mis à jour");
            }
            else
            {
                Console.WriteLine("Vous n'êtes pas autorisé a executer cette action");
            }
        }
    }
}
