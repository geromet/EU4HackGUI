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
        private void IdeaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(var idea in IdeaListBox.CheckedItems)
            {
                if (!Controller.GetSelectedIdeas().Contains(idea.ToString()))
                {
                    Controller.AddIdea(idea.ToString());
                    IdeaControl ideaControl = new IdeaControl();
                    ideaControl.SetLabel(idea.ToString());
                    ideaControl.Name = idea.ToString();
                    flowPanel.Controls.Add(ideaControl);
                }

            }
            foreach(string selectedIdea in Controller.GetSelectedIdeas())
            {
                if (!IdeaListBox.CheckedItems.Contains(selectedIdea))
                {
                    foreach(Control ideaControl in flowPanel.Controls)
                    {
                        if (ideaControl.Name == selectedIdea)
                        {
                            flowPanel.Controls.Remove(ideaControl);
                            Controller.RemoveIdea(selectedIdea);
                            break;
                        }
                    }
                    break;
                }
            }            
        }

        private void HackCountryIdeas_Click(object sender, EventArgs e)
        {
            Eu4HackGUI.Hack.Hack.Run(1, 1);
        }
    }
}
