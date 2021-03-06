
namespace Eu4HackGUI
{
    partial class IdeaControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Idea = new System.Windows.Forms.Label();
            this.Value = new System.Windows.Forms.TextBox();
            this.Substract = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Idea
            // 
            this.Idea.AutoEllipsis = true;
            this.Idea.AutoSize = true;
            this.Idea.Dock = System.Windows.Forms.DockStyle.Top;
            this.Idea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Idea.Location = new System.Drawing.Point(0, 0);
            this.Idea.MaximumSize = new System.Drawing.Size(100, 0);
            this.Idea.Name = "Idea";
            this.Idea.Size = new System.Drawing.Size(29, 13);
            this.Idea.TabIndex = 0;
            this.Idea.Text = "Idea";
            this.Idea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Value
            // 
            this.Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Value.Location = new System.Drawing.Point(3, 37);
            this.Value.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(26, 22);
            this.Value.TabIndex = 1;
            this.Value.Text = "0";
            // 
            // Substract
            // 
            this.Substract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Substract.AutoSize = true;
            this.Substract.Location = new System.Drawing.Point(52, 37);
            this.Substract.Margin = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.Substract.Name = "Substract";
            this.Substract.Size = new System.Drawing.Size(26, 23);
            this.Substract.TabIndex = 2;
            this.Substract.Text = "-";
            this.Substract.UseVisualStyleBackColor = true;
            this.Substract.Click += new System.EventHandler(this.Substract_Click);
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Add.AutoSize = true;
            this.Add.Location = new System.Drawing.Point(82, 37);
            this.Add.Margin = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(26, 23);
            this.Add.TabIndex = 3;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // IdeaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Substract);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.Idea);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IdeaControl";
            this.Size = new System.Drawing.Size(110, 65);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Idea;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.Button Substract;
        private System.Windows.Forms.Button Add;
    }
}