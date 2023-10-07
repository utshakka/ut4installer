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
    public partial class UC_Install : UserControl
    {
        public UC_Install()
        {
            InitializeComponent();
            FormHelper.Form_UC_Install = this;
        }

        private void UC_Start_Load(object sender, EventArgs e)
        {
            Installer.SystemChecks();

            tb_directory_install.Text = Installer.GetInstallPath();
            rtb_install.Text = Installer.GetInstallationSummary();
        }

        public void appendDisplayAndLog(string lineToAppend)
        {
            rtb_install.Text += lineToAppend + "\n";
            Logger.Log(lineToAppend, true);
        }

        private void btn_directory_install_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            DialogResult dialogResult = folderBrowser.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Installer.SetInstallPath(Path.Combine(folderBrowser.SelectedPath, "UnrealTournament"));
                tb_directory_install.Text = Installer.GetInstallPath();
                rtb_install.Text = Installer.GetInstallationSummary();
            }
        }

        private void btn_install_Click(object sender, EventArgs e)
        {
            // Disable form buttons during install
            disableButtons();

            // Start log with installation summary
            Logger.NewLog();
            Logger.Log(Installer.GetInstallationSummary());
            rtb_install.Text = Installer.GetInstallationSummary();

            // Begin game install
            Installer.InstallGame();

        }

        public void enableButtons()
        {
            btn_install.Enabled = true;
            btn_directory_install.Enabled = true;
        }

        public void disableButtons() 
        { 
            btn_install.Enabled = false;
            btn_directory_install.Enabled = false;
        }

        private void rtb_install_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            rtb_install.SelectionStart = rtb_install.Text.Length;
            // scroll it automatically
            rtb_install.ScrollToCaret();
        }
    }
}
