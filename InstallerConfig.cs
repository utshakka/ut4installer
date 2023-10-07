using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using IWshRuntimeLibrary;
using System.IO;
using System.ComponentModel.DataAnnotations;
using UT4_Installer.UserControls;

namespace UT4_Installer
{

    internal class InstallerConfig
    {
        //////////////////////////////////////////////////////////////////////////
        ///////////////////       CONFIGURATION VARIABLES      ///////////////////
        //////////////////////////////////////////////////////////////////////////
        // Installation and download directories
        private string installDirectory = "";
        private string userDocumentsDirectory = "";
        private string runtimeDirectory = "";

        // UT4 game runtime dependency status
        private bool hasDirectx = false;
        private bool hasVC2013 = false;

        private HandleDependencies dependencies = new HandleDependencies();
        private HandleDirectories directories = new HandleDirectories();

        // used for updating form progress bar
        private BackgroundWorker installGame;
        public Progress<ZipProgress> _progress;

        private bool installComplete = false;

        public InstallerConfig()
        {
            installGame = new BackgroundWorker();
            installGame.DoWork += InstallGame_DoWork;
            installGame.ProgressChanged += InstallGame_ReportProgress;
            installGame.RunWorkerCompleted += InstallGame_RunWorkerCompleted;
            installGame.WorkerSupportsCancellation = true;
            installGame.WorkerReportsProgress = true;

            _progress = new Progress<ZipProgress>();
            _progress.ProgressChanged += ZipReport;
        }

        //////////////////////////////////////////////////////////////////////////
        ///////////    INSTALL UT4 MAIN FUNCTION   ///////////////////////////////
        //////////////////////////////////////////////////////////////////////////
        public void InstallGame()
        {
            FormHelper.Form_UC_Install.appendDisplayAndLog("BEGIN INSTALL");

            // Check path for enough space
            // unzipped game is 19.3gb, make sure user has 19.5gb available
            if (!CheckDiskSpace())
            {
                MessageBox.Show("Not enough free disk space at chosen install directory", "Error");
                FormHelper.Form_UC_Install.appendDisplayAndLog("Cancelling install, not enough disk space at install directory");
                FormHelper.Form_UC_Install.enableButtons();
                return;
            }

            // Check paths for existing data - does UnrealTournament exist at install directory?
            if (!CheckPathsExisting())
            {
                MessageBox.Show("An UnrealTournament folder already exists at chosen install directory", "Error");
                FormHelper.Form_UC_Install.appendDisplayAndLog("Cancelling install, UnrealTournament folder already exists");
                FormHelper.Form_UC_Install.enableButtons();
                return;
            }

            // Check if install files exist and are valid - located @/Files/
            if (!VerifyInstallFiles())
            {
                MessageBox.Show("Install files missing or invalid", "Error");
                FormHelper.Form_UC_Install.appendDisplayAndLog("Cancelling install, install files missing or corrupted");
                FormHelper.Form_UC_Install.enableButtons();
                return;
            }

            // Begin lengthy game file extraction/installation
            // Finish up installation in backgroundworker
            installGame.RunWorkerAsync();
        }

        //////////////////////////////////////////////////////////////////////////
        /////////////////    Helper functions for game install   /////////////////
        //////////////////////////////////////////////////////////////////////////
        private bool CheckDiskSpace()
        {
            string updateText = "Has enough disk space for install?: ";
            bool diskSpacePass = directories.CheckInstallPathDiskSpace(installDirectory);

            if (diskSpacePass) { updateText += "Yes"; }
            else { updateText += "No"; }

            FormHelper.Form_UC_Install.appendDisplayAndLog(updateText);

            return diskSpacePass;
        }

        private bool CheckPathsExisting()
        {
            string updateText = "No existing UnrealTournament folder at install directory?: ";
            bool folderExistPass = directories.CheckGameFolderExists(installDirectory);

            if (folderExistPass) { updateText += "Yes"; }
            else { updateText += "No"; }

            FormHelper.Form_UC_Install.appendDisplayAndLog(updateText);

            return folderExistPass;
        }

        private bool VerifyInstallFiles()
        {
            string updateText = "Install files exist and verified?: ";
            bool installFilesPass = directories.CheckInstallFiles(runtimeDirectory);

            if (installFilesPass) { updateText += "Yes"; }
            else { updateText += "No"; }

            FormHelper.Form_UC_Install.appendDisplayAndLog(updateText);

            return installFilesPass;
        }

        //////////////////////////////////////////////////////////////////////////
        ////  FUNCTIONS TO UPDATE USER DIRECTORIES AND PC DEPENDENCY STATUS   ////
        //////////////////////////////////////////////////////////////////////////
        // tries to auto find directories used during installatioon
        public void FindUserPaths()
        {
            if (installDirectory == "") { installDirectory = directories.FindInstallPath(); }
            if (userDocumentsDirectory == "") { userDocumentsDirectory = directories.FindUserDocumentsPath(); }
            if (runtimeDirectory == "") { runtimeDirectory = directories.FindRuntimeDirectory(); }
        }
        public void SetInstallationDirectory(string path)
        {
            installDirectory = path;
        }
        public string GetInstallationDirectory() 
        {
            return installDirectory;
        }

        // checks to see if user has directx end user runtime and vc++2013
        public void UpdateDependencyStatus()
        {
            hasDirectx = dependencies.CheckDirectXDependency();
            hasVC2013 = dependencies.CheckVC2013Dependency();
        }



        //////////////////////////////////////////////////////////////////////////
        /////////////       GENERATE INSTALLATION TEXT SUMMARY      //////////////
        //////////////////////////////////////////////////////////////////////////
        // Generates installation summary for display in a textbox
        public string GenerateInstallationSummary()
          {
              string summary = "";

              summary = "Unreal Tournament 4\n\n";
              summary += "-Connected to new master server\n";
              summary += "-UT4UU v10.1.6\n";
              summary += "-Monkey Patch v1.0 (fix map change game crash)\n";
              summary += "-Audio Patch v1.1 (allows audio device change with game running)\n\n";
              summary += GenerateInstallationPathInfo();
              summary += GenerateInstallationDependencies();

              return summary;
          }


          // Compiles all of the installation paths to be used into a string
          private string GenerateInstallationPathInfo()
          {
             string installInfo = "";

              installInfo = "Install Directory:   ";
              installInfo += installDirectory + "\n";
              //installInfo += "User Documents Directory:   ";
              //installInfo += userDocumentsDirectory + "\n";

              return installInfo + "\n";
          }

          // Compiles game runtime dependency checks into a string
          private string GenerateInstallationDependencies()
          {
              string dependencies = "";

              dependencies = "Has DirectX End-User Runtime (June 2010)?:   ";
              if (hasDirectx) dependencies += "Yes\n";
              else dependencies += "No\n";

              dependencies += "Has VC++ 2013?:   ";
              if (hasVC2013) dependencies += "Yes\n";
              else dependencies += "No\n";

              return dependencies + "\n";
          }

        //////////////////////////////////////////////////////////////////////////
        //     BackgroundWorker for time consuming game install operations      //
        //////////////////////////////////////////////////////////////////////////
        private async void InstallGame_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                FormHelper.Form_UC_Install.panel_progress.Visible = false;
                FormHelper.Form_UC_Install.appendDisplayAndLog("Installation stopped....");
                FormHelper.Form_UC_Install.enableButtons();
            }
            else
            {
                FormHelper.Form_UC_Install.panel_progress.Visible = false;
                FormHelper.Form_UC_Install.appendDisplayAndLog("Installation complete.....");

                await Task.Delay(2000);

                UC_Finish uc_finish = new UC_Finish();
                FormHelper.Form_Main.updateDisplay(uc_finish);
            }
        }

        private void InstallGame_ReportProgress(object sender, ProgressChangedEventArgs e)
        {
            string action = e.UserState.ToString();
            
            switch (action)
            {
                case "enablebuttons":
                    FormHelper.Form_UC_Install.enableButtons();
                    break;
                case "startcopygame":
                    FormHelper.Form_UC_Install.panel_progress.Visible = true;
                    break;
                default:
                    FormHelper.Form_UC_Install.appendDisplayAndLog(action);
                    break;
            }
        }

        private void InstallGame_DoWork(object sender, DoWorkEventArgs e)
        {
            // Check if pc has required game dependencies installed and install if needed
            // If they fail to install, user can still install the game, but will be notified
            // that they have to manually handle the game dependencies later on for the game to run
            if (!CheckDependencies())
            {
                installGame.ReportProgress(0, "Game runtime dependencies missing and failed to install");
                //FormHelper.Form_UC_Install.appendDisplayAndLog("Game runtime dependencies missing or failed to install");

                DialogResult dialogResult = MessageBox.Show("Game runtime dependencies missing and failed to install.\n" +
                    "Game installation can continue, but might require a manual install of the runtime dependencies for the game to work.\n" +
                    "Do you want to proceed with the UT4 install?", "Runtime dependencies error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    installGame.ReportProgress(0, "User wishes to halt installation");
                    installGame.ReportProgress(0, "enablebuttons");
                    //FormHelper.Form_UC_Install.appendDisplayAndLog("User wishes to halt installation");
                    //FormHelper.Form_UC_Install.enableButtons();
                    e.Cancel = true;
                    return;
                }

                installGame.ReportProgress(0, "Installation will continue, but game might not start and require a manual install of runtime dependencies");
                //FormHelper.Form_UC_Install.appendDisplayAndLog("Installation will continue, but game might not start and require manual install of runtime dependencies");
            }

            // Extract game files to install dir
            installGame.ReportProgress(0, "startcopygame");
            installGame.ReportProgress(0, "Extracting game files to install directory");
            CopyGameFiles();


            // does Engine.ini exist in UnrealTournament folder in User Documents?
            // "C:\Users\USER\Documents\UnrealTournament\Saved\Config\WindowsNoEditor\Engine.ini"
            // if yes, check & append master server lines
            // if no, extract from /Files/
            installGame.ReportProgress(0, "Updating user document files to point to new master server");
            UpdateUserDocumentFiles();

            // update UU InstallInfo.bin in both locations
            installGame.ReportProgress(0, "Updating InstallInfo.bin files");
            UpdateInstallInfo();

            // create UT4 game shortcut
            CreateShortcut();
            installGame.ReportProgress(0, "Game shortcut was created");
        }

        private bool CheckDependencies()
        {
            if (!hasDirectx)
            {
                installGame.ReportProgress(0, "Installing DirectX End-User Runtime (June 2010)....");
                dependencies.InstallDirectX(); 
            }
            if (!hasVC2013) {
                installGame.ReportProgress(0, "Installing Visual C++ 2013....");
                dependencies.InstallVC2013();
            }

            string updateText = "Game runtime dependencies existing or installed?: ";
            bool checkDependencyPass = true;
            if (!dependencies.CheckDirectXDependency() || !dependencies.CheckVC2013Dependency())
            {
                checkDependencyPass = false;
            }

            if (checkDependencyPass) { updateText += "Yes"; }
            else { updateText += "No"; }

            installGame.ReportProgress(0, updateText);

            return checkDependencyPass;
        }

        private void CopyGameFiles()
        {
            string fileName = Path.Combine(runtimeDirectory, "Files", directories.GetZipGameFilename());
            string extractPath = Path.GetFullPath(Directory.GetParent(installDirectory).ToString());

            using (ZipArchive archive = ZipFile.OpenRead(fileName))
            {
                archive.ExtractToDirectory(extractPath, _progress);
            }
        }

        //Copy engine.ini with new master server links if not exist
        //Append master server lines in engine.ini if it does
        private void UpdateUserDocumentFiles()
        {
            string fileName = Path.Combine(runtimeDirectory, "Files", directories.GetZipUserDocFilename());
            string destFileName = @"\UnrealTournament\Saved\Config\WindowsNoEditor\Engine.ini";
            string fullDestPath = Path.GetFullPath(userDocumentsDirectory + destFileName);

            if (!System.IO.File.Exists(fullDestPath))
            {
                string extractPath = Path.GetFullPath(userDocumentsDirectory);

                using (ZipArchive archive = ZipFile.OpenRead(fileName))
                {
                    archive.ExtractToDirectory(extractPath, _progress);
                }
                Logger.Log("Engine.ini copied to " + fullDestPath, true);
            }
            else
            {
                bool needToWrite = false;
                string allContents = System.IO.File.ReadAllText(fullDestPath);

                foreach (string curItem in toCheck)
                {
                    if (!allContents.Contains(curItem))
                    {
                        needToWrite = true;
                        break;
                    }
                }

                if (needToWrite)
                {
                    // check for new lines at end of text file, append if needed
                    if (allContents.Length >= 2)
                    {
                        int numNewLines = 0;
                        if (allContents[allContents.Length - 1].ToString() == "\n" || allContents[allContents.Length - 1].ToString() == "\r\n" ||
                            allContents[allContents.Length - 1].ToString() == "\r")
                        {
                            numNewLines++;
                        }
                        if (allContents[allContents.Length - 2].ToString() == "\n" || allContents[allContents.Length - 2].ToString() == "\r\n" ||
                            allContents[allContents.Length - 2].ToString() == "\r")
                        {
                            numNewLines++;
                        }

                        using (StreamWriter sw = System.IO.File.AppendText(fullDestPath))
                        {
                            while (numNewLines < 2)
                            {
                                sw.Write("\n");
                                numNewLines++;
                            }
                        }
                    }

                    for (int i = 0; i < toCheck.Length; i++)
                    {
                        if (!allContents.Contains(toCheck[i]))
                        {
                            using (StreamWriter sw = System.IO.File.AppendText(fullDestPath))
                            {
                                if (i == toCheck.Length - 1)
                                {
                                    sw.Write(toCheck[i] + "\n");
                                }
                                else
                                {
                                    sw.Write(toCheck[i] + "\n\n");
                                }

                            }
                        }
                    }
                    Logger.Log("Engine.ini already exists, updated with code to connect to new master server", true);
                }
                else
                {
                    Logger.Log("Engine.ini already exists and new master server code is also present", true);
                }
            }
        }

        private string[] toCheck = new string[]
        {
            "[OnlineSubsystemMcp.OnlineContentControlsServiceMcp UnrealTournamentDev]\r\nDomain=master-ut4.timiimit.com\r\nProtocol=https",
            "[OnlineSubsystemMcp.BaseServiceMcp]\r\nDomain=master-ut4.timiimit.com\r\nProtocol=https",
            "[OnlineSubsystemMcp.GameServiceMcp]\r\nDomain=master-ut4.timiimit.com\r\nProtocol=https",
            "[OnlineSubsystemMcp.AccountServiceMcp]\r\nDomain=master-ut4.timiimit.com\r\nProtocol=https",
            "[OnlineSubsystemMcp.OnlineFriendsMcp]\r\nDomain=master-ut4.timiimit.com\r\nProtocol=https",
            "[OnlineSubsystemMcp.PersonaServiceMcp]\r\nDomain=master-ut4.timiimit.com\r\nProtocol=https",
            "[OnlineSubsystemMcp.OnlineImageServiceMcp]\r\nDomain=master-ut4.timiimit.com\r\nProtocol=https"
        };

        // Update InstallInfo.bin file created during normal UU install
        // must update sourceinstall path and character length of this install path
        //UnrealTournament\UnrealTournament\Plugins\UT4UU\InstallInfo.bin
        //UnrealTournament\WindowsServer\UnrealTournament\Plugins\UT4UU\InstallInfo.bin
        public void UpdateInstallInfo()
        {
            bool createShortcut;
            bool isDryRun;
            bool createSymbolicLinks;
            bool upgradeEngineModules;
            bool refreshingExperience;
            bool tryToInstallInLocalGameServer;
            string sourceLocation;
            string installLocation;
            string replacementSuffix;
            byte platformTarget;
            byte buildConfiguration;

            string[] installInfo = new string[]
            {
                Path.Combine(installDirectory, @"UnrealTournament\Plugins\UT4UU\InstallInfo.bin"),
                Path.Combine(installDirectory, @"WindowsServer\UnrealTournament\Plugins\UT4UU\InstallInfo.bin")
            };

            foreach (string infoItem in installInfo)
            {
                using (var r = new BinaryReader(new FileStream(infoItem, FileMode.Open, FileAccess.Read, FileShare.Read)))
                {
                    createShortcut = r.ReadBoolean();
                    isDryRun = r.ReadBoolean();
                    createSymbolicLinks = r.ReadBoolean();
                    upgradeEngineModules = r.ReadBoolean();
                    refreshingExperience = r.ReadBoolean();
                    tryToInstallInLocalGameServer = r.ReadBoolean();
                    sourceLocation = r.ReadString();
                    sourceLocation = "C:\\Generic\\Install\\Path";
                    installLocation = r.ReadString();
                    installLocation = installDirectory;
                    replacementSuffix = r.ReadString();
                    platformTarget = r.ReadByte();
                    buildConfiguration = r.ReadByte();
                }
                System.IO.File.Delete(infoItem);
                using (var w = new BinaryWriter(new FileStream(infoItem, FileMode.Create, FileAccess.Write, FileShare.Read)))
                {
                    w.Write(createShortcut);
                    w.Write(isDryRun);
                    w.Write(createSymbolicLinks);
                    w.Write(upgradeEngineModules);
                    w.Write(refreshingExperience);
                    w.Write(tryToInstallInLocalGameServer);
                    w.Write(sourceLocation);
                    w.Write(installLocation);
                    w.Write(replacementSuffix);
                    w.Write(platformTarget);
                    w.Write(buildConfiguration);
                }
            }
        }


        // Create game shortcut on desktop
        public void CreateShortcut()
        {
            WshShell shell = new();

            string shorcutDesktopLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), 
                "Unreal Tournament 4 UU.lnk");
            //"C:\Program Files\Epic Games\UnrealTournament\Engine\Binaries\Win64\UE4-Win64-Shipping.exe"
            string fullPathToExe = Path.Combine(installDirectory, @"Engine\Binaries\Win64\UE4-Win64-Shipping.exe");

            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shorcutDesktopLocation);
            shortcut.TargetPath = fullPathToExe;
            shortcut.WorkingDirectory = Path.GetDirectoryName(fullPathToExe);
            shortcut.Arguments = "UnrealTournament -epicapp=UnrealTournamentDev -epicenv=Prod -EpicPortal";
            shortcut.IconLocation = fullPathToExe + ", 0";
            shortcut.Description = "Run Unreal Tournament 4 as if it was ran from Epic Games Launcher";
            shortcut.Hotkey = "Ctrl+Shift+U";
            shortcut.Save();
        }

        private void ZipReport(object sender, ZipProgress zipProgress)
        {
            // update progress bar
            if (FormHelper.Form_UC_Install.pb_itemProgress.Maximum != zipProgress.Total)
            {
                FormHelper.Form_UC_Install.pb_itemProgress.Maximum = zipProgress.Total;
            }
            FormHelper.Form_UC_Install.pb_itemProgress.Value = zipProgress.Processed;

            // update labels
            string itemCount = "(" + zipProgress.Processed + "/" + zipProgress.Total + "): ";
            string itemName = "Unzipping " + Path.GetFileName(zipProgress.CurrentItem);
            FormHelper.Form_UC_Install.tb_progress.Text = itemCount + itemName;
        }

    }
}
