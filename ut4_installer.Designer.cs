﻿namespace UT4_Installer
{
    partial class form_ut4installer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ut4installer));
            panel_sidebar = new Panel();
            panel_finish = new Panel();
            label5 = new Label();
            panel_install = new Panel();
            label1 = new Label();
            panelActiveDisplay = new Panel();
            panel_sidebar.SuspendLayout();
            panel_finish.SuspendLayout();
            panel_install.SuspendLayout();
            SuspendLayout();
            // 
            // panel_sidebar
            // 
            panel_sidebar.BackColor = Color.FromArgb(33, 33, 33);
            panel_sidebar.Controls.Add(panel_finish);
            panel_sidebar.Controls.Add(panel_install);
            panel_sidebar.Dock = DockStyle.Left;
            panel_sidebar.Location = new Point(0, 0);
            panel_sidebar.Name = "panel_sidebar";
            panel_sidebar.Size = new Size(143, 512);
            panel_sidebar.TabIndex = 0;
            // 
            // panel_finish
            // 
            panel_finish.BackColor = Color.FromArgb(42, 42, 42);
            panel_finish.Controls.Add(label5);
            panel_finish.Dock = DockStyle.Top;
            panel_finish.Location = new Point(0, 45);
            panel_finish.Name = "panel_finish";
            panel_finish.Size = new Size(143, 45);
            panel_finish.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(13, 13);
            label5.Name = "label5";
            label5.Size = new Size(47, 18);
            label5.TabIndex = 0;
            label5.Text = "Finish";
            // 
            // panel_install
            // 
            panel_install.BackColor = Color.FromArgb(55, 55, 55);
            panel_install.Controls.Add(label1);
            panel_install.Dock = DockStyle.Top;
            panel_install.Location = new Point(0, 0);
            panel_install.Name = "panel_install";
            panel_install.Size = new Size(143, 45);
            panel_install.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(45, 18);
            label1.TabIndex = 0;
            label1.Text = "Install";
            // 
            // panelActiveDisplay
            // 
            panelActiveDisplay.BackColor = Color.FromArgb(55, 55, 55);
            panelActiveDisplay.Dock = DockStyle.Fill;
            panelActiveDisplay.Location = new Point(143, 0);
            panelActiveDisplay.Name = "panelActiveDisplay";
            panelActiveDisplay.Size = new Size(726, 512);
            panelActiveDisplay.TabIndex = 1;
            // 
            // form_ut4installer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 512);
            Controls.Add(panelActiveDisplay);
            Controls.Add(panel_sidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "form_ut4installer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UT4 Installer";
            Load += form_ut4installer_Load;
            panel_sidebar.ResumeLayout(false);
            panel_finish.ResumeLayout(false);
            panel_finish.PerformLayout();
            panel_install.ResumeLayout(false);
            panel_install.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_sidebar;
        private Panel panelActiveDisplay;
        private Panel panel_finish;
        private Label label5;
        private Panel panel_install;
        private Label label1;
    }
}