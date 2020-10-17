using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace BulkMail.xml
{
    class SaveXML
    {
        public static XDocument XMLFile;
        
        static public void SaveFile(MailData Data, String Filepath)
        {
            //Chargement du schéma
            String Schema = File.ReadAllText("BulkMail.xsd");
            XmlSchemaSet schema = new XmlSchemaSet();
            schema.Add("", XmlReader.Create(new StringReader(Schema)));
            //Base du XML
            XElement Nom = new XElement("nom", Data.Nom);
            XElement MailList = new XElement("mailList", Data.EmailList);

            //Création de l'élement Email
            XElement Objet = new XElement("objet",Data.Email[0]);
            XElement Expediteur = new XElement("expediteur",Data.Email[1]);
            XElement Corps = new XElement("corps",Data.Email[2]);
            XElement PiecesJointes = new XElement("piecesJointes",Data.PiecesJointes);
            XElement Email = new XElement("email", Objet, Expediteur, Corps, PiecesJointes);

            //Mise en place complète du XML
            XElement Root = new XElement("campagne", Nom, MailList, Email);
            XMLFile = new XDocument(Root);

            //On valide le schéma (normalement pas nécessaire, mais sait-on jamais)
            bool errors = false;
            XMLFile.Validate(schema,(o,e) =>
            {
                Console.WriteLine("{0}", e.Message);
                errors = true;
            });
            Console.WriteLine("{0}", errors ? "did not validate" : "validated");

            XMLFile.Save(Filepath);
        }
    }
}
