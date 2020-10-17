using BulkMail.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace BulkMail.Data
{
    public class DataDAO : IdataDAO
    {
        public MailData loadData(string Filepath)
        {
            MailData data = new MailData(true);
            XDocument file = XDocument.Load(Filepath);
            XElement campagne = file.Elements().First();
            data.Nom = campagne.Element("nom").Value.ToString();

            List<String> emailList = new List<string>();
            if (!(campagne.Element("mailList") is null))
            {
                foreach (String address in campagne.Element("mailList").Value.Split(' '))
                {
                    if (!String.IsNullOrEmpty(address))
                        emailList.Add(address);
                }
            }
            data.EmailList = emailList;

            object[] email = new object[3];
            email[0] = campagne.Element("email").Element("objet").Value.ToString();
            email[1] = campagne.Element("email").Element("expediteur").Value.ToString();
            email[2] = campagne.Element("email").Element("corps").Value.ToString();
            foreach (String PieceJointe in campagne.Element("email").Element("piecesJointes").Value.Split(' '))
            {
                if(!String.IsNullOrEmpty(PieceJointe))
                    data.PiecesJointes.Add(PieceJointe);
            }
            data.Email = email;
            data.Filepath = Filepath;
            return data;
        }

        public void saveData(MailData Data, String Filepath)
        {
            XDocument XMLFile;
            //Chargement du schéma
            String Schema = File.ReadAllText("BulkMail.xsd");
            XmlSchemaSet schema = new XmlSchemaSet();
            schema.Add("", XmlReader.Create(new StringReader(Schema)));
                //Base du XML
                XElement Nom = new XElement("nom", Data.Nom);
            XElement MailList = new XElement("mailList", Data.EmailList.Select(e => e + " "));

            //Création de l'élement Email
            XElement Objet = new XElement("objet", Data.Email[0]);
            XElement Expediteur = new XElement("expediteur", Data.Email[1]);
            XElement Corps = new XElement("corps", Data.Email[2]);
            XElement PiecesJointes = new XElement("piecesJointes", Data.PiecesJointes.Select(e => e+" "));
            XElement Email = new XElement("email", Objet, Expediteur, Corps, PiecesJointes);

            //Mise en place complète du XML
            XElement Root = new XElement("campagne", Nom, MailList, Email);
            XMLFile = new XDocument(Root);

            //On valide le schéma (normalement pas nécessaire, mais sait-on jamais)
            bool errors = false;
            XMLFile.Validate(schema, (o, e) =>
                {
                    Console.WriteLine("{0}", e.Message);
                    errors = true;
                });
            Console.WriteLine("{0}", errors? "did not validate" : "validated");

            XMLFile.Save(Filepath);
        }
    }
}
