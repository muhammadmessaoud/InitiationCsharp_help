using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptObjet.Heritage
{
    public class Chat : Animal
    {
        public override void Identite()
        {
            Console.WriteLine("Je suis un chat");
        }

        //le mot clef - base() / base(params) - nous permet d'appeler le constructeur de la classe parente (classe de base)
        public Chat(string nom, int age) : base(nom, age)
        {
            
        }

        public Chat()
        {

        }

    }
}
