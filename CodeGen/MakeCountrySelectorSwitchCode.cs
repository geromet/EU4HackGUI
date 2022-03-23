using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eu4HackGUI.CodeGen
{
    public class MakeCountrySelectorSwitchCode
    {
        static readonly string currentFolder = System.IO.Path.GetFullPath(@"..\..\..\");
        static readonly string dataFolder = "/Data/";
        static readonly string countryListName = "CountryList.txt";
        static readonly string countryListPath = (currentFolder + dataFolder + countryListName).ToString();
        public static void Run()
        {
            using (StreamWriter streamWriter = new StreamWriter(currentFolder + dataFolder + "CountrySelectorSwitch.txt"))
            {
                streamWriter.WriteLine("switch(CountryName)\n\t{");
                using (FileStream stream = File.Open(countryListPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using StreamReader reader = new StreamReader(stream);
                    string line;
                    string name;
                    string tag;
                    string code;
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine().Trim();
                        name = line[0..^4];
                        tag = line.Substring(line.Length-3);
                        code = ("case \"" + name + "\":\n\t{\n\tCountryTag = \"" + tag + "\";\nbreak;\n}");
                        streamWriter.WriteLine(code);
                    }
                    streamWriter.WriteLine("}");
                }
            }
        }  
    }
}
