
using System.Runtime.InteropServices;
using System.Security.Policy;
using UT4_Installer.UserControls;

namespace UT4_Installer
{
    public partial class form_ut4installer : Form
    {
        private List<Panel> panelSidebarList = new List<Panel>();
        private bool showCreateShortcut = false;
        private bool showCheckMasterServer = false;

        public form_ut4installer()
        {
            InitializeComponent();
            FormHelper.Form_Main = this;


            // Force title bar to dark
            UseImmersiveDarkMode(this.Handle, true);
        }

        private void form_ut4installer_Load(object sender, EventArgs e)
        {
            UC_Install uc = new UC_Install();
            FormHelper.activePanel = ActivePanel.Install;
            updateDisplay(uc);

            createSidebarPanelList();
        }

        // Creates a Panel array containing all of the sidebar panel tabs
        private void createSidebarPanelList()
        {
            panelSidebarList.Add(panel_install);
            panelSidebarList.Add(panel_finish);
            panelSidebarList.Add(panel_createShortcut);
            panelSidebarList.Add(panel_checkMasterServer);
        }

        // load desired UserControl form into active display panel (main window that user sees)
        public void updateDisplay(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelActiveDisplay.Controls.Clear();
            panelActiveDisplay.Controls.Add(userControl);
            userControl.BringToFront();

            if (userControl == FormHelper.Form_UC_Install) FormHelper.activePanel = ActivePanel.Install;
            else if (userControl == FormHelper.Form_UC_Finish) FormHelper.activePanel = ActivePanel.Finish;
            else if (userControl == FormHelper.Form_UC_CreateShortcut) FormHelper.activePanel = ActivePanel.CreateShortcut;
            else if (userControl == FormHelper.Form_UC_CheckMasterServer) { FormHelper.activePanel = ActivePanel.CheckMasterServer; }

            HighlightSelectedTabOnly(FormHelper.activePanel);
        }

        // update sidebar panel tab color so that only the current tab
        // has a different color compared to other non-active tabs
        private void HighlightSelectedTabOnly(ActivePanel activePanel)
        {
            Panel curPanel = new Panel();
            if (activePanel == ActivePanel.Install) { curPanel = panel_install; }
            else if (activePanel == ActivePanel.Finish) { curPanel = panel_finish; }
            else if (activePanel == ActivePanel.CreateShortcut) { curPanel = panel_createShortcut; }
            else if (activePanel == ActivePanel.CheckMasterServer) { curPanel = panel_checkMasterServer; }

            foreach (Panel panel in panelSidebarList)
            {
                if (panel == curPanel)
                {
                    panel.BackColor = Color.FromArgb(55, 55, 55);
                }
                else
                {
                    panel.BackColor = Color.FromArgb(42, 42, 42);
                }
            }
        }

        // disables extra buttons for when install is happening
        public void DisableButtons()
        {
            btn_checkMasterServerPanel.Enabled = false;
            btn_createShortcutPanel.Enabled = false;
        }
        // enables extra buttons for after install
        public void EnableButtons()
        {
            btn_checkMasterServerPanel.Enabled = true;
            btn_createShortcutPanel.Enabled = true;
        }

        private void updateExtraButtonLabels()
        {
            if (showCreateShortcut)
            {
                btn_createShortcutPanel.Text = "Create Shorcut\r\nHide";
            }
            else
            {
                btn_createShortcutPanel.Text = "Create Shorcut\r\nShow";
            }

            if (showCheckMasterServer)
            {
                btn_checkMasterServerPanel.Text = "Check Master Server\r\nHide";
            }
            else
            {
                btn_checkMasterServerPanel.Text = "Check Master Server\r\nShow";
            }
        }

        private void btn_createShortcutPanel_Click(object sender, EventArgs e)
        {
            if (!showCreateShortcut)
            {
                UC_CreateShortcut uc = new UC_CreateShortcut();
                FormHelper.activePanel = ActivePanel.CreateShortcut;
                updateDisplay(uc);

                showCreateShortcut = true;
                showCheckMasterServer = false;
                updateExtraButtonLabels();
            }
            else
            {
                UC_Install uc = new UC_Install();
                FormHelper.activePanel = ActivePanel.Install;
                updateDisplay(uc);

                showCreateShortcut = false;
                showCheckMasterServer = false;
                updateExtraButtonLabels();
            }

        }
        private void btn_checkMasterServerPanel_Click(object sender, EventArgs e)
        {
            if (!showCheckMasterServer)
            {
                UC_CheckMasterServer uc = new UC_CheckMasterServer();
                FormHelper.activePanel = ActivePanel.CheckMasterServer;
                updateDisplay(uc);

                showCreateShortcut = false;
                showCheckMasterServer = true;
                updateExtraButtonLabels();
            }
            else
            {
                UC_Install uc = new UC_Install();
                FormHelper.activePanel = ActivePanel.Install;
                updateDisplay(uc);

                showCreateShortcut = false;
                showCheckMasterServer = false;
                updateExtraButtonLabels();
            }
        }




        //Used for forcing dark title bar on winform
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1 = 19;
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        //Used for forcing dark title bar on winform
        private static bool UseImmersiveDarkMode(IntPtr handle, bool enabled)
        {
            if (IsWindows10OrGreater(17763))
            {
                var attribute = DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1;
                if (IsWindows10OrGreater(18985))
                {
                    attribute = DWMWA_USE_IMMERSIVE_DARK_MODE;
                }

                int useImmersiveDarkMode = enabled ? 1 : 0;
                return DwmSetWindowAttribute(handle, (int)attribute, ref useImmersiveDarkMode, sizeof(int)) == 0;
            }

            return false;
        }


        //Used for forcing dark title bar on winform
        private static bool IsWindows10OrGreater(int build = -1)
        {
            return Environment.OSVersion.Version.Major >= 10 && Environment.OSVersion.Version.Build >= build;
        }


    }
}