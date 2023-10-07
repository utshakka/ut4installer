using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UT4_Installer.UserControls
{

    public partial class UC_Finish : UserControl
    {

        public UC_Finish()
        {
            InitializeComponent();
            FormHelper.Form_UC_Finish = this;
        }

        private void UC_Finish_Load(object sender, EventArgs e)
        {
            tb_installdir.Text = Installer.GetInstallPath();

        }

        private void lbl_ms_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var si = new ProcessStartInfo(lbl_ms_link.Text);
            si.UseShellExecute = true;
            Process.Start(si);
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_viewlog_Click(object sender, EventArgs e)
        {
            Logger.OpenLog();
        }
    }
}
