namespace Eu4HackGUI.Controls
{
    partial class DevToolsControl
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
            this.CreateCountrySelectionSwitch = new System.Windows.Forms.Button();
            this.CreateCountryList = new System.Windows.Forms.Button();
            this.CreateIdeaList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateCountrySelectionSwitch
            // 
            this.CreateCountrySelectionSwitch.AutoSize = true;
            this.CreateCountrySelectionSwitch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateCountrySelectionSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CreateCountrySelectionSwitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateCountrySelectionSwitch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CreateCountrySelectionSwitch.FlatAppearance.BorderSize = 0;
            this.CreateCountrySelectionSwitch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CreateCountrySelectionSwitch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.CreateCountrySelectionSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateCountrySelectionSwitch.ForeColor = System.Drawing.Color.DarkGray;
            this.CreateCountrySelectionSwitch.Location = new System.Drawing.Point(0, 0);
            this.CreateCountrySelectionSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.CreateCountrySelectionSwitch.Name = "CreateCountrySelectionSwitch";
            this.CreateCountrySelectionSwitch.Size = new System.Drawing.Size(150, 25);
            this.CreateCountrySelectionSwitch.TabIndex = 0;
            this.CreateCountrySelectionSwitch.Text = "Create Country Selection Switch";
            this.CreateCountrySelectionSwitch.UseVisualStyleBackColor = false;
            // 
            // CreateCountryList
            // 
            this.CreateCountryList.AutoSize = true;
            this.CreateCountryList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateCountryList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CreateCountryList.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateCountryList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CreateCountryList.FlatAppearance.BorderSize = 0;
            this.CreateCountryList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CreateCountryList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.CreateCountryList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateCountryList.ForeColor = System.Drawing.Color.DarkGray;
            this.CreateCountryList.Location = new System.Drawing.Point(0, 25);
            this.CreateCountryList.Margin = new System.Windows.Forms.Padding(0);
            this.CreateCountryList.Name = "CreateCountryList";
            this.CreateCountryList.Size = new System.Drawing.Size(150, 25);
            this.CreateCountryList.TabIndex = 1;
            this.CreateCountryList.Text = "Create country list";
            this.CreateCountryList.UseVisualStyleBackColor = false;
            // 
            // CreateIdeaList
            // 
            this.CreateIdeaList.AutoSize = true;
            this.CreateIdeaList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateIdeaList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CreateIdeaList.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateIdeaList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CreateIdeaList.FlatAppearance.BorderSize = 0;
            this.CreateIdeaList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CreateIdeaList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.CreateIdeaList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateIdeaList.ForeColor = System.Drawing.Color.DarkGray;
            this.CreateIdeaList.Location = new System.Drawing.Point(0, 50);
            this.CreateIdeaList.Margin = new System.Windows.Forms.Padding(0);
            this.CreateIdeaList.Name = "CreateIdeaList";
            this.CreateIdeaList.Size = new System.Drawing.Size(150, 25);
            this.CreateIdeaList.TabIndex = 3;
            this.CreateIdeaList.Text = "CreateIdeaList";
            this.CreateIdeaList.UseVisualStyleBackColor = false;
            // 
            // DevToolsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.CreateIdeaList);
            this.Controls.Add(this.CreateCountryList);
            this.Controls.Add(this.CreateCountrySelectionSwitch);
            this.MinimumSize = new System.Drawing.Size(150, 75);
            this.Name = "DevToolsControl";
            this.Size = new System.Drawing.Size(150, 75);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateCountrySelectionSwitch;
        private System.Windows.Forms.Button CreateCountryList;
        private System.Windows.Forms.Button CreateIdeaList;
    }
}
