using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UT4_Installer.UserControls
{
    public partial class UC_CheckMasterServer : UserControl
    {
        private static string _engineIniPath = "";
        private string _missingLines = "";
        private int _missingCount = 0;
        private string _existingLines = "";
        private int _existingCount = 0;
        private static int _expectedCount = 7;

        public UC_CheckMasterServer()
        {
            InitializeComponent();
            FormHelper.Form_UC_CheckMasterServer = this;
        }

        private void UC_CheckMasterServer_Load(object sender, EventArgs e)
        {
            HandleDirectories handleDirectories = new HandleDirectories();
            if (_engineIniPath == "")
            {
                _engineIniPath = handleDirectories.SuggestEngineIniPath();
                tb_engineinipath.Text = _engineIniPath;
            }
            else
            {
                tb_engineinipath.Text = _engineIniPath;
            }
        }

        // Have user select their Engine.ini for UT4
        private void btn_selectEngineIni_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                _engineIniPath = openFileDialog.FileName;
                tb_engineinipath.Text = _engineIniPath;
            }
        }

        // Checks user UT4 Engine.ini for proper lines to connect to community
        // master server
        private void btn_checkEngineIni_Click(object sender, EventArgs e)
        {
            if (!IsValidEnginePath(_engineIniPath))
            {
                return;
            }

            CheckForMasterServerLines(_engineIniPath);
            DisplayConfigState();
        }

        // Updates (or creates if does not exist) Engine.ini with proper master
        // server lines
        private void btn_updateEngineIni_Click(object sender, EventArgs e)
        {
            // TODO
            // Add logic here.....if not valid, display error message, return and don't mess with rtb
            if (!IsValidEnginePath(_engineIniPath))
            {
                return;
            }

            UpdateConfig(_engineIniPath);
        }

        private bool IsValidEnginePath(string engineIniPath)
        {
            if (File.Exists(engineIniPath) && engineIniPath.Contains(@"UnrealTournament\Saved\Config\WindowsNoEditor\Engine.ini"))
            {
                return true;
            }
            else
            {
                if (engineIniPath != "") { MessageBox.Show("Path to Engine.ini not valid:\n" + engineIniPath); }
                else { MessageBox.Show("No Engine.ini selected."); }
                return false;
            }
        }

        private void ResetVars()
        {
            _missingLines = "";
            _existingLines = "";
            _missingCount = 0;
            _existingCount = 0;
        }

        private void CheckForMasterServerLines(string engineIniPath)
        {
            InstallerConfig installerConfig = new InstallerConfig();
            string[] toCheck = installerConfig.toCheck;
            string engineContents = System.IO.File.ReadAllText(engineIniPath);

            ResetVars();

            foreach (string curItem in toCheck)
            {
                if (engineContents.Contains(curItem))
                {
                    _existingLines += curItem + "\n\n";
                    _existingCount++;
                }
                else
                {
                    _missingLines += curItem + "\n\n";
                    _missingCount++;
                }                
            }
        }

        // Displays summary of found vs. missing 
        private void DisplayConfigState()
        {
            rtb_engineIni.Clear();
            rtb_engineIni.Text = _existingCount.ToString() + " out of " + _expectedCount.ToString() +
                                 " master server lines found\n";
            if (_missingCount > 0)
            {
                rtb_engineIni.Text += "Lines necessary to connect to the community master server are missing.\n" +
                    "Your game might not properly connect for online play.\n\n";
            }
            else
            {
                rtb_engineIni.Text += "All lines to connect to the community master server exist in the selected Engine.ini.\n" +
                    "Your game is configured to properly connect.\n\n";
            }
            rtb_engineIni.Text += "Found lines:\n";
            rtb_engineIni.Text += _existingLines;
            rtb_engineIni.Text += "\nMissing lines:\n";
            rtb_engineIni.Text += _missingLines;
        }

        // Checks for each master server line and appends if necessary
        private void UpdateConfig(string engineIniPath)
        {
            InstallerConfig installerConfig = new InstallerConfig();
            rtb_engineIni.Clear();

            string addedLines = installerConfig.UpdateEngineIni(engineIniPath);

            if (addedLines == "")
            {
                rtb_engineIni.Text = "No lines were added to Engine.ini.\n" +
                    "This means your game was already configured correctly to connect to the community master server.";
            }
            else
            {
                rtb_engineIni.Text = "Engine.ini was updated and your game is now properly configured to connect to the community master server.\n";
                rtb_engineIni.Text += "Lines added:\n";
                rtb_engineIni.Text += addedLines;
            }
        }
    }
}
