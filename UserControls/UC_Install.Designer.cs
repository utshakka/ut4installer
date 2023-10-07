namespace UT4_Installer.UserControls
{
    partial class UC_Install
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtb_install = new System.Windows.Forms.RichTextBox();
            this.panel_progress = new System.Windows.Forms.Panel();
            this.tb_progress = new System.Windows.Forms.TextBox();
            this.pb_itemProgress = new System.Windows.Forms.ProgressBar();
            this.btn_install = new System.Windows.Forms.Button();
            this.tb_directory_install = new System.Windows.Forms.TextBox();
            this.btn_directory_install = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_progress.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(199, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unreal Tournament 4 Installer";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtb_install);
            this.panel1.Location = new System.Drawing.Point(36, 152);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 222);
            this.panel1.TabIndex = 11;
            // 
            // rtb_install
            // 
            this.rtb_install.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.rtb_install.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_install.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_install.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtb_install.ForeColor = System.Drawing.Color.White;
            this.rtb_install.Location = new System.Drawing.Point(0, 0);
            this.rtb_install.Name = "rtb_install";
            this.rtb_install.ReadOnly = true;
            this.rtb_install.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtb_install.Size = new System.Drawing.Size(539, 222);
            this.rtb_install.TabIndex = 9;
            this.rtb_install.Text = "";
            this.rtb_install.TextChanged += new System.EventHandler(this.rtb_install_TextChanged);
            // 
            // panel_progress
            // 
            this.panel_progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel_progress.Controls.Add(this.tb_progress);
            this.panel_progress.Controls.Add(this.pb_itemProgress);
            this.panel_progress.Location = new System.Drawing.Point(36, 393);
            this.panel_progress.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel_progress.Name = "panel_progress";
            this.panel_progress.Size = new System.Drawing.Size(539, 55);
            this.panel_progress.TabIndex = 29;
            this.panel_progress.Visible = false;
            // 
            // tb_progress
            // 
            this.tb_progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.tb_progress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_progress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_progress.ForeColor = System.Drawing.Color.White;
            this.tb_progress.Location = new System.Drawing.Point(0, 0);
            this.tb_progress.Margin = new System.Windows.Forms.Padding(0);
            this.tb_progress.Multiline = true;
            this.tb_progress.Name = "tb_progress";
            this.tb_progress.ReadOnly = true;
            this.tb_progress.Size = new System.Drawing.Size(539, 25);
            this.tb_progress.TabIndex = 29;
            // 
            // pb_itemProgress
            // 
            this.pb_itemProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb_itemProgress.Location = new System.Drawing.Point(0, 25);
            this.pb_itemProgress.Margin = new System.Windows.Forms.Padding(0);
            this.pb_itemProgress.Name = "pb_itemProgress";
            this.pb_itemProgress.Size = new System.Drawing.Size(539, 30);
            this.pb_itemProgress.TabIndex = 28;
            // 
            // btn_install
            // 
            this.btn_install.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_install.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btn_install.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_install.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_install.ForeColor = System.Drawing.Color.White;
            this.btn_install.Location = new System.Drawing.Point(617, 455);
            this.btn_install.Name = "btn_install";
            this.btn_install.Size = new System.Drawing.Size(92, 43);
            this.btn_install.TabIndex = 30;
            this.btn_install.Text = "Install";
            this.btn_install.UseVisualStyleBackColor = false;
            this.btn_install.Click += new System.EventHandler(this.btn_install_Click);
            // 
            // tb_directory_install
            // 
            this.tb_directory_install.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.tb_directory_install.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_directory_install.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_directory_install.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.tb_directory_install.Location = new System.Drawing.Point(36, 91);
            this.tb_directory_install.Multiline = true;
            this.tb_directory_install.Name = "tb_directory_install";
            this.tb_directory_install.ReadOnly = true;
            this.tb_directory_install.Size = new System.Drawing.Size(539, 37);
            this.tb_directory_install.TabIndex = 33;
            // 
            // btn_directory_install
            // 
            this.btn_directory_install.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_directory_install.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btn_directory_install.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_directory_install.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_directory_install.ForeColor = System.Drawing.Color.White;
            this.btn_directory_install.Location = new System.Drawing.Point(586, 91);
            this.btn_directory_install.Name = "btn_directory_install";
            this.btn_directory_install.Size = new System.Drawing.Size(105, 37);
            this.btn_directory_install.TabIndex = 32;
            this.btn_directory_install.Text = "Browse";
            this.btn_directory_install.UseVisualStyleBackColor = false;
            this.btn_directory_install.Click += new System.EventHandler(this.btn_directory_install_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Choose a directory to install UT4 in:";
            // 
            // UC_Install
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.tb_directory_install);
            this.Controls.Add(this.btn_directory_install);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_install);
            this.Controls.Add(this.panel_progress);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "UC_Install";
            this.Size = new System.Drawing.Size(726, 512);
            this.Load += new System.EventHandler(this.UC_Start_Load);
            this.panel1.ResumeLayout(false);
            this.panel_progress.ResumeLayout(false);
            this.panel_progress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private RichTextBox rtb_install;
        private TextBox tb_directory_install;
        private Button btn_directory_install;
        private Label label5;
        public ProgressBar pb_itemProgress;
        public Panel panel_progress;
        public TextBox tb_progress;
        public Button btn_install;
    }
}
