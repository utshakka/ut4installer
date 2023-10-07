
using System.Runtime.InteropServices;
using UT4_Installer.UserControls;

namespace UT4_Installer
{
    public partial class form_ut4installer : Form
    {
        private Panel[] panelSidebarTabs = new Panel[2];

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

            createSidebarPanelGroup();
        }

        // Creates a Panel array containing all of the sidebar panel tabs
        private void createSidebarPanelGroup()
        {
            panelSidebarTabs[0] = panel_install;
            panelSidebarTabs[1] = panel_finish;
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

            highlightSelectedTabOnly(FormHelper.activePanel);
        }

        // update sidebar panel tab color so that only the current tab
        // has a different color compared to other non-active tabs
        private void highlightSelectedTabOnly(ActivePanel activePanel)
        {
            if (activePanel == ActivePanel.Install)
            {
                panel_install.BackColor = Color.FromArgb(55, 55, 55);
                panel_finish.BackColor = Color.FromArgb(42, 42, 42);
            }
            else // (FormHelper.activePanel == ActivePanel.Finish)
            {
                panel_install.BackColor = Color.FromArgb(42, 42, 42);
                panel_finish.BackColor = Color.FromArgb(55, 55, 55);
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