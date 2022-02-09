using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Eu4HackGUI.CodeGen;
namespace Eu4HackGUI
{
    public partial class GUI : Form
    {
        string CountryTag;
        List<string> SelectedIdeas = new List<string>();
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
            CountryTag = Controllers.Controller.SetCountryTag(SearchCountry.Text);
            SelectedCountry.Text = CountryTag;
        }

        private void CreateIdeaList_Click(object sender, EventArgs e)
        {
            MakeIdeaList.DoTheThing();
        }

        private void ValueInputPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IdeaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(var idea in IdeaListBox.CheckedItems)
            {
                if (!SelectedIdeas.Contains(idea.ToString()))
                {
                    SelectedIdeas.Add(idea.ToString());
                    IdeaControl ideaControl = new IdeaControl();
                    ideaControl.SetLabel(idea.ToString());
                    ideaControl.Name = idea.ToString();
                    flowPanel.Controls.Add(ideaControl);
                }

            }
            foreach(string selectedIdea in SelectedIdeas)
            {
                if (!IdeaListBox.CheckedItems.Contains(selectedIdea))
                {
                    foreach(Control ideaControl in flowPanel.Controls)
                    {
                        if (ideaControl.Name == selectedIdea)
                        {
                            flowPanel.Controls.Remove(ideaControl);
                            SelectedIdeas.Remove(selectedIdea);
                            break;
                        }
                    }
                    break;
                }
            }            
        }
    }
}
