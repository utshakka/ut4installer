namespace UT4_Installer
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
            this.panel_sidebar = new System.Windows.Forms.Panel();
            this.panel_finish = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_install = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelActiveDisplay = new System.Windows.Forms.Panel();
            this.panel_sidebar.SuspendLayout();
            this.panel_finish.SuspendLayout();
            this.panel_install.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_sidebar
            // 
            this.panel_sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel_sidebar.Controls.Add(this.panel_finish);
            this.panel_sidebar.Controls.Add(this.panel_install);
            this.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sidebar.Location = new System.Drawing.Point(0, 0);
            this.panel_sidebar.Name = "panel_sidebar";
            this.panel_sidebar.Size = new System.Drawing.Size(143, 512);
            this.panel_sidebar.TabIndex = 0;
            // 
            // panel_finish
            // 
            this.panel_finish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel_finish.Controls.Add(this.label5);
            this.panel_finish.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_finish.Location = new System.Drawing.Point(0, 45);
            this.panel_finish.Name = "panel_finish";
            this.panel_finish.Size = new System.Drawing.Size(143, 45);
            this.panel_finish.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Finish";
            // 
            // panel_install
            // 
            this.panel_install.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel_install.Controls.Add(this.label1);
            this.panel_install.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_install.Location = new System.Drawing.Point(0, 0);
            this.panel_install.Name = "panel_install";
            this.panel_install.Size = new System.Drawing.Size(143, 45);
            this.panel_install.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Install";
            // 
            // panelActiveDisplay
            // 
            this.panelActiveDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panelActiveDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActiveDisplay.Location = new System.Drawing.Point(143, 0);
            this.panelActiveDisplay.Name = "panelActiveDisplay";
            this.panelActiveDisplay.Size = new System.Drawing.Size(726, 512);
            this.panelActiveDisplay.TabIndex = 1;
            // 
            // form_ut4installer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 512);
            this.Controls.Add(this.panelActiveDisplay);
            this.Controls.Add(this.panel_sidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_ut4installer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UT4 Installer";
            this.Load += new System.EventHandler(this.form_ut4installer_Load);
            this.panel_sidebar.ResumeLayout(false);
            this.panel_finish.ResumeLayout(false);
            this.panel_finish.PerformLayout();
            this.panel_install.ResumeLayout(false);
            this.panel_install.PerformLayout();
            this.ResumeLayout(false);

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