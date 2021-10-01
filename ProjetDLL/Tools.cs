using ProjetDLL.ConceptsObjets.Encapsulation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjetDLL
{
    public class Tools
    {
        public static void MaMethode()
        {
            Console.WriteLine("Appel de la méthode définie dans le projet DLL");
        }

        //Méthode d'écriture dans un fichier
        public static void EcritureFichier(string path , string text)
        {
            StreamWriter sr = new StreamWriter(path,true); // cette surcharge nous permet de passer en mode ajout - contenu du fichier non écrasé 
            sr.WriteLine(); //Passage à une nouvelle ligne avant d'insérer du contenue
            sr.WriteLine(text);
            sr.Close();
        }

        //Méthode de lecture d'un fichier
        public static string LectureFichier(string path)
        {
            StreamReader sr = new StreamReader(path);
            string contenu =  sr.ReadToEnd();
            sr.Close();
            return contenu;
        }

        //Méthode de sérialisation binaire

        public static void ExportBIN(string path , List<CompteBancaire> list)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Create);
            binaryFormatter.Serialize(stream,list);
            stream.Close();
        }

        //Méthode de désérialization binaire
        public static List<CompteBancaire> ImportBin(string path)
        {
            List<CompteBancaire> list = new List<CompteBancaire>();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Stream st = new FileStream(path, FileMode.Open);
            list = (List<CompteBancaire>)binaryFormatter.Deserialize(st);
            st.Close();

            return list;
        } 

        //Méthode de sérialisation xml
        public static void ExportXml(string path , List<CompteBancaire> list)
        {
            XmlSerializer xmlSerial = new XmlSerializer(list.GetType());
            Stream stream = new FileStream(path, FileMode.Create);
            xmlSerial.Serialize(stream, list);
            stream.Close();

        }
        public static List<CompteBancaire> ImportXml(string path)
        {
            List<CompteBancaire> list = new List<CompteBancaire>();
            XmlSerializer xmlSerial = new XmlSerializer(list.GetType());
            Stream st = new FileStream(path, FileMode.Open);
            list = (List<CompteBancaire>)xmlSerial.Deserialize(st);
            st.Close();

            return list;
        }

        //Méthode de sérialisation JSON
        public static void ExportJson(string path, List<CompteBancaire> list)
        {
            DataContractJsonSerializer jsonSerial = new DataContractJsonSerializer(list.GetType());
            Stream stream = new FileStream(path, FileMode.Create);
            jsonSerial.WriteObject(stream, list);
            stream.Close();

        }

        //méthode de désérialization json 
        public static List<CompteBancaire> ImportJson(string path)
        {
            List<CompteBancaire> list = new List<CompteBancaire>();
            DataContractJsonSerializer jsonSerial = new DataContractJsonSerializer(list.GetType());
            Stream st = new FileStream(path, FileMode.Open);
            list = (List<CompteBancaire>)jsonSerial.ReadObject(st);
            st.Close();

            return list;
        }


    }
}
