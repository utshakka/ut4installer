namespace UT4_Installer.UserControls
{
    partial class UC_CreateShortcut
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
            tb_ut4basedir = new TextBox();
            btn_selectUT4Dir = new Button();
            label5 = new Label();
            tb_shortcutDestDir = new TextBox();
            btn_chooseShortcutDest = new Button();
            label4 = new Label();
            tb_shortcutName = new TextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            btn_createshortcut = new Button();
            label3 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(248, 16);
            label1.Name = "label1";
            label1.Size = new Size(231, 29);
            label1.TabIndex = 2;
            label1.Text = "Create UT4 Shortcut";
            // 
            // tb_ut4basedir
            // 
            tb_ut4basedir.BackColor = Color.FromArgb(42, 42, 42);
            tb_ut4basedir.BorderStyle = BorderStyle.FixedSingle;
            tb_ut4basedir.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_ut4basedir.ForeColor = SystemColors.ActiveBorder;
            tb_ut4basedir.Location = new Point(19, 82);
            tb_ut4basedir.Multiline = true;
            tb_ut4basedir.Name = "tb_ut4basedir";
            tb_ut4basedir.ReadOnly = true;
            tb_ut4basedir.Size = new Size(572, 37);
            tb_ut4basedir.TabIndex = 40;
            // 
            // btn_selectUT4Dir
            // 
            btn_selectUT4Dir.BackColor = Color.FromArgb(50, 50, 50);
            btn_selectUT4Dir.FlatAppearance.BorderColor = Color.FromArgb(92, 92, 92);
            btn_selectUT4Dir.FlatStyle = FlatStyle.Flat;
            btn_selectUT4Dir.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_selectUT4Dir.ForeColor = Color.White;
            btn_selectUT4Dir.Location = new Point(602, 82);
            btn_selectUT4Dir.Name = "btn_selectUT4Dir";
            btn_selectUT4Dir.Size = new Size(105, 37);
            btn_selectUT4Dir.TabIndex = 39;
            btn_selectUT4Dir.Text = "Browse";
            btn_selectUT4Dir.UseVisualStyleBackColor = false;
            btn_selectUT4Dir.Click += btn_selectUT4Dir_Click;
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
            label5.Size = new Size(215, 18);
            label5.TabIndex = 38;
            label5.Text = "Select your UT4 base directory:";
            // 
            // tb_shortcutDestDir
            // 
            tb_shortcutDestDir.BackColor = Color.FromArgb(42, 42, 42);
            tb_shortcutDestDir.BorderStyle = BorderStyle.FixedSingle;
            tb_shortcutDestDir.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_shortcutDestDir.ForeColor = SystemColors.ActiveBorder;
            tb_shortcutDestDir.Location = new Point(19, 155);
            tb_shortcutDestDir.Multiline = true;
            tb_shortcutDestDir.Name = "tb_shortcutDestDir";
            tb_shortcutDestDir.ReadOnly = true;
            tb_shortcutDestDir.Size = new Size(572, 37);
            tb_shortcutDestDir.TabIndex = 46;
            // 
            // btn_chooseShortcutDest
            // 
            btn_chooseShortcutDest.BackColor = Color.FromArgb(50, 50, 50);
            btn_chooseShortcutDest.FlatAppearance.BorderColor = Color.FromArgb(92, 92, 92);
            btn_chooseShortcutDest.FlatStyle = FlatStyle.Flat;
            btn_chooseShortcutDest.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_chooseShortcutDest.ForeColor = Color.White;
            btn_chooseShortcutDest.Location = new Point(602, 155);
            btn_chooseShortcutDest.Name = "btn_chooseShortcutDest";
            btn_chooseShortcutDest.Size = new Size(105, 37);
            btn_chooseShortcutDest.TabIndex = 45;
            btn_chooseShortcutDest.Text = "Browse";
            btn_chooseShortcutDest.UseVisualStyleBackColor = false;
            btn_chooseShortcutDest.Click += btn_chooseShortcutDest_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(55, 55, 55);
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(19, 132);
            label4.Margin = new Padding(3, 0, 3, 2);
            label4.Name = "label4";
            label4.Size = new Size(259, 18);
            label4.TabIndex = 44;
            label4.Text = "Choose shortcut destination directory:";
            // 
            // tb_shortcutName
            // 
            tb_shortcutName.BackColor = Color.FromArgb(42, 42, 42);
            tb_shortcutName.BorderStyle = BorderStyle.FixedSingle;
            tb_shortcutName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_shortcutName.ForeColor = SystemColors.ActiveBorder;
            tb_shortcutName.Location = new Point(19, 228);
            tb_shortcutName.Name = "tb_shortcutName";
            tb_shortcutName.Size = new Size(311, 23);
            tb_shortcutName.TabIndex = 49;
            tb_shortcutName.Text = "Unreal Tournament 4";
            tb_shortcutName.TextChanged += tb_shortcutName_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(55, 55, 55);
            label6.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(19, 205);
            label6.Margin = new Padding(3, 0, 3, 2);
            label6.Name = "label6";
            label6.Size = new Size(198, 18);
            label6.TabIndex = 47;
            label6.Text = "Enter desired shortcut name:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(42, 42, 42);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ActiveBorder;
            textBox1.Location = new Point(164, 390);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(493, 22);
            textBox1.TabIndex = 50;
            textBox1.Text = "UnrealTournament -epicapp=UnrealTournamentDev -epicenv=Prod -EpicPortal";
            // 
            // btn_createshortcut
            // 
            btn_createshortcut.BackColor = Color.FromArgb(42, 42, 42);
            btn_createshortcut.FlatAppearance.BorderColor = Color.FromArgb(92, 92, 92);
            btn_createshortcut.FlatStyle = FlatStyle.Flat;
            btn_createshortcut.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_createshortcut.ForeColor = Color.White;
            btn_createshortcut.Location = new Point(414, 213);
            btn_createshortcut.Name = "btn_createshortcut";
            btn_createshortcut.Size = new Size(293, 36);
            btn_createshortcut.TabIndex = 51;
            btn_createshortcut.Text = "Create UT4 Shortcut";
            btn_createshortcut.UseVisualStyleBackColor = false;
            btn_createshortcut.Click += btn_createshortcut_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(55, 55, 55);
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(336, 231);
            label3.Margin = new Padding(3, 0, 3, 2);
            label3.Name = "label3";
            label3.Size = new Size(31, 18);
            label3.TabIndex = 53;
            label3.Text = ".lnk";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(55, 55, 55);
            label7.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(19, 337);
            label7.Margin = new Padding(3, 0, 3, 2);
            label7.Name = "label7";
            label7.Size = new Size(139, 18);
            label7.TabIndex = 54;
            label7.Text = "Create a shortcut to";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(42, 42, 42);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.ActiveBorder;
            textBox2.Location = new Point(164, 337);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(440, 22);
            textBox2.TabIndex = 55;
            textBox2.Text = "\\UnrealTournament\\Engine\\Binaries\\Win64\\UE4-Win64-Shipping.exe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(55, 55, 55);
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(19, 304);
            label2.Margin = new Padding(3, 0, 3, 2);
            label2.Name = "label2";
            label2.Size = new Size(117, 18);
            label2.TabIndex = 56;
            label2.Text = "Manual creation:";
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(55, 55, 55);
            label8.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(19, 373);
            label8.Margin = new Padding(3, 0, 3, 2);
            label8.Name = "label8";
            label8.Size = new Size(139, 65);
            label8.TabIndex = 57;
            label8.Text = "Add the following at the end of the shortcut target line";
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(55, 55, 55);
            label9.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(19, 448);
            label9.Margin = new Padding(3, 0, 3, 2);
            label9.Name = "label9";
            label9.Size = new Size(139, 39);
            label9.TabIndex = 58;
            label9.Text = "Full target line example";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(42, 42, 42);
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = SystemColors.ActiveBorder;
            textBox3.Location = new Point(164, 444);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(543, 47);
            textBox3.TabIndex = 59;
            textBox3.Text = "\"C:\\Program Files\\UnrealTournament\\Engine\\Binaries\\Win64\\UE4-Win64-Shipping.exe\" UnrealTournament -epicapp=UnrealTournamentDev -epicenv=Prod -EpicPortal";
            // 
            // UC_CreateShortcut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 55, 55);
            Controls.Add(textBox3);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(btn_createshortcut);
            Controls.Add(tb_shortcutName);
            Controls.Add(label6);
            Controls.Add(tb_shortcutDestDir);
            Controls.Add(btn_chooseShortcutDest);
            Controls.Add(label4);
            Controls.Add(tb_ut4basedir);
            Controls.Add(btn_selectUT4Dir);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "UC_CreateShortcut";
            Size = new Size(726, 512);
            Load += UC_CreateShortcut_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_ut4basedir;
        private Button btn_selectUT4Dir;
        private Label label5;
        private TextBox tb_shortcutDestDir;
        private Button btn_chooseShortcutDest;
        private Label label4;
        private TextBox tb_shortcutName;
        private Label label6;
        private TextBox textBox1;
        public Button btn_createshortcut;
        private Label label3;
        private Label label7;
        private TextBox textBox2;
        private Label label2;
        private Label label8;
        private Label label9;
        private TextBox textBox3;
    }
}
