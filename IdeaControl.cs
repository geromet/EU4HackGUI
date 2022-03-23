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
        public int Id { get; set; }
        public void SetLabel(string label)
        {
            Idea.Text = label;
        }

        private void Add_Click(object sender, EventArgs e)
        { 
            double value = Double.Parse(Value.Text);
            value += 0.1f;
            Value.Text = Math.Round(value, 2).ToString();
        }

        private void Value_TextChanged(object sender, EventArgs e)
        {
            CheckNumeric();
        }

        private void Substract_Click(object sender, EventArgs e)
        {
            double value = Double.Parse(Value.Text);
            value -= 0.1f;
            Value.Text = Math.Round(value, 2).ToString();
        }

        void CheckNumeric()
        {
            if (Value.Text.StartsWith(","))
            {
                Value.Text = "0";
            }
            if (Value.Text.Length == 0)
            {
                Value.Text = "0";
            }
            
            Value.Text = Math.Round(Double.Parse(Regex.Replace(Value.Text, "[^-,0-9]", "")), 2).ToString();
        }
    }
}
