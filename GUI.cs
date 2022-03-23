using System;
using System.Collections.Generic;
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

        private void CreateCountryList_Click(object sender, EventArgs e)
        {
            MakeCountryNameList.DoTheThing();
        }

        private void CreateCountrySelectionSwitch_Click(object sender, EventArgs e)
        {
            MakeCountrySelectorSwitchCode.DoTheThing();
        }

        private void SearchCountry_TextChanged(object sender, EventArgs e)
        {
            Controller.SetCountryTag(SearchCountry.Text);
            SelectedCountry.Text = Controller.GetCountryTag();
        }

        private void CreateIdeaList_Click(object sender, EventArgs e)
        {
            MakeIdeaList.DoTheThing();
        }
        private void IdeaListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Control Sender = (Control)sender;
            IdeaControl ideaControl = new IdeaControl();
            ideaControl.SetLabel(Sender.Text);
            ideaControl.Name = Sender.Text;
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
        private void Run_Click(object sender, EventArgs e)
        {
            Eu4HackGUI.Hack.Hack.Run(1, 1);
        }

        private void TypeCheckListBox_ItemCheck(object sender, EventArgs e)
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
            foreach(string type in Controller.GetSelectedTypes())
            {
                text += type + "    ";
            }
            if(text == "")
            {
                text = "None selected";
            }
            SelectedTypesLabel.Text = text;
        }

    }
}
