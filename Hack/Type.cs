using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Eu4HackGUI.Hack;

namespace Eu4HackGUI.Hack
{
    public class Type
    {
        private string _fileName;
        private string _backupDir;
        private string _sourceDir;
        private string _destinationDir;
        private string _searchString;
        private int _copyDelay;

        public void Clean()
        {
            File.Copy(Path.GetFullPath(Path.Combine(_backupDir, _fileName)), Path.GetFullPath(Path.Combine(_destinationDir, _fileName)), true);
        }
        public void Set(string fileName, string backupDir, string sourceDir, string destinationDir, string searchString, int copyDelay)
        {
            _fileName = fileName;
            _backupDir = backupDir;
            _sourceDir = sourceDir;
            _destinationDir = destinationDir;
            _searchString = searchString;
            _copyDelay = copyDelay;
        }
        public bool TryCopy(string line)
        {
            if(line.Contains(_searchString))
            {
                Thread.Sleep(_copyDelay);
                File.Copy(Path.GetFullPath(Path.Combine(_sourceDir, _fileName)), Path.GetFullPath(Path.Combine(_destinationDir, _fileName)), true);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
