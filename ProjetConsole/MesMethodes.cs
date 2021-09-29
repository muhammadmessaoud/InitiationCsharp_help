using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    public class MesMethodes
    {
        //Une classe peut contenir 2 types de méthodes
        //Méthode de classe - méthode static accéssibles via la classe directement
        //Méthode d'instance : pas de mot static - accéssibles via une instance de la classe (donc via un objet de la classe)

        /// <summary>
        /// Méthode calcule la somme de 2 entiers
        /// </summary>
        /// <param name="x">est un entier</param>
        /// <param name="y">est un entier</param>
        /// <returns>est un entier. Somme de x et y</returns>
        public static int Somme(int x, int y)
        {
            return x + y;
        }

        //Surcharge(overload): le fait de pouvoir définir la même méthode dans la même classe avec uniquement la liste des paramétres qui change


        public static double Somme(double x, double y)
        {
            return x + y;
        }

        public static void Afficher()
        {
            Console.WriteLine("Méthode void sans type de retour.");
        }

        //Méthode pour lister le contenu d'un tableau

        public static void Afficher(int[] tab)
        {
            foreach (var item in tab)
            {
                Console.WriteLine(item);
            }
        }

        //Méthode qui renvoie la somme des éléments d'un tableaux d'entiers

        public static int Somme(int[] tab)
        {
            int som = 0;
            foreach (var item in tab)
            {
                som += item;
            }

            return som;
        } 

        //Méthode qui renvoie la moyenne des éléments d'un tableau d'entiers: somme elements / nombre elements

        public static double Moyenne(int[] tab)
        {
            double som = 0;
            foreach (var item in tab)
            {
                som += item;
            }
            return som / tab.Length;
        }

        //Méthode qui renvoie l'élément le plus petit d'un tableau d'entiers
        public static int Minimum(int[] tab)
        {
            int min = tab[0];
            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i] < min)
                {
                    min = tab[i];
                }
            }
            return min;
        }

        //Paramétres optionnels d'une méthode
        //Se sont des params qui possèdent des valeurs par defaut et doivent être définis à la fin de la liste des params
        public static int SommeOptional(int x, int y, int z = 10)
        {
            return x + y + z;
        }

        //Méthode qui permute 2 entiers
        //Ref: concerne que les types simples (types valeur) 
        //Passage de paramétres par réference

        public static void Permuter(ref int x, ref int y)  //x = 10, y = 20;
        {
            int temp = x; //10
            x = y; //20
            y = temp; //10
        }

        //Paramétres en sortie
        public static double Calculer(double x, double y, out double somme, out double moyenne )
        {
            moyenne = (x + y) / 2;
            somme = x + y;
            return x * y;
        }

        //Nombre variable de paramétres d'une méthode

        //public static int Produit(int x, int y)
        //{
        //    return x * y;
        //}

        //public static int Produit(int x, int y, int z)
        //{
        //    return x * y * z;
        //}

        //public static int Produit(int x, int y, int z, int a)
        //{
        //    return x * y * z * a;
        //}
       
        public static int Produit(params int[] tab)
        {
            int prod = 1;
            foreach (var item in tab)
            {
                prod *= item;
            }

            return prod;
        }
    }
}
