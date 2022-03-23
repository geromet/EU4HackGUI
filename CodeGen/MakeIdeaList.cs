using System.Threading;
using System.Collections.Generic;
using System.IO;

namespace Eu4HackGUI.CodeGen
{
    public class MakeIdeaList
    {
        private static readonly string currentFolder = System.IO.Path.GetFullPath(@"..\..\..\");
        private static readonly string dataFolder = "/Data/";
        private static readonly string ideas = "00_country_ideas.txt";
        private static readonly string ideaPath = (currentFolder + dataFolder + ideas).ToString();
        public static void DoTheThing()
        {
            using (StreamWriter streamWriter = new StreamWriter(currentFolder + dataFolder + "IdeaList.txt"))
            {
                using (FileStream stream = File.Open(ideaPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using StreamReader reader = new StreamReader(stream);
                    string line;
                    string output;
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        if (line.StartsWith("\t\t"))
                        {
                            output = line.Split('=')[0].Replace("\t", string.Empty).Trim();
                            streamWriter.WriteLine(output);
                        }
                    }
                    Step2();
                }
            }
        }
        static void Step2()
        {
            
            using(StreamWriter streamWriter2 = new StreamWriter(currentFolder + dataFolder + "IdeaCleanedList.txt"))
            {
                using (FileStream stream2 = File.Open(currentFolder + dataFolder + "IdeaList.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    List<string> list = new List<string>();
                    bool copy = true;
                    using StreamReader reader2 = new StreamReader(stream2);
                    string line;
                    string[] output ={""};
                    while (!reader2.EndOfStream)
                    {
                        line = reader2.ReadLine();
                        list.Add(line);
                    }
                    List<string> list2 = new List<string>();
                    for (int i = 0; i < list.Count; i++)
                    {
                        copy = true;
                        for (int o=0;o<list2.Count;o++)
                        {
                            if (list[i].Equals(list2[o]))
                            {
                                copy=false;
                            }
                            
                        }
                        if (copy&& !list[i].Equals("tag")&& !list[i].Contains("#")&&!list[i].Contains("}") && !list[i].Contains("AND") && !list[i].Contains("TAG"))
                        {
                                    list2.Add(list[i]);
                                    streamWriter2.WriteLine(list[i]);
                        }
                    }
                }
            }         
        }
    }
}