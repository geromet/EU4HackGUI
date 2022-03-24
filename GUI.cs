using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eu4HackGUI.CodeGen;

namespace Eu4HackGUI
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private async void CreateCountryList_Click(object sender, EventArgs e) => await Task.Run(() => MakeCountryNameList.Run());
        private async void CreateCountrySelectionSwitch_Click(object sender, EventArgs e) => await Task.Run(() => MakeCountrySelectorSwitchCode.Run());
        private async void CreateIdeaList_Click(object sender, EventArgs e) => await Task.Run(() => MakeIdeaList.Run());




    }
}
