
using ProjetDLL;
using ProjetDLL.ConceptObjet.Encapsulation;
using ProjetVB.DLL;
using System;
using System.Collections.Generic;
using System.IO;

namespace ProjetConsole
{
    enum Profiles
    {
        ADMIN,
        MANAGER,
        RH
    }

    enum Etat
    {
        NEUF,
        EXCELLENT,
        BON,
        MAUVAIS
    }

    enum Authorisations
    {
        READ,
        WRITE,
        DELETE,
        ALL
    }

    class User
    {
        public string nom;
        public List<Authorisations> authorisations;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //ceci est un commentaire sur une ligne
            /*
             * ceci est un commentaire sur
             * plusieurs lignes
             */


            Console.WriteLine("test de c#");
            Tools.MaMethode();
            Class1.MaMethode();

            #region Variables
            Console.WriteLine("****************VARIABLES***************");

            //Variable: zone mémoire qui contient une valeur typée
            //Types simples (types valeur): entiers, réels, bool, char
            //Types complèxes (types réferences): tableau, string, dates, Classes (objets)

            //entiers: byte(1 o), short (2 o), int(4 o), long (8 o)
            //réels: flots(4 o), double(8 o), decimal (16 o)

            //déclaration d'une variable: type nom_variable = valeur
            int myInt = 10;

            int myInt2 = myInt;

            myInt = 20;

            Console.WriteLine("Contenu de myInt: "+myInt); //+: concaténation

            double myDouble = 10.5;
            char myChar = 'b';
            bool myBool = true;

            string maChaine = "b";

            string maChaine2 = maChaine;

            maChaine.ToUpper();

            //Mot Clé var: Inférence de type - c'est le compilateur qui détermine le type de la variable
            //selon sa valeur

            var maVariable = "10.5";
            //maVariable = 5; erreur de compilation

            //Types nullables: .net propose une syntaxe qui permet de définir des types simples null
            int? x = 1;

            //Avant utilisation de x, on doit vérifier qu'elle contient une valeur
            if (x.HasValue)
            {
                Console.WriteLine("x nest pas null");
            }
            else
            {
                Console.WriteLine("x est null");
            }

            string str = null;

            int age = 0;
            Console.WriteLine("Quel est votre age:");
            age = Convert.ToInt32(Console.ReadLine()); //si le user oublie de fournir l'age on aura 
                                                       //une erreur

            Console.WriteLine("Votre age est: "+age);

            //Contante: variable contenant une valeur qu'on ne peut pas modifier
            const double MA_CONSTANTE = 10.5;
            //MA_CONSTANTE = 25; -- Erreur de compilation


            #endregion

            #region Opérateurs
            Console.WriteLine("****************OPERATEURS***************");

            //Opérateurs mathématique:+, -, *, /, % (Modulo: reste de la division entière)
            Console.WriteLine("Reste de la division de 10 par 3: "+(10 % 3));

            //Opérateurs combinés: +=, -=, *= , /=
            myInt += 5; //myInt = myInt + 5

            //Opérateurs d'incrémentation et de décrémentation:
            int val = 0;
            Console.WriteLine("Pré incrémentation: "+(++val)); //incrémente val ensuite utilise sa valeur
            Console.WriteLine("Post incrémentation: "+(val++)); //utilise val ensuite l'incrémente de 1
            Console.WriteLine(++val + val++); //6
            Console.WriteLine(6+"5"+2); //652
            Console.WriteLine(  6+2+"5");//85
            Console.WriteLine("6"+5+2); //652

            //Opérateurs de comparaison: ==(égalité), <,>,<=,>=, !=(différent)
            //Opérateurs logiques: && (et logique), || (ou logique), ! (non logique), ^(ou exclusif)

            int v1 = 10, v2 = 15;
            Console.WriteLine( (v1>v2) && (v1<v2));
            //Table logique
            //A     B       A&&B    A||B    A^B
            //v     v        v        v     f
            //v     f        f        v     v
            //f     v        f        v     v
            //f     f        f        f     f





            #endregion

            #region Conversion de types
            Console.WriteLine("****************CONVERSIONS***************");

            //Conversion implicite: concerne le passage d'un type inférieur à un type supérieur
            byte myByte = 10;
            int myInt3 = myByte;

            //Conversion explicite: passage d'un type sup à un type inf - Risque de perte de données
            //Pour les conversions explicites on peut utiliser:
            //CAST: (int), (byte), (double)...
            //La classe Convert
            int myInt4 = 20;
            byte myByte2 = (byte)myInt4;
            byte myByte3 = Convert.ToByte(myInt4);

            string chaine = "25";
            int myInt5 = Convert.ToInt32(chaine);
            int myInt6 = int.Parse(chaine);

            #endregion

            #region Conditions
            Console.WriteLine("****************CONDITIONS***************");

            //Exprimer un test conditionnel: If(condition == vraie){instructions;}else{instructions;}

            int nb = 5;
            if (nb > 0)
            {
                Console.WriteLine("nb positif");
            }
            else if (nb == 0)
            {
                Console.WriteLine("nb est null");
            }
            else
            {
                Console.WriteLine("nb négatif");
            }

            //Switch: est une variante de la condition IF
            int note = 10;
            switch (note)
            {
                case 0:
                    Console.WriteLine("recalé");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Les 10, 11 et 12");
                    break;
                default:
                    Console.WriteLine("Autre note");
                    break;
            }

            //Opérateur ternaire:
            int maVar = (10 < 5)? 10 : 5; //maVar = 5
            #endregion

            #region Boucles
            Console.WriteLine("****************BOUCLES***************");

            //Boucles conditionnelles: While, do while
            //Boucles itératives: For, Foreach

            //For
            for (int i = 0; i < 10; i++)
            {
                //Passer à l'itération suivante si i == 3
                if (i == 3)
                {
                    continue;
                }

                Console.WriteLine("Passage n°: "+i);

                
                //Quitter la boucle for si i = 6
                if (i == 6)
                {
                    break; //permet de sortir de la boucle FOR
                }
            }

            //FOREACH
            int[] tab = { 1, 2, 3, 4 };
            foreach (int item in tab) //pour chaque int item contenu dans la tableau tab
            {
                Console.WriteLine(item);
            }

            //While
            int valeur = 1;

            while (valeur < 5) //Tant que valeur est inférieur à 5
            {
                Console.WriteLine("Passage n°: "+valeur);
                valeur++;
            }

            //Do While: s'execute au moins une fois

            do
            {
                Console.WriteLine("Passage n°: "+valeur);
                valeur++;
            } while (valeur < 10);


            //
          

            //si l'age est compris entre 18 et 60 // Afficher valide - sinon age non - saisir un 
            //nouveau age

            do
            {
                Console.WriteLine("Quel est votre age:");
                int ageUser = Convert.ToInt32(Console.ReadLine());
                if (ageUser>= 18 && ageUser <= 60)
                {
                    break;
                }
            } while (true);
            #endregion

            #region Tableaux
            Console.WriteLine("****************TABELAUX***************");

            //Tableau: un ensemble d'éléments typés

            //1 dimension

            //Déclaration d'un tableau
            int[] tableau = new int[3]; //tableau de 3 cases
            tableau[0] = 10;
            tableau[1] = 20;
            tableau[2] = 30;
            Console.WriteLine("Taille du tableau: "+tableau.Length); //3

            //Parcours du tableau avec la boucle foreach
            foreach (int item in tableau)
            {
                Console.WriteLine(item);
            }

            //Parcours du tableau avec la boucle FOR
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine(tableau[i]);
            }

            //2ème façon de déclarer un tableau
            int[] tableau2 = { 10, 20, 30 };

            //2 dimensions
            int[    ,   ] matrice = new int[2, 3];
            matrice[0, 0] = 10;
            matrice[0, 1] = 20;
            matrice[0, 2] = 30;
            matrice[1, 0] = 40;
            matrice[1, 1] = 50;
            matrice[1, 2] = 60;

            int[,] matrice2 = { {10,15,58 }, {12,25,32 } }; //autre façon de déclarer un tableau à 2 dimensions

            Console.WriteLine("Nombre de lignes de la matrice2: "+matrice2.GetLength(0)); //2
            Console.WriteLine("Nombre de colonnes de la matrcie2: "+matrice2.GetLength(1)); //3
            Console.WriteLine("Nombre total d'élements de matrice2: "+matrice2.Length); //6
            Console.WriteLine("Nombre de dimensions de matrice2: "+matrice2.Rank); //2

            #endregion

            #region Méthodes

            Console.WriteLine("****************METHODES***************");

            //Méthode: un ensemble d'instructions réutilisables
            //Dans la programmation objet on a 2 types de méthodes:
            //Procédures: méthode qui ne renvoie aucune valeur (void)
            //Fonctions: méthode qui renvoie un résultat  - on doit préciser le type du résultat renvoyé
            //Déclaration d'une méthode: Visilité [mot-clé static] type_retour Nom_Methode(paramétres) { instructions; }


            int resultat = MesMethodes.Somme(10, 20);
            Console.WriteLine(resultat);

            MesMethodes.Afficher();

            int[] monTableau = { 10, 0, 20, 15,2,25 };

            MesMethodes.Afficher(monTableau);
            Console.WriteLine("Somme des éléments du tableau: "+MesMethodes.Somme(monTableau));
            Console.WriteLine("Moyenne des éléments du tableau: "+MesMethodes.Moyenne(monTableau));
            Console.WriteLine("L'élément le plus petit du tableau: "+MesMethodes.Minimum(monTableau));

            //Appel de la méthode avec des params optionnels
            MesMethodes.SommeOptional(10, 20); //Valeur par defaut de z qui est prise en compte
            MesMethodes.SommeOptional(10, 20, 50);

            int val1 = 10, val2 = 20;

            //Concténation +
            Console.WriteLine("concaténation: "+MesMethodes.Somme(val1, val2));

            //Interpolation
            Console.WriteLine($"Avant permutation: val1 = {val1} - val2 = {val2}");

            MesMethodes.Permuter(ref val1, ref val2);

            Console.WriteLine($"Après permutation val1 = {val1} - val2 = {val2}");

            //Appel de méthode avec des paramétres en sortie

            double sum = 0, moyenne = 0;
            double produit = MesMethodes.Calculer(10, 20, out sum, out moyenne);
            Console.WriteLine($"Produit = {produit}");
            Console.WriteLine($"sum = {sum}");
            Console.WriteLine($"moyenne = {moyenne}");

            //Appel de la méthode avec un nombre variable d'arguments
            MesMethodes.Produit(10, 20);
            MesMethodes.Produit(10, 20, 30);
            MesMethodes.Produit(10, 20, 30, 40);

            //Authentification ok
            //ok



            #endregion

            #region Dates

            Console.WriteLine("******************DATES****************");

            //Création d'objets de type Date

            DateTime dt = DateTime.Now;
            Console.WriteLine($"Date avec DateTime.Now: {dt}");

            DateTime dt2 = DateTime.Today;
            Console.WriteLine($"Date avec DateTime.Today: {dt2}");

            DateTime dt3 = new DateTime(2019, 5, 1, 15, 23, 45);
            Console.WriteLine($"Date avec appel du constructeur new: {dt3}");

            Console.WriteLine("Comparaison de dt et dt2 avec CompareTo: "+dt.CompareTo(dt2)); // 1
            Console.WriteLine("Egalité de dt et dt2: "+dt.Equals(dt2)); //false

            //Opérations
            Console.WriteLine("Ajouter 2 et demi jours à dt: "+dt.AddDays(2.5));

            Console.WriteLine("dt - dt2: "+dt.Subtract(dt2));
            Console.WriteLine("dt2 - dt: "+dt2.Subtract(dt));

            //Recherhes
            Console.WriteLine("Date de dt: "+dt.Date);
            Console.WriteLine("Jour du mois de dt: "+dt.Day);
            Console.WriteLine("Jour de la semaine de dt: "+dt.DayOfWeek);
            Console.WriteLine("Jour de l'année de dt: "+dt.DayOfYear);

            //Formattage des objets de type DateTime
            Console.WriteLine("Format long de Date: "+dt.ToLongDateString());
            Console.WriteLine("Format court de Date: "+dt.ToShortDateString());
            Console.WriteLine("Format long de Time: "+dt.ToLongTimeString());
            Console.WriteLine("Format court de Time: "+dt.ToShortTimeString());



            #endregion

            #region Enum

            //Enum: une liste de constantes

            Console.WriteLine("*****************ENUM***************");

            Etat etat = Etat.EXCELLENT;
            Console.WriteLine(etat);

            Console.WriteLine("Quel le code votre profil(0,1,2): ");
            int codeProfil = Convert.ToInt32(Console.ReadLine());

            Profiles profil = (Profiles)codeProfil;
            Console.WriteLine("Votre profil est: "+profil);

            User user = new User();
            user.nom = "nomUser";
            user.authorisations = new List<Authorisations> { Authorisations.READ, Authorisations.WRITE, Authorisations.DELETE };
            bool suppression = false;

            foreach (var auth in user.authorisations)
            {
                if (auth.Equals(Authorisations.DELETE))
                {
                    suppression = true;
                }
            }

            if (suppression)
            {
                Console.WriteLine("User peut faire des suppressions");
            }
            else
            {
                Console.WriteLine("Opération interdite");
            }



            #endregion

            #region Concept objets

            //Encapsulation - Heritage - Abstraction - Polymorphisme - Agrégation 

            Console.WriteLine("***********************CCONCEPT OBJETS**************************");

            double longueur = 20;
            double largeur = 15;
            double surface = Surface(longueur , largeur);

            double longueur1 = 20;
            double largeur1 = 15;
            double surface1 = Surface(longueur1 , largeur1);

            //Mise en place de l'encapsulation 
            //1 - Rasembler dans une seule et même classe les paramètres et les fonctions qui concernent le même objet 
            //2 - Empêcher l'accès public aux attributs
            //3 - L'accès aux attributs d'une classe doit forcément passer par les Getters / Setters;

            /* Rectangle rec = new Rectangle();
             rec.SetLargeur(15);
             rec.SetLongueur(20);
             rec.Surface();

             Rectangle rec2 = new Rectangle();
             rec.SetLargeur(-15);
             rec.SetLongueur(50);
             rec2.Surface();
             Console.WriteLine(rec2.GetLargeur());*/


            //toutes classes possède un constructeur par défaut - Une méthode qui porte le nom de la classe

            CompteBancaire compte = new CompteBancaire();
            compte.Numero = "145gty";
            compte.Solde = 1500;

            compte.Depot(1000);
            compte.Retrait(500);

            CompteBancaire compte2 = new CompteBancaire("sdd122", 2500);
            Console.WriteLine(compte2);


            CompteBancaire compte3 = new CompteBancaire();
            Console.WriteLine($"Compte3 avec constructeur par défautl : {compte3}");



            #endregion






            //Maintenir la console active
            Console.ReadLine();
            
        }

        private static double Surface(double longueur, double largeur)
            {
                return longueur * largeur ;
            }

    }
}
