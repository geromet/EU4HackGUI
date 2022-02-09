using Eu4HackGUI.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eu4HackGUI.Controllers
{
    public static class Controller
    {
        public static string SetCountryTag(string countryName)
        {
            return (GetCountryTag.Get(countryName).ToString());
        }
    }
}
