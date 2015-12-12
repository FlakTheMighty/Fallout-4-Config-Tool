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
 * Retain folder structure to allow for easily uninstalling mods with extra folders
 * 
 * 
 */
namespace Fallout_4_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listActiveMods.DragDrop += listActiveMods_DragDrop;
            listActiveMods.DragOver += listActiveMods_DragOver;
            listActiveMods.MouseDown += listActiveMods_MouseDown;
        }
        string fallout4DocsDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\My Games\Fallout4";
        string fallout4InstallDirectory = @"C:\Program Files (x86)\Steam\steamapps\common\Fallout4";
        string fallout4AppDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"Local\Fallout4";

        List<string> pluginList = new List<string>();
        List<string> fallout4Prefs = new List<string>();
        List<string> fallout4 = new List<string>();

        List<string> pluginOrder = new List<string>();

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            Process.Start("steam://run/377160");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkSettings();

            loadPluginList();
            loadFallout4Prefs();
            loadFallout4();

            checkFileSensitiveSettings();

            txtDataDirectory.Text = fallout4InstallDirectory + @"\Data";
            Properties.Settings.Default.Save();
        }

        private void btnSetReadOnly_Click(object sender, EventArgs e)
        {
            bool state = false;
            FileAttributes attributes = File.GetAttributes(fallout4AppDataDirectory + @"\plugins.txt");

            if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                makeFilesReadWrite();
                state = false;
            }
            else
            {
                makeFilesReadOnly();
                state = true;
            }
        }

        private void makeFilesReadOnly()
        {
            File.SetAttributes(fallout4AppDataDirectory + @"\plugins.txt", FileAttributes.ReadOnly);
            File.SetAttributes(fallout4DocsDirectory + @"\fallout4.ini", FileAttributes.ReadOnly);
            File.SetAttributes(fallout4DocsDirectory + @"\fallout4prefs.ini", FileAttributes.ReadOnly);
        }

        private void makeFilesReadWrite()
        {
            File.SetAttributes(fallout4AppDataDirectory + @"\plugins.txt", FileAttributes.Normal);
            File.SetAttributes(fallout4DocsDirectory + @"\fallout4.ini", FileAttributes.Normal);
            File.SetAttributes(fallout4DocsDirectory + @"\fallout4prefs.ini", FileAttributes.Normal);
        }

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

            //disregard this long chain of comments
            //for (int i = listAvailableMods.Items.Count - 1; i >= 0; i--)
            //{
            //    if (listAvailableMods.SelectedIndex == (i))
            //    {
            //        
            //        listActiveMods.Items.Add(listAvailableMods.Items[i]);

            //        listActiveMods.ClearSelected();

            //        listAvailableMods.Items.Remove(listAvailableMods.Items[i]);

            //        

            //    }
            //}

            //addto plugins.txt

            makeFilesReadOnly();

            populateModLists();

        }

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

        private void populateModLists()
        {
            listActiveMods.Items.Clear();
            listAvailableMods.Items.Clear();
            //check the files in the Data Folder
            string[] files = System.IO.Directory.GetFiles(fallout4InstallDirectory + @"\Data", "*.esp");
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

        private void refreshModLists()
        {
            loadPluginList();
        }

        private void removeFromPlugins(string modName)
        {
            pluginList.Remove(modName);
        }

        private void addToPlugins(string modName)
        {
            pluginList.Add(modName);
        }

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

        private void savePluginList()
        {
            File.WriteAllLines(fallout4AppDataDirectory + @"\plugins.txt", pluginList);
        }

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
            else if(!chkSkipLauncher.Checked && Properties.Settings.Default.skipLauncher)
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
    }
}