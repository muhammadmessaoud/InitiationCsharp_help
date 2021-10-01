using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Conjugaison
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objectif: extractions, comparaisons et conténations de chaines

            //Les sujets
            string[] sujets = { "Je", "Tu", "Il/Elle", "Nous", "Vous", "Ils/Elles" };

            //Les terminaisons
            string[] terminaisons = { "e", "es", "e", "ons", "ez", "ent" };

            //Verbe du premier groupe se terminat par er autre que le verbe aller
            string verbe = null;

            //Demander la saisie d'un verbe se terminant par er autre que aller - Tant que le verbe n'est valide le user doit fournir un autre verbe
            while (true)
            {
                Console.WriteLine("Saisissez un verbe se terminat par er autre que aller:");
                verbe = Console.ReadLine();
                if (verbe.EndsWith("er") && !verbe.Equals("aller"))
                {
                    break;
                }
            }

            //Afficher le verbe conjugué
            //Eliminer le er du verbe
            string radical = verbe.Substring(0, verbe.Length - 2);


            for (int i = 0; i < sujets.Length; i++)
            {
                Console.WriteLine(sujets[i]+" "+radical+terminaisons[i]);
            }


            Console.ReadLine();

        }
    }
}
