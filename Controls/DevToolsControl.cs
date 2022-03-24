using Eu4HackGUI.CodeGen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eu4HackGUI.Controls
{
    public partial class DevToolsControl : UserControl
    {
        public DevToolsControl()
        {
            InitializeComponent();
        }
        private async void CreateCountryList_Click(object sender, EventArgs e) => await Task.Run(() => MakeCountryNameList.Run());
        private async void CreateCountrySelectionSwitch_Click(object sender, EventArgs e) => await Task.Run(() => MakeCountrySelectorSwitchCode.Run());
        private async void CreateIdeaList_Click(object sender, EventArgs e) => await Task.Run(() => MakeIdeaList.Run());

    }
}
