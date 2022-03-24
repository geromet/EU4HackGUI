﻿using System;
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
        private Dictionary<TabPage, Color> TabColors = new Dictionary<TabPage, Color>();
        public GUI() 
        {
            InitializeComponent();
            HackPanel.Visible = false;
            IdeasPanel.Visible = false;
            DevToolsPanel.Visible = false;
            ProvincesPanel.Visible = false;
        }
        
        private async void CreateCountryList_Click(object sender, EventArgs e) => await Task.Run(() => MakeCountryNameList.Run());
        private async void CreateCountrySelectionSwitch_Click(object sender, EventArgs e) => await Task.Run(() => MakeCountrySelectorSwitchCode.Run());        
        private async void CreateIdeaList_Click(object sender, EventArgs e) => await Task.Run(() => MakeIdeaList.Run());
        private void SearchCountry_TextChanged(object sender, EventArgs e)
        {
            Controller.SetCountryTag(SearchCountry.Text);
            SelectedCountry.Text = Controller.GetCountryTag();
        }
        private void IdeaListBox_ItemCheck(object sender, ItemCheckEventArgs e)=> IdeaItemCheck(sender);

        private void Run_Click(object sender, EventArgs e) => RunHack(sender);
        private void RunHack(object sender)
        {
            if(Controller.HackIsRunning)
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
        private void IdeaItemCheck(object sender)
        {
            Control Sender = (Control)sender;
            IdeaControl ideaControl = new();
            ideaControl.Name = Sender.Text;
            ideaControl.SetLabel(Sender.Text);
            if (!IdeaListBox.CheckedItems.Contains(Sender.Text))
            {
                Controller.AddIdea(Sender.Text);
                flowPanel.Controls.Add(ideaControl);
            }
            else
            {
                Controller.RemoveIdea(Sender.Text);
                flowPanel.Controls.Remove(flowPanel.Controls.Find(ideaControl.Name, false)[0]);
            }
        }

        private void DevToolsButton_Click(object sender, EventArgs e) => TogglePanels(DevToolsPanel);
        private void IdeasButton_Click(object sender, EventArgs e) => TogglePanels(IdeasPanel);
        private void ProvincesButton_Click(object sender, EventArgs e) => TogglePanels(ProvincesPanel);
        private void HackButton_Click(object sender, EventArgs e)=> TogglePanels(HackPanel);
        private void TogglePanels(Panel sender)
        {
            sender.Visible = true;
            foreach (Panel panel in this.Controls)
            {
                if(panel == sender||panel ==MenuPanel)
                {
                    continue;
                }
                panel.Visible = false;
            }
        }
    }
}
