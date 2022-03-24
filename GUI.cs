using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eu4HackGUI.CodeGen;
using Eu4HackGUI.Controls;

namespace Eu4HackGUI
{
    public partial class GUI : Form
    {

        public GUI()
        {
            InitializeComponent();
            IdeasPanel.Visible = false;
            HackPanel.Visible = false;
            DevToolsPanel.Visible = false;
        }


        private void IdeasButton_Click(object sender, EventArgs e) => TogglePanel(IdeasControlPanel);
        private void HackButton_Click(object sender, EventArgs e) => TogglePanel (HackPanel);
        private void DevToolsButton_Click(object sender, EventArgs e) => TogglePanel(DevToolsPanel);
        private void TogglePanel(Control Control)
        {
            foreach(Panel panel)
            Control.Visible = !Control.Visible;
        }
    }
}
