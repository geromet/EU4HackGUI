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
    public partial class IdeasControl : UserControl
    {
        public IdeasControl()
        {
            InitializeComponent();
        }
        private void IdeaListBox_ItemCheck(object sender, ItemCheckEventArgs e) => IdeaItemCheck(sender);
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
    }
}
