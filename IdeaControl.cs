using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Eu4HackGUI
{
    public partial class IdeaControl : UserControl
    {
        public IdeaControl()
        {
            InitializeComponent();
        }
        public void SetLabel(string label)
        {
            Idea.Text = label;
        }
        private void Add_Click(object sender, EventArgs e) => Value.Text = SetValue(Math.Round(Double.Parse(Value.Text)+0.1f, 2).ToString());            
        private void Value_TextChanged(object sender, EventArgs e) => SetValue(Value.Text);
        private void Substract_Click(object sender, EventArgs e) => Value.Text = SetValue(Math.Round(Double.Parse(Value.Text)-0.1f, 2).ToString());
        private string SetValue(string value) => 
            value.StartsWith(",") || 
            value.Length == 0 || 
            value == "-0" 
                ? value = "0" 
                : value = (Math.Round(Double.Parse(Regex.Replace(value, "[^-,0-9]", "")), 2).ToString());
    }
}
