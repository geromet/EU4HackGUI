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
        private static int _gameLoadDelay;

        private static List<Type> _types = new List<Type>();
        private static List<Type> _usedTypes = new List<Type>();

        public static void AddType(string fileName, string backupDir, string sourceDir, string destinationDir, string searchString, int copyDelay)
        {
            Type type = new Type();
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
            Country_Ideas.Add();
            Country.Add();
            Province.Add();
            _readDelay = 200;//200
            _gameLoadDelay = 5000;//5000
        }
       
        public static void Run(int copyDelay, int readDelay)
        {
            Initialize(copyDelay, readDelay);
            Clean();
            Backup();
            WaitForGame();
            FileStream stream = File.Open((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Paradox Interactive/Europa Universalis IV/logs/setup.log").ToString(), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            using (stream)
            {
                StreamReader reader = new StreamReader(stream);
                using (reader)
                {
                    string line;
                    Thread.Sleep(_readDelay);
                    while (_types.Count > 0)
                    {
                        line = reader.ReadLine();
                        if (line == null)
                        {
                            continue;
                        }
                        List<Type> types = new List<Type>();
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
            
        }
        public static void Backup()
        {
            foreach (Type type in _types)
            {
                type.Clean();
            }
        }
        private static void WaitForGame()
        {
            while (true)
            {
                if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Paradox Interactive/Europa Universalis IV/logs/setup.log"))
                {
                    Thread.Sleep(_gameLoadDelay);
                    break;
                }
            }
                
        }
        private static void Clean()
        {
            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Paradox Interactive/Europa Universalis IV/logs/setup.log");
            foreach(Type type in _usedTypes)
            {
                type.Clean();
            }
            
        }

    }
}
