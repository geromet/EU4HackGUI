using Eu4HackGUI.Hack.Presets;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Eu4HackGUI.Hack
{
    public class Hack
    {
        private static int _readDelay;
        private static List<Type> _types = new();
        private static List<Type> _usedTypes = new();

        public static void AddType(string fileName, string backupDir, string sourceDir, string destinationDir, string searchString, int copyDelay)
        {
            Type type = new();
            type.Set(fileName, backupDir, sourceDir, destinationDir, searchString,copyDelay);
            _types.Add(type);
        }
        public static void RemoveType(Type type)
        {
            _usedTypes.Add(type);
            _types.Remove(type);
        }
        private static void Initialize(int readDelay, int gameLoadDelay)
        {
            foreach(string type in Controller.GetSelectedTypes())
            {
                switch(type)
                {
                    case "Country_Ideas" :
                        Country_Ideas.Add();
                        break;
                    case "Provinces":
                        Province.Add();
                        break;
                    case "Countries":
                        Country.Add();
                        break;
                }
            }
            
            Country.Add();
            Province.Add();
            _readDelay = 200;//200
        }
       
        public static void Run(int copyDelay, int readDelay)
        {
            Process thisProc = Process.GetCurrentProcess();
            thisProc.PriorityClass = ProcessPriorityClass.BelowNormal;
            Initialize(copyDelay, readDelay);
            Clean();
            WaitForGame();
            FileStream stream = File.Open((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Paradox Interactive/Europa Universalis IV/logs/setup.log").ToString(), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            using (stream)
            {
                StreamReader reader = new StreamReader(stream);
                using (reader)
                {
                    string line;
                    int nullDelay = 0;
                    int nulls = 0;
                    int reads = 0;
                    bool sleeping = true;
                    Thread.Sleep(_readDelay);
                    while (_types.Count > 0)
                    {
                        DateTime lastTime = DateTime.Now;
                        line = reader.ReadLine();
                        if (line == null)
                        {
                            nulls++;
                            DateTime currentTime = DateTime.Now;
                            if (nulls < 1.5 * reads)
                            {
                                nullDelay -= (currentTime.Millisecond - lastTime.Millisecond);
                            }
                            else if (nulls > 8 * reads)
                            {
                                nullDelay += 4 * (currentTime.Millisecond - lastTime.Millisecond);
                            }
                            else if (nulls > 4 * reads)
                            {
                                nullDelay += 2 * (currentTime.Millisecond - lastTime.Millisecond);
                            }
                            else if (nulls > 2 * reads)
                            {
                                sleeping = true;
                                nullDelay += (currentTime.Millisecond - lastTime.Millisecond);
                            }
                            else
                            {
                                sleeping = false;
                            }
                            Thread.Sleep(nullDelay);
                            continue;
                        }
                        if(sleeping) reads++;
                         List <Type> types = new List<Type>();
                        foreach (Type type in _types)
                        {
                            if (type.TryCopy(line))
                            {
                                types.Add(type);
                            }
                        }
                        foreach(Type type in types)
                        {
                            _types.Remove(type);
                        }
                    }
                }    
            }
            Controller.HackIsRunning = false;    
        }

        private static void WaitForGame()
        {
            while (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Paradox Interactive/Europa Universalis IV/logs/setup.log"))
            {
                Thread.Sleep(500);
            }
                
        }
        private static void Clean()
        {
            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Paradox Interactive/Europa Universalis IV/logs/setup.log");
            foreach(Type type in _usedTypes)
            {
                type.Clean();
            }
            foreach (Type type in _types)
            {
                type.Clean();
            }

        }

    }
}
