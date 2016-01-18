using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * TODO
 * Retain folder structure to allow for easily uninstalling mods with loose files
 * 
 * bEssentialTakeNoDamage?
 * 
 * Find the remaining parts of the ini
 * - Texture Quality
 * - Shadow Quality
 * - Lighting Quality
 * - Motion Blur
 * - Screen Space Reflections
 * (already found decal, it's just a lot of different parts, need to check how they interact)
 */
namespace Fallout_4_Launcher
{
    public partial class Form1 : Form
    {
        string fallout4DocsDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\My Games\Fallout4";
        string fallout4InstallDirectory = @"C:\Program Files (x86)\Steam\steamapps\common\Fallout4";
        string fallout4AppDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"Local\Fallout4";

        List<string> pluginList = new List<string>();
        List<string> fallout4Prefs = new List<string>();
        List<string> fallout4 = new List<string>();

        List<string> pluginOrder = new List<string>();
        public Form1()
        {
            InitializeComponent();

            listActiveMods.DragDrop += listActiveMods_DragDrop;
            listActiveMods.DragOver += listActiveMods_DragOver;
            listActiveMods.MouseDown += listActiveMods_MouseDown;

            //the following have not been implemented yet
            cmbTextureQuality.Enabled = false;
            cmbShadowQuality.Enabled = false;
            cmbDecalQuantity.Enabled = false;
            cmbLightingQuality.Enabled = false;
            chkMotionBlur.Enabled = false;
            chkScreenSpaceReflections.Enabled = false;
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            //this placement is temporary, it's just for testing
            VersionControl vc = new VersionControl();

            vc.checkForUpdate();
            lblVersion.Text = "Version " + vc.getVersion();

            checkSettings();

            loadPluginList();
            loadFallout4Prefs();
            loadFallout4();

            checkFileSensitiveSettings();

            txtDataDirectory.Text = fallout4InstallDirectory + @"\Data";
            Properties.Settings.Default.Save();
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            Process.Start("steam://run/377160");
        }

        private void btnSetReadOnly_Click(object sender, EventArgs e)
        {
            FileAttributes attributes = File.GetAttributes(fallout4AppDataDirectory + @"\plugins.txt");

            if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                makeFilesReadWrite();
            }
            else
            {
                makeFilesReadOnly();
            }
        }

        //moves mods from the inactive list to the active list
        private void btnActivateSelected_Click(object sender, EventArgs e)
        {
            makeFilesReadWrite();
            ListBox.SelectedObjectCollection sourceItems = listAvailableMods.SelectedItems;

            foreach (var item in sourceItems)
            {
                listActiveMods.Items.Add(item);
                addToPlugins(item.ToString());
                Console.WriteLine(pluginList);
            }
            while (listAvailableMods.SelectedItems.Count > 0)
            {
                listAvailableMods.Items.Remove(listAvailableMods.SelectedItems[0]);
            }

            savePluginList();

            //addto plugins.txt

            makeFilesReadOnly();

            populateModLists();

        }

        //moves mods form the active list to the inactive list
        private void btnDeactivateSelected_Click(object sender, EventArgs e)
        {
            makeFilesReadWrite();

            ListBox.SelectedObjectCollection sourceItems = listActiveMods.SelectedItems;

            foreach (var item in sourceItems)
            {
                listAvailableMods.Items.Add(item);
                removeFromPlugins(item.ToString());
            }
            while (listActiveMods.SelectedItems.Count > 0)
            {
                listActiveMods.Items.Remove(listActiveMods.SelectedItems[0]);
            }

            savePluginList();

            //disregard this as well
            //for (int i = listActiveMods.Items.Count - 1; i >= 0; i--)
            //{
            //    if (listActiveMods.SelectedIndex == (i))
            //    {
            //        removeFromPlugins(listActiveMods.Items[i].ToString());

            //        listAvailableMods.Items.Add(listActiveMods.Items[i]);

            //        listAvailableMods.ClearSelected();

            //        listActiveMods.Items.Remove(listActiveMods.Items[i]);

            //        savePluginList();

            //    }
            //}

            //remove from plugins.txt

            makeFilesReadOnly();

            populateModLists();
        }

        //these should allow the user to rearrange the items in the list
        private void listActiveMods_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.listActiveMods.SelectedItem == null) return;
            this.listActiveMods.DoDragDrop(this.listActiveMods.SelectedItem, DragDropEffects.Move);
        }

        private void listActiveMods_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listActiveMods_DragDrop(object sender, DragEventArgs e)
        {
            Point point = listActiveMods.PointToClient(new Point(e.X, e.Y));
            int index = this.listActiveMods.IndexFromPoint(point);
            if (index < 0)
            {
                index = this.listActiveMods.Items.Count - 1;
            }
            object data = this.listActiveMods.SelectedItem;
            this.listActiveMods.Items.Remove(data);
            this.listActiveMods.Items.Insert(index, data);

            pluginOrder.Clear();
            for (int i = 0; i < listActiveMods.Items.Count; i++)
            {
                pluginOrder.Add(listActiveMods.Items[i].ToString());
                Console.WriteLine(pluginOrder[i]);
            }

            overridePlugins();
        }

        private void btnEnableMods_Click(object sender, EventArgs e)
        {
            enableMods();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            listActiveMods.Items.Clear();
            listAvailableMods.Items.Clear();

            loadPluginList();
            loadFallout4Prefs();
            loadFallout4();
        }

        private void btnRevertExecutables_Click(object sender, EventArgs e)
        {
            if (File.Exists(fallout4InstallDirectory + @"\Fallout4-BACKUP.exe"))
            {
                File.Delete(fallout4InstallDirectory + @"\Fallout4.exe");
                File.Copy(fallout4InstallDirectory + @"\Fallout4-BACKUP.exe", fallout4InstallDirectory + @"\Fallout4.exe");
            }
            if (File.Exists(fallout4InstallDirectory + @"\Fallout4Launcher-BACKUP.exe"))
            {
                File.Delete(fallout4InstallDirectory + @"\Fallout4Launcher.exe");
                File.Copy(fallout4InstallDirectory + @"\Fallout4Launcher-BACKUP.exe", fallout4InstallDirectory + @"\Fallout4Launcher.exe");
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            File.Copy(fallout4AppDataDirectory + @"\plugins.txt", fallout4AppDataDirectory + @"\plugins-BACKUP.txt");
            File.Copy(fallout4DocsDirectory + @"\fallout4.ini", fallout4DocsDirectory + @"\Fallout4-BACKUP.ini");
            File.Copy(fallout4DocsDirectory + @"\fallout4prefs.ini", fallout4DocsDirectory + @"\Fallout4Prefs-BACKUP.ini");
        }

        private void btnOpenDataFolder_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", txtDataDirectory.Text = fallout4InstallDirectory + @"\Data");
        }

        private void btnGameLauncher_Click(object sender, EventArgs e)
        {
            Process.Start(fallout4InstallDirectory + @"\Fallout4.exe");
        }

        private void lblGitLink_Click(object sender, EventArgs e)
        {
            //link those friends to the repo!
            Process.Start("https://github.com/FlakTheMighty/Fallout-4-Config-Tool");
        }

        private void chkSkipLauncher_CheckedChanged(object sender, EventArgs e)
        {
            //backups just in case ;)
            if (!File.Exists(fallout4InstallDirectory + @"\Fallout4-BACKUP.exe"))
            {
                File.Copy(fallout4InstallDirectory + @"\Fallout4.exe", fallout4InstallDirectory + @"\Fallout4-BACKUP.exe");

            }

            if (!File.Exists(fallout4InstallDirectory + @"\Fallout4Launcher-BACKUP.exe"))
            {
                File.Copy(fallout4InstallDirectory + @"\Fallout4Launcher.exe", fallout4InstallDirectory + @"\Fallout4Launcher-BACKUP.exe");

            }

            if (chkSkipLauncher.Checked && !Properties.Settings.Default.skipLauncher)
            {
                //temporarily name Fallout4Launcher to a temporary name so we can rename Fallout4 to Fallout4Launcher
                File.Move(fallout4InstallDirectory + @"\Fallout4Launcher.exe", fallout4InstallDirectory + @"\Fallout4-t.exe");
                File.Move(fallout4InstallDirectory + @"\Fallout4.exe", fallout4InstallDirectory + @"\Fallout4Launcher.exe");
                File.Move(fallout4InstallDirectory + @"\Fallout4-t.exe", fallout4InstallDirectory + @"\Fallout4.exe");
            }
            else if (!chkSkipLauncher.Checked && Properties.Settings.Default.skipLauncher)
            {
                //just redo it
                File.Move(fallout4InstallDirectory + @"\Fallout4Launcher.exe", fallout4InstallDirectory + @"\Fallout4-t.exe");
                File.Move(fallout4InstallDirectory + @"\Fallout4.exe", fallout4InstallDirectory + @"\Fallout4Launcher.exe");
                File.Move(fallout4InstallDirectory + @"\Fallout4-t.exe", fallout4InstallDirectory + @"\Fallout4.exe");
            }

            if (chkSkipLauncher.Checked)
            {
                Properties.Settings.Default.skipLauncher = true;
            }
            else
            {
                Properties.Settings.Default.skipLauncher = false;

            }

            Properties.Settings.Default.Save();

            if (chkSkipLauncher.Checked)
            {
                btnGameLauncher.Visible = true;
            }
            else
            {
                btnGameLauncher.Visible = false;
            }
        }

        private void chkCompanionApp_CheckedChanged(object sender, EventArgs e)
        {
            int indexOfCompanionApp = parseFallout4PrefsINI("bPipboyCompanionEnabled=");

            if (chkCompanionApp.Checked)
            {
                //remove the item at index of whatever "fDefaultWorldFOV=" is
                fallout4Prefs.RemoveAt(indexOfCompanionApp);
                //add new copy with
                fallout4Prefs.Insert(indexOfCompanionApp, "bPipboyCompanionEnabled=" + 1);
            }
            else
            {
                //remove the item at index of whatever "bPipboyCompanionEnabled=" is
                fallout4Prefs.RemoveAt(indexOfCompanionApp);
                //add new copy
                fallout4Prefs.Insert(indexOfCompanionApp, "bPipboyCompanionEnabled=" + 0);
            }
            makeFilesReadWrite();
            File.WriteAllLines(fallout4DocsDirectory + @"\Fallout4Prefs.ini", fallout4Prefs);
            makeFilesReadOnly();
        }

        private void txtFOVFirstPerson_TextChanged(object sender, EventArgs e)
        {
            //this one has to stay the same without the parse methods, otherwise it's going to break and use the wrong entry for FOV
            int indexOfFirstPersonFOV = -1;
            foreach (string line in fallout4)
            {
                indexOfFirstPersonFOV++;//"fDefault1stPersonFOV="
                if (line.Contains("[Display]"))
                {
                    indexOfFirstPersonFOV++;
                    break;
                }
            }

            if (!fallout4[indexOfFirstPersonFOV].Contains("fDefault1stPersonFOV="))
            {
                fallout4.Insert(indexOfFirstPersonFOV, "fDefault1stPersonFOV=");
            }

            //make sure the value is only an int
            int parsedValue;
            if (!int.TryParse(txtFOVFirstPerson.Text, out parsedValue))
            {
                parsedValue = 80;
            }

            //remove the item at index of whatever "fDefault1stPersonFOV=" is
            fallout4.RemoveAt(indexOfFirstPersonFOV);
            //add new copy with the parsed value
            fallout4.Insert(indexOfFirstPersonFOV, "fDefault1stPersonFOV=" + parsedValue);

            makeFilesReadWrite();
            File.WriteAllLines(fallout4DocsDirectory + @"\Fallout4.ini", fallout4);
            makeFilesReadOnly();
        }

        private void txtFOVThirdPerson_TextChanged(object sender, EventArgs e)
        {
            //this one has to stay the same without the parse methods, otherwise it's going to break and use the wrong entry for FOV
            int indexOfThirdPersonFOV = -1;
            foreach (string line in fallout4)
            {
                indexOfThirdPersonFOV++;//fDefaultWorldFOV=
                if (line.Contains("[Display]"))
                {
                    indexOfThirdPersonFOV += 2;

                    break;
                }
            }

            if (!fallout4[indexOfThirdPersonFOV].Contains("fDefaultWorldFOV="))
            {
                fallout4.Insert(indexOfThirdPersonFOV, "fDefaultWorldFOV=");
            }

            //make sure the value is only an int
            int parsedValue;
            if (!int.TryParse(txtFOVThirdPerson.Text, out parsedValue))
            {
                parsedValue = 70;
            }

            //remove the item at index of whatever "fDefaultWorldFOV=" is
            fallout4.RemoveAt(indexOfThirdPersonFOV);
            //add new copy with the parsed value
            fallout4.Insert(indexOfThirdPersonFOV, "fDefaultWorldFOV=" + parsedValue);

            makeFilesReadWrite();
            File.WriteAllLines(fallout4DocsDirectory + @"\Fallout4.ini", fallout4);
            makeFilesReadOnly();
        }

        private void txtXResolution_TextChanged(object sender, EventArgs e)
        {
            int indexOfXResolution = parseFallout4PrefsINI("iSize W=");

            fallout4Prefs.RemoveAt(indexOfXResolution);
            fallout4Prefs.Insert(indexOfXResolution, "iSize W=" + txtXResolution.Text);

            makeFilesReadWrite();
            File.WriteAllLines(fallout4DocsDirectory + @"\Fallout4Prefs.ini", fallout4Prefs);
            makeFilesReadOnly();
        }

        private void txtYResolution_TextChanged(object sender, EventArgs e)
        {
            int indexOfYResolution = parseFallout4PrefsINI("iSize H=");

            fallout4Prefs.RemoveAt(indexOfYResolution);
            fallout4Prefs.Insert(indexOfYResolution, "iSize H=" + txtYResolution.Text);

            makeFilesReadWrite();
            File.WriteAllLines(fallout4DocsDirectory + @"\Fallout4Prefs.ini", fallout4Prefs);
            makeFilesReadOnly();
        }

        private void cmbDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexOfDifficulty = parseFallout4PrefsINI("iDifficulty=");

            //remove the item at index of whatever "iDifficulty=" is
            fallout4Prefs.RemoveAt(indexOfDifficulty);
            //add new copy with
            fallout4Prefs.Insert(indexOfDifficulty, "iDifficulty=" + cmbDifficulty.SelectedIndex);

            makeFilesReadWrite();
            File.WriteAllLines(fallout4DocsDirectory + @"\Fallout4Prefs.ini", fallout4Prefs);
            makeFilesReadOnly();
        }

        private void cmbAntialiasing_SelectedIndexChanged(object sender, EventArgs e)
        {
            string writeToFile = "";
            int indexOfAliasing = parseFallout4PrefsINI("sAntiAliasing=");
            switch (cmbAntialiasing.SelectedIndex)
            {

                case 0:
                    break;
                case 1:
                    writeToFile = "FXAA";
                    break;
                case 2:
                    writeToFile = "TAA";
                    break;
            }
            fallout4Prefs.Remove(fallout4Prefs[indexOfAliasing]);
            fallout4Prefs.Insert(indexOfAliasing, "sAntiAliasing=" + writeToFile);

            makeFilesReadWrite();
            File.WriteAllLines(fallout4DocsDirectory + @"\Fallout4Prefs.ini", fallout4Prefs);
            makeFilesReadOnly();
        }

        private void cmbAnisotropicFiltering_SelectedIndexChanged(object sender, EventArgs e)
        {
            int writeToFile = 1;
            int indexOfAnisotropic = parseFallout4PrefsINI("iMaxAnisotropy=");
            switch (cmbAnisotropicFiltering.SelectedIndex)
            {

                case 0:
                    break;
                case 1:
                    writeToFile = 2;
                    break;
                case 2:
                    writeToFile = 4;
                    break;
                case 3:
                    writeToFile = 8;
                    break;
                case 4:
                    writeToFile = 12;
                    break;
                case 5:
                    writeToFile = 16;
                    break;
            }
            fallout4Prefs.Remove(fallout4Prefs[indexOfAnisotropic]);
            fallout4Prefs.Insert(indexOfAnisotropic, "iMaxAnisotropy=" + writeToFile);

            makeFilesReadWrite();
            File.WriteAllLines(fallout4DocsDirectory + @"\Fallout4Prefs.ini", fallout4Prefs);
            makeFilesReadOnly();
        }

        private void cmbShadowDistance_SelectedIndexChanged(object sender, EventArgs e)
        {
            int writeToFile = 3000;
            int indexOfShadowDist = parseFallout4PrefsINI("fDirShadowDistance=");
            int indexOfShadowDist2 = parseFallout4PrefsINI("fShadowDistance=");
            switch (cmbShadowDistance.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    writeToFile = 14000;
                    break;
                case 2:
                    writeToFile = 20000;
                    break;
            }
            fallout4Prefs.Remove(fallout4Prefs[indexOfShadowDist]);
            fallout4Prefs.Insert(indexOfShadowDist, "fDirShadowDistance=" + writeToFile);
            fallout4Prefs.Remove(fallout4Prefs[indexOfShadowDist2]);
            fallout4Prefs.Insert(indexOfShadowDist2, "fShadowDistance=" + writeToFile);

            makeFilesReadWrite();
            File.WriteAllLines(fallout4DocsDirectory + @"\Fallout4Prefs.ini", fallout4Prefs);
            makeFilesReadOnly();
        }

        private void cmbGodrayQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            int writeToFile = 0;
            int indexOfGodrayEnabled = parseFallout4PrefsINI("bVolumetricLightingEnable=");
            int indexOfGodrayQuality = parseFallout4PrefsINI("iVolumetricLightingQuality=");

            if (cmbGodrayQuality.SelectedIndex > 0)
            {
                switch (cmbGodrayQuality.SelectedIndex)
                {
                    case 1:
                        writeToFile = 0;
                        //bVolumetricLightingEnable=1
                        break;
                    case 2:
                        writeToFile = 1;
                        break;
                    case 3:
                        writeToFile = 2;
                        break;
                    case 4:
                        writeToFile = 3;
                        break;
                }

                fallout4Prefs.Remove(fallout4Prefs[indexOfGodrayEnabled]);
                fallout4Prefs.Insert(indexOfGodrayEnabled, "bVolumetricLightingEnable=1");
            }
            else
            {
                writeToFile = 0;
                fallout4Prefs.Remove(fallout4Prefs[indexOfGodrayEnabled]);
                fallout4Prefs.Insert(indexOfGodrayEnabled, "bVolumetricLightingEnable=0");
            }

            fallout4Prefs.Remove(fallout4Prefs[indexOfGodrayQuality]);
            fallout4Prefs.Insert(indexOfGodrayQuality, "iVolumetricLightingQuality=" + writeToFile);

            makeFilesReadWrite();
            File.WriteAllLines(fallout4DocsDirectory + @"\Fallout4Prefs.ini", fallout4Prefs);
            makeFilesReadOnly();
        }

        private void cmbTextureQuality_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbDOF_SelectedIndexChanged(object sender, EventArgs e)
        {
            int writeToFile = 0;
            int indexOfDOF = parseFallout4PrefsINI("bDoDepthOfField=");
            int indexOfBokeh = parseFallout4PrefsINI("bScreenSpaceBokeh=");

            if (cmbDOF.SelectedIndex > 0)
            {
                switch (cmbDOF.SelectedIndex)
                {
                    case 1:
                        writeToFile = 0;
                        break;
                    case 2:
                        writeToFile = 1;
                        break;
                }

                fallout4Prefs.Remove(fallout4Prefs[indexOfDOF]);
                fallout4Prefs.Insert(indexOfDOF, "bDoDepthOfField=1");
            }
            else
            {
                writeToFile = 0;
                fallout4Prefs.Remove(fallout4Prefs[indexOfDOF]);
                fallout4Prefs.Insert(indexOfDOF, "bDoDepthOfField=0");
            }

            fallout4Prefs.Remove(fallout4Prefs[indexOfBokeh]);
            fallout4Prefs.Insert(indexOfBokeh, "bScreenSpaceBokeh=" + writeToFile);

            makeFilesReadWrite();
            File.WriteAllLines(fallout4DocsDirectory + @"\Fallout4Prefs.ini", fallout4Prefs);
            makeFilesReadOnly();
        }

        private void cmbAmbientOcclusion_SelectedIndexChanged(object sender, EventArgs e)
        {
            int writeToFile = 0;
            int indexOfAO = parseFallout4PrefsINI("bSAOEnable=");
            switch (cmbAmbientOcclusion.SelectedIndex)
            {
                case 0:
                    writeToFile = 0;
                    break;
                case 1:
                    writeToFile = 1;
                    break;
            }

            fallout4Prefs.Remove(fallout4Prefs[indexOfAO]);
            fallout4Prefs.Insert(indexOfAO, "bSAOEnable=" + writeToFile);

            makeFilesReadWrite();
            File.WriteAllLines(fallout4DocsDirectory + @"\Fallout4Prefs.ini", fallout4Prefs);
            makeFilesReadOnly();
        }

        private void cmbFullscreen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int writeToFileBorderless = 0;
            int writeToFileFullscreen = 0;
            int indexOfBorderless = parseFallout4PrefsINI("bBorderless=");
            int indexOfFullScreen = parseFallout4PrefsINI("bFull Screen=");

            switch (cmbFullscreen.SelectedIndex)
            {
                case 0:
                    writeToFileBorderless = 0;
                    writeToFileFullscreen = 0;
                    break;
                case 1:
                    writeToFileBorderless = 1;
                    writeToFileFullscreen = 0;
                    break;
                case 2:
                    writeToFileBorderless = 1;
                    writeToFileFullscreen = 1;
                    break;
            }

            fallout4Prefs.Remove(fallout4Prefs[indexOfBorderless]);
            fallout4Prefs.Insert(indexOfBorderless, "bBorderless=" + writeToFileBorderless);

            fallout4Prefs.Remove(fallout4Prefs[indexOfFullScreen]);
            fallout4Prefs.Insert(indexOfFullScreen, "bFull Screen=" + writeToFileFullscreen);

            makeFilesReadWrite();
            File.WriteAllLines(fallout4DocsDirectory + @"\Fallout4Prefs.ini", fallout4Prefs);
            makeFilesReadOnly();
        }

        private void chkWetness_CheckedChanged(object sender, EventArgs e)
        {
            int writeToFile = 1;
            int indexOfWetness = parseFallout4PrefsINI("bEnableWetnessMaterials=");
            if (chkWetness.Checked)
            {
                writeToFile = 1;
            }
            else
            {
                writeToFile = 0;
            }

            fallout4Prefs.Remove(fallout4Prefs[indexOfWetness]);
            fallout4Prefs.Insert(indexOfWetness, "bEnableWetnessMaterials=" + writeToFile);

            makeFilesReadWrite();
            File.WriteAllLines(fallout4DocsDirectory + @"\Fallout4Prefs.ini", fallout4Prefs);
            makeFilesReadOnly();
        }

        private void chkRainOcclusion_CheckedChanged(object sender, EventArgs e)
        {
            int writeToFile = 1;
            int indexOfRainOcclusion = parseFallout4PrefsINI("bEnableRainOcclusion=");
            if (chkRainOcclusion.Checked)
            {
                writeToFile = 1;
            }
            else
            {
                writeToFile = 0;
            }

            fallout4Prefs.Remove(fallout4Prefs[indexOfRainOcclusion]);
            fallout4Prefs.Insert(indexOfRainOcclusion, "bEnableRainOcclusion=" + writeToFile);

            makeFilesReadWrite();
            File.WriteAllLines(fallout4DocsDirectory + @"\Fallout4Prefs.ini", fallout4Prefs);
            makeFilesReadOnly();
        }

        private void chkLensFlare_CheckedChanged(object sender, EventArgs e)
        {
            int writeToFile = 1;
            int indexOfLensFlare = parseFallout4PrefsINI("bLensFlare=");
            if (chkRainOcclusion.Checked)
            {
                writeToFile = 1;
            }
            else
            {
                writeToFile = 0;
            }

            fallout4Prefs.Remove(fallout4Prefs[indexOfLensFlare]);
            fallout4Prefs.Insert(indexOfLensFlare, "bLensFlare=" + writeToFile);

            makeFilesReadWrite();
            File.WriteAllLines(fallout4DocsDirectory + @"\Fallout4Prefs.ini", fallout4Prefs);
            makeFilesReadOnly();
        }

        private void btnReloadMods_Click(object sender, EventArgs e)
        {
            refreshModLists();
        }

        /// <summary> Loads plugins.txt into List pluginList
        /// </summary>
        private void loadPluginList()
        {
            pluginList.Clear();

            TextReader tr;
            tr = File.OpenText(fallout4AppDataDirectory + @"\plugins.txt");

            string line;
            line = tr.ReadLine();
            while (line != null)
            {
                pluginList.Add(line);
                line = tr.ReadLine();
            }
            tr.Close();
            populateModLists();
        }

        /// <summary> Loads Fallout4Prefs.ini into List Fallout4Prefs
        /// </summary>
        private void loadFallout4Prefs()
        {
            fallout4Prefs.Clear();

            TextReader tr;
            tr = File.OpenText(fallout4DocsDirectory + @"\Fallout4Prefs.ini");

            string line;
            line = tr.ReadLine();
            while (line != null)
            {
                fallout4Prefs.Add(line);
                line = tr.ReadLine();
            }
            tr.Close();
        }

        /// <summary>Loads the Fallout4.ini file into List fallout4
        /// </summary>
        private void loadFallout4()
        {
            fallout4.Clear();

            TextReader tr;
            tr = File.OpenText(fallout4DocsDirectory + @"\Fallout4.ini");

            string line;
            line = tr.ReadLine();
            while (line != null)
            {
                fallout4.Add(line);
                line = tr.ReadLine();
            }
            tr.Close();
        }

        /// <summary>Checks settings that do not require a file to have been loaded
        /// </summary>
        private void checkSettings()
        {
            if (Properties.Settings.Default.appdataDirectory != "")
            {
                fallout4AppDataDirectory = Properties.Settings.Default.appdataDirectory;
            }

            if (Properties.Settings.Default.installDirectory != "")
            {
                fallout4InstallDirectory = Properties.Settings.Default.installDirectory;
            }

            if (Properties.Settings.Default.docsDirectory != "")
            {
                fallout4DocsDirectory = Properties.Settings.Default.docsDirectory;
            }

            if (!Directory.Exists(fallout4InstallDirectory))
            {
                MessageBox.Show("Cannot find your install directory, please show me where it is.", "Whoops");
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = "";
                ofd.Filter = "Fallout4 (.exe)|Fallout4.exe";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fallout4InstallDirectory = ofd.FileName;
                    //remove the exe from the path
                    fallout4InstallDirectory = fallout4InstallDirectory.Remove(fallout4InstallDirectory.IndexOf(@"\Fallout4.exe"));
                    Properties.Settings.Default.installDirectory = fallout4InstallDirectory;
                }
            }

            if (fallout4AppDataDirectory.Contains("Roaming"))
            {
                fallout4AppDataDirectory = fallout4AppDataDirectory.Remove(fallout4AppDataDirectory.IndexOf("Roaming"), 7);
                Properties.Settings.Default.appdataDirectory = fallout4AppDataDirectory;
            }
        }

        /// <summary>Checks settings that require files to have been loaded and sets corresponding element to their value
        /// </summary>
        private void checkFileSensitiveSettings()
        {
            if (Properties.Settings.Default.skipLauncher)
            {
                chkSkipLauncher.Checked = true;
            }
            else
            {
                chkSkipLauncher.Checked = false;
            }

            //check if the companion app is on
            if (fallout4Prefs[parseFallout4PrefsINI("bPipboyCompanionEnabled=")].Contains("bPipboyCompanionEnabled=") &&
                Convert.ToInt32(fallout4Prefs[parseFallout4PrefsINI("bPipboyCompanionEnabled=")].Substring(24)) == 1)
            {
                chkCompanionApp.Checked = true;
            }
            else
            {
                chkCompanionApp.Checked = false;
            }

            //check for first person FOV value
            if (fallout4[parseFallout4INI("fDefault1stPersonFOV=")].Contains("fDefault1stPersonFOV="))
            {
                txtFOVFirstPerson.Text = fallout4[parseFallout4INI("fDefault1stPersonFOV=")].Substring(21);
            }
            else
            {
                txtFOVFirstPerson.Text = "80";
            }

            //check for third person FOV value
            if (fallout4[parseFallout4INI("fDefaultWorldFOV=")].Contains("fDefaultWorldFOV="))
            {
                txtFOVThirdPerson.Text = fallout4[parseFallout4INI("fDefaultWorldFOV=")].Substring(17);
            }
            else
            {
                txtFOVThirdPerson.Text = "70";
            }

            //set the difficulty
            cmbDifficulty.SelectedIndex = Convert.ToInt32(fallout4Prefs[parseFallout4PrefsINI("iDifficulty=")].Substring(12));

            //set the antialiasing
            switch (fallout4Prefs[parseFallout4PrefsINI("sAntiAliasing=")].Substring(14))
            {
                case "":
                    cmbAntialiasing.SelectedIndex = 0;
                    break;
                case "FXAA":
                    cmbAntialiasing.SelectedIndex = 1;
                    break;
                case "TAA":
                    cmbAntialiasing.SelectedIndex = 2;
                    break;
            }

            //set the anisotropic filtering
            switch (Convert.ToInt32(fallout4Prefs[parseFallout4PrefsINI("iMaxAnisotropy=")].Substring(15)))
            {
                case 1:
                    cmbAnisotropicFiltering.SelectedIndex = 0;
                    break;
                case 2:
                    cmbAnisotropicFiltering.SelectedIndex = 1;
                    break;
                case 4:
                    cmbAnisotropicFiltering.SelectedIndex = 2;
                    break;
                case 8:
                    cmbAnisotropicFiltering.SelectedIndex = 3;
                    break;
                case 12:
                    cmbAnisotropicFiltering.SelectedIndex = 4;
                    break;
                case 16:
                    cmbAnisotropicFiltering.SelectedIndex = 5;
                    break;
            }

            //set the godray quality
            //check if it's enabled first, otherwise set it to off
            if (Convert.ToInt32(fallout4Prefs[parseFallout4PrefsINI("bVolumetricLightingEnable=")].Substring(26)) == 1)
            {
                switch (Convert.ToInt32(fallout4Prefs[parseFallout4PrefsINI("iVolumetricLightingQuality=")].Substring(27)))
                {
                    case 0:
                        cmbGodrayQuality.SelectedIndex = 1;
                        //bVolumetricLightingEnable=1
                        break;
                    case 1:
                        cmbGodrayQuality.SelectedIndex = 2;
                        break;
                    case 2:
                        cmbGodrayQuality.SelectedIndex = 3;
                        break;
                    case 3:
                        cmbGodrayQuality.SelectedIndex = 4;
                        break;
                }
            }
            else
            {
                cmbGodrayQuality.SelectedIndex = 0;
            }

            //fDirShadowDistance=
            //fShadowDistance=
            //set the shadow distance
            //convert it to a double first because if you save ingame, it'll save as a double for some reason
            switch (Convert.ToInt32(Convert.ToDouble(fallout4Prefs[parseFallout4PrefsINI("fDirShadowDistance=")].Substring(19))))
            {
                case 3000:
                    cmbShadowDistance.SelectedIndex = 0;
                    break;
                case 14000:
                    cmbShadowDistance.SelectedIndex = 1;
                    break;
                case 20000:
                    cmbShadowDistance.SelectedIndex = 2;
                    break;
            }

            //set depth of field
            if (Convert.ToInt32(fallout4Prefs[parseFallout4PrefsINI("bDoDepthOfField=")].Substring(16)) == 1)
            {
                switch (Convert.ToInt32(fallout4Prefs[parseFallout4PrefsINI("bScreenSpaceBokeh=")].Substring(18)))
                {
                    case 0:
                        cmbDOF.SelectedIndex = 1;
                        break;
                    case 1:
                        cmbDOF.SelectedIndex = 2;
                        break;
                }
            }
            else
            {
                cmbDOF.SelectedIndex = 0;
            }

            //set ambient occlusion
            //bSAOEnable=
            switch (Convert.ToInt32(Convert.ToDouble(fallout4Prefs[parseFallout4PrefsINI("bSAOEnable=")].Substring(11))))
            {
                case 0:
                    cmbAmbientOcclusion.SelectedIndex = 0;
                    break;
                case 1:
                    cmbAmbientOcclusion.SelectedIndex = 1;
                    break;
            }

            //set wetness
            if (Convert.ToInt32(fallout4Prefs[parseFallout4PrefsINI("bEnableWetnessMaterials=")].Substring(24)) == 1)
            {
                chkWetness.Checked = true;
            }
            else
            {
                chkWetness.Checked = false;
            }

            //set rain occlusion
            if (Convert.ToInt32(fallout4Prefs[parseFallout4PrefsINI("bEnableRainOcclusion=")].Substring(21)) == 1)
            {
                chkRainOcclusion.Checked = true;
            }
            else
            {
                chkRainOcclusion.Checked = false;
            }

            //set lens flare
            if (Convert.ToInt32(fallout4Prefs[parseFallout4PrefsINI("bLensFlare=")].Substring(11)) == 1)
            {
                chkLensFlare.Checked = true;
            }
            else
            {
                chkLensFlare.Checked = false;
            }

            //set fullscreen
            if (Convert.ToInt32(fallout4Prefs[parseFallout4PrefsINI("bBorderless=")].Substring(12)) == 1 &&
                Convert.ToInt32(fallout4Prefs[parseFallout4PrefsINI("bFull Screen=")].Substring(13)) == 0)
            {
                cmbFullscreen.SelectedIndex = 1;
            }
            else if (Convert.ToInt32(fallout4Prefs[parseFallout4PrefsINI("bBorderless=")].Substring(12)) == 0 &&
                Convert.ToInt32(fallout4Prefs[parseFallout4PrefsINI("bFull Screen=")].Substring(13)) == 0)
            {
                cmbFullscreen.SelectedIndex = 0;
            }
            else if (Convert.ToInt32(fallout4Prefs[parseFallout4PrefsINI("bFull Screen=")].Substring(13)) == 1)
            {
                cmbFullscreen.SelectedIndex = 2;
            }

            txtXResolution.Text = Convert.ToInt32(fallout4Prefs[parseFallout4PrefsINI("iSize W=")].Substring(8)).ToString();
            txtYResolution.Text = Convert.ToInt32(fallout4Prefs[parseFallout4PrefsINI("iSize H=")].Substring(8)).ToString();
            //iSize H=1080
            //iSize W=1920

            //decals
            /*
             * iMaxSkinDecalsPerFrame=
             * iMaxDecalsPerFrame=
             * uMaxDecals=
             * bDecals=
             * bSkinnedDecals=
             * uMaxSkinDecals=
             * uMaxSkinDecalsPerActor=
             */

            //set the shadow quality
            //shadow quality modifies multiple things, doing later
            //switch (Convert.ToInt32(fallout4Prefs[parseFallout4PrefsINI("iShadowMapResolution=")].Substring(21)))
            //{
            //    case 1024:
            //        cmbShadowQuality.SelectedIndex = 0;
            //        break;
            //    case 2048:
            //        cmbShadowQuality.SelectedIndex = 1;
            //        break;
            //    case 20000:
            //        cmbShadowQuality.SelectedIndex = 2;
            //        break;
            //}
        }

        /// <summary>Adds the Read Only attribute to ini files and plugins.txt
        /// </summary>
        private void makeFilesReadOnly()
        {
            File.SetAttributes(fallout4AppDataDirectory + @"\plugins.txt", FileAttributes.ReadOnly);
            File.SetAttributes(fallout4DocsDirectory + @"\fallout4.ini", FileAttributes.ReadOnly);
            File.SetAttributes(fallout4DocsDirectory + @"\fallout4prefs.ini", FileAttributes.ReadOnly);
        }

        /// <summary>Removes the Read Only attribute to ini files and plugins.txt
        /// </summary>
        private void makeFilesReadWrite()
        {
            File.SetAttributes(fallout4AppDataDirectory + @"\plugins.txt", FileAttributes.Normal);
            File.SetAttributes(fallout4DocsDirectory + @"\fallout4.ini", FileAttributes.Normal);
            File.SetAttributes(fallout4DocsDirectory + @"\fallout4prefs.ini", FileAttributes.Normal);
        }

        /// <summary>Parses the Fallout4.ini file and returns the index of that line, -1 if it's not found.
        /// <para>(parseFor) The string you're looking for, keep = in the string.</para>
        /// </summary>
        private int parseFallout4INI(string parseFor)
        {
            int indexOfParam = -1;
            foreach (string line in fallout4)
            {
                indexOfParam++;
                if (line.Contains(parseFor))
                {
                    break;
                }
            }

            if (indexOfParam <= fallout4.Count())
            {
                return indexOfParam;
            }
            else
            {
                return -1;
            }

        }

        /// <summary>Parses the Fallout4Prefs.ini file and returns the index of that line, -1 if it's not found.
        /// <para>(parseFor) The string you're looking for, keep = in the string.</para>
        /// </summary>
        private int parseFallout4PrefsINI(string parseFor)
        {
            int indexOfParam = -1;
            foreach (string line in fallout4Prefs)
            {
                indexOfParam++;
                if (line.Contains(parseFor))
                {
                    break;
                }
            }

            if (indexOfParam <= fallout4Prefs.Count())
            {
                return indexOfParam;
            }
            else
            {
                return -1;
            }
        }

        /// <summary> Populates the Active and Inactive lists with mods from Data folder and plugins.txt
        /// </summary>
        private void populateModLists()
        {
            listActiveMods.Items.Clear();
            listAvailableMods.Items.Clear();
            //check the files in the Data Folder
            string[] espFiles = System.IO.Directory.GetFiles(fallout4InstallDirectory + @"\Data", "*.esp");
            string[] esmFiles = System.IO.Directory.GetFiles(fallout4InstallDirectory + @"\Data", "*.esm");

            List<string> filesTemp = new List<string>();

            //add the esm files to the temporary list first, they're more important
            for (int i = 0; i < esmFiles.Count(); i++)
            {
                filesTemp.Add(esmFiles[i]);
            }
            //add the esp files to the temporary list
            for (int i = 0; i < espFiles.Count(); i++)
            {
                filesTemp.Add(espFiles[i]);
            }

            //set the files array to the complete list of all esm and esp files
            string[] files = new string[filesTemp.Count()];

            for (int i = 0; i < files.Length; i++)
            {
                files[i] = filesTemp[i];
            }

            List<string> fileNames = new List<string>();

            //add them to the available, regardless of them being active
            for (int i = 0; i < files.Length; i++)
            {
                if (File.Exists(files[i]))
                {
                    fileNames.Add(Path.GetFileName(files[i]));
                    listAvailableMods.Items.Add(fileNames[i]);
                }
            }

            //set the active mods to the active list
            for (int i = 2; i < pluginList.Count(); i++)
            {
                //only add them if it's not commented out!
                if (!pluginList[i].Contains("#"))
                {
                    listActiveMods.Items.Add(pluginList[i]);
                }
            }

            //remove active mods from available
            for (int i = 0; i < listActiveMods.Items.Count; i++)
            {
                for (int j = 0; j < listAvailableMods.Items.Count; j++)
                {
                    if (listActiveMods.Items[i].Equals(listAvailableMods.Items[j]))
                    {
                        listAvailableMods.Items.RemoveAt(j);
                    }
                }
            }
        }

        /// <summary>Reloads both mod lists
        /// </summary>
        private void refreshModLists()
        {
            loadPluginList();
        }

        /// <summary>Removes an item to List pluginList
        /// <param name="modName">File to remove</param>
        /// </summary>
        private void removeFromPlugins(string modName)
        {
            pluginList.Remove(modName);
        }

        /// <summary>Adds an item to List pluginList
        /// <param name="modName">File to add</param>
        /// </summary>
        private void addToPlugins(string modName)
        {
            pluginList.Add(modName);
        }

        /// <summary>Adds Bethesda comments to plugins.txt
        /// </summary>
        private void overridePlugins()
        {
            List<string> temp = new List<string>();
            temp.Add("# This file is used by Fallout4 to keep track of your downloaded content.");
            temp.Add("# Please do not modify this file.");
            for (int i = 0; i < pluginOrder.Count; i++)
            {
                temp.Add(pluginOrder[i]);
            }

            makeFilesReadWrite();
            File.WriteAllLines(fallout4AppDataDirectory + @"\plugins.txt", temp);
            makeFilesReadOnly();
        }

        /// <summary>Writes the List pluginList to plugins.txt
        /// </summary>
        private void savePluginList()
        {
            File.WriteAllLines(fallout4AppDataDirectory + @"\plugins.txt", pluginList);
        }

        /// <summary>Adds the required lines to the ini files to allow loading mods
        /// </summary>
        private void enableMods()
        {
            try
            {
                fallout4Prefs.Insert(fallout4Prefs.IndexOf("[Launcher]") + 1, "bEnableFileSelection=1");
                fallout4.Insert(fallout4.IndexOf(@"sResourceDataDirsFinal=STRINGS\"),
                    @"sResourceDataDirsFinal=STRINGS\, TEXTURES\, MUSIC\, SOUND\, INTERFACE\, MESHES\, PROGRAMS\, MATERIALS\, LODSETTINGS\, VIS\, MISC\, SCRIPTS\, SHADERSFX\ ");
                fallout4.RemoveAt(fallout4.IndexOf(@"sResourceDataDirsFinal=STRINGS\"));

                makeFilesReadWrite();
                File.WriteAllLines(fallout4DocsDirectory + @"\Fallout4.ini", fallout4);
                File.WriteAllLines(fallout4DocsDirectory + @"\Fallout4Prefs.ini", fallout4Prefs);
                makeFilesReadOnly();
            }
            catch (Exception e)
            {
                MessageBox.Show("Looks like you already have mod loading enabled.", "Whoops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}