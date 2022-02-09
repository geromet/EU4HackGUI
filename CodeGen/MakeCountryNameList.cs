using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eu4HackGUI.CodeGen
{
    public static class MakeCountryNameList
    {
        static readonly string currentFolder = System.IO.Path.GetFullPath(@"..\..\..\");
        static readonly string dataFolder = "/Data/";
        static readonly string countryListName = "CountryList.txt";
        static readonly string countryListPath = (currentFolder + dataFolder + countryListName).ToString();
        public static void DoTheThing()
        {
            using (StreamWriter streamWriter = new StreamWriter(currentFolder + dataFolder + "CountryNameList.txt"))
            {
                using (FileStream stream = File.Open(countryListPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using StreamReader reader = new StreamReader(stream);
                    string line;
                    string name;
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine().Trim();
                        name = line[0..^4];
                        streamWriter.WriteLine(name);
                    }
                }
            }
        }
    }
}
