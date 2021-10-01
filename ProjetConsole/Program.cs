
using ProjetConsole.Metier;
using ProjetConsole.Model;
using ProjetDLL;
using ProjetDLL.ConceptsObjets.Abstraction;
using ProjetDLL.ConceptsObjets.Association;
using ProjetDLL.ConceptsObjets.Encapsulation;
using ProjetDLL.ConceptsObjets.Heritage;
using ProjetVB.DLL;
using System;
using System.Collections;
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

            #region Concepts objets

            //Encapsulation - Héritage - Abstraction - Polymorphisme - Agrégation (association - composition)

            Console.WriteLine("*************CONCEPTS OBJETS************");

            double longueur = 20;
            double largeur = 15;
            double surface = Surface(longueur, largeur);
            

            double longueur1 = 20;
            double largeur1 = 15;
            double surface1 = Surface(longueur, largeur);

            //Mise en place de l'encapsulation
            //1- Rassembler dans une seule et même classe les params et les fonctions qui concernent le même objet
            //2- Empecher l'accès public aux attributs
            //3- L'accés aux attributs d'une classe doit forcément passé par les Getteurs / Setteurs

            //Rectangle rec = new Rectangle();
            //rec.SetLargeur(15);
            //rec.SetLargeur( 20);
            //rec.Surface();

            //Rectangle rec2 = new Rectangle();
            //rec2.SetLargeur(-15);
            //rec2.SetLargeur(50);
            //rec2.Surface();

            //Console.WriteLine(rec2.GetLargeur());

            //Toute classe possède un constructeur par defaut - Une méthode qui porte le nom de la classe

            CompteBancaire compte = new CompteBancaire(); //1
            compte.Numero = "145gty";
            compte.Solde = 1500;

            CompteBancaire compte2 = new CompteBancaire("sdd122", 2500); //2

            compte.Depot(1000);
            compte.Retrait(500);

            Console.WriteLine(compte2);

            CompteBancaire compte3 = new CompteBancaire(); //3
            Console.WriteLine($"Compte3 avec constructeur par defaut: {compte3}");

            CompteBancaire compte4 = new CompteBancaire("dhdf12", 2500); //4

            Console.WriteLine("Compte2 est égale à Compte4: "+compte2.Equals(compte4));

            //Héritage

            Animal animal = new Animal();
            animal.Nom = "Animal";
            animal.Age = 5;

            Chat chat = new Chat();
            chat.Nom = "chat";
            chat.Age = 3;
            chat.Identite();

            Animal animal1 = new Animal("animal1", 5);
            Chat chat2 = new Chat("chat2", 4);

            Chien chien = new Chien("chien", 4, "caniche");

            Animal animal3 = new Animal();
            Animal animal4 = new Chat();
            Animal animal5 = new Chien();

            //Un objet de type animal peut prendre plusieurs formes - Polymorphisme - est une conséquence de l'héritage
            //Intérêt: pouvoir manipuler des objets sans se soucier de leur type

            string[] tabString = new string[2];
            tabString[0] = "test";
            tabString[1] = "test1";

            //Collection polymorphique
            Animal[] animaux = new Animal[3];
            animaux[0] = new Animal();
            animaux[1] = new Chat();
            animaux[2] = new Chien();

            object obj = 1;
            object obj1 = "chaine";
            object obj2 = new Animal();
            object obj3 = true;

            Identite(animal1);
            Identite(chat);
            Identite(chien);


            //Abstraction
            //Une classe abstraite est une classe qu'on ne peut pas instancier

            Personne per = new Femme();
            Personne per2 = new Homme("n", "p");

            Homme homme = new Homme("nom", "prenom");
            //Association
            Client client = new Client();
            client.Nom = "nomClient";
            client.Adresse = new Adresse() { Num = 15, Street = "rue de Paris 75010 Paris" }; //utilisation d'initialisateur automatique

            //ContactDAO dao = new ContactDAO();

            //Console.WriteLine("Quel est l'id du contact:");
            //int id = Convert.ToInt32(Console.ReadLine());
            //Contact contact = dao.GetById(id);
            //Console.WriteLine(contact);


            #endregion

            #region Exceptions

            Console.WriteLine("*************EXCEPTIONS**************");
            //Exception: c'est une erreur qui provoque l'arrêt de l'application
            //Pour eviter l'arrêt de l'application, on doit gérer l'exception
            //Pour gérer une exception on utilise le try - catch

            int nombre = 10;
            int[] tabEntier = { 1, 2 };
            

            try
            {
                //Console.WriteLine(tabEntier[2]);
                Console.WriteLine(nombre / 2);
                
            }
            
            catch (Exception ex)
            {
                Console.WriteLine("Exception traitée");
                Console.WriteLine("Message de l'exception: "+ex.Message);
                Console.WriteLine("Trace: "+ex.StackTrace);
            }
            finally
            {
                //Le bloc finally sert à libérer les ressources eventuellement utilisées dans le bloc try
                Console.WriteLine("Bloc finally...............");
            }

           

            
            try
            {
                Division(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            CompteBancaire monCompte = new CompteBancaire("145hgt", 1000);

            try
            {
                monCompte.Retrait(2000);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            

            Console.WriteLine("La suite de l'application.........");

            #endregion

            #region Classe String

            Console.WriteLine("************CLASSE STRING***************");

            string paragraph = " ceci est une chaine "; //Possibilité de créer des objets string via une chaine littérale 
            paragraph = paragraph.ToUpper();

            Console.WriteLine(paragraph);
            //Les objets de type string sont immuables. Une fois crées on ne peut pas les modifier en mémoire

            string paragraph2 = " CECI EST UNE CHAINE ";

            //Comparaison des objets string
            Console.WriteLine("Comparaison du contenu: "+paragraph.Equals(paragraph2));
            Console.WriteLine("Comparaison des références: "+object.ReferenceEquals(paragraph, paragraph2));

            //Quelques méthodes
            Console.WriteLine("Taille du paragraph: "+paragraph.Length); // 21 - un objet string est un tableau de char
            Console.WriteLine("Premier char du paragraph: "+paragraph[0]); // espace
            Console.WriteLine("Paragraph commence par C ?: "+paragraph.StartsWith("C")); //false
            Console.WriteLine("Paragraph se termine par un espace?: "+paragraph.EndsWith(" ")); //true
            Console.WriteLine("Eliminer les espaces de début et de fin du paragraph: "+paragraph.Trim());
            Console.WriteLine("Remplacer une chiane par une autre: "+paragraph.Replace("UNE CHAINE","UN PARAGRAPH" ));

            //Extraction de sous chaines
            Console.WriteLine("Sous chaine1: " + paragraph.Substring(1));
            Console.WriteLine("Sous chaine2: " + paragraph.Substring(1, 3)); //CEC

            //Chaine CSV
            //Découoage d'une chaine: Split
            string chaineCSV = "dawan;jehann;paris";
            string[] tabCSV = chaineCSV.Split(';');
            foreach (var item in tabCSV)
            {
                Console.WriteLine(item);
            }

            //Join
            string[] mots = { "ceci", "est", "un", "join" };
            string phrase = string.Join(" ", mots);

            Console.WriteLine($"Phrase: {phrase}");

            Console.WriteLine("Nombre de mots: " + MesMethodes.NombreMots("ceci est une chaine")); //4
            Console.WriteLine("Inverse de bonjour: "+MesMethodes.InverserChaine("bonjour"));
            Console.WriteLine("ressasser est un palindrôme: "+MesMethodes.VerifPalindrome("ressasser"));
            #endregion

            #region Collections

            Console.WriteLine("********************COLLECTIONS*****************");
            //Collections: se sont des tableaux dynamiques - leur taille n'est pas fixe

            //Collections faiblement typées

            //ArrayList
            Console.WriteLine("**************ARRAYLAIST");
            ArrayList tabDynamic = new ArrayList();

            Console.WriteLine("Taille du tableau dynamique: "+tabDynamic.Count); //0
            tabDynamic.Add(5);
            tabDynamic.Add("test");
            tabDynamic.Add(true);

            Console.WriteLine("Taille du tableau après ajout: "+tabDynamic.Count); //3
            Console.WriteLine("Tableau contient la chaine test? :"+tabDynamic.Contains("test")); //true

            tabDynamic.Remove("test");

            Console.WriteLine("Tableau contient la chaine test après suppression?: "+tabDynamic.Contains("test")); //false

            Console.WriteLine("Index de true dans le tableau: "+tabDynamic.IndexOf(true)); //1

            tabDynamic.Insert(1, "dawan");

            Console.WriteLine("Index de true après appel de Insert: "+tabDynamic.IndexOf(true)); //2

            foreach (var item in tabDynamic)
            {
                Console.WriteLine(item);
            }

            //Pile - Stack - Stockage LIFO : Last In First Out
            Console.WriteLine("*****************STACK- PILE");

            Stack pile = new Stack();

            pile.Push(5);
            pile.Push("test");
            pile.Push(true);
            pile.Push(15.5);

            Console.WriteLine("Nom bre d'éléments dans la pile!: "+pile.Count); //

            Console.WriteLine("La pile contient 15.5 ?: "+pile.Contains(15.5)); //true

            pile.Pop();

            Console.WriteLine("La pile contient 15.5 après appel de POP?: "+pile.Contains(15.5)); //false

            Console.WriteLine("Dernier élément de la pile: "+pile.Peek()); //true

            //Queue: stockage FIFO: First In First Out 

            Console.WriteLine("*****************QUEUE");
            Queue fifo = new Queue();

            fifo.Enqueue(5);
            fifo.Enqueue("test");
            fifo.Enqueue(true);

            Console.WriteLine("Taille de fifo: "+fifo.Count); //3

            Console.WriteLine("Fifo contient le chiffre 5? :"+fifo.Contains(5)); //5

            fifo.Dequeue();

            Console.WriteLine("Fifo contient le chiffre 5 après appel de Dequeue? : "+fifo.Contains(5)); //false

            //Collections fortement typées

            //List
            Console.WriteLine("**************LIST");
            List<string> jours = new List<string>();

            Console.WriteLine("Taille de la liste: "+jours.Count); //0

            jours.Add("Lundi");
            jours.Add("Mardi");
            jours.Add("Mercredi");
            Console.WriteLine("La liste contien Mardi?: "+jours.Contains("Mardi")); //true

            jours.Remove("Mardi");

            Console.WriteLine("La liste contient Mardi après appel de Remove?: "+jours.Contains("Mardi")); //false

            foreach (string item in jours)
            {
                Console.WriteLine(item);
            }

            //Supprimer le contenu de la liste
            jours.Clear();

            Console.WriteLine("Taille de liste après appel de clear: "+jours.Count); //0

            //Dictionary: Stockage de type clé=valeur
            Console.WriteLine("***********DICTIONNAIRE");
            Dictionary<int, string> dictionnaire = new Dictionary<int, string>();

            Console.WriteLine("Taille du dictionnaire: "+dictionnaire.Count); //0
            dictionnaire.Add(10, "admin");
            dictionnaire.Add(150, "password");

            if (dictionnaire.ContainsKey(10))
            {
                Console.WriteLine(dictionnaire[10]);
            }

            if (dictionnaire.ContainsKey(100))
            {
                Console.WriteLine(dictionnaire[100]);
            }
            else
            {
                Console.WriteLine("Le dictionnaire ne contient pas la clé 100");
            }

            //Afficher les valeurs + clés du dictionnaire

            foreach (int cle in dictionnaire.Keys)
            {
                Console.WriteLine($"Cle: {cle} - {dictionnaire[cle]}");
            }

            Dictionary<string, List<CompteBancaire>> mesComptes = new Dictionary<string, List<CompteBancaire>>();

            List<CompteBancaire> compteDebiteurs = new List<CompteBancaire>();
            compteDebiteurs.Add(new CompteBancaire("125dsd", -1500));
            compteDebiteurs.Add(new CompteBancaire("fre158", -2500));
            compteDebiteurs.Add(new CompteBancaire("ddf45", -4500));



            List<CompteBancaire> comptesCrediteurs = new List<CompteBancaire>();
            comptesCrediteurs.Add(new CompteBancaire("587dsqdq", 1500));
            comptesCrediteurs.Add(new CompteBancaire("fgt478", 2500));
            comptesCrediteurs.Add(new CompteBancaire("gvt", 4500));

            //Ajout des listes dans le dictionnaire
            mesComptes.Add("debiteurs", compteDebiteurs);
            mesComptes.Add("crediteurs", comptesCrediteurs);

            

            //Afficher les comptes créditeurs du dictionnaire

            if (mesComptes.ContainsKey("crediteurs"))
            {
                foreach (var item in mesComptes["crediteurs"])
                {
                    Console.WriteLine(item);
                }      
            }


            #endregion

            #region Fichiers
            Console.WriteLine("**************FICHIERS***********");

            // .net fournit un certais nombre de classes qui nous permettent de manipuler les fichier et les dossiers

            // Dossier : Directory 
            // Fichiers : File et FileInfo , les 2 classes présentent les même méthodes à la seule différence, elles sont static pour la classe File et d'instance pour la classe FileInfo;

            // Pour les opérations de lectures, écritures : StreamWriter - StreamReader;

            //Caractères d'échappement \n : retour à la ligne ---- \t: tabulation ---- \\ échapper le \

            Console.WriteLine("\tBonjour, \nje suis en formation chez Dawan.\nFormation c#");

            //chaine verbatim
            Console.WriteLine(@"    Bonjour,
Je suis en formation chez Dawan.
Formation c#");

            //Création d'un répertoire 
            Directory.CreateDirectory("dossier"); //chemin relatif à l'exécutable du projet bin/Debug
            //Directory.CreateDirectory("C:\\dossier");  chemin absolue
            Directory.CreateDirectory(@"C:\dossier"); // chemin absolue


            //Récupérer les fichiers d'un dossier
            string[] files = Directory.GetFiles(@"C:\dossier\");

            foreach (var f in files)
            {
                Console.WriteLine(f);
            }
            string fichierSource = @"C:\dossier\coucou.txt";
            string fichierCible = @"C:\dossier\coucouCopy.txt";

            try
            {
                File.Copy(fichierSource, fichierCible);
            }
            catch (Exception e)
            {
                if (File.Exists(fichierCible))
                {
                    File.Delete(fichierCible);
                    Console.WriteLine($"Fichier {fichierCible} supprimé");
                }
            }

            //Utilisation de FileInfo pour récupérer les infos concernant un fichier bien particulier

            FileInfo fileInfo = new FileInfo(@"C:\dossier\coucou.txt");
            Console.WriteLine("Heure de création du fichier : " + fileInfo.CreationTime);
            Console.WriteLine("Heure de dernière modification du fichier : " + fileInfo.LastWriteTime);
            Console.WriteLine("Heure de dernière accès du fichier : " + fileInfo.LastAccessTime);
            Console.WriteLine("Extensions du fichier : " + fileInfo.Extension);
            Console.WriteLine("Taille en octets du fichier : " + fileInfo.Length);

            //Lecture - Ecriture de fichiers
            //Flux : canal ente la sourve et la destination
            //1 - Charger le fichier dans le flux(lecture/ecriture)
            //2 - Execution des opérations (lecture/ecriture)
            //3 - Fermeture du flux


            StreamWriter streamWriter = new StreamWriter(fichierSource);
            streamWriter.Write("Salut Muhammad");
            streamWriter.Close();

            StreamReader streamReader = new StreamReader(fichierSource);
            string contenu = streamReader.ReadToEnd();
            streamReader.Close();

            Console.WriteLine(contenu);

            //Utilisation de la classe Tools définie dans le projet DLL
            Tools.EcritureFichier(fichierSource, "\nWesh le s ça dit quoi?");
            Console.WriteLine(Tools.LectureFichier(fichierSource));


            #endregion

            #region Sérialisation

            //Sérialisation est un mécanisme qui nous permet de sauvegarder un objet dans un fichier
            //3 types de sérialisations possibles en .net
            //Binaire : BinaryFormatter
            //XML: XmlSerializer
            //JSON: DataContractJsonSerializer

            List<CompteBancaire> liste = new List<CompteBancaire>();
            liste.Add(new CompteBancaire("151dfg", 4500));
            liste.Add(new CompteBancaire("556dgd", 5000));
            liste.Add(new CompteBancaire("762sfgs", 7500));
            liste.Add(new CompteBancaire("397zera", 8900));

            //FileStream , MemoryStream
            Console.WriteLine("**************SERIALISATION BINAIRE*********************");
            Tools.ExportBIN(fichierSource, liste);

            List<CompteBancaire> listBin = Tools.ImportBin(fichierSource);

            foreach (var item in listBin)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("******************Sérialisation XML*******************");

            Tools.ExportXml(fichierSource, liste);

            List<CompteBancaire> listXml = Tools.ImportXml(fichierSource);

            foreach (var item in listXml)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("**************SERIALISATION JSON*******************");

            Tools.ExportJson(fichierSource, liste);

            List<CompteBancaire> listJson = Tools.ImportJson(fichierSource);

            foreach (var item in listJson)
            {
                Console.WriteLine(item);
            }


            #endregion


            //Maintenir la console active
            Console.ReadLine();
            
        }

        private static double Surface(double longueur, double largeur)
        {
            return longueur * largeur;
        }

        //public static void Identite(Chat chat)
        //{
        //    chat.Identite();
        //}

        //public static void Identite(Chien chien)
        //{
        //    chien.Identite();
        //}

        //Méthode polymorphique

        public static void Identite(Animal animal)
        {
            animal.Identite();
        }


       /// <summary>
       /// Cette méthode peut générer une exception de type DivideByZero
       /// </summary>
       /// <param name="x"></param>
        public static void Division(int x)
        {
            //Option1: traiter l'exception dans la méthode
            //try
            //{
            //    Console.WriteLine(10 / x);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Exception traitée par la méthode.......");
            //}

            //Option2: l'exception non traitée par la méthode
            //La méthode remonte l'exception à l'utilisateur
            if (x != 0)
            {
                Console.WriteLine(10 / x);
            }
            else
            {
                //throw: permet de déclecher une exception - permet de remonter l'exception
                throw new Exception();
            }
            
        }
    }
}
