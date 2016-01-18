using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fallout_4_Launcher
{
    class VersionControl
    {
        int version = 1, revision = 0;
        string fullVersion;

        string versionLocation = "https://raw.githubusercontent.com/FlakTheMighty/Fallout-4-Config-Tool/master/Fallout%204%20Launcher/version.txt";

        public VersionControl()
        {
            fullVersion = version + "." + revision;
        }

        public void checkForUpdate()
        {
            WebClient versionCheckClient = new WebClient();
            versionCheckClient.DownloadFile(versionLocation, "tmp-FO4CfgToolVersion.txt");

            string tmp = File.ReadAllText("tmp-FO4CfgToolVersion.txt");

            int servVersion = 0, servRevision = 0;

            File.Delete("tmp-FO4CfgToolVersion.txt");

            try
            {
                servVersion = Int32.Parse(tmp.Substring(0, 1));
                servRevision = Int32.Parse(tmp.Substring(2, 1));
            }
            catch (Exception)
            {
            }

            if (version < servVersion)
            {
                
            }
            else if (version == servVersion && revision < servRevision)
            {
                Console.WriteLine("There's a new version up on Github, why don't you download it?");
                if (InputBox.ShowDialog("There's a new version up on Github,\n        why don't you download it?", "Update") == 1)
                {
                    downloadUpdate();
                }
            }

        }

        public void downloadUpdate()
        {
            Process.Start("https://github.com/FlakTheMighty/Fallout-4-Config-Tool/blob/master/Stable-Release/Fallout%204%20Launcher.exe?raw=true");
        }

        public string getVersion()
        {
            return version + "." + revision;
        }
    }

    class InputBox
    {
        public static int ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 300;
            prompt.Height = 125;
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.Text = caption;
            prompt.StartPosition = FormStartPosition.CenterParent;
            Label textLabel = new Label() { Left = 55, Top = 10, Text = text };
            textLabel.AutoSize = true;
            Button confirmation = new Button() { Text = "Download Now", Left = 150, Width = 100, Top = 55, DialogResult = DialogResult.OK };
            Button cancelation = new Button() { Text = "Maybe Later", Left = 40, Width = 100, Top = 55, DialogResult = DialogResult.Cancel };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancelation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            prompt.FormBorderStyle = FormBorderStyle.FixedSingle;
            prompt.MaximizeBox = false;
            prompt.Icon = Properties.Resources.vault_icon;

            return prompt.ShowDialog() == DialogResult.OK ? 1 : 0;
        }
    }
}