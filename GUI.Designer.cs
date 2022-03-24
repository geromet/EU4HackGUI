﻿using System.Collections.Generic;
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
            this.Main = new System.Windows.Forms.SplitContainer();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.DevToolsPanel = new System.Windows.Forms.Panel();
            this.CreateIdeaList = new System.Windows.Forms.Button();
            this.CreateCountrySelectionSwitch = new System.Windows.Forms.Button();
            this.CreateCountryList = new System.Windows.Forms.Button();
            this.SelectedCountry = new System.Windows.Forms.Label();
            this.Divider = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.HackButton = new System.Windows.Forms.Button();
            this.IdeasButton = new System.Windows.Forms.Button();
            this.ProvincesButton = new System.Windows.Forms.Button();
            this.DevToolsButton = new System.Windows.Forms.Button();
            this.HackPanel = new System.Windows.Forms.Panel();
            this.IdeasPanel = new System.Windows.Forms.Panel();
            this.ProvincesPanel = new System.Windows.Forms.Panel();
            this.IdeaSelection = new System.Windows.Forms.SplitContainer();
            this.IdeaListBox = new System.Windows.Forms.CheckedListBox();
            this.HorizontalContainer = new System.Windows.Forms.SplitContainer();
            this.SearchCountry = new System.Windows.Forms.TextBox();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Hack = new System.Windows.Forms.SplitContainer();
            this.TypeCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.Run = new System.Windows.Forms.Button();
            this.SelectedTypesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Main)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.Main.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.DevToolsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Divider)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.Divider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.HackPanel.SuspendLayout();
            this.IdeasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdeaSelection)).BeginInit();
            this.IdeaSelection.Panel1.SuspendLayout();
            this.IdeaSelection.Panel2.SuspendLayout();
            this.IdeaSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalContainer)).BeginInit();
            this.HorizontalContainer.Panel1.SuspendLayout();
            this.HorizontalContainer.Panel2.SuspendLayout();
            this.HorizontalContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hack)).BeginInit();
            this.Hack.Panel1.SuspendLayout();
            this.Hack.Panel2.SuspendLayout();
            this.Hack.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.Main.IsSplitterFixed = true;
            this.Main.Location = new System.Drawing.Point(10, 10);
            this.Main.Name = "Main";
            // 
            // Main.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MenuPanel);
            // 
            // Main.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ProvincesPanel);
            this.splitContainer1.Panel2.Controls.Add(this.IdeasPanel);
            this.splitContainer1.Panel2.Controls.Add(this.HackPanel);
            this.splitContainer1.Panel2.Controls.Add(this.DevToolsPanel);
            this.Main.Size = new System.Drawing.Size(780, 408);
            this.Main.SplitterDistance = 120;
            this.Main.SplitterWidth = 1;
            this.Main.TabIndex = 4;
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.Divider);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(120, 408);
            this.MenuPanel.TabIndex = 0;
            // 
            // DevToolsPanel
            // 
            this.DevToolsPanel.Controls.Add(this.SelectedCountry);
            this.DevToolsPanel.Controls.Add(this.CreateCountryList);
            this.DevToolsPanel.Controls.Add(this.CreateCountrySelectionSwitch);
            this.DevToolsPanel.Controls.Add(this.CreateIdeaList);
            this.DevToolsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DevToolsPanel.Location = new System.Drawing.Point(0, 0);
            this.DevToolsPanel.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.DevToolsPanel.Name = "DevToolsPanel";
            this.DevToolsPanel.Size = new System.Drawing.Size(659, 408);
            this.DevToolsPanel.TabIndex = 13;
            // 
            // CreateIdeaList
            // 
            this.CreateIdeaList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CreateIdeaList.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateIdeaList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CreateIdeaList.FlatAppearance.BorderSize = 0;
            this.CreateIdeaList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CreateIdeaList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CreateIdeaList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateIdeaList.ForeColor = System.Drawing.Color.DarkGray;
            this.CreateIdeaList.Location = new System.Drawing.Point(0, 0);
            this.CreateIdeaList.Margin = new System.Windows.Forms.Padding(0);
            this.CreateIdeaList.Name = "CreateIdeaList";
            this.CreateIdeaList.Size = new System.Drawing.Size(659, 28);
            this.CreateIdeaList.TabIndex = 13;
            this.CreateIdeaList.Text = "CreateIdeaList";
            this.CreateIdeaList.UseVisualStyleBackColor = false;
            // 
            // CreateCountrySelectionSwitch
            // 
            this.CreateCountrySelectionSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CreateCountrySelectionSwitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateCountrySelectionSwitch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CreateCountrySelectionSwitch.FlatAppearance.BorderSize = 0;
            this.CreateCountrySelectionSwitch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CreateCountrySelectionSwitch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CreateCountrySelectionSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateCountrySelectionSwitch.ForeColor = System.Drawing.Color.DarkGray;
            this.CreateCountrySelectionSwitch.Location = new System.Drawing.Point(0, 28);
            this.CreateCountrySelectionSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.CreateCountrySelectionSwitch.Name = "CreateCountrySelectionSwitch";
            this.CreateCountrySelectionSwitch.Size = new System.Drawing.Size(659, 28);
            this.CreateCountrySelectionSwitch.TabIndex = 14;
            this.CreateCountrySelectionSwitch.Text = "Create Country Selection Switch";
            this.CreateCountrySelectionSwitch.UseVisualStyleBackColor = false;
            // 
            // CreateCountryList
            // 
            this.CreateCountryList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CreateCountryList.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateCountryList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CreateCountryList.FlatAppearance.BorderSize = 0;
            this.CreateCountryList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CreateCountryList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CreateCountryList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateCountryList.ForeColor = System.Drawing.Color.DarkGray;
            this.CreateCountryList.Location = new System.Drawing.Point(0, 56);
            this.CreateCountryList.Margin = new System.Windows.Forms.Padding(0);
            this.CreateCountryList.Name = "CreateCountryList";
            this.CreateCountryList.Size = new System.Drawing.Size(659, 28);
            this.CreateCountryList.TabIndex = 15;
            this.CreateCountryList.Text = "Create country list";
            this.CreateCountryList.UseVisualStyleBackColor = false;
            // 
            // SelectedCountry
            // 
            this.SelectedCountry.AutoSize = true;
            this.SelectedCountry.ForeColor = System.Drawing.Color.DarkGray;
            this.SelectedCountry.Location = new System.Drawing.Point(269, 194);
            this.SelectedCountry.Name = "SelectedCountry";
            this.SelectedCountry.Size = new System.Drawing.Size(121, 20);
            this.SelectedCountry.TabIndex = 16;
            this.SelectedCountry.Text = "Selected Country";
            // 
            // Divider
            // 
            this.Divider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Divider.Location = new System.Drawing.Point(0, 0);
            this.Divider.Name = "Divider";
            this.Divider.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Divider.Panel1
            // 
            //this.splitContainer1.Panel1.Controls.Add(this.splitContainer1);
            // 
            // Divider.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.Divider.Size = new System.Drawing.Size(120, 408);
            this.Divider.SplitterDistance = 204;
            this.Divider.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.HackButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.IdeasButton);
            this.splitContainer1.Size = new System.Drawing.Size(120, 204);
            this.splitContainer1.SplitterDistance = 102;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ProvincesButton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.DevToolsButton);
            this.splitContainer2.Size = new System.Drawing.Size(120, 200);
            this.splitContainer2.SplitterDistance = 100;
            this.splitContainer2.TabIndex = 1;
            // 
            // HackButton
            // 
            this.HackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HackButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.HackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.HackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HackButton.ForeColor = System.Drawing.Color.DimGray;
            this.HackButton.Location = new System.Drawing.Point(0, 0);
            this.HackButton.Name = "HackButton";
            this.HackButton.Size = new System.Drawing.Size(120, 102);
            this.HackButton.TabIndex = 0;
            this.HackButton.Text = "Hack";
            this.HackButton.UseVisualStyleBackColor = true;
            this.HackButton.Click += new System.EventHandler(this.HackButton_Click);
            // 
            // IdeasButton
            // 
            this.IdeasButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdeasButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.IdeasButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.IdeasButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.IdeasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IdeasButton.ForeColor = System.Drawing.Color.DimGray;
            this.IdeasButton.Location = new System.Drawing.Point(0, 0);
            this.IdeasButton.Name = "IdeasButton";
            this.IdeasButton.Size = new System.Drawing.Size(120, 98);
            this.IdeasButton.TabIndex = 1;
            this.IdeasButton.Text = "Ideas";
            this.IdeasButton.UseVisualStyleBackColor = true;
            this.IdeasButton.Click += new System.EventHandler(this.IdeasButton_Click);
            // 
            // ProvincesButton
            // 
            this.ProvincesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProvincesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ProvincesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ProvincesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ProvincesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProvincesButton.ForeColor = System.Drawing.Color.DimGray;
            this.ProvincesButton.Location = new System.Drawing.Point(0, 0);
            this.ProvincesButton.Name = "ProvincesButton";
            this.ProvincesButton.Size = new System.Drawing.Size(120, 100);
            this.ProvincesButton.TabIndex = 1;
            this.ProvincesButton.Text = "Provinces";
            this.ProvincesButton.UseVisualStyleBackColor = true;
            this.ProvincesButton.Click += new System.EventHandler(this.ProvincesButton_Click);
            // 
            // DevToolsButton
            // 
            this.DevToolsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DevToolsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DevToolsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DevToolsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DevToolsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DevToolsButton.ForeColor = System.Drawing.Color.DimGray;
            this.DevToolsButton.Location = new System.Drawing.Point(0, 0);
            this.DevToolsButton.Name = "DevToolsButton";
            this.DevToolsButton.Size = new System.Drawing.Size(120, 96);
            this.DevToolsButton.TabIndex = 1;
            this.DevToolsButton.Text = "Dev Tools";
            this.DevToolsButton.UseVisualStyleBackColor = true;
            this.DevToolsButton.Click += new System.EventHandler(this.DevToolsButton_Click);
            // 
            // HackPanel
            // 
            this.HackPanel.Controls.Add(this.Hack);
            this.HackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HackPanel.Location = new System.Drawing.Point(0, 0);
            this.HackPanel.Name = "HackPanel";
            this.HackPanel.Size = new System.Drawing.Size(659, 408);
            this.HackPanel.TabIndex = 17;
            // 
            // IdeasPanel
            // 
            this.IdeasPanel.Controls.Add(this.IdeaSelection);
            this.IdeasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdeasPanel.Location = new System.Drawing.Point(0, 0);
            this.IdeasPanel.Name = "IdeasPanel";
            this.IdeasPanel.Size = new System.Drawing.Size(659, 408);
            this.IdeasPanel.TabIndex = 18;
            // 
            // ProvincesPanel
            // 
            this.ProvincesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProvincesPanel.Location = new System.Drawing.Point(0, 0);
            this.ProvincesPanel.Name = "ProvincesPanel";
            this.ProvincesPanel.Size = new System.Drawing.Size(659, 408);
            this.ProvincesPanel.TabIndex = 19;
            // 
            // IdeaSelection
            // 
            this.IdeaSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.IdeaSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdeaSelection.Enabled = false;
            this.IdeaSelection.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.IdeaSelection.IsSplitterFixed = true;
            this.IdeaSelection.Location = new System.Drawing.Point(0, 0);
            this.IdeaSelection.Name = "IdeaSelection";
            // 
            // IdeaSelection.Panel1
            // 
            this.IdeaSelection.Panel1.Controls.Add(this.IdeaListBox);
            // 
            // IdeaSelection.Panel2
            // 
            this.IdeaSelection.Panel2.Controls.Add(this.HorizontalContainer);
            this.IdeaSelection.Size = new System.Drawing.Size(659, 408);
            this.IdeaSelection.SplitterDistance = 200;
            this.IdeaSelection.SplitterWidth = 1;
            this.IdeaSelection.TabIndex = 5;
            this.IdeaSelection.Visible = false;
            // 
            // IdeaListBox
            // 
            this.IdeaListBox.BackColor = System.Drawing.Color.Black;
            this.IdeaListBox.CheckOnClick = true;
            this.IdeaListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdeaListBox.ForeColor = System.Drawing.Color.DarkGray;
            this.IdeaListBox.FormattingEnabled = true;
            this.IdeaListBox.Items.AddRange(new object[] {
            "adm_tech_cost_modifier",
            "administrative_efficiency",
            "advisor_cost",
            "advisor_pool",
            "ae_impact",
            "allowed_marine_fraction",
            "amount_of_banners",
            "army_tradition",
            "army_tradition_decay",
            "army_tradition_from_battle",
            "artillery_cost",
            "artillery_fire",
            "artillery_power",
            "auto_explore_adjacent_to_colony",
            "autonomy_change_time",
            "backrow_artillery_damage",
            "blockade_efficiency",
            "build_cost",
            "build_time",
            "burghers_influence_modifier",
            "burghers_loyalty_modifier",
            "capture_ship_chance",
            "caravan_power",
            "cav_to_inf_ratio",
            "cavalry_cost",
            "cavalry_fire",
            "cavalry_flanking",
            "cavalry_power",
            "church_loyalty_modifier",
            "church_power_modifier",
            "colonists",
            "core_creation",
            "culture_conversion_cost",
            "defensiveness",
            "development_cost",
            "devotion",
            "dip_tech_cost_modifier",
            "diplomatic_annexation_cost",
            "diplomatic_reputation",
            "diplomatic_upkeep",
            "diplomats",
            "discipline",
            "disengagement_chance",
            "drill_gain_modifier",
            "embargo_efficiency",
            "embracement_cost",
            "enforce_religion_cost",
            "envoy_travel_time",
            "expand_administration_cost",
            "fabricate_claims_cost",
            "female_advisor_chance",
            "fire_damage",
            "fire_damage_received",
            "flagship_cost",
            "fort_maintenance_modifier",
            "free_adm_policy",
            "free_dip_policy",
            "free_leader_pool",
            "free_mil_policy",
            "galley_cost",
            "galley_power",
            "garrison_size",
            "general_cost",
            "global_autonomy",
            "global_colonial_growth",
            "global_foreign_trade_power",
            "global_garrison_growth",
            "global_heretic_missionary_strength",
            "global_institution_spread",
            "global_manpower_modifier",
            "global_missionary_strength",
            "global_naval_engagement_modifier",
            "global_own_trade_power",
            "global_prov_trade_power_modifier",
            "global_regiment_cost",
            "global_regiment_recruit_speed",
            "global_sailors_modifier",
            "global_ship_cost",
            "global_ship_recruit_speed",
            "global_ship_trade_power",
            "global_spy_defence",
            "global_tariffs",
            "global_tax_modifier",
            "global_trade_goods_size_modifier",
            "global_trade_power",
            "global_unrest",
            "governing_capacity_modifier",
            "harsh_treatment_cost",
            "has_country_flag",
            "heavy_ship_cost",
            "heavy_ship_power",
            "heir_chance",
            "horde_unity",
            "hostile_attrition",
            "idea_claim_colonies",
            "idea_cost",
            "imperial_authority",
            "imperial_authority_value",
            "imperial_mandate",
            "improve_relation_modifier",
            "infantry_cost",
            "infantry_power",
            "inflation_reduction",
            "interest",
            "justify_trade_conflict_cost",
            "land_attrition",
            "land_forcelimit_modifier",
            "land_maintenance_modifier",
            "land_morale",
            "leader_land_fire",
            "leader_land_manuever",
            "leader_land_shock",
            "leader_naval_fire",
            "leader_naval_manuever",
            "leader_naval_shock",
            "leader_siege",
            "legitimacy",
            "liberty_desire",
            "liberty_desire_from_subject_development",
            "light_ship_cost",
            "light_ship_power",
            "loot_amount",
            "manpower_recovery_speed",
            "max_revolutionary_zeal",
            "may_establish_frontier",
            "may_explore",
            "may_perform_slave_raid",
            "may_perform_slave_raid_on_same_religion",
            "may_recruit_female_generals",
            "merc_maintenance_modifier",
            "mercenary_cost",
            "mercenary_discipline",
            "mercenary_manpower",
            "merchants",
            "meritocracy",
            "migration_cost",
            "mil_tech_cost_modifier",
            "min_autonomy_in_territories",
            "missionaries",
            "missionary_maintenance_cost",
            "monarch_diplomatic_power",
            "monarch_military_power",
            "monthly_fervor_increase",
            "monthly_piety",
            "movement_speed",
            "native_assimilation",
            "native_uprising_chance",
            "naval_attrition",
            "naval_forcelimit_modifier",
            "naval_maintenance_modifier",
            "naval_morale",
            "naval_tradition_from_battle",
            "navy_tradition",
            "navy_tradition_decay",
            "no_religion_penalty",
            "nobles_loyalty_modifier",
            "num_accepted_cultures",
            "own_coast_naval_combat_bonus",
            "papal_influence",
            "placed_merchant_power",
            "possible_dip_policy",
            "possible_policy",
            "power_projection_from_insults",
            "prestige",
            "prestige_decay",
            "prestige_from_land",
            "primary_culture",
            "privateer_efficiency",
            "production_efficiency",
            "province_warscore_cost",
            "range",
            "rebel_support_efficiency",
            "recover_army_morale_speed",
            "recover_navy_morale_speed",
            "reduced_liberty_desire",
            "reelection_cost",
            "reform_progress_growth",
            "reinforce_cost_modifier",
            "reinforce_speed",
            "religion_group",
            "religious_unity",
            "republican_tradition",
            "rival_border_fort_maintenance",
            "sailor_maintenance_modifer",
            "sailors_recovery_speed",
            "same_culture_advisor_cost",
            "ship_durability",
            "ship_power_propagation",
            "shock_damage",
            "shock_damage_received",
            "siege_ability",
            "siege_blockade_progress",
            "spy_offence",
            "stability_cost_modifier",
            "state_maintenance_modifier",
            "sunk_ship_morale_hit_recieved",
            "technology_cost",
            "tolerance_heathen",
            "tolerance_heretic",
            "tolerance_own",
            "trade_company_investment_cost",
            "trade_efficiency",
            "trade_range_modifier",
            "trade_steering",
            "transport_cost",
            "unjustified_demands",
            "vassal_forcelimit_bonus",
            "vassal_income",
            "war_exhaustion",
            "war_exhaustion_cost",
            "yearly_absolutism",
            "yearly_corruption",
            "yearly_tribal_allegiance",
            "years_of_nationalism"});
            this.IdeaListBox.Location = new System.Drawing.Point(0, 0);
            this.IdeaListBox.Name = "IdeaListBox";
            this.IdeaListBox.Size = new System.Drawing.Size(200, 408);
            this.IdeaListBox.Sorted = true;
            this.IdeaListBox.TabIndex = 3;
            // 
            // HorizontalContainer
            // 
            this.HorizontalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HorizontalContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.HorizontalContainer.IsSplitterFixed = true;
            this.HorizontalContainer.Location = new System.Drawing.Point(0, 0);
            this.HorizontalContainer.Name = "HorizontalContainer";
            this.HorizontalContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // HorizontalContainer.Panel1
            // 
            this.HorizontalContainer.Panel1.Controls.Add(this.SearchCountry);
            // 
            // HorizontalContainer.Panel2
            // 
            this.HorizontalContainer.Panel2.Controls.Add(this.flowPanel);
            this.HorizontalContainer.Size = new System.Drawing.Size(458, 408);
            this.HorizontalContainer.SplitterDistance = 25;
            this.HorizontalContainer.TabIndex = 6;
            // 
            // SearchCountry
            // 
            this.SearchCountry.AutoCompleteCustomSource.AddRange(new string[] {
            "Sweden",
            "Denmark",
            "Finland",
            "Gotland",
            "Norway",
            "Holstein",
            "Scandinavia",
            "Estonia",
            "Livonia",
            "Sapmi",
            "Karelia",
            "Iceland",
            "Achaea",
            "Albania",
            "Athens",
            "Bosnia",
            "Bulgaria",
            "Byzantium",
            "Corfu",
            "Croatia",
            "Crete",
            "Cyprus",
            "Dalmatia",
            "Epirus",
            "Greece",
            "The Knights",
            "Morea",
            "Moldavia",
            "Montenegro",
            "Naxos",
            "Ragusa",
            "Romania",
            "Serbia",
            "Transylvania",
            "Wallachia",
            "Hungary",
            "Nitra",
            "Ottomans",
            "Clanricarde",
            "Cornwall",
            "England",
            "Leinster",
            "Ireland",
            "Thomond",
            "Scotland",
            "Tyrone",
            "Wales",
            "Northumberland",
            "Great Britain",
            "Meath",
            "Ulster",
            "Desmond",
            "Sligo",
            "Kildare",
            "Gaeldom",
            "Ormond",
            "Tyrconnell",
            "Offaly",
            "Munster",
            "Mann",
            "The Isles",
            "Brazil",
            "Canada",
            "Chile",
            "Colombia",
            "Haiti",
            "La Plata",
            "Louisiana",
            "Mexico",
            "Peru",
            "Paraguay",
            "Quebec",
            "United Central America",
            "United States",
            "Venezuela",
            "Australia",
            "California",
            "Texas",
            "Cascadia",
            "Alaska",
            "Zealandia",
            "Illinois",
            "Florida",
            "Vermont",
            "Sonora",
            "West Indies",
            "Cuba",
            "Danzig",
            "Krakow",
            "Lithuania",
            "Livonian Order",
            "Mazovia",
            "Poland",
            "Prussia",
            "Kurland",
            "Riga",
            "Teutonic Order",
            "Commonwealth",
            "Galicia–Volhynia",
            "Kiev",
            "Chernigov",
            "Odoyev",
            "Alençon",
            "Strasbourg",
            "Armagnac",
            "Auvergne",
            "Avignon",
            "Bourbonnais",
            "Brittany",
            "Burgundy",
            "Champagne",
            "Corsica",
            "Dauphine",
            "Foix",
            "France",
            "Gascony",
            "Nevers",
            "Normandy",
            "Orleans",
            "Picardy",
            "Provence",
            "Sardinia-Piedmont",
            "Toulouse",
            "Berry",
            "Aachen",
            "Anhalt",
            "Ansbach",
            "Augsburg",
            "Baden",
            "Bavaria",
            "Bohemia",
            "Brandenburg",
            "Bremen",
            "Brunswick",
            "East Frisia",
            "Frankfurt",
            "Germany",
            "Austria",
            "Hamburg",
            "Hanover",
            "Hesse",
            "Holy Roman Empire",
            "Cleves",
            "Cologne",
            "Saxe-Lauenburg",
            "Lorraine",
            "Lüneburg",
            "Magdeburg",
            "Mainz",
            "Meissen",
            "Mecklenburg",
            "Münster",
            "Moravia",
            "Oldenburg",
            "The Palatinate",
            "Pomerania",
            "Saxony",
            "Silesia",
            "Salzburg",
            "Styria",
            "Switzerland",
            "Thuringia",
            "Tirol",
            "Trier",
            "Ulm",
            "Wurzburg",
            "Westphalia",
            "Wurttemberg",
            "Nuremberg",
            "Memmingen",
            "Verden",
            "Nassau",
            "Dortmund",
            "Dithmarschen",
            "Aragon",
            "Castile",
            "Catalonia",
            "Granada",
            "Navarra",
            "Portugal",
            "Spain",
            "Galicia",
            "León",
            "Andalusia",
            "Valencia",
            "Asturias",
            "Majorca",
            "Aquileia",
            "Etruria",
            "Ferrara",
            "Genoa",
            "Italy",
            "Mantua",
            "Milan",
            "Modena",
            "Naples",
            "The Papal State",
            "Parma",
            "Pisa",
            "Sardinia",
            "Savoy",
            "Sicily",
            "Siena",
            "Tuscany",
            "Urbino",
            "Venice",
            "Montferrat",
            "Lucca",
            "Florence",
            "Malta",
            "Brabant",
            "Flanders",
            "Friesland",
            "Gelre",
            "Hainaut",
            "Holland",
            "Liege",
            "Luxembourg",
            "Netherlands",
            "Utrecht",
            "Armenia",
            "Astrakhan",
            "Crimea",
            "Georgia",
            "Kazan",
            "Muscovy",
            "Novgorod",
            "Pskov",
            "Qasim",
            "Russia",
            "Ryazan",
            "Tver",
            "Ruthenia",
            "Yaroslavl",
            "Zaporozhie",
            "Nogai",
            "Sibir",
            "Polotsk",
            "Perm",
            "Theodoro",
            "Bashkiria",
            "Beloozero",
            "Rostov",
            "Great Horde",
            "Golden Horde",
            "Aden",
            "Haasa",
            "Anizah",
            "Arabia",
            "Ardalan",
            "Soran",
            "Dawasir",
            "Eretna",
            "Fadl",
            "Germiyan",
            "Hadramut",
            "Hejaz",
            "Lebanon",
            "Makuria",
            "Medina",
            "Mikhlaf",
            "Mahra",
            "Najd",
            "Najran",
            "Oman",
            "Rassids",
            "Shammar",
            "Sharjah",
            "Shirvan",
            "Yas",
            "Yemen",
            "Hisn Kayfa",
            "Bitlis",
            "Aq Qoyunlu",
            "Aydin",
            "Candar",
            "Dulkadir",
            "Iraq",
            "Karaman",
            "Syria",
            "Trebizond",
            "Saruhan",
            "Mentese",
            "Ramazan",
            "Avaria",
            "Kharabakh",
            "Samtskhe",
            "Ardabil",
            "Mushasha",
            "Rûm",
            "Algiers",
            "Fez",
            "Mamluks",
            "Morocco",
            "Tripoli",
            "Tunis",
            "Egypt",
            "Kabylia",
            "Tafilalt",
            "Sus",
            "Tlemcen",
            "Touggourt",
            "Djerid",
            "Fezzan",
            "Mzab",
            "Salé",
            "Tétouan",
            "Marrakesh",
            "Kazakh",
            "Khiva",
            "Uzbek",
            "Ferghana",
            "Bukhara",
            "Afghanistan",
            "Khorasan",
            "Persia",
            "Qara Qoyunlu",
            "Timurids",
            "Transoxiana",
            "Gilan",
            "Circassia",
            "Gazikumukh",
            "Imereti",
            "Mazandaran",
            "Hormuz",
            "Luristan",
            "Sistan",
            "Biapas",
            "Fars",
            "Kerman",
            "Yazd",
            "Isfahan",
            "Tabriz",
            "Basra",
            "Maregheh",
            "Ajam",
            "Aztec",
            "Cherokee",
            "Chimu",
            "Creek",
            "Huron",
            "Inca",
            "Iroquois",
            "Maya",
            "Shawnee",
            "Zapotec",
            "Ashanti",
            "Benin",
            "Ethiopia",
            "Kongo",
            "Mali",
            "Funj",
            "Songhai",
            "Kilwa",
            "Mutapa",
            "Adal",
            "Hausa",
            "Kanem Bornu",
            "Loango",
            "Oyo",
            "Segu",
            "Sokoto",
            "Jolof",
            "Sofala",
            "Mombasa",
            "Malindi",
            "Ajuuraan",
            "Mogadishu",
            "Ennarea",
            "Aussa",
            "Alodia",
            "Darfur",
            "Geledi",
            "Harar",
            "Hobyo",
            "Kaffa",
            "Medri Bahri",
            "Majeerteen",
            "Marehan",
            "Pate",
            "Warsangali",
            "Semien",
            "Beja",
            "Jimma",
            "Welayta",
            "Damot",
            "Hadiya",
            "Shewa",
            "Janjiro",
            "Dongola",
            "Tyo",
            "Soyo",
            "Kasanje",
            "Luba",
            "Lunda",
            "Chokwe",
            "Kikondja",
            "Kazembe",
            "Yaka",
            "Kalundwe",
            "Kuba",
            "Rwanda",
            "Burundi",
            "Buganda",
            "Nkore",
            "Karagwe",
            "Bunyoro",
            "Busoga",
            "Buha",
            "Maravi",
            "Lundu",
            "Tumbuka",
            "Makua",
            "Butua",
            "Imerina",
            "Sakalava",
            "Betsimisaraka",
            "Mahafaly",
            "Antemoro",
            "Annam",
            "Arakan",
            "Aceh",
            "Ayutthaya",
            "Bali",
            "Banten",
            "Brunei",
            "Champa",
            "Chagatai",
            "Champasak",
            "Dai Viet",
            "Japan",
            "Amago",
            "Asakura",
            "Chosokabe",
            "Date",
            "Hojo",
            "Hosokawa",
            "Hatakeyama",
            "Ikeda",
            "Imagawa",
            "Maeda",
            "Mori",
            "Oda",
            "Otomo",
            "Ouchi",
            "Shiba",
            "Shimazu",
            "Takeda",
            "Tokugawa",
            "Uesugi",
            "Yamana",
            "Nanbu",
            "Ashikaga",
            "Kitabatake",
            "Ainu",
            "Akamatsu",
            "Ando",
            "Chiba",
            "Isshiki",
            "Ito",
            "Kikuchi",
            "Kono",
            "Ogasawara",
            "Shoni",
            "Satake",
            "Toki",
            "Utsunomiya",
            "Tsutsui",
            "Mongolia",
            "Khmer",
            "Korea",
            "Lan Na",
            "Luang Prabang",
            "Lan Xang",
            "Majapahit",
            "Manchu",
            "Makassar",
            "Malacca",
            "Ming",
            "Mataram",
            "Oirat",
            "Pattani",
            "Pegu",
            "Qing",
            "Ryukyu",
            "Shan",
            "Sukhothai",
            "Sulu",
            "Taungu",
            "Tibet",
            "Tonkin",
            "Vientiane",
            "Zhou",
            "Shun",
            "Xi",
            "Yuan",
            "Tungning",
            "Ilkhanate",
            "Kalmyk",
            "Mongol Empire",
            "So",
            "Nivkh",
            "Solon",
            "Donghai",
            "Udege",
            "Yeren",
            "Haixi",
            "Jianzhou",
            "Korchin",
            "Khalkha",
            "Kara Del",
            "Dzungar",
            "Yarkand",
            "Chahar",
            "Khoshuud",
            "Sarig Yogir",
            "Tsang",
            "Kham",
            "Guge",
            "U",
            "Dali",
            "Yi",
            "Miao",
            "Min",
            "Yue",
            "Shu",
            "Ning",
            "Chu",
            "Tang",
            "Wu",
            "Qi",
            "Yan",
            "Jin",
            "Liang",
            "Qin",
            "Huai",
            "Changsheng",
            "Baluchistan",
            "Bengal",
            "Bijapur",
            "Bahmanis",
            "Delhi",
            "Golkonda",
            "Deccan",
            "Marathas",
            "Mughals",
            "Mysore",
            "Vijayanagar",
            "Ahmednagar",
            "Assam",
            "Gujarat",
            "Jaunpur",
            "Madurai",
            "Malwa",
            "Marwar",
            "Mewar",
            "Multan",
            "Nagpur",
            "Nepal",
            "Orissa",
            "Punjab",
            "Sindh",
            "Berar",
            "Jangladesh",
            "Carnatic",
            "Garha",
            "Garjat",
            "Gwalior",
            "Dhundhar",
            "Kashmir",
            "Keladi",
            "Khandesh",
            "Oudh",
            "Venad",
            "Calicut",
            "Mewat",
            "Baroda",
            "Bastar",
            "Bhutan",
            "Bundelkhand",
            "Kotte",
            "Jaisalmer",
            "Kachar",
            "Koch",
            "Kangra",
            "Kutch",
            "Kochin",
            "Manipur",
            "Hadoti",
            "Nagaur",
            "Rohilkhand",
            "Ladakh",
            "Baghelkhand",
            "Jaffna",
            "Patiala",
            "Garhwal",
            "Chanda",
            "Jharkhand",
            "Habsan",
            "Tirhut",
            "Rewa Kantha",
            "Baglana",
            "Tripura",
            "Sadiya",
            "Bharat",
            "Andhra",
            "Maldives",
            "Bishnupur",
            "Sikkim",
            "Idar",
            "Jhalavad",
            "Palitana",
            "Navanagar",
            "Rajkot",
            "Junagarh",
            "Porbandar",
            "Kalinjar",
            "Kalpi",
            "Sambalpur",
            "Patna",
            "Ratanpur",
            "Kalahandi",
            "Keonhjar",
            "Parlakhimidi",
            "Jeypore",
            "Surguja",
            "Kandy",
            "Telingana",
            "Kolathunad",
            "Dang",
            "Doti",
            "Gorkha",
            "Jumla",
            "Limbuwan",
            "Makwanpur",
            "Sirmur",
            "Kathmandu",
            "Kumaon",
            "Gingee",
            "Tanjore",
            "Sirhind",
            "Rajputana",
            "Bar",
            "Lübeck",
            "Smolensk",
            "Nizhny Novgorod",
            "Jerusalem",
            "Malaya",
            "Hindustan",
            "Abenaki",
            "Apache",
            "Assiniboine",
            "Blackfoot",
            "Caddo",
            "Chickasaw",
            "Choctaw",
            "Cheyenne",
            "Comanche",
            "Fox",
            "Illiniwek",
            "Lenape",
            "Mahican",
            "Mikmaq",
            "Miami",
            "Navajo",
            "Ojibwe",
            "Osage",
            "Ottawa",
            "Pawnee",
            "Pequot",
            "Pima",
            "Potawatomi",
            "Powhatan",
            "Pueblo",
            "Shoshone",
            "Sioux",
            "Susquehannock",
            "Cree",
            "Air",
            "Bonoman",
            "Dahomey",
            "Dagbon",
            "Fulo",
            "Jenné",
            "Kano",
            "Kaabu",
            "Kong",
            "Katsina",
            "Mossi",
            "Nupe",
            "Timbuktu",
            "Yao",
            "Yatenga",
            "Macina",
            "Zazzau",
            "Ndongo",
            "Ava",
            "Hsenwi",
            "Johor",
            "Kedah",
            "Ligor",
            "Muan Phuang",
            "Mong Yang",
            "Perak",
            "Mong Mao",
            "Mong Kawng",
            "Mong Pai",
            "Mong Nai",
            "Kale",
            "Hsipaw",
            "Prome",
            "Chukchi",
            "Khodynt",
            "Chavchuveny",
            "Kamchadals",
            "Buryatia",
            "Arapaho",
            "Colima",
            "Chinook",
            "Cocomes",
            "Haida",
            "Itza",
            "Kiche",
            "Kiowa",
            "Mixtec",
            "Salish",
            "Tarascan",
            "Tlapanec",
            "Tlaxcala",
            "Totonac",
            "Wichita",
            "Xiu",
            "Blambangan",
            "Buton",
            "Cirebon",
            "Demak",
            "Pagarruyung",
            "Palembang",
            "Pasai",
            "Siak",
            "Sunda",
            "Kutai",
            "Banjar",
            "Lanfang",
            "Lanao",
            "Luwu",
            "Maguindanao",
            "Ternate",
            "Tidore",
            "Madyas",
            "Pangasinan",
            "Tondo",
            "Maynila",
            "Cebu",
            "Butuan",
            "Cusco",
            "Calchaqui",
            "Mapuche",
            "Muisca",
            "Quito",
            "Cajamarca",
            "Huyla",
            "Potiguara",
            "Tupiniquim",
            "Tupinamba",
            "Tapuia",
            "Guarani",
            "Charrua",
            "Wanka",
            "Chachapoya",
            "Colla",
            "Charca",
            "Pacajes",
            "Arawak",
            "Carib",
            "Ichma",
            "Matlatzinca",
            "Coixtlahuaca",
            "Teotitlan",
            "Xalisco",
            "Guamar",
            "Huastec",
            "Chichimeca",
            "Otomi",
            "Yokotan",
            "Tzotzil",
            "Kaqchikel",
            "Chactemal",
            "Keres",
            "Zuni",
            "Mescalero",
            "Lipan",
            "Chorti",
            "Miskito",
            "Tairona",
            "Can Pech",
            "Tonala",
            "Yaqui",
            "Yokuts",
            "New Providence",
            "Port Royal",
            "Tortuga",
            "Libertatia",
            "Munich",
            "Landshut",
            "Ingolstadt",
            "Passau",
            "Bregenz",
            "Konstanz",
            "Rothenburg",
            "Bayreuth",
            "Regensburg",
            "Geneva",
            "Three Leagues",
            "Opole",
            "Glogow",
            "Bologna",
            "Padua",
            "Saluzzo",
            "Spoleto",
            "Wolgast",
            "Stettin",
            "Goslar",
            "Lusatia",
            "Rügen",
            "Cilli",
            "Herzegovina",
            "Trent",
            "Berg",
            "Mulhouse",
            "Bamberg",
            "Ruppin",
            "Lippe",
            "Paderborn",
            "Calenberg",
            "Donauwörth",
            "Osnabrück",
            "Verona",
            "Coburg",
            "Lotharingia",
            "Perugia",
            "Two Sicilies",
            "Franconia",
            "Swabia",
            "Jan Mayen",
            "Roman Empire",
            "Synthetics",
            "Jomsvikings",
            "Hashashin",
            "Israel",
            "Knights Templar",
            "Trapalanda"});
            this.SearchCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchCountry.BackColor = System.Drawing.Color.Black;
            this.SearchCountry.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchCountry.ForeColor = System.Drawing.Color.DarkGray;
            this.SearchCountry.Location = new System.Drawing.Point(0, 0);
            this.SearchCountry.Name = "SearchCountry";
            this.SearchCountry.Size = new System.Drawing.Size(458, 27);
            this.SearchCountry.TabIndex = 1;
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.AutoSize = true;
            this.flowPanel.BackColor = System.Drawing.Color.Black;
            this.flowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel.Location = new System.Drawing.Point(0, 0);
            this.flowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(458, 379);
            this.flowPanel.TabIndex = 5;
            // 
            // Hack
            // 
            this.Hack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Hack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Hack.Enabled = false;
            this.Hack.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.Hack.IsSplitterFixed = true;
            this.Hack.Location = new System.Drawing.Point(0, 0);
            this.Hack.Name = "Hack";
            // 
            // Hack.Panel1
            // 
            this.Hack.Panel1.Controls.Add(this.TypeCheckListBox);
            // 
            // Hack.Panel2
            // 
            this.Hack.Panel2.Controls.Add(this.Run);
            this.Hack.Panel2.Controls.Add(this.SelectedTypesLabel);
            this.Hack.Size = new System.Drawing.Size(659, 408);
            this.Hack.SplitterDistance = 200;
            this.Hack.SplitterWidth = 1;
            this.Hack.TabIndex = 6;
            // 
            // TypeCheckListBox
            // 
            this.TypeCheckListBox.BackColor = System.Drawing.Color.Black;
            this.TypeCheckListBox.CheckOnClick = true;
            this.TypeCheckListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.TypeCheckListBox.ForeColor = System.Drawing.Color.DarkGray;
            this.TypeCheckListBox.FormattingEnabled = true;
            this.TypeCheckListBox.Items.AddRange(new object[] {
            "Country_Ideas",
            "Provinces",
            "Countries"});
            this.TypeCheckListBox.Location = new System.Drawing.Point(0, 0);
            this.TypeCheckListBox.Name = "TypeCheckListBox";
            this.TypeCheckListBox.Size = new System.Drawing.Size(231, 408);
            this.TypeCheckListBox.TabIndex = 2;
            // 
            // Run
            // 
            this.Run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Run.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Run.FlatAppearance.BorderSize = 0;
            this.Run.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Run.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Run.ForeColor = System.Drawing.Color.DarkGray;
            this.Run.Location = new System.Drawing.Point(181, 190);
            this.Run.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(217, 29);
            this.Run.TabIndex = 4;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = false;
            // 
            // SelectedTypesLabel
            // 
            this.SelectedTypesLabel.AutoSize = true;
            this.SelectedTypesLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SelectedTypesLabel.Location = new System.Drawing.Point(0, 388);
            this.SelectedTypesLabel.Name = "SelectedTypesLabel";
            this.SelectedTypesLabel.Size = new System.Drawing.Size(106, 20);
            this.SelectedTypesLabel.TabIndex = 3;
            this.SelectedTypesLabel.Text = "None Selected";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.Main);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "GUI";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.Text = "GUI";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Main)).EndInit();
            this.Main.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.DevToolsPanel.ResumeLayout(false);
            this.DevToolsPanel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Divider)).EndInit();
            this.Divider.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.HackPanel.ResumeLayout(false);
            this.IdeasPanel.ResumeLayout(false);
            this.IdeaSelection.Panel1.ResumeLayout(false);
            this.IdeaSelection.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IdeaSelection)).EndInit();
            this.IdeaSelection.ResumeLayout(false);
            this.HorizontalContainer.Panel1.ResumeLayout(false);
            this.HorizontalContainer.Panel1.PerformLayout();
            this.HorizontalContainer.Panel2.ResumeLayout(false);
            this.HorizontalContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalContainer)).EndInit();
            this.HorizontalContainer.ResumeLayout(false);
            this.Hack.Panel1.ResumeLayout(false);
            this.Hack.Panel2.ResumeLayout(false);
            this.Hack.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hack)).EndInit();
            this.Hack.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        private SplitContainer Main;
        private Panel MenuPanel;
        private Panel DevToolsPanel;
        private Label SelectedCountry;
        private Button CreateCountryList;
        private Button CreateCountrySelectionSwitch;
        private Button CreateIdeaList;
        private SplitContainer splitContainer1;
        private Button HackButton;
        private Button IdeasButton;
        private SplitContainer Divider;
        private SplitContainer splitContainer2;
        private Button ProvincesButton;
        private Button DevToolsButton;
        private Panel ProvincesPanel;
        private Panel IdeasPanel;
        private Panel HackPanel;
        private SplitContainer IdeaSelection;
        private CheckedListBox IdeaListBox;
        private SplitContainer HorizontalContainer;
        private TextBox SearchCountry;
        private FlowLayoutPanel flowPanel;
        private SplitContainer Hack;
        private CheckedListBox TypeCheckListBox;
        private Button Run;
        private Label SelectedTypesLabel;
    }
}