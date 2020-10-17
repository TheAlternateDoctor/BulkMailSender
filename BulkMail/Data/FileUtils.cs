using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkMail.Data
{
    public static class FileUtils
    {
        public static void exportMailList(List<String> emails)
        {
            OpenFileDialog exportFile = new OpenFileDialog();
            if (exportFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(exportFile.FileName, emails);
            }
        }

        public static List<String> importMailList()
        {
            OpenFileDialog openAdressFile = new OpenFileDialog();
            openAdressFile.Filter = "Fichier TXT (*.txt)|*.txt|Fichier CSV (*.csv)|*.csv";
            List<String> adresses = new List<String>();
            if (openAdressFile.ShowDialog() == DialogResult.OK)
            {
                String filepath = openAdressFile.FileName;
                if (Path.GetExtension(filepath).ToLower().Equals(".txt"))
                {
                    String[] addressesInFile = File.ReadAllLines(filepath);
                    foreach(String address in addressesInFile)
                    {
                        if (address.Contains("@"))
                            adresses.Add(address);
                    }

                }
                else if (Path.GetExtension(filepath).ToLower().Equals(".csv")){
                    TextFieldParser csvParser = new TextFieldParser(filepath);
                    csvParser.SetDelimiters(new string[] { ";" });
                    while (!csvParser.EndOfData)
                    {
                        foreach(String address in csvParser.ReadFields())
                        {
                            if (address.Contains("@"))
                                adresses.Add(address);
                        }  
                    }
                    return adresses;
                }
            }
            return adresses;
        }
    }
}
