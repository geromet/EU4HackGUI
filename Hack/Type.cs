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
            if (_fileName == "*.txt")
            {
                string[] textFiles = Directory.GetFiles(_backupDir, "*.txt");

                foreach (string textFile in textFiles)
                {
                    File.Copy(textFile, Path.Combine(_destinationDir, textFile.Substring(_backupDir.Length)), true);
                }
            }
            else
            {
                File.Copy(Path.GetFullPath(Path.Combine(_backupDir, _fileName)), Path.GetFullPath(Path.Combine(_destinationDir, _fileName)), true);
            }
            
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
                if (_fileName =="*.txt")
                {
                    string[] textFiles = Directory.GetFiles(_sourceDir, "*.txt");

                    foreach (string textFile in textFiles)
                    {
                        string fileName = textFile.Substring(_sourceDir.Length);

                        File.Copy(Path.Combine(_sourceDir, fileName),Path.Combine(_destinationDir, fileName), true);

                       // _sourceDir = C:\Users\gerom\Desktop\Eu4HackGUI\bin\Release\net6.0 - windows10.0.22000.0\publish\Files\history\countries
                       //   _destinationDir = C:\Program Files(x86)\Steam\steamapps\common\Europa Universalis IV\history\countries
                       //fileName = HOL - Holland.txt

                       // _sourceDir, fileName = C:\Users\gerom\Desktop\Eu4HackGUI\bin\Release\net6.0 - windows10.0.22000.0\publish\Files\history\countries\ HOL - Holland.txt

                       // _destinationDir, fileName = C:\HOL - Holland.txt

                    }
                }
                else
                {
                    File.Copy(Path.GetFullPath(Path.Combine(_sourceDir, _fileName)), Path.GetFullPath(Path.Combine(_destinationDir, _fileName)), true);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
