namespace Eu4HackGUI.Controls
{
    partial class IdeasControl
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.IdeaListBox = new System.Windows.Forms.CheckedListBox();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.IdeaListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowPanel);
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.splitContainer1.Size = new System.Drawing.Size(231, 75);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 5;
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
            this.IdeaListBox.Size = new System.Drawing.Size(261, 75);
            this.IdeaListBox.Sorted = true;
            this.IdeaListBox.TabIndex = 2;
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
            this.flowPanel.Size = new System.Drawing.Size(25, 75);
            this.flowPanel.TabIndex = 3;
            // 
            // IdeasControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(150, 75);
            this.Name = "IdeasControl";
            this.Size = new System.Drawing.Size(231, 75);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox IdeaListBox;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
    }
}
