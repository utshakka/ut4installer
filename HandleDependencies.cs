using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT4_Installer
{
    internal class HandleDependencies
    {       
        // keys to check for in HKLM registry if vc++2013 is installed
        // 30501.0 is latest via microsoft installer
        // 40664.0 is latest available by microft as a separate update
        // vc2013 x64 12.0.30501.0 - HKLM\SOFTWARE\Classes\Installer\Dependencies\{050d4fc8-5d48-4b8f-8972-47c82c46020f}
        // vc2013 x64 12.0.40664.0 - HKLM\SOFTWARE\Classes\Installer\Dependencies\{042d26ef-3dbe-4c25-95d3-4c1b11b235a7}
        private readonly string[] vc2013_64_registry = new string[]
        {
            @"SOFTWARE\Classes\Installer\Dependencies\{050d4fc8-5d48-4b8f-8972-47c82c46020f}",
            @"SOFTWARE\Classes\Installer\Dependencies\{042d26ef-3dbe-4c25-95d3-4c1b11b235a7}"
        };

        // files to check for in \Windows\System32\ as an indicator if directx end user runtime (June 2010) is installed
        private readonly string[] dx_files = new string[]
        {
            @"xinput1_3.dll",
            @"XAudio2_7.dll",
            @"XAPOFX1_5.dll",
            @"X3DAudio1_7.dll"
        };

        // does user have directx end-user runtime (june 2010) installed?
        // needs:
        //  xinput1_3.dll -> System32
        //  XAPOFX1_5.dll -> System32
        //  XAudio2_7.dll -> System32
        //  X3DAudio1_7.dll -> System32
        public bool CheckDirectXDependency()
        {
            foreach (string dxfile in dx_files)
            {
                if (!File.Exists(Path.Combine(Environment.SystemDirectory, dxfile))) { return false; }
            }
            return true;
        }

        // does user have vc++ 2013 (x64) installed?
        public bool CheckVC2013Dependency()
        {
            foreach (string keypath in vc2013_64_registry)
            {
                RegistryKey? key = Registry.LocalMachine.OpenSubKey(keypath);
                if (key != null) { return true; }
            }

            return false;
        }

        // Install of directx enduser runtime (june2010)
        public bool InstallDirectX()
        {
            string strWorkPath = Environment.CurrentDirectory;
            string resourceName = "DXSETUP.exe";

            string fullPath = Path.Combine(strWorkPath, "Resources", "dx", resourceName);

            if (File.Exists(fullPath))
            {
                try
                {
                    // install dx using microsoft installer (silent install)
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.FileName = fullPath;
                    process.StartInfo.Arguments = "/silent";
                    process.StartInfo.UseShellExecute = false;
                    process.Start();
                    process.WaitForExit();
                    if (process.ExitCode == 0)
                    {
                        Logger.Log("Directx end user runtime (June 2010) successfully installed", true);
                        return true;
                    }
                    else
                    {
                        Logger.Log("Error installing directx end user runtime (June 2010)", true);
                        return false;
                    }

                }
                catch (Exception ex) {
                    Logger.Log(ex.Message, true);
                    Logger.Log("Error installing directx end user runtime (June 2010)", true);
                }
            }
            else
            {
                Logger.Log(resourceName + " not found in installer directory: " + fullPath, true);
            }
            return false;
        }

        // Silently installs VC2013
        public bool InstallVC2013()
        {
            string strWorkPath = Environment.CurrentDirectory;
            string resourceName = "vcredist_x64_12.0.40664.exe";

            string fullPath = Path.Combine(strWorkPath, "Resources", resourceName);

            if (File.Exists(fullPath))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = fullPath;
                process.StartInfo.Arguments = "/c /install /quiet /norestart";
                process.StartInfo.UseShellExecute = false;
                process.Start();
                process.WaitForExit();
                if (process.ExitCode == 0)
                {
                    Logger.Log("VC2013+ (x64_12.0.40664) successfully installed", true);
                    return true;
                }
                else
                {
                    Logger.Log("Could not install VC2013+ (x64_12.0.40664)", true);
                    return false;
                }
            }
            else
            {
                Logger.Log(resourceName + " not found in installer directory: " + fullPath, true);
            }
            return false;
        }
    }
}
