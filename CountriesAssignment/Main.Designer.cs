namespace CountriesAssignment
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CountryInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteCountryButton = new System.Windows.Forms.Button();
            this.SaveNewCountryButton = new System.Windows.Forms.Button();
            this.CountryNameText = new System.Windows.Forms.TextBox();
            this.CountryNameLabel = new System.Windows.Forms.Label();
            this.TradePotentialText = new System.Windows.Forms.TextBox();
            this.TradePotentialLabel = new System.Windows.Forms.Label();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.DelPartnerButton = new System.Windows.Forms.Button();
            this.AddPartnerButton = new System.Windows.Forms.Button();
            this.GDPText = new System.Windows.Forms.TextBox();
            this.InflationText = new System.Windows.Forms.TextBox();
            this.TradeBalanceText = new System.Windows.Forms.TextBox();
            this.HDIText = new System.Windows.Forms.TextBox();
            this.TradePartnersList = new System.Windows.Forms.ListBox();
            this.TradePartnersLabel = new System.Windows.Forms.Label();
            this.HDIRankingLabel = new System.Windows.Forms.Label();
            this.TradeBalanceLabel = new System.Windows.Forms.Label();
            this.InflationLabel = new System.Windows.Forms.Label();
            this.GDPGrowthLabel = new System.Windows.Forms.Label();
            this.CountryGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchResultsLabel = new System.Windows.Forms.Label();
            this.SearchCountryText = new System.Windows.Forms.TextBox();
            this.GenInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.TreeHeightText = new System.Windows.Forms.TextBox();
            this.NoOfCountriesText = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.NoOfCountriesLabel = new System.Windows.Forms.Label();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.CountriesList = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.CountryInfoGroupBox.SuspendLayout();
            this.CountryGroupBox.SuspendLayout();
            this.GenInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDatabaseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openDatabaseToolStripMenuItem
            // 
            this.openDatabaseToolStripMenuItem.Name = "openDatabaseToolStripMenuItem";
            this.openDatabaseToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.openDatabaseToolStripMenuItem.Text = "Open Database";
            this.openDatabaseToolStripMenuItem.Click += new System.EventHandler(this.OpenDatabaseToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // CountryInfoGroupBox
            // 
            this.CountryInfoGroupBox.Controls.Add(this.DeleteCountryButton);
            this.CountryInfoGroupBox.Controls.Add(this.SaveNewCountryButton);
            this.CountryInfoGroupBox.Controls.Add(this.CountryNameText);
            this.CountryInfoGroupBox.Controls.Add(this.CountryNameLabel);
            this.CountryInfoGroupBox.Controls.Add(this.TradePotentialText);
            this.CountryInfoGroupBox.Controls.Add(this.TradePotentialLabel);
            this.CountryInfoGroupBox.Controls.Add(this.SaveChangesButton);
            this.CountryInfoGroupBox.Controls.Add(this.DelPartnerButton);
            this.CountryInfoGroupBox.Controls.Add(this.AddPartnerButton);
            this.CountryInfoGroupBox.Controls.Add(this.GDPText);
            this.CountryInfoGroupBox.Controls.Add(this.InflationText);
            this.CountryInfoGroupBox.Controls.Add(this.TradeBalanceText);
            this.CountryInfoGroupBox.Controls.Add(this.HDIText);
            this.CountryInfoGroupBox.Controls.Add(this.TradePartnersList);
            this.CountryInfoGroupBox.Controls.Add(this.TradePartnersLabel);
            this.CountryInfoGroupBox.Controls.Add(this.HDIRankingLabel);
            this.CountryInfoGroupBox.Controls.Add(this.TradeBalanceLabel);
            this.CountryInfoGroupBox.Controls.Add(this.InflationLabel);
            this.CountryInfoGroupBox.Controls.Add(this.GDPGrowthLabel);
            this.CountryInfoGroupBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.CountryInfoGroupBox.Location = new System.Drawing.Point(454, 27);
            this.CountryInfoGroupBox.Name = "CountryInfoGroupBox";
            this.CountryInfoGroupBox.Size = new System.Drawing.Size(358, 391);
            this.CountryInfoGroupBox.TabIndex = 2;
            this.CountryInfoGroupBox.TabStop = false;
            this.CountryInfoGroupBox.Text = "View/Edit Country Information";
            // 
            // DeleteCountryButton
            // 
            this.DeleteCountryButton.Location = new System.Drawing.Point(127, 351);
            this.DeleteCountryButton.Name = "DeleteCountryButton";
            this.DeleteCountryButton.Size = new System.Drawing.Size(176, 23);
            this.DeleteCountryButton.TabIndex = 18;
            this.DeleteCountryButton.Text = "Delete Country";
            this.DeleteCountryButton.UseVisualStyleBackColor = true;
            this.DeleteCountryButton.Click += new System.EventHandler(this.DeleteCountryButton_Click);
            // 
            // SaveNewCountryButton
            // 
            this.SaveNewCountryButton.Location = new System.Drawing.Point(127, 321);
            this.SaveNewCountryButton.Name = "SaveNewCountryButton";
            this.SaveNewCountryButton.Size = new System.Drawing.Size(176, 23);
            this.SaveNewCountryButton.TabIndex = 17;
            this.SaveNewCountryButton.Text = "Save As New Country";
            this.SaveNewCountryButton.UseVisualStyleBackColor = true;
            this.SaveNewCountryButton.Click += new System.EventHandler(this.SaveNewCountryButton_Click);
            // 
            // CountryNameText
            // 
            this.CountryNameText.Location = new System.Drawing.Point(155, 17);
            this.CountryNameText.Name = "CountryNameText";
            this.CountryNameText.Size = new System.Drawing.Size(100, 20);
            this.CountryNameText.TabIndex = 16;
            // 
            // CountryNameLabel
            // 
            this.CountryNameLabel.AutoSize = true;
            this.CountryNameLabel.Location = new System.Drawing.Point(37, 22);
            this.CountryNameLabel.Name = "CountryNameLabel";
            this.CountryNameLabel.Size = new System.Drawing.Size(38, 13);
            this.CountryNameLabel.TabIndex = 15;
            this.CountryNameLabel.Text = "Name:";
            // 
            // TradePotentialText
            // 
            this.TradePotentialText.Location = new System.Drawing.Point(155, 253);
            this.TradePotentialText.Name = "TradePotentialText";
            this.TradePotentialText.Size = new System.Drawing.Size(100, 20);
            this.TradePotentialText.TabIndex = 14;
            this.TradePotentialText.Text = "N/A";
            // 
            // TradePotentialLabel
            // 
            this.TradePotentialLabel.AutoSize = true;
            this.TradePotentialLabel.Location = new System.Drawing.Point(35, 257);
            this.TradePotentialLabel.Name = "TradePotentialLabel";
            this.TradePotentialLabel.Size = new System.Drawing.Size(120, 13);
            this.TradePotentialLabel.TabIndex = 13;
            this.TradePotentialLabel.Text = "Biggest Trade Potential:";
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(258, 279);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(61, 36);
            this.SaveChangesButton.TabIndex = 12;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // DelPartnerButton
            // 
            this.DelPartnerButton.Location = new System.Drawing.Point(178, 279);
            this.DelPartnerButton.Name = "DelPartnerButton";
            this.DelPartnerButton.Size = new System.Drawing.Size(53, 36);
            this.DelPartnerButton.TabIndex = 11;
            this.DelPartnerButton.Text = "Delete Partner";
            this.DelPartnerButton.UseVisualStyleBackColor = true;
            this.DelPartnerButton.Click += new System.EventHandler(this.DelPartnerButton_Click);
            // 
            // AddPartnerButton
            // 
            this.AddPartnerButton.Location = new System.Drawing.Point(105, 280);
            this.AddPartnerButton.Name = "AddPartnerButton";
            this.AddPartnerButton.Size = new System.Drawing.Size(50, 37);
            this.AddPartnerButton.TabIndex = 10;
            this.AddPartnerButton.Text = "Add Partner";
            this.AddPartnerButton.UseVisualStyleBackColor = true;
            this.AddPartnerButton.Click += new System.EventHandler(this.AddPartnerButton_Click);
            // 
            // GDPText
            // 
            this.GDPText.Location = new System.Drawing.Point(155, 43);
            this.GDPText.Name = "GDPText";
            this.GDPText.Size = new System.Drawing.Size(100, 20);
            this.GDPText.TabIndex = 9;
            // 
            // InflationText
            // 
            this.InflationText.Location = new System.Drawing.Point(155, 67);
            this.InflationText.Name = "InflationText";
            this.InflationText.Size = new System.Drawing.Size(100, 20);
            this.InflationText.TabIndex = 8;
            // 
            // TradeBalanceText
            // 
            this.TradeBalanceText.Location = new System.Drawing.Point(155, 92);
            this.TradeBalanceText.Name = "TradeBalanceText";
            this.TradeBalanceText.Size = new System.Drawing.Size(100, 20);
            this.TradeBalanceText.TabIndex = 7;
            // 
            // HDIText
            // 
            this.HDIText.Location = new System.Drawing.Point(155, 119);
            this.HDIText.Name = "HDIText";
            this.HDIText.Size = new System.Drawing.Size(100, 20);
            this.HDIText.TabIndex = 6;
            // 
            // TradePartnersList
            // 
            this.TradePartnersList.FormattingEnabled = true;
            this.TradePartnersList.Location = new System.Drawing.Point(155, 148);
            this.TradePartnersList.Name = "TradePartnersList";
            this.TradePartnersList.Size = new System.Drawing.Size(132, 95);
            this.TradePartnersList.TabIndex = 5;
            // 
            // TradePartnersLabel
            // 
            this.TradePartnersLabel.AutoSize = true;
            this.TradePartnersLabel.Location = new System.Drawing.Point(37, 148);
            this.TradePartnersLabel.Name = "TradePartnersLabel";
            this.TradePartnersLabel.Size = new System.Drawing.Size(112, 13);
            this.TradePartnersLabel.TabIndex = 4;
            this.TradePartnersLabel.Text = "Main Trade Partner(s):";
            // 
            // HDIRankingLabel
            // 
            this.HDIRankingLabel.AutoSize = true;
            this.HDIRankingLabel.Location = new System.Drawing.Point(37, 120);
            this.HDIRankingLabel.Name = "HDIRankingLabel";
            this.HDIRankingLabel.Size = new System.Drawing.Size(72, 13);
            this.HDIRankingLabel.TabIndex = 3;
            this.HDIRankingLabel.Text = "HDI Ranking:";
            // 
            // TradeBalanceLabel
            // 
            this.TradeBalanceLabel.AutoSize = true;
            this.TradeBalanceLabel.Location = new System.Drawing.Point(35, 94);
            this.TradeBalanceLabel.Name = "TradeBalanceLabel";
            this.TradeBalanceLabel.Size = new System.Drawing.Size(80, 13);
            this.TradeBalanceLabel.TabIndex = 2;
            this.TradeBalanceLabel.Text = "Trade Balance:";
            // 
            // InflationLabel
            // 
            this.InflationLabel.AutoSize = true;
            this.InflationLabel.Location = new System.Drawing.Point(36, 70);
            this.InflationLabel.Name = "InflationLabel";
            this.InflationLabel.Size = new System.Drawing.Size(47, 13);
            this.InflationLabel.TabIndex = 1;
            this.InflationLabel.Text = "Inflation:";
            // 
            // GDPGrowthLabel
            // 
            this.GDPGrowthLabel.AutoSize = true;
            this.GDPGrowthLabel.Location = new System.Drawing.Point(36, 47);
            this.GDPGrowthLabel.Name = "GDPGrowthLabel";
            this.GDPGrowthLabel.Size = new System.Drawing.Size(70, 13);
            this.GDPGrowthLabel.TabIndex = 0;
            this.GDPGrowthLabel.Text = "GDP Growth:";
            // 
            // CountryGroupBox
            // 
            this.CountryGroupBox.Controls.Add(this.SearchResultsLabel);
            this.CountryGroupBox.Controls.Add(this.SearchCountryText);
            this.CountryGroupBox.Controls.Add(this.GenInfoGroupBox);
            this.CountryGroupBox.Controls.Add(this.InstructionLabel);
            this.CountryGroupBox.Controls.Add(this.CountriesList);
            this.CountryGroupBox.Location = new System.Drawing.Point(9, 27);
            this.CountryGroupBox.Name = "CountryGroupBox";
            this.CountryGroupBox.Size = new System.Drawing.Size(439, 279);
            this.CountryGroupBox.TabIndex = 4;
            this.CountryGroupBox.TabStop = false;
            this.CountryGroupBox.Text = "Search";
            // 
            // SearchResultsLabel
            // 
            this.SearchResultsLabel.AutoSize = true;
            this.SearchResultsLabel.Location = new System.Drawing.Point(172, 24);
            this.SearchResultsLabel.Name = "SearchResultsLabel";
            this.SearchResultsLabel.Size = new System.Drawing.Size(145, 13);
            this.SearchResultsLabel.TabIndex = 6;
            this.SearchResultsLabel.Text = "All Countries/Search Results:";
            // 
            // SearchCountryText
            // 
            this.SearchCountryText.Location = new System.Drawing.Point(6, 44);
            this.SearchCountryText.Name = "SearchCountryText";
            this.SearchCountryText.Size = new System.Drawing.Size(122, 20);
            this.SearchCountryText.TabIndex = 5;
            this.SearchCountryText.TextChanged += new System.EventHandler(this.SearchCountryText_TextChanged);
            // 
            // GenInfoGroupBox
            // 
            this.GenInfoGroupBox.Controls.Add(this.TreeHeightText);
            this.GenInfoGroupBox.Controls.Add(this.NoOfCountriesText);
            this.GenInfoGroupBox.Controls.Add(this.HeightLabel);
            this.GenInfoGroupBox.Controls.Add(this.NoOfCountriesLabel);
            this.GenInfoGroupBox.Location = new System.Drawing.Point(9, 169);
            this.GenInfoGroupBox.Name = "GenInfoGroupBox";
            this.GenInfoGroupBox.Size = new System.Drawing.Size(419, 100);
            this.GenInfoGroupBox.TabIndex = 4;
            this.GenInfoGroupBox.TabStop = false;
            this.GenInfoGroupBox.Text = "General Information";
            // 
            // TreeHeightText
            // 
            this.TreeHeightText.Location = new System.Drawing.Point(214, 54);
            this.TreeHeightText.Name = "TreeHeightText";
            this.TreeHeightText.Size = new System.Drawing.Size(113, 20);
            this.TreeHeightText.TabIndex = 5;
            // 
            // NoOfCountriesText
            // 
            this.NoOfCountriesText.Location = new System.Drawing.Point(214, 27);
            this.NoOfCountriesText.Name = "NoOfCountriesText";
            this.NoOfCountriesText.Size = new System.Drawing.Size(113, 20);
            this.NoOfCountriesText.TabIndex = 4;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(89, 57);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(78, 13);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "Height of Tree:";
            // 
            // NoOfCountriesLabel
            // 
            this.NoOfCountriesLabel.AutoSize = true;
            this.NoOfCountriesLabel.Location = new System.Drawing.Point(88, 29);
            this.NoOfCountriesLabel.Name = "NoOfCountriesLabel";
            this.NoOfCountriesLabel.Size = new System.Drawing.Size(106, 13);
            this.NoOfCountriesLabel.TabIndex = 1;
            this.NoOfCountriesLabel.Text = "Number of Countries:";
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.Location = new System.Drawing.Point(6, 22);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(88, 19);
            this.InstructionLabel.TabIndex = 1;
            this.InstructionLabel.Text = "Search by name:";
            // 
            // CountriesList
            // 
            this.CountriesList.FormattingEnabled = true;
            this.CountriesList.Location = new System.Drawing.Point(175, 40);
            this.CountriesList.Name = "CountriesList";
            this.CountriesList.Size = new System.Drawing.Size(192, 121);
            this.CountriesList.TabIndex = 0;
            this.CountriesList.SelectedIndexChanged += new System.EventHandler(this.CountriesList_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 430);
            this.Controls.Add(this.CountryGroupBox);
            this.Controls.Add(this.CountryInfoGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main - International Trading Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.CountryInfoGroupBox.ResumeLayout(false);
            this.CountryInfoGroupBox.PerformLayout();
            this.CountryGroupBox.ResumeLayout(false);
            this.CountryGroupBox.PerformLayout();
            this.GenInfoGroupBox.ResumeLayout(false);
            this.GenInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox CountryInfoGroupBox;
        private System.Windows.Forms.GroupBox CountryGroupBox;
        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.ListBox CountriesList;
        private System.Windows.Forms.Label SearchResultsLabel;
        private System.Windows.Forms.TextBox SearchCountryText;
        private System.Windows.Forms.GroupBox GenInfoGroupBox;
        private System.Windows.Forms.TextBox TreeHeightText;
        private System.Windows.Forms.TextBox NoOfCountriesText;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label NoOfCountriesLabel;
        private System.Windows.Forms.Label TradeBalanceLabel;
        private System.Windows.Forms.Label InflationLabel;
        private System.Windows.Forms.Label GDPGrowthLabel;
        private System.Windows.Forms.Button DelPartnerButton;
        private System.Windows.Forms.Button AddPartnerButton;
        private System.Windows.Forms.TextBox GDPText;
        private System.Windows.Forms.TextBox InflationText;
        private System.Windows.Forms.TextBox TradeBalanceText;
        private System.Windows.Forms.TextBox HDIText;
        private System.Windows.Forms.ListBox TradePartnersList;
        private System.Windows.Forms.Label TradePartnersLabel;
        private System.Windows.Forms.Label HDIRankingLabel;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.TextBox TradePotentialText;
        private System.Windows.Forms.Label TradePotentialLabel;
        private System.Windows.Forms.TextBox CountryNameText;
        private System.Windows.Forms.Label CountryNameLabel;
        private System.Windows.Forms.ToolStripMenuItem openDatabaseToolStripMenuItem;
        private System.Windows.Forms.Button DeleteCountryButton;
        private System.Windows.Forms.Button SaveNewCountryButton;
    }
}

