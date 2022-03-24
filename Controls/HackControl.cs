using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eu4HackGUI.Controls
{
    public partial class HackControl : UserControl
    {
        public HackControl()
        {
            InitializeComponent();
        }
        private void SearchCountry_TextChanged(object sender, EventArgs e)
        {
            Controller.SetCountryTag(SearchCountry.Text);
            SelectedCountry.Text = Controller.GetCountryTag();
        }
        private void Run_Click(object sender, EventArgs e) => RunHack(sender);
        private void RunHack(object sender)
        {
            if (Controller.HackIsRunning)
            {
                return;
            }
            else
            {
                Controller.HackIsRunning = true;
                Run.Text = "Running";
                Run.Enabled = false;
                RunHackAsync();
                WaitForHack();
            }


        }
        private async void RunHackAsync() => await Task.Run(() => Eu4HackGUI.Hack.Hack.Run(1, 1));
        private async void WaitForHack() => await Task.Run(() => CheckHackRunning());
        private void CheckHackRunning()
        {
            Process thisProc = Process.GetCurrentProcess();
            thisProc.PriorityClass = ProcessPriorityClass.BelowNormal;
            while (Controller.HackIsRunning)
            {

            }
            Run.Enabled = true;
            Run.Text = "Stopped";
        }

        private void TypeCheckListBox_ItemCheck(object sender, EventArgs e) => TypeItemCheck(sender);
        private void TypeItemCheck(object sender)
        {
            Control Sender = (Control)sender;
            if (!TypeCheckListBox.CheckedItems.Contains(Sender.Text))
            {
                Controller.AddType(Sender.Text);
            }
            else
            {
                Controller.RemoveType(Sender.Text);
            }
            string text = "";
            foreach (string type in Controller.GetSelectedTypes())
            {
                text += type + "    ";
            }
            if (text == "")
            {
                text = "None selected";
            }
            SelectedTypesLabel.Text = text;
        }
    }
}
