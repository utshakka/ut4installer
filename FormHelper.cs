using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UT4_Installer.UserControls;

namespace UT4_Installer
{
    // Active panel states to assist in updating selected sidebar graphics
    public enum ActivePanel
    {
        Install,
        Finish
    }

    public class FormHelper
    {
        public static form_ut4installer Form_Main;
        public static UC_Install Form_UC_Install;
        public static UC_Finish Form_UC_Finish;


        public static ActivePanel activePanel=ActivePanel.Install;
    }
}
