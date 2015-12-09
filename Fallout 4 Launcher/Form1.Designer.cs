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
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnEnableMods = new System.Windows.Forms.Button();
            this.btnSetReadOnly = new System.Windows.Forms.Button();
            this.tabMods = new System.Windows.Forms.TabPage();
            this.btnOpenDataFolder = new System.Windows.Forms.Button();
            this.txtDataDirectory = new System.Windows.Forms.TextBox();
            this.btnDeactivateSelected = new System.Windows.Forms.Button();
            this.btnActivateSelected = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listAvailableMods = new System.Windows.Forms.CheckedListBox();
            this.listActiveMods = new System.Windows.Forms.CheckedListBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.chkSkipLauncher = new System.Windows.Forms.CheckBox();
            this.miscSettingsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGameLauncher = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLaunch)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.tabMods.SuspendLayout();
            this.miscSettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGame);
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Controls.Add(this.tabMods);
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
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(537, 318);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(90, 23);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "Backup Configs";
            this.toolTip.SetToolTip(this.btnBackup, "Creates a copy of your config files located\r\nin the same folder as the original.");
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(3, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Reload";
            this.toolTip.SetToolTip(this.btnReload, "Reloads any file loaded by the launcher(configs)");
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnEnableMods
            // 
            this.btnEnableMods.Location = new System.Drawing.Point(8, 48);
            this.btnEnableMods.Name = "btnEnableMods";
            this.btnEnableMods.Size = new System.Drawing.Size(113, 36);
            this.btnEnableMods.TabIndex = 1;
            this.btnEnableMods.Text = "Enable Loading Mods";
            this.toolTip.SetToolTip(this.btnEnableMods, "Enables the ability to load mods by adding required lines to INI files");
            this.btnEnableMods.UseVisualStyleBackColor = true;
            this.btnEnableMods.Click += new System.EventHandler(this.btnEnableMods_Click);
            // 
            // btnSetReadOnly
            // 
            this.btnSetReadOnly.Location = new System.Drawing.Point(8, 6);
            this.btnSetReadOnly.Name = "btnSetReadOnly";
            this.btnSetReadOnly.Size = new System.Drawing.Size(113, 36);
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
            this.tabMods.Controls.Add(this.label2);
            this.tabMods.Controls.Add(this.label1);
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
            this.txtDataDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.label2.Location = new System.Drawing.Point(383, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inactive:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(8, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Active:";
            // 
            // listAvailableMods
            // 
            this.listAvailableMods.BackColor = System.Drawing.SystemColors.Control;
            this.listAvailableMods.FormattingEnabled = true;
            this.listAvailableMods.Location = new System.Drawing.Point(387, 77);
            this.listAvailableMods.Name = "listAvailableMods";
            this.listAvailableMods.Size = new System.Drawing.Size(240, 229);
            this.listAvailableMods.TabIndex = 1;
            // 
            // listActiveMods
            // 
            this.listActiveMods.AllowDrop = true;
            this.listActiveMods.BackColor = System.Drawing.SystemColors.Control;
            this.listActiveMods.FormattingEnabled = true;
            this.listActiveMods.Location = new System.Drawing.Point(8, 77);
            this.listActiveMods.Name = "listActiveMods";
            this.listActiveMods.Size = new System.Drawing.Size(240, 229);
            this.listActiveMods.TabIndex = 0;
            // 
            // chkSkipLauncher
            // 
            this.chkSkipLauncher.AutoSize = true;
            this.chkSkipLauncher.BackColor = System.Drawing.Color.Transparent;
            this.chkSkipLauncher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.chkSkipLauncher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.chkSkipLauncher.Location = new System.Drawing.Point(8, 90);
            this.chkSkipLauncher.Name = "chkSkipLauncher";
            this.chkSkipLauncher.Size = new System.Drawing.Size(116, 44);
            this.chkSkipLauncher.TabIndex = 4;
            this.chkSkipLauncher.Text = "Skip Game\r\n Launcher";
            this.toolTip.SetToolTip(this.chkSkipLauncher, "Renames the executables to skip the default launcher\r\n(creates a backup of origin" +
        "al two files)");
            this.chkSkipLauncher.UseVisualStyleBackColor = false;
            this.chkSkipLauncher.CheckedChanged += new System.EventHandler(this.chkSkipLauncher_CheckedChanged);
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
            // btnGameLauncher
            // 
            this.btnGameLauncher.Location = new System.Drawing.Point(84, 3);
            this.btnGameLauncher.Name = "btnGameLauncher";
            this.btnGameLauncher.Size = new System.Drawing.Size(130, 23);
            this.btnGameLauncher.TabIndex = 3;
            this.btnGameLauncher.Text = "Open Game Launcher";
            this.btnGameLauncher.UseVisualStyleBackColor = true;
            this.btnGameLauncher.Visible = false;
            this.btnGameLauncher.Click += new System.EventHandler(this.btnGameLauncher_Click);
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
            this.tabMods.ResumeLayout(false);
            this.tabMods.PerformLayout();
            this.miscSettingsPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox listAvailableMods;
        private System.Windows.Forms.CheckedListBox listActiveMods;
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
    }
}

