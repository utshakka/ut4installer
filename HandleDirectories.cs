using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace UT4_Installer
{
    internal class HandleDirectories
    {
        // Size of ut4 game unzipped in mb
        private const int diskSpaceRequiredMB = 19500;

        // Expected install file names and file sizes
        private const string zipGameFilename = "UnrealTournament (installer_v1.0.3).zip";
        private const string zipUserDocFilename = "UnrealTournamentUserDocuments (installer_v1.0.3).zip";

        private const long zipGameFilesize = 10429026048; // bytes
        private const long zipUserDocFilesize = 1088; // bytes

        //////////////////////////////////////////////////////////////////////////
        ///////////         DETERMINE USER/PC SPECIFIC PATHS         /////////////
        //////////////////////////////////////////////////////////////////////////
        // tries to find & suggest a typical install path
        // for example:  C:\Program Files\UnrealTournament\
        public string FindInstallPath()
        {
            try
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "UnrealTournament");
            }
            catch (Exception ex)
            {
                Logger.Log("Find install path error", true);
                Logger.Log(ex.Message);
                return "";
            }
        }

        // finds user documents folder path
        public string FindUserDocumentsPath()
        {
            try
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
                //return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"UnrealTournament\Saved\Config\WindowsNoEditor");
            }
            catch (Exception ex)
            {
                Logger.Log("Find user documents path error", true);
                Logger.Log(ex.Message);
                return "";
            }
        }

        // find current runtime directory
        public string FindRuntimeDirectory()
        { 
            try
            {
                return Environment.CurrentDirectory;
            }
            catch (Exception ex)
            {
                Logger.Log("Find runtime directory error", true);
                Logger.Log(ex.Message);
                return "";
            }
        }


        //////////////////////////////////////////////////////////////////////////
        ///////////       VALIDATION CHECKS ON SELECTED PATHS        /////////////
        //////////////////////////////////////////////////////////////////////////
        // Check that install path has enough diskspace
        public bool CheckInstallPathDiskSpace(string installPath)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in allDrives)
            {
                if (drive.Name == Path.GetPathRoot(installPath))
                {
                    double availableSpace = ConvertBytesToMegabytes(drive.AvailableFreeSpace);
                    if (availableSpace < diskSpaceRequiredMB)
                    {
                        Logger.Log("Drive " + drive.Name + " has " + availableSpace.ToString("0") + "mb available and requires " + diskSpaceRequiredMB + "mb.", true);
                        return false;
                    }
                }
            }

            return true;
        }
        private static double ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }

        // Check for existing folders at install path to avoid overwrite
        public bool CheckGameFolderExists(string installPath)
        {
            if (Directory.Exists(installPath)) 
            {
                Logger.Log(installPath + " already exists. Delete folder or choose another install path", true);
                return false;
            }
            return true;
        }

        // Check runtimeDirectory/Files/ for necessary install files
        // Check filesize as crude md5 checksum
        public bool CheckInstallFiles(string runtimeDirectory)
        {
            // check main game zip
            string mainGame = Path.Combine(runtimeDirectory, "Files", zipGameFilename);
            if (File.Exists(mainGame))
            {
                long length = new System.IO.FileInfo(mainGame).Length;
                if (length != zipGameFilesize)
                {
                    Logger.Log("Game filesize read: " + length + " bytes   Game filesize expected: " + zipGameFilesize + " bytes", true);
                    return false;
                }
            }

            // check userdocs zip
            string userDocs = Path.Combine(runtimeDirectory, "Files", zipUserDocFilename);
            if (File.Exists(userDocs))
            {
                long length = new System.IO.FileInfo(userDocs).Length;
                if (length != zipUserDocFilesize)
                {
                    Logger.Log("User doc filesize read: " + length + " bytes   User doc filesize expected: " + zipGameFilesize + " bytes", true);
                    return false;
                }
            }

            return true;
        }

        public string GetZipGameFilename()
        {
            return zipGameFilename;
        }
        public string GetZipUserDocFilename()
        {
            return zipUserDocFilename;
        }
    }
}
