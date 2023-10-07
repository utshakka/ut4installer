using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT4_Installer
{
    public static class Installer
    {
        private static InstallerConfig installerConfig = new InstallerConfig();

        // Checks user system for predetermined install directory, locates user documents folder,
        // stores current runtime directory, and checks if required runtime dependencies are installed
        public static void SystemChecks()
        {
            installerConfig.FindUserPaths();
            installerConfig.UpdateDependencyStatus();
        }

        // Sets a new UT4 installation path
        public static void SetInstallPath(string path)
        {
            installerConfig.SetInstallationDirectory(path);
        }
        public static string GetInstallPath()
        {
            return installerConfig.GetInstallationDirectory();
        }

        // Generates a string summary of the items found via functions
        // called in SystemChecks()
        public static string GetInstallationSummary()
        {
            return installerConfig.GenerateInstallationSummary();
        }

        // Performs multiple validation checks and proceeds to install
        // the UT4 game.
        // Enough disk space, files already exist in install location, etc
        public static void InstallGame()
        {
            installerConfig.InstallGame();
        }

    }
}
