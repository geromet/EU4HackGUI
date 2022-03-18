using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eu4HackGUI.Hack.Presets
{
    internal class Country_Ideas
    {
        private static string fileName = "00_country_ideas.txt";
        private static string backupDir = "Files/backup/common/ideas";
        private static string sourceDir = "Files/common/ideas";
        private static string destinationDir = "C:/Program Files (x86)/Steam/steamapps/common/Europa Universalis IV/common/ideas";
        private static string searchString = "ChurchAspectDatabase Initialized";
        private static int copyDelay = 0;
        public static void Add()
        {
            Hack.AddType(fileName, backupDir, sourceDir, destinationDir, searchString, copyDelay);
        }
    }
}
