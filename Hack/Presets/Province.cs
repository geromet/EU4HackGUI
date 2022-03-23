using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eu4HackGUI.Hack.Presets
{
    internal class Province
    {
        private static string fileName = "97 - Holland.txt";
        private static string backupDir = "Files/backup/history/provinces";
        private static string sourceDir = "Files/history/provinces";
        private static string destinationDir = "C:/Program Files (x86)/Steam/steamapps/common/Europa Universalis IV/history/provinces";
        private static string searchString = "LeaderPersonalities loaded";
        private static int copyDelay = 100;
        public static void Add()
        {
            Hack.AddType(fileName, backupDir, sourceDir, destinationDir, searchString, copyDelay);
        }
    }
}
