using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UT4_Installer.UserControls
{
    public partial class UC_CreateShortcut : UserControl
    {
        private static string _ut4Dir = "";
        private static string _shortcutDestDir = "";
        private string _shortcutName = "Unreal Tournament 4";
        public UC_CreateShortcut()
        {
            InitializeComponent();
            FormHelper.Form_UC_CreateShortcut = this;
        }

        private void UC_CreateShortcut_Load(object sender, EventArgs e)
        {
            HandleDirectories handleDirectories = new HandleDirectories();
            tb_ut4basedir.Text = _ut4Dir;
            if (_shortcutDestDir == "")
            {
                _shortcutDestDir = handleDirectories.SuggestShortcutDestDir();
                tb_shortcutDestDir.Text = _shortcutDestDir;
            }
            else
            {
                tb_shortcutDestDir.Text = _shortcutDestDir;
            }
            tb_shortcutName.Text = _shortcutName;

        }

        // Have user select UT4 base directory via prompt
        private void btn_selectUT4Dir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            DialogResult dialogResult = folderBrowser.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                _ut4Dir = folderBrowser.SelectedPath;
                tb_ut4basedir.Text = _ut4Dir;
            }
        }

        // Have user choose a directory for shortcut to be created at
        private void btn_chooseShortcutDest_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            DialogResult dialogResult = folderBrowser.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                _shortcutDestDir = folderBrowser.SelectedPath;
                tb_shortcutDestDir.Text = _shortcutDestDir;
            }
        }

        // Creates shortcut based on inputted user entries
        private void btn_createshortcut_Click(object sender, EventArgs e)
        {
            if (_ut4Dir == "")
            {
                MessageBox.Show("No UT4 directory selected.");
                return;
            }
            // Validate ut4 directory
            if (!ValidateUT4Dir(_ut4Dir) || !IsValidFilename(_shortcutName) || 
                !IsValidDestination(_shortcutDestDir))
            {
                return;
            }
            else // Create shortcut
            {
                try
                {
                    Installer.CreateShortcut(_shortcutName, _shortcutDestDir, _ut4Dir);
                }
                catch
                {
                    MessageBox.Show("Failed to create shorcut");
                }
            }

        }

        private bool ValidateUT4Dir(string directory)
        {
            string fullPathUE4 = Path.Combine(directory, @"Engine\Binaries\Win64\UE4-Win64-Shipping.exe");
            if (File.Exists(fullPathUE4)) { return true; }
            else
            {
                MessageBox.Show("UT4 exe not found at:\n" + fullPathUE4);
                return false;
            }
        }

        private bool IsValidFilename(string fileName)
        {
            bool isValid = !string.IsNullOrEmpty(fileName) && 
                            fileName.IndexOfAny(Path.GetInvalidFileNameChars()) < 0;

            if (isValid) { return true; }
            else
            {
                MessageBox.Show("Invalid shortcut filename:\n" +  fileName);
                return false;
            }
        }

        private bool IsValidDestination(string destination)
        {
            if (Directory.Exists(destination)) { return true; }
            else
            {
                MessageBox.Show("Shortcut destination path does not exist:\n" + destination);
                return false;
            }
        }

        private void tb_shortcutName_TextChanged(object sender, EventArgs e)
        {
            _shortcutName = tb_shortcutName.Text;
        }
    }
}
