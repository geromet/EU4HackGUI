using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eu4HackGUI.Hack.Presets
{
    internal class Country
    {
        private static string fileName = "Hol - Holland.txt";
        private static string backupDir = "Files/backup/history/countries";
        private static string sourceDir = "Files/history/countries";
        private static string destinationDir = "C:/Program Files (x86)/Steam/steamapps/common/Europa Universalis IV/history/countries";
        private static string searchString = "LeaderPersonalities loaded";
        private static int copyDelay = 0;
        public static void Add()
        {
            Hack.AddType(fileName, backupDir, sourceDir, destinationDir, searchString, copyDelay);
        }
    }
}
