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
            if (chkSkipLauncher.Checked && !Properties.Settings.Default.skipLauncher)
            {
                //temporarily name Fallout4Launcher to a temporary name so we can rename Fallout4 to Fallout4Launcher
                File.Move(fallout4InstallDirectory + @"\Fallout4Launcher.exe", fallout4InstallDirectory + @"\Fallout4-t.exe");
                File.Move(fallout4InstallDirectory + @"\Fallout4.exe", fallout4InstallDirectory + @"\Fallout4Launcher.exe");
                File.Move(fallout4InstallDirectory + @"\Fallout4-t.exe", fallout4InstallDirectory + @"\Fallout4.exe");
            }
            else
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

            if (Properties.Settings.Default.firstPersonFOV != 80)
            {
                txtFOVFirstPerson.Text = Properties.Settings.Default.firstPersonFOV.ToString();
            }
            if (Properties.Settings.Default.thirdPersonFOV != 70)
            {
                txtFOVThirdPerson.Text = Properties.Settings.Default.thirdPersonFOV.ToString();
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

            if (chkSkipLauncher.Checked)
            {
                btnGameLauncher.Visible = true;
            }
            else
            {
                btnGameLauncher.Visible = false;
            }
        }

        private void txtFOVFirstPerson_TextChanged(object sender, EventArgs e)
        {
            int indexOfFirstPersonFOV = -1;
            foreach (string line in fallout4)
            {
                indexOfFirstPersonFOV++;
                if (line.Contains("fDefault1stPersonFOV="))
                {
                    break;
                }
            }

            //make sure the value is only an int
            int parsedValue;
            if (!int.TryParse(txtFOVFirstPerson.Text, out parsedValue))
            {
                txtFOVFirstPerson.Text = Properties.Settings.Default.firstPersonFOV.ToString();
                parsedValue = 80;
            }

            //don't rewrite to the ini if we don't have to
            if (parsedValue != Properties.Settings.Default.firstPersonFOV)
            {
                Properties.Settings.Default.firstPersonFOV = parsedValue;
                Properties.Settings.Default.Save();
                //remove the item at index of whatever "fDefault1stPersonFOV=" is
                fallout4.RemoveAt(indexOfFirstPersonFOV);
                //add new copy with the parsed value
                fallout4.Insert(indexOfFirstPersonFOV, "fDefault1stPersonFOV=" + parsedValue);
            }

            makeFilesReadWrite();
            File.WriteAllLines(fallout4DocsDirectory + @"\Fallout4.ini", fallout4);
            makeFilesReadOnly();
        }

        private void txtFOVThirdPerson_TextChanged(object sender, EventArgs e)
        {
            int indexOfThirdPersonFOV = -1;
            foreach (string line in fallout4)
            {
                indexOfThirdPersonFOV++;
                if (line.Contains("fDefaultWorldFOV="))
                {
                    break;
                }
            }

            //make sure the value is only an int
            int parsedValue;
            if (!int.TryParse(txtFOVThirdPerson.Text, out parsedValue))
            {
                txtFOVThirdPerson.Text = Properties.Settings.Default.thirdPersonFOV.ToString();
                parsedValue = 70;
            }

            //don't rewrite to the ini if we don't have to
            if (parsedValue != Properties.Settings.Default.thirdPersonFOV)
            {
                Properties.Settings.Default.thirdPersonFOV = parsedValue;
                Properties.Settings.Default.Save();

                //remove the item at index of whatever "fDefaultWorldFOV=" is
                fallout4.RemoveAt(indexOfThirdPersonFOV);
                //add new copy with the parsed value
                fallout4.Insert(indexOfThirdPersonFOV, "fDefaultWorldFOV=" + parsedValue);
            }

            makeFilesReadWrite();
            File.WriteAllLines(fallout4DocsDirectory + @"\Fallout4.ini", fallout4);
            makeFilesReadOnly();
        }
    }
}