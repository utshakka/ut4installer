using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace UT4_Installer
{
    public abstract class LogBase
    {
        protected readonly object lockObj = new object();

        public abstract void Log(string message);
    }

    public class FileLogger : LogBase
    {
        private static string? filePath;
        public override void Log(string message)
        {
            // Ensure StreamWriter has a filepath to write to
            CheckFilePath();

            lock (lockObj)
            {
                using (StreamWriter streamWriter = new StreamWriter(filePath, true))
                {
                    streamWriter.WriteLine(message);
                    streamWriter.Close();
                }
            }
        }

        // Create log entry with DateTime identifier before message
        public void Log(string message, bool prefixDateTime)
        {
            if (prefixDateTime)
            {
                Log("[" + DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss") + "] : " + message);
            }
            else
            {
                Log(message);
            }
        }

        private void CheckFilePath()
        {
            if (filePath == null || filePath == "")
            {
                filePath = Path.Combine(Environment.CurrentDirectory, DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + "_Log.txt");
            }
        }

        // Forces a new log to be started by resetting filepath to null
        public void NewLog()
        {
            filePath = null;
        }

        public void OpenLog()
        {
            if (File.Exists(filePath))
            {
                var si = new ProcessStartInfo("notepad.exe", filePath);
                si.UseShellExecute = true;
                Process.Start(si);
            }
            else
            {
                MessageBox.Show("Log file does not exist", "Log file");
            }
        }
    }

    public static class Logger
    {
        private static FileLogger logger = new FileLogger();
        public static void Log(string message)
        {
            logger.Log(message);
        }

        public static void Log(string message, bool prefixDateTime)
        {
            logger.Log(message, prefixDateTime);
        }
        
        public static void NewLog()
        {
            logger.NewLog();
        }

        public static void OpenLog()
        {
            logger.OpenLog();
        }
    }
}
