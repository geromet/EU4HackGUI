using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Eu4HackGUI
{
    partial class GUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.Panel();
            this.ProvincesButton = new System.Windows.Forms.Button();
            this.DevToolsButton = new System.Windows.Forms.Button();
            this.IdeasButton = new System.Windows.Forms.Button();
            this.HackButton = new System.Windows.Forms.Button();
            this.Space = new System.Windows.Forms.Panel();
            this.DevToolsControl = new Eu4HackGUI.Controls.DevToolsControl();
            this.HackControl = new Eu4HackGUI.Controls.HackControl();
            this.IdeasControl = new Eu4HackGUI.Controls.IdeasControl();
            this.Menu.SuspendLayout();
            this.Space.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Menu.Controls.Add(this.ProvincesButton);
            this.Menu.Controls.Add(this.DevToolsButton);
            this.Menu.Controls.Add(this.IdeasButton);
            this.Menu.Controls.Add(this.HackButton);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(100, 428);
            this.Menu.TabIndex = 0;
            // 
            // ProvincesButton
            // 
            this.ProvincesButton.AutoSize = true;
            this.ProvincesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ProvincesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProvincesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProvincesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ProvincesButton.FlatAppearance.BorderSize = 0;
            this.ProvincesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ProvincesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ProvincesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProvincesButton.ForeColor = System.Drawing.Color.DimGray;
            this.ProvincesButton.Location = new System.Drawing.Point(0, 96);
            this.ProvincesButton.Name = "ProvincesButton";
            this.ProvincesButton.Size = new System.Drawing.Size(100, 32);
            this.ProvincesButton.TabIndex = 0;
            this.ProvincesButton.Text = "Provinces";
            this.ProvincesButton.UseVisualStyleBackColor = false;
            // 
            // DevToolsButton
            // 
            this.DevToolsButton.AutoSize = true;
            this.DevToolsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DevToolsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DevToolsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DevToolsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DevToolsButton.FlatAppearance.BorderSize = 0;
            this.DevToolsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DevToolsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DevToolsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DevToolsButton.ForeColor = System.Drawing.Color.DimGray;
            this.DevToolsButton.Location = new System.Drawing.Point(0, 64);
            this.DevToolsButton.Name = "DevToolsButton";
            this.DevToolsButton.Size = new System.Drawing.Size(100, 32);
            this.DevToolsButton.TabIndex = 1;
            this.DevToolsButton.Text = "DevTools";
            this.DevToolsButton.UseVisualStyleBackColor = false;
            // 
            // IdeasButton
            // 
            this.IdeasButton.AutoSize = true;
            this.IdeasButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.IdeasButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IdeasButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.IdeasButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.IdeasButton.FlatAppearance.BorderSize = 0;
            this.IdeasButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.IdeasButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.IdeasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IdeasButton.ForeColor = System.Drawing.Color.DimGray;
            this.IdeasButton.Location = new System.Drawing.Point(0, 32);
            this.IdeasButton.Name = "IdeasButton";
            this.IdeasButton.Size = new System.Drawing.Size(100, 32);
            this.IdeasButton.TabIndex = 2;
            this.IdeasButton.Text = "Ideas";
            this.IdeasButton.UseVisualStyleBackColor = false;
            this.IdeasButton.Click += new System.EventHandler(this.IdeasButton_Click);
            // 
            // HackButton
            // 
            this.HackButton.AutoSize = true;
            this.HackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.HackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HackButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HackButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.HackButton.FlatAppearance.BorderSize = 0;
            this.HackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.HackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.HackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HackButton.ForeColor = System.Drawing.Color.DimGray;
            this.HackButton.Location = new System.Drawing.Point(0, 0);
            this.HackButton.Name = "HackButton";
            this.HackButton.Size = new System.Drawing.Size(100, 32);
            this.HackButton.TabIndex = 3;
            this.HackButton.Text = "Hack";
            this.HackButton.UseVisualStyleBackColor = false;
            // 
            // Space
            // 
            this.Space.Controls.Add(this.IdeasControl);
            this.Space.Controls.Add(this.DevToolsControl);
            this.Space.Controls.Add(this.HackControl);
            this.Space.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Space.Location = new System.Drawing.Point(100, 0);
            this.Space.Name = "Space";
            this.Space.Size = new System.Drawing.Size(700, 428);
            this.Space.TabIndex = 1;
            // 
            // DevToolsControl
            // 
            this.DevToolsControl.AutoSize = true;
            this.DevToolsControl.BackColor = System.Drawing.Color.Black;
            this.DevToolsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DevToolsControl.Enabled = false;
            this.DevToolsControl.Location = new System.Drawing.Point(0, 0);
            this.DevToolsControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DevToolsControl.MinimumSize = new System.Drawing.Size(171, 95);
            this.DevToolsControl.Name = "DevToolsControl";
            this.DevToolsControl.Size = new System.Drawing.Size(700, 428);
            this.DevToolsControl.TabIndex = 1;
            this.DevToolsControl.Visible = false;
            // 
            // HackControl
            // 
            this.HackControl.AutoSize = true;
            this.HackControl.BackColor = System.Drawing.Color.Black;
            this.HackControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HackControl.Enabled = false;
            this.HackControl.Location = new System.Drawing.Point(0, 0);
            this.HackControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HackControl.MinimumSize = new System.Drawing.Size(171, 95);
            this.HackControl.Name = "HackControl";
            this.HackControl.Size = new System.Drawing.Size(700, 428);
            this.HackControl.TabIndex = 0;
            this.HackControl.Visible = false;
            // 
            // IdeasControl
            // 
            this.IdeasControl.AutoSize = true;
            this.IdeasControl.BackColor = System.Drawing.Color.Black;
            this.IdeasControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdeasControl.Location = new System.Drawing.Point(0, 0);
            this.IdeasControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IdeasControl.MinimumSize = new System.Drawing.Size(171, 95);
            this.IdeasControl.Name = "IdeasControl";
            this.IdeasControl.Size = new System.Drawing.Size(700, 428);
            this.IdeasControl.TabIndex = 2;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.Space);
            this.Controls.Add(this.Menu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "GUI";
            this.ShowIcon = false;
            this.Text = "GUI";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.Space.ResumeLayout(false);
            this.Space.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private Panel Menu;
        private Button ProvincesButton;
        private Button DevToolsButton;
        private Button IdeasButton;
        private Button HackButton;
        private Panel Space;
        private Controls.HackControl HackControl;
        private Controls.DevToolsControl DevToolsControl;
        private Controls.IdeasControl IdeasControl;
    }
}