using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptObjet.Heritage
{
    public class Animal
    {

        public string Nom { get; set; }
        public int Age { get; set; }

        public Animal(string nom, int age)
        {
            Nom = nom;
            Age = age;
        }

        public Animal()
        {
        }

        public override string ToString()
        {
            return $"Nom : {Nom} - Age : {Age}";
        }

        //le mot clef virtual permet aux classes enfant de pouvoir redéfinir cette méthode
        public virtual void Identite()
        {
            Console.WriteLine("Je suis un animal");
        }


        private void MethodPrive()
        {
            Console.WriteLine("private");
        }



    }
}
