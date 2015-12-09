namespace Fallout_4_Launcher
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGame = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLaunch = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.miscSettingsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnGameLauncher = new System.Windows.Forms.Button();
            this.chkSkipLauncher = new System.Windows.Forms.CheckBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnEnableMods = new System.Windows.Forms.Button();
            this.btnSetReadOnly = new System.Windows.Forms.Button();
            this.tabMods = new System.Windows.Forms.TabPage();
            this.btnOpenDataFolder = new System.Windows.Forms.Button();
            this.txtDataDirectory = new System.Windows.Forms.TextBox();
            this.btnDeactivateSelected = new System.Windows.Forms.Button();
            this.btnActivateSelected = new System.Windows.Forms.Button();
            this.lblInactiveMods = new System.Windows.Forms.Label();
            this.lblActiveMods = new System.Windows.Forms.Label();
            this.listAvailableMods = new System.Windows.Forms.ListBox();
            this.listActiveMods = new System.Windows.Forms.ListBox();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.imgVaultBoy = new System.Windows.Forms.PictureBox();
            this.lblGitLink = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl.SuspendLayout();
            this.tabGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLaunch)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.miscSettingsPanel.SuspendLayout();
            this.tabMods.SuspendLayout();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVaultBoy)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGame);
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Controls.Add(this.tabMods);
            this.tabControl.Controls.Add(this.tabAbout);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(643, 375);
            this.tabControl.TabIndex = 0;
            // 
            // tabGame
            // 
            this.tabGame.BackColor = System.Drawing.SystemColors.Control;
            this.tabGame.BackgroundImage = global::Fallout_4_Launcher.Properties.Resources.blue_background;
            this.tabGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabGame.Controls.Add(this.pictureBox1);
            this.tabGame.Controls.Add(this.btnLaunch);
            this.tabGame.Controls.Add(this.button1);
            this.tabGame.Location = new System.Drawing.Point(4, 22);
            this.tabGame.Name = "tabGame";
            this.tabGame.Padding = new System.Windows.Forms.Padding(3);
            this.tabGame.Size = new System.Drawing.Size(635, 349);
            this.tabGame.TabIndex = 0;
            this.tabGame.Text = "Game";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Fallout_4_Launcher.Properties.Resources.fallout4_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 80);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Transparent;
            this.btnLaunch.BackgroundImage = global::Fallout_4_Launcher.Properties.Resources.vault111_door_play;
            this.btnLaunch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLaunch.Location = new System.Drawing.Point(222, 80);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(192, 190);
            this.btnLaunch.TabIndex = 1;
            this.btnLaunch.TabStop = false;
            this.toolTip.SetToolTip(this.btnLaunch, "Launch the game");
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(222, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 190);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.SystemColors.Control;
            this.tabSettings.BackgroundImage = global::Fallout_4_Launcher.Properties.Resources.blue_background;
            this.tabSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabSettings.Controls.Add(this.miscSettingsPanel);
            this.tabSettings.Controls.Add(this.chkSkipLauncher);
            this.tabSettings.Controls.Add(this.btnBackup);
            this.tabSettings.Controls.Add(this.btnEnableMods);
            this.tabSettings.Controls.Add(this.btnSetReadOnly);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(635, 349);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            // 
            // miscSettingsPanel
            // 
            this.miscSettingsPanel.BackColor = System.Drawing.Color.Transparent;
            this.miscSettingsPanel.Controls.Add(this.btnReload);
            this.miscSettingsPanel.Controls.Add(this.btnGameLauncher);
            this.miscSettingsPanel.Location = new System.Drawing.Point(8, 315);
            this.miscSettingsPanel.Name = "miscSettingsPanel";
            this.miscSettingsPanel.Size = new System.Drawing.Size(321, 28);
            this.miscSettingsPanel.TabIndex = 5;
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F);
            this.btnReload.Location = new System.Drawing.Point(3, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Reload";
            this.toolTip.SetToolTip(this.btnReload, "Reloads any file loaded by the launcher(configs)");
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnGameLauncher
            // 
            this.btnGameLauncher.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F);
            this.btnGameLauncher.Location = new System.Drawing.Point(84, 3);
            this.btnGameLauncher.Name = "btnGameLauncher";
            this.btnGameLauncher.Size = new System.Drawing.Size(130, 23);
            this.btnGameLauncher.TabIndex = 3;
            this.btnGameLauncher.Text = "Open Game Launcher";
            this.btnGameLauncher.UseVisualStyleBackColor = true;
            this.btnGameLauncher.Visible = false;
            this.btnGameLauncher.Click += new System.EventHandler(this.btnGameLauncher_Click);
            // 
            // chkSkipLauncher
            // 
            this.chkSkipLauncher.AutoSize = true;
            this.chkSkipLauncher.BackColor = System.Drawing.Color.Transparent;
            this.chkSkipLauncher.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSkipLauncher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.chkSkipLauncher.Location = new System.Drawing.Point(8, 102);
            this.chkSkipLauncher.Name = "chkSkipLauncher";
            this.chkSkipLauncher.Size = new System.Drawing.Size(93, 46);
            this.chkSkipLauncher.TabIndex = 4;
            this.chkSkipLauncher.Text = "Skip Game\r\n Launcher";
            this.toolTip.SetToolTip(this.chkSkipLauncher, "Renames the executables to skip the default launcher\r\n(creates a backup of origin" +
        "al two files)");
            this.chkSkipLauncher.UseVisualStyleBackColor = false;
            this.chkSkipLauncher.CheckedChanged += new System.EventHandler(this.chkSkipLauncher_CheckedChanged);
            // 
            // btnBackup
            // 
            this.btnBackup.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F);
            this.btnBackup.Location = new System.Drawing.Point(537, 318);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(90, 23);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "Backup Configs";
            this.toolTip.SetToolTip(this.btnBackup, "Creates a copy of your config files located\r\nin the same folder as the original.");
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnEnableMods
            // 
            this.btnEnableMods.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnableMods.Location = new System.Drawing.Point(8, 54);
            this.btnEnableMods.Name = "btnEnableMods";
            this.btnEnableMods.Size = new System.Drawing.Size(113, 42);
            this.btnEnableMods.TabIndex = 1;
            this.btnEnableMods.Text = "Enable Loading Mods";
            this.toolTip.SetToolTip(this.btnEnableMods, "Enables the ability to load mods by adding required lines to INI files");
            this.btnEnableMods.UseVisualStyleBackColor = true;
            this.btnEnableMods.Click += new System.EventHandler(this.btnEnableMods_Click);
            // 
            // btnSetReadOnly
            // 
            this.btnSetReadOnly.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F);
            this.btnSetReadOnly.Location = new System.Drawing.Point(8, 6);
            this.btnSetReadOnly.Name = "btnSetReadOnly";
            this.btnSetReadOnly.Size = new System.Drawing.Size(113, 42);
            this.btnSetReadOnly.TabIndex = 0;
            this.btnSetReadOnly.Text = "Toggle Read Only";
            this.toolTip.SetToolTip(this.btnSetReadOnly, "Toggles plugins.txt, Fallout4.ini, and Fallout4Prefs.ini from Read Only to Read W" +
        "rite and vice-versa");
            this.btnSetReadOnly.UseVisualStyleBackColor = true;
            this.btnSetReadOnly.Click += new System.EventHandler(this.btnSetReadOnly_Click);
            // 
            // tabMods
            // 
            this.tabMods.BackColor = System.Drawing.SystemColors.Control;
            this.tabMods.BackgroundImage = global::Fallout_4_Launcher.Properties.Resources.blue_background;
            this.tabMods.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabMods.Controls.Add(this.btnOpenDataFolder);
            this.tabMods.Controls.Add(this.txtDataDirectory);
            this.tabMods.Controls.Add(this.btnDeactivateSelected);
            this.tabMods.Controls.Add(this.btnActivateSelected);
            this.tabMods.Controls.Add(this.lblInactiveMods);
            this.tabMods.Controls.Add(this.lblActiveMods);
            this.tabMods.Controls.Add(this.listAvailableMods);
            this.tabMods.Controls.Add(this.listActiveMods);
            this.tabMods.Location = new System.Drawing.Point(4, 22);
            this.tabMods.Name = "tabMods";
            this.tabMods.Padding = new System.Windows.Forms.Padding(3);
            this.tabMods.Size = new System.Drawing.Size(635, 349);
            this.tabMods.TabIndex = 2;
            this.tabMods.Text = "Mods";
            // 
            // btnOpenDataFolder
            // 
            this.btnOpenDataFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenDataFolder.Location = new System.Drawing.Point(552, 17);
            this.btnOpenDataFolder.Name = "btnOpenDataFolder";
            this.btnOpenDataFolder.Size = new System.Drawing.Size(75, 26);
            this.btnOpenDataFolder.TabIndex = 7;
            this.btnOpenDataFolder.Text = "Open";
            this.btnOpenDataFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpenDataFolder.UseVisualStyleBackColor = true;
            this.btnOpenDataFolder.Click += new System.EventHandler(this.btnOpenDataFolder_Click);
            // 
            // txtDataDirectory
            // 
            this.txtDataDirectory.BackColor = System.Drawing.SystemColors.Control;
            this.txtDataDirectory.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataDirectory.Location = new System.Drawing.Point(8, 17);
            this.txtDataDirectory.Name = "txtDataDirectory";
            this.txtDataDirectory.Size = new System.Drawing.Size(541, 26);
            this.txtDataDirectory.TabIndex = 6;
            // 
            // btnDeactivateSelected
            // 
            this.btnDeactivateSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeactivateSelected.Location = new System.Drawing.Point(324, 115);
            this.btnDeactivateSelected.Name = "btnDeactivateSelected";
            this.btnDeactivateSelected.Size = new System.Drawing.Size(46, 23);
            this.btnDeactivateSelected.TabIndex = 5;
            this.btnDeactivateSelected.Text = "-->";
            this.btnDeactivateSelected.UseVisualStyleBackColor = true;
            this.btnDeactivateSelected.Click += new System.EventHandler(this.btnDeactivateSelected_Click);
            // 
            // btnActivateSelected
            // 
            this.btnActivateSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivateSelected.Location = new System.Drawing.Point(263, 115);
            this.btnActivateSelected.Name = "btnActivateSelected";
            this.btnActivateSelected.Size = new System.Drawing.Size(46, 23);
            this.btnActivateSelected.TabIndex = 4;
            this.btnActivateSelected.Text = "<--";
            this.btnActivateSelected.UseVisualStyleBackColor = true;
            this.btnActivateSelected.Click += new System.EventHandler(this.btnActivateSelected_Click);
            // 
            // lblInactiveMods
            // 
            this.lblInactiveMods.AutoSize = true;
            this.lblInactiveMods.BackColor = System.Drawing.Color.Transparent;
            this.lblInactiveMods.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInactiveMods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.lblInactiveMods.Location = new System.Drawing.Point(383, 54);
            this.lblInactiveMods.Name = "lblInactiveMods";
            this.lblInactiveMods.Size = new System.Drawing.Size(60, 21);
            this.lblInactiveMods.TabIndex = 3;
            this.lblInactiveMods.Text = "Inactive:";
            // 
            // lblActiveMods
            // 
            this.lblActiveMods.AutoSize = true;
            this.lblActiveMods.BackColor = System.Drawing.Color.Transparent;
            this.lblActiveMods.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveMods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.lblActiveMods.Location = new System.Drawing.Point(8, 54);
            this.lblActiveMods.Name = "lblActiveMods";
            this.lblActiveMods.Size = new System.Drawing.Size(50, 21);
            this.lblActiveMods.TabIndex = 2;
            this.lblActiveMods.Text = "Active:";
            // 
            // listAvailableMods
            // 
            this.listAvailableMods.BackColor = System.Drawing.SystemColors.Control;
            this.listAvailableMods.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAvailableMods.FormattingEnabled = true;
            this.listAvailableMods.ItemHeight = 16;
            this.listAvailableMods.Location = new System.Drawing.Point(387, 77);
            this.listAvailableMods.Name = "listAvailableMods";
            this.listAvailableMods.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listAvailableMods.Size = new System.Drawing.Size(240, 212);
            this.listAvailableMods.TabIndex = 1;
            // 
            // listActiveMods
            // 
            this.listActiveMods.AllowDrop = true;
            this.listActiveMods.BackColor = System.Drawing.SystemColors.Control;
            this.listActiveMods.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listActiveMods.FormattingEnabled = true;
            this.listActiveMods.ItemHeight = 16;
            this.listActiveMods.Location = new System.Drawing.Point(8, 77);
            this.listActiveMods.Name = "listActiveMods";
            this.listActiveMods.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listActiveMods.Size = new System.Drawing.Size(240, 212);
            this.listActiveMods.TabIndex = 0;
            // 
            // tabAbout
            // 
            this.tabAbout.BackgroundImage = global::Fallout_4_Launcher.Properties.Resources.blue_background;
            this.tabAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabAbout.Controls.Add(this.imgVaultBoy);
            this.tabAbout.Controls.Add(this.lblGitLink);
            this.tabAbout.Controls.Add(this.lblAbout);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(635, 349);
            this.tabAbout.TabIndex = 3;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // imgVaultBoy
            // 
            this.imgVaultBoy.BackgroundImage = global::Fallout_4_Launcher.Properties.Resources.vaultboy_thumbs;
            this.imgVaultBoy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgVaultBoy.Location = new System.Drawing.Point(388, 116);
            this.imgVaultBoy.Name = "imgVaultBoy";
            this.imgVaultBoy.Size = new System.Drawing.Size(239, 230);
            this.imgVaultBoy.TabIndex = 5;
            this.imgVaultBoy.TabStop = false;
            this.toolTip.SetToolTip(this.imgVaultBoy, "Thanks for downloading, if you could star the repo that would be awesome!");
            // 
            // lblGitLink
            // 
            this.lblGitLink.AutoSize = true;
            this.lblGitLink.BackColor = System.Drawing.Color.Transparent;
            this.lblGitLink.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGitLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.lblGitLink.Location = new System.Drawing.Point(81, 87);
            this.lblGitLink.Name = "lblGitLink";
            this.lblGitLink.Size = new System.Drawing.Size(349, 21);
            this.lblGitLink.TabIndex = 4;
            this.lblGitLink.Text = "https://github.com/FlakTheMighty/Fallout-4-Config-Tool";
            this.lblGitLink.Click += new System.EventHandler(this.lblGitLink_Click);
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.BackColor = System.Drawing.Color.Transparent;
            this.lblAbout.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.lblAbout.Location = new System.Drawing.Point(81, 3);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(472, 105);
            this.lblAbout.TabIndex = 3;
            this.lblAbout.Text = resources.GetString("lblAbout.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 375);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Fallout 4 Config Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLaunch)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.miscSettingsPanel.ResumeLayout(false);
            this.tabMods.ResumeLayout(false);
            this.tabMods.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVaultBoy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGame;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox btnLaunch;
        private System.Windows.Forms.Button btnSetReadOnly;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabPage tabMods;
        private System.Windows.Forms.Label lblInactiveMods;
        private System.Windows.Forms.Label lblActiveMods;
        private System.Windows.Forms.ListBox listAvailableMods;
        private System.Windows.Forms.ListBox listActiveMods;
        private System.Windows.Forms.Button btnDeactivateSelected;
        private System.Windows.Forms.Button btnActivateSelected;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnEnableMods;
        private System.Windows.Forms.TextBox txtDataDirectory;
        private System.Windows.Forms.Button btnOpenDataFolder;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.CheckBox chkSkipLauncher;
        private System.Windows.Forms.FlowLayoutPanel miscSettingsPanel;
        private System.Windows.Forms.Button btnGameLauncher;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Label lblGitLink;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.PictureBox imgVaultBoy;
    }
}

