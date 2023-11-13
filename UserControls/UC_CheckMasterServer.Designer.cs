namespace UT4_Installer.UserControls
{
    partial class UC_CheckMasterServer
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
            label1 = new Label();
            tb_engineinipath = new TextBox();
            btn_selectEngineIni = new Button();
            label5 = new Label();
            btn_checkEngineIni = new Button();
            rtb_engineIni = new RichTextBox();
            btn_updateEngineIni = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(126, 16);
            label1.Name = "label1";
            label1.Size = new Size(475, 29);
            label1.TabIndex = 3;
            label1.Text = "Check Config for Master Server Connection";
            // 
            // tb_engineinipath
            // 
            tb_engineinipath.BackColor = Color.FromArgb(42, 42, 42);
            tb_engineinipath.BorderStyle = BorderStyle.FixedSingle;
            tb_engineinipath.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_engineinipath.ForeColor = SystemColors.ActiveBorder;
            tb_engineinipath.Location = new Point(19, 82);
            tb_engineinipath.Multiline = true;
            tb_engineinipath.Name = "tb_engineinipath";
            tb_engineinipath.ReadOnly = true;
            tb_engineinipath.Size = new Size(572, 37);
            tb_engineinipath.TabIndex = 43;
            // 
            // btn_selectEngineIni
            // 
            btn_selectEngineIni.BackColor = Color.FromArgb(50, 50, 50);
            btn_selectEngineIni.FlatAppearance.BorderColor = Color.FromArgb(92, 92, 92);
            btn_selectEngineIni.FlatStyle = FlatStyle.Flat;
            btn_selectEngineIni.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_selectEngineIni.ForeColor = Color.White;
            btn_selectEngineIni.Location = new Point(602, 82);
            btn_selectEngineIni.Name = "btn_selectEngineIni";
            btn_selectEngineIni.Size = new Size(105, 37);
            btn_selectEngineIni.TabIndex = 42;
            btn_selectEngineIni.Text = "Browse";
            btn_selectEngineIni.UseVisualStyleBackColor = false;
            btn_selectEngineIni.Click += btn_selectEngineIni_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(55, 55, 55);
            label5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(19, 59);
            label5.Margin = new Padding(3, 0, 3, 2);
            label5.Name = "label5";
            label5.Size = new Size(185, 18);
            label5.TabIndex = 41;
            label5.Text = "Select your UT4 Engine.ini:";
            // 
            // btn_checkEngineIni
            // 
            btn_checkEngineIni.BackColor = Color.FromArgb(42, 42, 42);
            btn_checkEngineIni.FlatAppearance.BorderColor = Color.FromArgb(92, 92, 92);
            btn_checkEngineIni.FlatStyle = FlatStyle.Flat;
            btn_checkEngineIni.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_checkEngineIni.ForeColor = Color.White;
            btn_checkEngineIni.Location = new Point(19, 141);
            btn_checkEngineIni.Name = "btn_checkEngineIni";
            btn_checkEngineIni.Size = new Size(335, 36);
            btn_checkEngineIni.TabIndex = 52;
            btn_checkEngineIni.Text = "Check Engine.ini";
            btn_checkEngineIni.UseVisualStyleBackColor = false;
            btn_checkEngineIni.Click += btn_checkEngineIni_Click;
            // 
            // rtb_engineIni
            // 
            rtb_engineIni.BackColor = Color.FromArgb(42, 42, 42);
            rtb_engineIni.BorderStyle = BorderStyle.None;
            rtb_engineIni.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rtb_engineIni.ForeColor = Color.White;
            rtb_engineIni.Location = new Point(19, 183);
            rtb_engineIni.Name = "rtb_engineIni";
            rtb_engineIni.ReadOnly = true;
            rtb_engineIni.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            rtb_engineIni.Size = new Size(688, 312);
            rtb_engineIni.TabIndex = 53;
            rtb_engineIni.Text = "";
            // 
            // btn_updateEngineIni
            // 
            btn_updateEngineIni.BackColor = Color.FromArgb(42, 42, 42);
            btn_updateEngineIni.FlatAppearance.BorderColor = Color.FromArgb(92, 92, 92);
            btn_updateEngineIni.FlatStyle = FlatStyle.Flat;
            btn_updateEngineIni.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_updateEngineIni.ForeColor = Color.White;
            btn_updateEngineIni.Location = new Point(372, 141);
            btn_updateEngineIni.Name = "btn_updateEngineIni";
            btn_updateEngineIni.Size = new Size(335, 36);
            btn_updateEngineIni.TabIndex = 54;
            btn_updateEngineIni.Text = "Update/Create Engine.ini";
            btn_updateEngineIni.UseVisualStyleBackColor = false;
            btn_updateEngineIni.Click += btn_updateEngineIni_Click;
            // 
            // UC_CheckMasterServer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 55, 55);
            Controls.Add(btn_updateEngineIni);
            Controls.Add(rtb_engineIni);
            Controls.Add(btn_checkEngineIni);
            Controls.Add(tb_engineinipath);
            Controls.Add(btn_selectEngineIni);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "UC_CheckMasterServer";
            Size = new Size(726, 512);
            Load += UC_CheckMasterServer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_engineinipath;
        private Button btn_selectEngineIni;
        private Label label5;
        public Button btn_checkEngineIni;
        private RichTextBox rtb_engineIni;
        public Button btn_updateEngineIni;
    }
}
