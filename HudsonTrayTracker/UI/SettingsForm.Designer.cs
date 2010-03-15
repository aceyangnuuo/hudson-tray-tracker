namespace Hudson.TrayTracker.UI
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.tabControl = new DevExpress.XtraTab.XtraTabControl();
            this.serversTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.serversSettingsControl = new Hudson.TrayTracker.UI.Controls.ServersSettingsControl();
            this.notificationsTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.notificationsSettingsControl = new Hudson.TrayTracker.UI.Controls.NotificationsSettingsControl();
            this.generalTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.refreshLabel = new DevExpress.XtraEditors.LabelControl();
            this.refreshSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.serversTabPage.SuspendLayout();
            this.notificationsTabPage.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabPage = this.serversTabPage;
            this.tabControl.Size = new System.Drawing.Size(746, 411);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.serversTabPage,
            this.notificationsTabPage,
            this.generalTabPage});
            // 
            // serversTabPage
            // 
            this.serversTabPage.Controls.Add(this.serversSettingsControl);
            this.serversTabPage.Name = "serversTabPage";
            this.serversTabPage.Size = new System.Drawing.Size(715, 402);
            this.serversTabPage.Text = "Servers and projects";
            // 
            // serversSettingsControl
            // 
            this.serversSettingsControl.AutoSize = true;
            this.serversSettingsControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.serversSettingsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serversSettingsControl.Location = new System.Drawing.Point(0, 0);
            this.serversSettingsControl.LookAndFeel.UseDefaultLookAndFeel = false;
            this.serversSettingsControl.LookAndFeel.UseWindowsXPTheme = true;
            this.serversSettingsControl.Name = "serversSettingsControl";
            this.serversSettingsControl.Size = new System.Drawing.Size(715, 402);
            this.serversSettingsControl.TabIndex = 0;
            // 
            // notificationsTabPage
            // 
            this.notificationsTabPage.Controls.Add(this.notificationsSettingsControl);
            this.notificationsTabPage.Name = "notificationsTabPage";
            this.notificationsTabPage.Size = new System.Drawing.Size(715, 402);
            this.notificationsTabPage.Text = "Sound notifications";
            // 
            // notificationsSettingsControl
            // 
            this.notificationsSettingsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationsSettingsControl.Location = new System.Drawing.Point(0, 0);
            this.notificationsSettingsControl.Name = "notificationsSettingsControl";
            this.notificationsSettingsControl.Size = new System.Drawing.Size(715, 402);
            this.notificationsSettingsControl.TabIndex = 0;
            // 
            // generalTabPage
            // 
            this.generalTabPage.Controls.Add(this.groupControl1);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Size = new System.Drawing.Size(715, 402);
            this.generalTabPage.Text = "General";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.tableLayoutPanel2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(715, 402);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "General options";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(711, 380);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.refreshLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.refreshSpinEdit, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(705, 26);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // refreshLabel
            // 
            this.refreshLabel.Location = new System.Drawing.Point(3, 6);
            this.refreshLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.refreshLabel.Name = "refreshLabel";
            this.refreshLabel.Size = new System.Drawing.Size(97, 13);
            this.refreshLabel.TabIndex = 4;
            this.refreshLabel.Text = "Refresh interval (s):";
            // 
            // refreshSpinEdit
            // 
            this.refreshSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.refreshSpinEdit.Location = new System.Drawing.Point(106, 3);
            this.refreshSpinEdit.Name = "refreshSpinEdit";
            this.refreshSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.refreshSpinEdit.Properties.Mask.EditMask = "N0";
            this.refreshSpinEdit.Properties.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.refreshSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.refreshSpinEdit.TabIndex = 1;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 411);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Hudson Tray Tracker - Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.serversTabPage.ResumeLayout(false);
            this.serversTabPage.PerformLayout();
            this.notificationsTabPage.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabControl;
        private DevExpress.XtraTab.XtraTabPage serversTabPage;
        private DevExpress.XtraTab.XtraTabPage notificationsTabPage;
        private Hudson.TrayTracker.UI.Controls.ServersSettingsControl serversSettingsControl;
        private Hudson.TrayTracker.UI.Controls.NotificationsSettingsControl notificationsSettingsControl;
        private DevExpress.XtraTab.XtraTabPage generalTabPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SpinEdit refreshSpinEdit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl refreshLabel;
        private DevExpress.XtraEditors.GroupControl groupControl1;

    }
}