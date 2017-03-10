namespace VSExporter
{
    partial class VSExporterDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VSExporterDialog));
            this.label_DirPath = new System.Windows.Forms.Label();
            this.textBox_DirPath = new System.Windows.Forms.TextBox();
            this.button_DirPath = new System.Windows.Forms.Button();
            this.checkBox_ExportShortcuts = new System.Windows.Forms.CheckBox();
            this.checkBox_ExportSettings = new System.Windows.Forms.CheckBox();
            this.checkBox_ExportExtensions = new System.Windows.Forms.CheckBox();
            this.groupBox_Shortcuts = new System.Windows.Forms.GroupBox();
            this.textBox_ShortcutsFileName = new System.Windows.Forms.TextBox();
            this.label_ShortcutsFileName = new System.Windows.Forms.Label();
            this.checkBox_ShortcutsNonDefaults = new System.Windows.Forms.CheckBox();
            this.groupBox_Settings = new System.Windows.Forms.GroupBox();
            this.textBox_SettingsFileName = new System.Windows.Forms.TextBox();
            this.checkBox_SettingsNonDefaults = new System.Windows.Forms.CheckBox();
            this.label_SettingsFileName = new System.Windows.Forms.Label();
            this.groupBox_Extensions = new System.Windows.Forms.GroupBox();
            this.textBox_ExtensionsFileName = new System.Windows.Forms.TextBox();
            this.label_ExtensionsFileName = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.groupBox_Shortcuts.SuspendLayout();
            this.groupBox_Settings.SuspendLayout();
            this.groupBox_Extensions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_DirPath
            // 
            this.label_DirPath.AutoSize = true;
            this.label_DirPath.Location = new System.Drawing.Point(18, 18);
            this.label_DirPath.Name = "label_DirPath";
            this.label_DirPath.Size = new System.Drawing.Size(116, 17);
            this.label_DirPath.TabIndex = 0;
            this.label_DirPath.Text = "Output Directory:";
            // 
            // textBox_DirPath
            // 
            this.textBox_DirPath.Location = new System.Drawing.Point(140, 15);
            this.textBox_DirPath.Name = "textBox_DirPath";
            this.textBox_DirPath.Size = new System.Drawing.Size(483, 22);
            this.textBox_DirPath.TabIndex = 1;
            this.textBox_DirPath.Text = "C:/";
            // 
            // button_DirPath
            // 
            this.button_DirPath.Location = new System.Drawing.Point(629, 15);
            this.button_DirPath.Name = "button_DirPath";
            this.button_DirPath.Size = new System.Drawing.Size(33, 23);
            this.button_DirPath.TabIndex = 2;
            this.button_DirPath.Text = "...";
            this.button_DirPath.UseVisualStyleBackColor = true;
            this.button_DirPath.Click += new System.EventHandler(this.Button_DirPath_Click);
            // 
            // checkBox_ExportShortcuts
            // 
            this.checkBox_ExportShortcuts.AutoSize = true;
            this.checkBox_ExportShortcuts.Checked = true;
            this.checkBox_ExportShortcuts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ExportShortcuts.Location = new System.Drawing.Point(11, 26);
            this.checkBox_ExportShortcuts.Name = "checkBox_ExportShortcuts";
            this.checkBox_ExportShortcuts.Size = new System.Drawing.Size(134, 21);
            this.checkBox_ExportShortcuts.TabIndex = 3;
            this.checkBox_ExportShortcuts.Text = "Export Shortcuts";
            this.checkBox_ExportShortcuts.UseVisualStyleBackColor = true;
            // 
            // checkBox_ExportSettings
            // 
            this.checkBox_ExportSettings.AutoSize = true;
            this.checkBox_ExportSettings.Checked = true;
            this.checkBox_ExportSettings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ExportSettings.Location = new System.Drawing.Point(11, 26);
            this.checkBox_ExportSettings.Name = "checkBox_ExportSettings";
            this.checkBox_ExportSettings.Size = new System.Drawing.Size(125, 21);
            this.checkBox_ExportSettings.TabIndex = 4;
            this.checkBox_ExportSettings.Text = "Export Settings";
            this.checkBox_ExportSettings.UseVisualStyleBackColor = true;
            // 
            // checkBox_ExportExtensions
            // 
            this.checkBox_ExportExtensions.AutoSize = true;
            this.checkBox_ExportExtensions.Checked = true;
            this.checkBox_ExportExtensions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ExportExtensions.Location = new System.Drawing.Point(11, 26);
            this.checkBox_ExportExtensions.Name = "checkBox_ExportExtensions";
            this.checkBox_ExportExtensions.Size = new System.Drawing.Size(142, 21);
            this.checkBox_ExportExtensions.TabIndex = 5;
            this.checkBox_ExportExtensions.Text = "Export Extensions";
            this.checkBox_ExportExtensions.UseVisualStyleBackColor = true;
            // 
            // groupBox_Shortcuts
            // 
            this.groupBox_Shortcuts.Controls.Add(this.textBox_ShortcutsFileName);
            this.groupBox_Shortcuts.Controls.Add(this.label_ShortcutsFileName);
            this.groupBox_Shortcuts.Controls.Add(this.checkBox_ShortcutsNonDefaults);
            this.groupBox_Shortcuts.Controls.Add(this.checkBox_ExportShortcuts);
            this.groupBox_Shortcuts.Location = new System.Drawing.Point(16, 50);
            this.groupBox_Shortcuts.Name = "groupBox_Shortcuts";
            this.groupBox_Shortcuts.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox_Shortcuts.Size = new System.Drawing.Size(340, 110);
            this.groupBox_Shortcuts.TabIndex = 6;
            this.groupBox_Shortcuts.TabStop = false;
            this.groupBox_Shortcuts.Text = "Shortcuts";
            // 
            // textBox_ShortcutsFileName
            // 
            this.textBox_ShortcutsFileName.Location = new System.Drawing.Point(89, 74);
            this.textBox_ShortcutsFileName.Name = "textBox_ShortcutsFileName";
            this.textBox_ShortcutsFileName.Size = new System.Drawing.Size(241, 22);
            this.textBox_ShortcutsFileName.TabIndex = 6;
            this.textBox_ShortcutsFileName.Text = "Shortcuts.xml";
            // 
            // label_ShortcutsFileName
            // 
            this.label_ShortcutsFileName.AutoSize = true;
            this.label_ShortcutsFileName.Location = new System.Drawing.Point(8, 77);
            this.label_ShortcutsFileName.Name = "label_ShortcutsFileName";
            this.label_ShortcutsFileName.Size = new System.Drawing.Size(75, 17);
            this.label_ShortcutsFileName.TabIndex = 5;
            this.label_ShortcutsFileName.Text = "File Name:";
            // 
            // checkBox_ShortcutsNonDefaults
            // 
            this.checkBox_ShortcutsNonDefaults.AutoSize = true;
            this.checkBox_ShortcutsNonDefaults.Enabled = false;
            this.checkBox_ShortcutsNonDefaults.Location = new System.Drawing.Point(11, 53);
            this.checkBox_ShortcutsNonDefaults.Name = "checkBox_ShortcutsNonDefaults";
            this.checkBox_ShortcutsNonDefaults.Size = new System.Drawing.Size(142, 21);
            this.checkBox_ShortcutsNonDefaults.TabIndex = 4;
            this.checkBox_ShortcutsNonDefaults.Text = "Only non-defaults";
            this.checkBox_ShortcutsNonDefaults.UseVisualStyleBackColor = true;
            // 
            // groupBox_Settings
            // 
            this.groupBox_Settings.Controls.Add(this.textBox_SettingsFileName);
            this.groupBox_Settings.Controls.Add(this.checkBox_SettingsNonDefaults);
            this.groupBox_Settings.Controls.Add(this.label_SettingsFileName);
            this.groupBox_Settings.Controls.Add(this.checkBox_ExportSettings);
            this.groupBox_Settings.Location = new System.Drawing.Point(16, 166);
            this.groupBox_Settings.Name = "groupBox_Settings";
            this.groupBox_Settings.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox_Settings.Size = new System.Drawing.Size(340, 110);
            this.groupBox_Settings.TabIndex = 7;
            this.groupBox_Settings.TabStop = false;
            this.groupBox_Settings.Text = "Settings";
            // 
            // textBox_SettingsFileName
            // 
            this.textBox_SettingsFileName.Location = new System.Drawing.Point(89, 74);
            this.textBox_SettingsFileName.Name = "textBox_SettingsFileName";
            this.textBox_SettingsFileName.Size = new System.Drawing.Size(241, 22);
            this.textBox_SettingsFileName.TabIndex = 8;
            this.textBox_SettingsFileName.Text = "Settings.xml";
            // 
            // checkBox_SettingsNonDefaults
            // 
            this.checkBox_SettingsNonDefaults.AutoSize = true;
            this.checkBox_SettingsNonDefaults.Enabled = false;
            this.checkBox_SettingsNonDefaults.Location = new System.Drawing.Point(11, 53);
            this.checkBox_SettingsNonDefaults.Name = "checkBox_SettingsNonDefaults";
            this.checkBox_SettingsNonDefaults.Size = new System.Drawing.Size(142, 21);
            this.checkBox_SettingsNonDefaults.TabIndex = 5;
            this.checkBox_SettingsNonDefaults.Text = "Only non-defaults";
            this.checkBox_SettingsNonDefaults.UseVisualStyleBackColor = true;
            // 
            // label_SettingsFileName
            // 
            this.label_SettingsFileName.AutoSize = true;
            this.label_SettingsFileName.Location = new System.Drawing.Point(8, 77);
            this.label_SettingsFileName.Name = "label_SettingsFileName";
            this.label_SettingsFileName.Size = new System.Drawing.Size(75, 17);
            this.label_SettingsFileName.TabIndex = 7;
            this.label_SettingsFileName.Text = "File Name:";
            // 
            // groupBox_Extensions
            // 
            this.groupBox_Extensions.Controls.Add(this.textBox_ExtensionsFileName);
            this.groupBox_Extensions.Controls.Add(this.checkBox_ExportExtensions);
            this.groupBox_Extensions.Controls.Add(this.label_ExtensionsFileName);
            this.groupBox_Extensions.Location = new System.Drawing.Point(16, 282);
            this.groupBox_Extensions.Name = "groupBox_Extensions";
            this.groupBox_Extensions.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox_Extensions.Size = new System.Drawing.Size(340, 80);
            this.groupBox_Extensions.TabIndex = 8;
            this.groupBox_Extensions.TabStop = false;
            this.groupBox_Extensions.Text = "Extensions";
            // 
            // textBox_ExtensionsFileName
            // 
            this.textBox_ExtensionsFileName.Location = new System.Drawing.Point(89, 47);
            this.textBox_ExtensionsFileName.Name = "textBox_ExtensionsFileName";
            this.textBox_ExtensionsFileName.Size = new System.Drawing.Size(241, 22);
            this.textBox_ExtensionsFileName.TabIndex = 10;
            this.textBox_ExtensionsFileName.Text = "Extensions.xml";
            // 
            // label_ExtensionsFileName
            // 
            this.label_ExtensionsFileName.AutoSize = true;
            this.label_ExtensionsFileName.Location = new System.Drawing.Point(8, 50);
            this.label_ExtensionsFileName.Name = "label_ExtensionsFileName";
            this.label_ExtensionsFileName.Size = new System.Drawing.Size(75, 17);
            this.label_ExtensionsFileName.TabIndex = 9;
            this.label_ExtensionsFileName.Text = "File Name:";
            // 
            // button_OK
            // 
            this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_OK.Location = new System.Drawing.Point(368, 282);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(140, 80);
            this.button_OK.TabIndex = 9;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(514, 282);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(140, 80);
            this.button_Cancel.TabIndex = 10;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // VSExporterDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(670, 380);
            this.ControlBox = false;
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.groupBox_Extensions);
            this.Controls.Add(this.groupBox_Settings);
            this.Controls.Add(this.groupBox_Shortcuts);
            this.Controls.Add(this.button_DirPath);
            this.Controls.Add(this.textBox_DirPath);
            this.Controls.Add(this.label_DirPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VSExporterDialog";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VS Exporter Dialog";
            this.groupBox_Shortcuts.ResumeLayout(false);
            this.groupBox_Shortcuts.PerformLayout();
            this.groupBox_Settings.ResumeLayout(false);
            this.groupBox_Settings.PerformLayout();
            this.groupBox_Extensions.ResumeLayout(false);
            this.groupBox_Extensions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_DirPath;
        private System.Windows.Forms.TextBox textBox_DirPath;
        private System.Windows.Forms.Button button_DirPath;
        private System.Windows.Forms.CheckBox checkBox_ExportShortcuts;
        private System.Windows.Forms.CheckBox checkBox_ExportSettings;
        private System.Windows.Forms.CheckBox checkBox_ExportExtensions;
        private System.Windows.Forms.GroupBox groupBox_Shortcuts;
        private System.Windows.Forms.TextBox textBox_ShortcutsFileName;
        private System.Windows.Forms.Label label_ShortcutsFileName;
        private System.Windows.Forms.CheckBox checkBox_ShortcutsNonDefaults;
        private System.Windows.Forms.GroupBox groupBox_Settings;
        private System.Windows.Forms.TextBox textBox_SettingsFileName;
        private System.Windows.Forms.CheckBox checkBox_SettingsNonDefaults;
        private System.Windows.Forms.Label label_SettingsFileName;
        private System.Windows.Forms.GroupBox groupBox_Extensions;
        private System.Windows.Forms.TextBox textBox_ExtensionsFileName;
        private System.Windows.Forms.Label label_ExtensionsFileName;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
    }
}