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
            this.imgFallout4 = new System.Windows.Forms.PictureBox();
            this.btnLaunch = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabVideoSettings = new System.Windows.Forms.TabPage();
            this.chkLensFlare = new System.Windows.Forms.CheckBox();
            this.chkMotionBlur = new System.Windows.Forms.CheckBox();
            this.chkRainOcclusion = new System.Windows.Forms.CheckBox();
            this.chkWetness = new System.Windows.Forms.CheckBox();
            this.chkScreenSpaceReflections = new System.Windows.Forms.CheckBox();
            this.lblAmbientOcclusion = new System.Windows.Forms.Label();
            this.cmbAmbientOcclusion = new System.Windows.Forms.ComboBox();
            this.lblDOF = new System.Windows.Forms.Label();
            this.cmbDOF = new System.Windows.Forms.ComboBox();
            this.lblGodrayQualtiy = new System.Windows.Forms.Label();
            this.cmbGodrayQuality = new System.Windows.Forms.ComboBox();
            this.lblLightingQuality = new System.Windows.Forms.Label();
            this.cmbLightingQuality = new System.Windows.Forms.ComboBox();
            this.lblDecalQuantity = new System.Windows.Forms.Label();
            this.cmbDecalQuantity = new System.Windows.Forms.ComboBox();
            this.lblShadowDistance = new System.Windows.Forms.Label();
            this.cmbShadowDistance = new System.Windows.Forms.ComboBox();
            this.lblShadowQuality = new System.Windows.Forms.Label();
            this.cmbShadowQuality = new System.Windows.Forms.ComboBox();
            this.lblTextureQuality = new System.Windows.Forms.Label();
            this.cmbTextureQuality = new System.Windows.Forms.ComboBox();
            this.lblAnisotropicFiltering = new System.Windows.Forms.Label();
            this.cmbAnisotropicFiltering = new System.Windows.Forms.ComboBox();
            this.lblAntialiasing = new System.Windows.Forms.Label();
            this.cmbAntialiasing = new System.Windows.Forms.ComboBox();
            this.tabExtraSettings = new System.Windows.Forms.TabPage();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.chkCompanionApp = new System.Windows.Forms.CheckBox();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.grpFOV = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFOVThirdPerson = new System.Windows.Forms.TextBox();
            this.txtFOVFirstPerson = new System.Windows.Forms.TextBox();
            this.miscSettingsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnGameLauncher = new System.Windows.Forms.Button();
            this.btnRevertExecutables = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.imgVaultBoy = new System.Windows.Forms.PictureBox();
            this.lblGitLink = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnReloadMods = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFallout4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLaunch)).BeginInit();
            this.tabVideoSettings.SuspendLayout();
            this.tabExtraSettings.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            this.grpFOV.SuspendLayout();
            this.miscSettingsPanel.SuspendLayout();
            this.tabMods.SuspendLayout();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVaultBoy)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGame);
            this.tabControl.Controls.Add(this.tabVideoSettings);
            this.tabControl.Controls.Add(this.tabExtraSettings);
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
            this.tabGame.Controls.Add(this.imgFallout4);
            this.tabGame.Controls.Add(this.btnLaunch);
            this.tabGame.Controls.Add(this.button1);
            this.tabGame.Location = new System.Drawing.Point(4, 22);
            this.tabGame.Name = "tabGame";
            this.tabGame.Padding = new System.Windows.Forms.Padding(3);
            this.tabGame.Size = new System.Drawing.Size(635, 349);
            this.tabGame.TabIndex = 0;
            this.tabGame.Text = "Game";
            // 
            // imgFallout4
            // 
            this.imgFallout4.BackColor = System.Drawing.Color.Transparent;
            this.imgFallout4.BackgroundImage = global::Fallout_4_Launcher.Properties.Resources.fallout4_logo;
            this.imgFallout4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgFallout4.Location = new System.Drawing.Point(0, 269);
            this.imgFallout4.Name = "imgFallout4";
            this.imgFallout4.Size = new System.Drawing.Size(222, 80);
            this.imgFallout4.TabIndex = 2;
            this.imgFallout4.TabStop = false;
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
            // tabVideoSettings
            // 
            this.tabVideoSettings.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabVideoSettings.BackgroundImage = global::Fallout_4_Launcher.Properties.Resources.blue_background;
            this.tabVideoSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabVideoSettings.Controls.Add(this.chkLensFlare);
            this.tabVideoSettings.Controls.Add(this.chkMotionBlur);
            this.tabVideoSettings.Controls.Add(this.chkRainOcclusion);
            this.tabVideoSettings.Controls.Add(this.chkWetness);
            this.tabVideoSettings.Controls.Add(this.chkScreenSpaceReflections);
            this.tabVideoSettings.Controls.Add(this.lblAmbientOcclusion);
            this.tabVideoSettings.Controls.Add(this.cmbAmbientOcclusion);
            this.tabVideoSettings.Controls.Add(this.lblDOF);
            this.tabVideoSettings.Controls.Add(this.cmbDOF);
            this.tabVideoSettings.Controls.Add(this.lblGodrayQualtiy);
            this.tabVideoSettings.Controls.Add(this.cmbGodrayQuality);
            this.tabVideoSettings.Controls.Add(this.lblLightingQuality);
            this.tabVideoSettings.Controls.Add(this.cmbLightingQuality);
            this.tabVideoSettings.Controls.Add(this.lblDecalQuantity);
            this.tabVideoSettings.Controls.Add(this.cmbDecalQuantity);
            this.tabVideoSettings.Controls.Add(this.lblShadowDistance);
            this.tabVideoSettings.Controls.Add(this.cmbShadowDistance);
            this.tabVideoSettings.Controls.Add(this.lblShadowQuality);
            this.tabVideoSettings.Controls.Add(this.cmbShadowQuality);
            this.tabVideoSettings.Controls.Add(this.lblTextureQuality);
            this.tabVideoSettings.Controls.Add(this.cmbTextureQuality);
            this.tabVideoSettings.Controls.Add(this.lblAnisotropicFiltering);
            this.tabVideoSettings.Controls.Add(this.cmbAnisotropicFiltering);
            this.tabVideoSettings.Controls.Add(this.lblAntialiasing);
            this.tabVideoSettings.Controls.Add(this.cmbAntialiasing);
            this.tabVideoSettings.Location = new System.Drawing.Point(4, 22);
            this.tabVideoSettings.Name = "tabVideoSettings";
            this.tabVideoSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabVideoSettings.Size = new System.Drawing.Size(635, 349);
            this.tabVideoSettings.TabIndex = 4;
            this.tabVideoSettings.Text = "Video Settings";
            // 
            // chkLensFlare
            // 
            this.chkLensFlare.BackColor = System.Drawing.Color.Transparent;
            this.chkLensFlare.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.chkLensFlare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.chkLensFlare.Location = new System.Drawing.Point(401, 244);
            this.chkLensFlare.Name = "chkLensFlare";
            this.chkLensFlare.Size = new System.Drawing.Size(88, 25);
            this.chkLensFlare.TabIndex = 24;
            this.chkLensFlare.Text = "Lens Flare";
            this.chkLensFlare.UseVisualStyleBackColor = false;
            // 
            // chkMotionBlur
            // 
            this.chkMotionBlur.BackColor = System.Drawing.Color.Transparent;
            this.chkMotionBlur.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.chkMotionBlur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.chkMotionBlur.Location = new System.Drawing.Point(401, 203);
            this.chkMotionBlur.Name = "chkMotionBlur";
            this.chkMotionBlur.Size = new System.Drawing.Size(96, 25);
            this.chkMotionBlur.TabIndex = 23;
            this.chkMotionBlur.Text = "Motion Blur";
            this.chkMotionBlur.UseVisualStyleBackColor = false;
            // 
            // chkRainOcclusion
            // 
            this.chkRainOcclusion.BackColor = System.Drawing.Color.Transparent;
            this.chkRainOcclusion.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.chkRainOcclusion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.chkRainOcclusion.Location = new System.Drawing.Point(401, 162);
            this.chkRainOcclusion.Name = "chkRainOcclusion";
            this.chkRainOcclusion.Size = new System.Drawing.Size(116, 25);
            this.chkRainOcclusion.TabIndex = 22;
            this.chkRainOcclusion.Text = "Rain Occlusion";
            this.chkRainOcclusion.UseVisualStyleBackColor = false;
            // 
            // chkWetness
            // 
            this.chkWetness.BackColor = System.Drawing.Color.Transparent;
            this.chkWetness.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.chkWetness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.chkWetness.Location = new System.Drawing.Point(401, 121);
            this.chkWetness.Name = "chkWetness";
            this.chkWetness.Size = new System.Drawing.Size(77, 25);
            this.chkWetness.TabIndex = 21;
            this.chkWetness.Text = "Wetness";
            this.chkWetness.UseVisualStyleBackColor = false;
            // 
            // chkScreenSpaceReflections
            // 
            this.chkScreenSpaceReflections.BackColor = System.Drawing.Color.Transparent;
            this.chkScreenSpaceReflections.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.chkScreenSpaceReflections.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.chkScreenSpaceReflections.Location = new System.Drawing.Point(401, 80);
            this.chkScreenSpaceReflections.Name = "chkScreenSpaceReflections";
            this.chkScreenSpaceReflections.Size = new System.Drawing.Size(177, 25);
            this.chkScreenSpaceReflections.TabIndex = 20;
            this.chkScreenSpaceReflections.Text = "Screen Space Reflections";
            this.chkScreenSpaceReflections.UseVisualStyleBackColor = false;
            // 
            // lblAmbientOcclusion
            // 
            this.lblAmbientOcclusion.BackColor = System.Drawing.Color.Transparent;
            this.lblAmbientOcclusion.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.lblAmbientOcclusion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.lblAmbientOcclusion.Location = new System.Drawing.Point(56, 172);
            this.lblAmbientOcclusion.Name = "lblAmbientOcclusion";
            this.lblAmbientOcclusion.Size = new System.Drawing.Size(124, 21);
            this.lblAmbientOcclusion.TabIndex = 19;
            this.lblAmbientOcclusion.Text = "Ambient Occlusion:";
            // 
            // cmbAmbientOcclusion
            // 
            this.cmbAmbientOcclusion.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.cmbAmbientOcclusion.FormattingEnabled = true;
            this.cmbAmbientOcclusion.Items.AddRange(new object[] {
            "Off",
            "SSAO"});
            this.cmbAmbientOcclusion.Location = new System.Drawing.Point(60, 196);
            this.cmbAmbientOcclusion.Name = "cmbAmbientOcclusion";
            this.cmbAmbientOcclusion.Size = new System.Drawing.Size(121, 29);
            this.cmbAmbientOcclusion.TabIndex = 18;
            // 
            // lblDOF
            // 
            this.lblDOF.BackColor = System.Drawing.Color.Transparent;
            this.lblDOF.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.lblDOF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.lblDOF.Location = new System.Drawing.Point(56, 228);
            this.lblDOF.Name = "lblDOF";
            this.lblDOF.Size = new System.Drawing.Size(39, 21);
            this.lblDOF.TabIndex = 17;
            this.lblDOF.Text = "DOF:";
            // 
            // cmbDOF
            // 
            this.cmbDOF.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.cmbDOF.FormattingEnabled = true;
            this.cmbDOF.Items.AddRange(new object[] {
            "Standard",
            "Bokeh"});
            this.cmbDOF.Location = new System.Drawing.Point(60, 252);
            this.cmbDOF.Name = "cmbDOF";
            this.cmbDOF.Size = new System.Drawing.Size(121, 29);
            this.cmbDOF.TabIndex = 16;
            // 
            // lblGodrayQualtiy
            // 
            this.lblGodrayQualtiy.BackColor = System.Drawing.Color.Transparent;
            this.lblGodrayQualtiy.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.lblGodrayQualtiy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.lblGodrayQualtiy.Location = new System.Drawing.Point(227, 284);
            this.lblGodrayQualtiy.Name = "lblGodrayQualtiy";
            this.lblGodrayQualtiy.Size = new System.Drawing.Size(105, 21);
            this.lblGodrayQualtiy.TabIndex = 15;
            this.lblGodrayQualtiy.Text = "Godrays Quality:";
            // 
            // cmbGodrayQuality
            // 
            this.cmbGodrayQuality.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.cmbGodrayQuality.FormattingEnabled = true;
            this.cmbGodrayQuality.Items.AddRange(new object[] {
            "Off",
            "Low",
            "Medium",
            "High",
            "Ultra"});
            this.cmbGodrayQuality.Location = new System.Drawing.Point(231, 308);
            this.cmbGodrayQuality.Name = "cmbGodrayQuality";
            this.cmbGodrayQuality.Size = new System.Drawing.Size(121, 29);
            this.cmbGodrayQuality.TabIndex = 14;
            this.cmbGodrayQuality.SelectedIndexChanged += new System.EventHandler(this.cmbGodrayQuality_SelectedIndexChanged);
            // 
            // lblLightingQuality
            // 
            this.lblLightingQuality.BackColor = System.Drawing.Color.Transparent;
            this.lblLightingQuality.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.lblLightingQuality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.lblLightingQuality.Location = new System.Drawing.Point(227, 228);
            this.lblLightingQuality.Name = "lblLightingQuality";
            this.lblLightingQuality.Size = new System.Drawing.Size(105, 21);
            this.lblLightingQuality.TabIndex = 13;
            this.lblLightingQuality.Text = "Lighting Quality:";
            // 
            // cmbLightingQuality
            // 
            this.cmbLightingQuality.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.cmbLightingQuality.FormattingEnabled = true;
            this.cmbLightingQuality.Items.AddRange(new object[] {
            "Medium",
            "High",
            "Ultra"});
            this.cmbLightingQuality.Location = new System.Drawing.Point(231, 252);
            this.cmbLightingQuality.Name = "cmbLightingQuality";
            this.cmbLightingQuality.Size = new System.Drawing.Size(121, 29);
            this.cmbLightingQuality.TabIndex = 12;
            // 
            // lblDecalQuantity
            // 
            this.lblDecalQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblDecalQuantity.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.lblDecalQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.lblDecalQuantity.Location = new System.Drawing.Point(227, 172);
            this.lblDecalQuantity.Name = "lblDecalQuantity";
            this.lblDecalQuantity.Size = new System.Drawing.Size(99, 21);
            this.lblDecalQuantity.TabIndex = 11;
            this.lblDecalQuantity.Text = "Decal Quantity:";
            // 
            // cmbDecalQuantity
            // 
            this.cmbDecalQuantity.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.cmbDecalQuantity.FormattingEnabled = true;
            this.cmbDecalQuantity.Items.AddRange(new object[] {
            "None",
            "Medium",
            "High",
            "Ultra"});
            this.cmbDecalQuantity.Location = new System.Drawing.Point(231, 196);
            this.cmbDecalQuantity.Name = "cmbDecalQuantity";
            this.cmbDecalQuantity.Size = new System.Drawing.Size(121, 29);
            this.cmbDecalQuantity.TabIndex = 10;
            // 
            // lblShadowDistance
            // 
            this.lblShadowDistance.BackColor = System.Drawing.Color.Transparent;
            this.lblShadowDistance.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.lblShadowDistance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.lblShadowDistance.Location = new System.Drawing.Point(227, 116);
            this.lblShadowDistance.Name = "lblShadowDistance";
            this.lblShadowDistance.Size = new System.Drawing.Size(114, 21);
            this.lblShadowDistance.TabIndex = 9;
            this.lblShadowDistance.Text = "Shadow Distance:";
            // 
            // cmbShadowDistance
            // 
            this.cmbShadowDistance.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.cmbShadowDistance.FormattingEnabled = true;
            this.cmbShadowDistance.Items.AddRange(new object[] {
            "Medium",
            "High",
            "Ultra"});
            this.cmbShadowDistance.Location = new System.Drawing.Point(231, 140);
            this.cmbShadowDistance.Name = "cmbShadowDistance";
            this.cmbShadowDistance.Size = new System.Drawing.Size(121, 29);
            this.cmbShadowDistance.TabIndex = 8;
            this.cmbShadowDistance.SelectedIndexChanged += new System.EventHandler(this.cmbShadowDistance_SelectedIndexChanged);
            // 
            // lblShadowQuality
            // 
            this.lblShadowQuality.BackColor = System.Drawing.Color.Transparent;
            this.lblShadowQuality.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.lblShadowQuality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.lblShadowQuality.Location = new System.Drawing.Point(227, 60);
            this.lblShadowQuality.Name = "lblShadowQuality";
            this.lblShadowQuality.Size = new System.Drawing.Size(104, 21);
            this.lblShadowQuality.TabIndex = 7;
            this.lblShadowQuality.Text = "Shadow Quality:";
            // 
            // cmbShadowQuality
            // 
            this.cmbShadowQuality.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.cmbShadowQuality.FormattingEnabled = true;
            this.cmbShadowQuality.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Ultra"});
            this.cmbShadowQuality.Location = new System.Drawing.Point(231, 84);
            this.cmbShadowQuality.Name = "cmbShadowQuality";
            this.cmbShadowQuality.Size = new System.Drawing.Size(121, 29);
            this.cmbShadowQuality.TabIndex = 6;
            // 
            // lblTextureQuality
            // 
            this.lblTextureQuality.BackColor = System.Drawing.Color.Transparent;
            this.lblTextureQuality.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.lblTextureQuality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.lblTextureQuality.Location = new System.Drawing.Point(227, 4);
            this.lblTextureQuality.Name = "lblTextureQuality";
            this.lblTextureQuality.Size = new System.Drawing.Size(99, 21);
            this.lblTextureQuality.TabIndex = 5;
            this.lblTextureQuality.Text = "Texture Quality:";
            // 
            // cmbTextureQuality
            // 
            this.cmbTextureQuality.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.cmbTextureQuality.FormattingEnabled = true;
            this.cmbTextureQuality.Items.AddRange(new object[] {
            "Medium",
            "High",
            "Ultra"});
            this.cmbTextureQuality.Location = new System.Drawing.Point(231, 28);
            this.cmbTextureQuality.Name = "cmbTextureQuality";
            this.cmbTextureQuality.Size = new System.Drawing.Size(121, 29);
            this.cmbTextureQuality.TabIndex = 4;
            // 
            // lblAnisotropicFiltering
            // 
            this.lblAnisotropicFiltering.BackColor = System.Drawing.Color.Transparent;
            this.lblAnisotropicFiltering.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.lblAnisotropicFiltering.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.lblAnisotropicFiltering.Location = new System.Drawing.Point(56, 116);
            this.lblAnisotropicFiltering.Name = "lblAnisotropicFiltering";
            this.lblAnisotropicFiltering.Size = new System.Drawing.Size(131, 21);
            this.lblAnisotropicFiltering.TabIndex = 3;
            this.lblAnisotropicFiltering.Text = "Anisotropic Filtering:";
            // 
            // cmbAnisotropicFiltering
            // 
            this.cmbAnisotropicFiltering.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.cmbAnisotropicFiltering.FormattingEnabled = true;
            this.cmbAnisotropicFiltering.Items.AddRange(new object[] {
            "Off",
            "2 Samples",
            "4 Samples",
            "8 Samples",
            "12 Samples",
            "16 Samples"});
            this.cmbAnisotropicFiltering.Location = new System.Drawing.Point(60, 140);
            this.cmbAnisotropicFiltering.Name = "cmbAnisotropicFiltering";
            this.cmbAnisotropicFiltering.Size = new System.Drawing.Size(121, 29);
            this.cmbAnisotropicFiltering.TabIndex = 2;
            this.cmbAnisotropicFiltering.SelectedIndexChanged += new System.EventHandler(this.cmbAnisotropicFiltering_SelectedIndexChanged);
            // 
            // lblAntialiasing
            // 
            this.lblAntialiasing.BackColor = System.Drawing.Color.Transparent;
            this.lblAntialiasing.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.lblAntialiasing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.lblAntialiasing.Location = new System.Drawing.Point(56, 60);
            this.lblAntialiasing.Name = "lblAntialiasing";
            this.lblAntialiasing.Size = new System.Drawing.Size(83, 21);
            this.lblAntialiasing.TabIndex = 1;
            this.lblAntialiasing.Text = "Antialiasing:";
            // 
            // cmbAntialiasing
            // 
            this.cmbAntialiasing.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.cmbAntialiasing.FormattingEnabled = true;
            this.cmbAntialiasing.Items.AddRange(new object[] {
            "Off",
            "FXAA",
            "TAA"});
            this.cmbAntialiasing.Location = new System.Drawing.Point(60, 84);
            this.cmbAntialiasing.Name = "cmbAntialiasing";
            this.cmbAntialiasing.Size = new System.Drawing.Size(121, 29);
            this.cmbAntialiasing.TabIndex = 0;
            this.cmbAntialiasing.SelectedIndexChanged += new System.EventHandler(this.cmbAntialiasing_SelectedIndexChanged);
            // 
            // tabExtraSettings
            // 
            this.tabExtraSettings.BackColor = System.Drawing.SystemColors.Control;
            this.tabExtraSettings.BackgroundImage = global::Fallout_4_Launcher.Properties.Resources.blue_background;
            this.tabExtraSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabExtraSettings.Controls.Add(this.grpGeneral);
            this.tabExtraSettings.Controls.Add(this.grpFOV);
            this.tabExtraSettings.Controls.Add(this.miscSettingsPanel);
            this.tabExtraSettings.Controls.Add(this.chkSkipLauncher);
            this.tabExtraSettings.Controls.Add(this.btnBackup);
            this.tabExtraSettings.Controls.Add(this.btnEnableMods);
            this.tabExtraSettings.Controls.Add(this.btnSetReadOnly);
            this.tabExtraSettings.Location = new System.Drawing.Point(4, 22);
            this.tabExtraSettings.Name = "tabExtraSettings";
            this.tabExtraSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabExtraSettings.Size = new System.Drawing.Size(635, 349);
            this.tabExtraSettings.TabIndex = 1;
            this.tabExtraSettings.Text = "Extra Settings";
            // 
            // grpGeneral
            // 
            this.grpGeneral.BackColor = System.Drawing.Color.Transparent;
            this.grpGeneral.Controls.Add(this.lblDifficulty);
            this.grpGeneral.Controls.Add(this.chkCompanionApp);
            this.grpGeneral.Controls.Add(this.cmbDifficulty);
            this.grpGeneral.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.grpGeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.grpGeneral.Location = new System.Drawing.Point(434, 102);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(193, 111);
            this.grpGeneral.TabIndex = 7;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General Options";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.BackColor = System.Drawing.Color.Transparent;
            this.lblDifficulty.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.lblDifficulty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.lblDifficulty.Location = new System.Drawing.Point(24, 22);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(67, 21);
            this.lblDifficulty.TabIndex = 9;
            this.lblDifficulty.Text = "Difficulty:";
            // 
            // chkCompanionApp
            // 
            this.chkCompanionApp.AutoSize = true;
            this.chkCompanionApp.BackColor = System.Drawing.Color.Transparent;
            this.chkCompanionApp.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCompanionApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.chkCompanionApp.Location = new System.Drawing.Point(28, 77);
            this.chkCompanionApp.Name = "chkCompanionApp";
            this.chkCompanionApp.Size = new System.Drawing.Size(122, 25);
            this.chkCompanionApp.TabIndex = 7;
            this.chkCompanionApp.Text = "Companion App";
            this.toolTip.SetToolTip(this.chkCompanionApp, "Enables the companion app");
            this.chkCompanionApp.UseVisualStyleBackColor = false;
            this.chkCompanionApp.CheckedChanged += new System.EventHandler(this.chkCompanionApp_CheckedChanged);
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Items.AddRange(new object[] {
            "Very Easy",
            "Easy",
            "Normal",
            "Hard",
            "Very Hard",
            "Survival"});
            this.cmbDifficulty.Location = new System.Drawing.Point(28, 46);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(141, 29);
            this.cmbDifficulty.TabIndex = 8;
            this.cmbDifficulty.SelectedIndexChanged += new System.EventHandler(this.cmbDifficulty_SelectedIndexChanged);
            // 
            // grpFOV
            // 
            this.grpFOV.BackColor = System.Drawing.Color.Transparent;
            this.grpFOV.Controls.Add(this.label3);
            this.grpFOV.Controls.Add(this.label2);
            this.grpFOV.Controls.Add(this.txtFOVThirdPerson);
            this.grpFOV.Controls.Add(this.txtFOVFirstPerson);
            this.grpFOV.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.grpFOV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.grpFOV.Location = new System.Drawing.Point(434, 6);
            this.grpFOV.Name = "grpFOV";
            this.grpFOV.Size = new System.Drawing.Size(193, 90);
            this.grpFOV.TabIndex = 6;
            this.grpFOV.TabStop = false;
            this.grpFOV.Text = "FOV Options";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.Location = new System.Drawing.Point(16, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Third Person FOV:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.Location = new System.Drawing.Point(16, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Person FOV:";
            // 
            // txtFOVThirdPerson
            // 
            this.txtFOVThirdPerson.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtFOVThirdPerson.Location = new System.Drawing.Point(133, 54);
            this.txtFOVThirdPerson.Name = "txtFOVThirdPerson";
            this.txtFOVThirdPerson.Size = new System.Drawing.Size(43, 26);
            this.txtFOVThirdPerson.TabIndex = 1;
            this.txtFOVThirdPerson.Text = "70";
            this.txtFOVThirdPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFOVThirdPerson.TextChanged += new System.EventHandler(this.txtFOVThirdPerson_TextChanged);
            // 
            // txtFOVFirstPerson
            // 
            this.txtFOVFirstPerson.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtFOVFirstPerson.Location = new System.Drawing.Point(133, 24);
            this.txtFOVFirstPerson.Name = "txtFOVFirstPerson";
            this.txtFOVFirstPerson.Size = new System.Drawing.Size(43, 26);
            this.txtFOVFirstPerson.TabIndex = 0;
            this.txtFOVFirstPerson.Text = "80";
            this.txtFOVFirstPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFOVFirstPerson.TextChanged += new System.EventHandler(this.txtFOVFirstPerson_TextChanged);
            // 
            // miscSettingsPanel
            // 
            this.miscSettingsPanel.BackColor = System.Drawing.Color.Transparent;
            this.miscSettingsPanel.Controls.Add(this.btnReload);
            this.miscSettingsPanel.Controls.Add(this.btnGameLauncher);
            this.miscSettingsPanel.Controls.Add(this.btnRevertExecutables);
            this.miscSettingsPanel.Location = new System.Drawing.Point(8, 315);
            this.miscSettingsPanel.Name = "miscSettingsPanel";
            this.miscSettingsPanel.Size = new System.Drawing.Size(523, 28);
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
            // btnRevertExecutables
            // 
            this.btnRevertExecutables.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F);
            this.btnRevertExecutables.Location = new System.Drawing.Point(220, 3);
            this.btnRevertExecutables.Name = "btnRevertExecutables";
            this.btnRevertExecutables.Size = new System.Drawing.Size(109, 23);
            this.btnRevertExecutables.TabIndex = 6;
            this.btnRevertExecutables.Text = "Revert Executables";
            this.toolTip.SetToolTip(this.btnRevertExecutables, "In the event the Skip Launcher option breaks, use this option");
            this.btnRevertExecutables.UseVisualStyleBackColor = true;
            this.btnRevertExecutables.Click += new System.EventHandler(this.btnRevertExecutables_Click);
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
            this.tabMods.Controls.Add(this.btnReloadMods);
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
            this.tabAbout.Controls.Add(this.label1);
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(81, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 105);
            this.label1.TabIndex = 6;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // imgVaultBoy
            // 
            this.imgVaultBoy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imgVaultBoy.BackgroundImage = global::Fallout_4_Launcher.Properties.Resources.vaultboy_thumbs;
            this.imgVaultBoy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgVaultBoy.Location = new System.Drawing.Point(413, 132);
            this.imgVaultBoy.Name = "imgVaultBoy";
            this.imgVaultBoy.Size = new System.Drawing.Size(214, 214);
            this.imgVaultBoy.TabIndex = 5;
            this.imgVaultBoy.TabStop = false;
            this.toolTip.SetToolTip(this.imgVaultBoy, "Thanks for downloading, if you could star the repo that would be awesome!");
            // 
            // lblGitLink
            // 
            this.lblGitLink.BackColor = System.Drawing.Color.Transparent;
            this.lblGitLink.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGitLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.lblGitLink.Location = new System.Drawing.Point(81, 108);
            this.lblGitLink.Name = "lblGitLink";
            this.lblGitLink.Size = new System.Drawing.Size(349, 21);
            this.lblGitLink.TabIndex = 4;
            this.lblGitLink.Text = "https://github.com/FlakTheMighty/Fallout-4-Config-Tool";
            this.lblGitLink.Click += new System.EventHandler(this.lblGitLink_Click);
            // 
            // lblAbout
            // 
            this.lblAbout.BackColor = System.Drawing.Color.Transparent;
            this.lblAbout.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(112)))));
            this.lblAbout.Location = new System.Drawing.Point(81, 3);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(472, 105);
            this.lblAbout.TabIndex = 3;
            this.lblAbout.Text = resources.GetString("lblAbout.Text");
            // 
            // btnReloadMods
            // 
            this.btnReloadMods.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F);
            this.btnReloadMods.Location = new System.Drawing.Point(278, 144);
            this.btnReloadMods.Name = "btnReloadMods";
            this.btnReloadMods.Size = new System.Drawing.Size(75, 23);
            this.btnReloadMods.TabIndex = 8;
            this.btnReloadMods.Text = "Reload";
            this.toolTip.SetToolTip(this.btnReloadMods, "Reloads the mod lists");
            this.btnReloadMods.UseVisualStyleBackColor = true;
            this.btnReloadMods.Click += new System.EventHandler(this.btnReloadMods_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.imgFallout4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLaunch)).EndInit();
            this.tabVideoSettings.ResumeLayout(false);
            this.tabExtraSettings.ResumeLayout(false);
            this.tabExtraSettings.PerformLayout();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpFOV.ResumeLayout(false);
            this.grpFOV.PerformLayout();
            this.miscSettingsPanel.ResumeLayout(false);
            this.tabMods.ResumeLayout(false);
            this.tabMods.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgVaultBoy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGame;
        private System.Windows.Forms.TabPage tabExtraSettings;
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
        private System.Windows.Forms.PictureBox imgFallout4;
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
        private System.Windows.Forms.PictureBox imgVaultBoy;
        private System.Windows.Forms.Button btnRevertExecutables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.GroupBox grpFOV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFOVThirdPerson;
        private System.Windows.Forms.TextBox txtFOVFirstPerson;
        private System.Windows.Forms.CheckBox chkCompanionApp;
        private System.Windows.Forms.ComboBox cmbDifficulty;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.TabPage tabVideoSettings;
        private System.Windows.Forms.CheckBox chkLensFlare;
        private System.Windows.Forms.CheckBox chkMotionBlur;
        private System.Windows.Forms.CheckBox chkRainOcclusion;
        private System.Windows.Forms.CheckBox chkWetness;
        private System.Windows.Forms.CheckBox chkScreenSpaceReflections;
        private System.Windows.Forms.Label lblAmbientOcclusion;
        private System.Windows.Forms.ComboBox cmbAmbientOcclusion;
        private System.Windows.Forms.Label lblDOF;
        private System.Windows.Forms.ComboBox cmbDOF;
        private System.Windows.Forms.Label lblGodrayQualtiy;
        private System.Windows.Forms.ComboBox cmbGodrayQuality;
        private System.Windows.Forms.Label lblLightingQuality;
        private System.Windows.Forms.ComboBox cmbLightingQuality;
        private System.Windows.Forms.Label lblDecalQuantity;
        private System.Windows.Forms.ComboBox cmbDecalQuantity;
        private System.Windows.Forms.Label lblShadowDistance;
        private System.Windows.Forms.ComboBox cmbShadowDistance;
        private System.Windows.Forms.Label lblShadowQuality;
        private System.Windows.Forms.ComboBox cmbShadowQuality;
        private System.Windows.Forms.Label lblTextureQuality;
        private System.Windows.Forms.ComboBox cmbTextureQuality;
        private System.Windows.Forms.Label lblAnisotropicFiltering;
        private System.Windows.Forms.ComboBox cmbAnisotropicFiltering;
        private System.Windows.Forms.Label lblAntialiasing;
        private System.Windows.Forms.ComboBox cmbAntialiasing;
        private System.Windows.Forms.Button btnReloadMods;
    }
}

