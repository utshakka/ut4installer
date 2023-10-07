namespace UT4_Installer.UserControls
{
    partial class UC_Finish
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
            this.btn_finish = new System.Windows.Forms.Button();
            this.btn_viewlog = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ms_link = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_installdir = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_finish
            // 
            this.btn_finish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_finish.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btn_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_finish.ForeColor = System.Drawing.Color.White;
            this.btn_finish.Location = new System.Drawing.Point(617, 455);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(92, 43);
            this.btn_finish.TabIndex = 31;
            this.btn_finish.Text = "Exit";
            this.btn_finish.UseVisualStyleBackColor = false;
            this.btn_finish.Click += new System.EventHandler(this.btn_finish_Click);
            // 
            // btn_viewlog
            // 
            this.btn_viewlog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_viewlog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btn_viewlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_viewlog.ForeColor = System.Drawing.Color.White;
            this.btn_viewlog.Location = new System.Drawing.Point(285, 457);
            this.btn_viewlog.Name = "btn_viewlog";
            this.btn_viewlog.Size = new System.Drawing.Size(157, 43);
            this.btn_viewlog.TabIndex = 32;
            this.btn_viewlog.Text = "View Install Log";
            this.btn_viewlog.UseVisualStyleBackColor = false;
            this.btn_viewlog.Click += new System.EventHandler(this.btn_viewlog_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(241, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "Installation Complete!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Game installed to:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "A shortcut has been placed on your desktop:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(39, 156);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(578, 18);
            this.label6.TabIndex = 37;
            this.label6.Text = "You must create an account on the new community master server to enable online pl" +
    "ay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "1) Create account here:";
            // 
            // lbl_ms_link
            // 
            this.lbl_ms_link.ActiveLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_ms_link.AutoSize = true;
            this.lbl_ms_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_ms_link.LinkColor = System.Drawing.Color.White;
            this.lbl_ms_link.Location = new System.Drawing.Point(234, 185);
            this.lbl_ms_link.Name = "lbl_ms_link";
            this.lbl_ms_link.Size = new System.Drawing.Size(160, 18);
            this.lbl_ms_link.TabIndex = 39;
            this.lbl_ms_link.TabStop = true;
            this.lbl_ms_link.Text = "https://ut4.timiimit.com/";
            this.lbl_ms_link.VisitedLinkColor = System.Drawing.Color.White;
            this.lbl_ms_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_ms_link_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(65, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(552, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "2) Copy auth code from site, start game, and paste into popup asking for auth cod" +
    "e";
            // 
            // tb_installdir
            // 
            this.tb_installdir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.tb_installdir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_installdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_installdir.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.tb_installdir.Location = new System.Drawing.Point(172, 66);
            this.tb_installdir.Multiline = true;
            this.tb_installdir.Name = "tb_installdir";
            this.tb_installdir.ReadOnly = true;
            this.tb_installdir.Size = new System.Drawing.Size(516, 23);
            this.tb_installdir.TabIndex = 41;
            this.tb_installdir.Text = "(install directory)";
            this.tb_installdir.WordWrap = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox1.Location = new System.Drawing.Point(346, 99);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(192, 23);
            this.textBox1.TabIndex = 43;
            this.textBox1.Text = "Unreal Tournament 4 UU";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.WordWrap = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UT4_Installer.Properties.Resources.auth_code_instructions;
            this.pictureBox1.Location = new System.Drawing.Point(39, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(649, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // UC_Finish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tb_installdir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_ms_link);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_viewlog);
            this.Controls.Add(this.btn_finish);
            this.Name = "UC_Finish";
            this.Size = new System.Drawing.Size(726, 512);
            this.Load += new System.EventHandler(this.UC_Finish_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_finish;
        private Button btn_viewlog;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label1;
        private LinkLabel lbl_ms_link;
        private Label label3;
        private TextBox tb_installdir;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}
