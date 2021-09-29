using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            string choix = "";
            double valeur1 = 0, valeur2 = 0;

            ////Affichage du menu
            //Console.WriteLine("**************Calculatrice console*************");
            //Console.WriteLine("-Choisir une opération:");
            //Console.WriteLine("-Addition: tapez a");
            //Console.WriteLine("-Soustraction : tapez s");
            //Console.WriteLine("-Multiplication : tapez m");
            //Console.WriteLine("-Division : tapez d");

            ////Récupérer le choix de l'utilisateur - si le choix n'est pas valide - on l'invite 
            ////à faire un autre choix
            //do
            //{
            //    Console.WriteLine("Faites votre choix:");
            //    choix = Console.ReadLine();
            //    if (choix == "a" || choix == "s" || choix == "m" || choix == "d")
            //    {
            //        break;
            //    }
            //} while (true);


            ////Demander la saisie de la valeur1
            //Console.WriteLine("Donnez valeur1:");
            //valeur1 = Convert.ToDouble(Console.ReadLine());

            ////Demander la saisie de la valeur2
            //Console.WriteLine("Donnez valeur2:");
            //valeur2 = Convert.ToDouble(Console.ReadLine());

            ////Afficher à la console le résultat
            //switch (choix)
            //{
            //    case "a":
            //        Console.WriteLine(valeur1+ "+"+valeur2 + "="+(valeur1+valeur2));
            //        break;
            //    case "s":
            //        Console.WriteLine(valeur1 + "-" + valeur2 + "=" + (valeur1 - valeur2));
            //        break;
            //    case "m":
            //        Console.WriteLine(valeur1 + "x" + valeur2 + "=" + (valeur1 * valeur2));
            //        break;
            //    case "d":
            //        Console.WriteLine(valeur1 + "/" + valeur2 + "=" + (valeur1 / valeur2));
            //        break;

            //}

            Module1.Menu();
            choix = Module2.Choix();
            valeur1 = Module3.Valeur();
            valeur2 = Module3.Valeur();
            Module4.BoucleSwicth(choix, valeur1, valeur2);

            //Maintenir la console active
            Console.ReadLine();
        }
    }
}
