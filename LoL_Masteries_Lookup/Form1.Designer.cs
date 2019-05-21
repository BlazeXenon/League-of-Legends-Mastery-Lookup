namespace LoL_Masteries_Lookup
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtboxChampName = new System.Windows.Forms.TextBox();
            this.lblChampionName = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.browser = new Microsoft.Toolkit.Forms.UI.Controls.WebView();
            this.loadingBar = new System.Windows.Forms.ProgressBar();
            this.systemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.systemTrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mobaylticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opggToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.championggToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showNotificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.browser)).BeginInit();
            this.systemTrayMenu.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtboxChampName
            // 
            this.txtboxChampName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxChampName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxChampName.Location = new System.Drawing.Point(15, 61);
            this.txtboxChampName.Name = "txtboxChampName";
            this.txtboxChampName.Size = new System.Drawing.Size(1187, 44);
            this.txtboxChampName.TabIndex = 0;
            this.txtboxChampName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblChampionName
            // 
            this.lblChampionName.AutoSize = true;
            this.lblChampionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChampionName.Location = new System.Drawing.Point(10, 27);
            this.lblChampionName.Name = "lblChampionName";
            this.lblChampionName.Size = new System.Drawing.Size(177, 25);
            this.lblChampionName.TabIndex = 2;
            this.lblChampionName.Text = "Champion Name:";
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(1208, 61);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(100, 44);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // browser
            // 
            this.browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browser.Location = new System.Drawing.Point(15, 111);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(1293, 606);
            this.browser.TabIndex = 5;
            // 
            // loadingBar
            // 
            this.loadingBar.Location = new System.Drawing.Point(1208, 33);
            this.loadingBar.MarqueeAnimationSpeed = 0;
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.Size = new System.Drawing.Size(100, 25);
            this.loadingBar.TabIndex = 6;
            // 
            // systemTray
            // 
            this.systemTray.ContextMenuStrip = this.systemTrayMenu;
            this.systemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("systemTray.Icon")));
            this.systemTray.Text = "League of Legends - Mastery Lookup";
            this.systemTray.Visible = true;
            // 
            // systemTrayMenu
            // 
            this.systemTrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.systemTrayMenu.Name = "systemTrayMenu";
            this.systemTrayMenu.Size = new System.Drawing.Size(104, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1320, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem,
            this.showNotificationsToolStripMenuItem,
            this.alwaysOnTopToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mobaylticsToolStripMenuItem,
            this.opggToolStripMenuItem,
            this.championggToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // mobaylticsToolStripMenuItem
            // 
            this.mobaylticsToolStripMenuItem.CheckOnClick = true;
            this.mobaylticsToolStripMenuItem.Name = "mobaylticsToolStripMenuItem";
            this.mobaylticsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.mobaylticsToolStripMenuItem.Text = "Mobalytics";
            this.mobaylticsToolStripMenuItem.Click += new System.EventHandler(this.MobaylticsToolStripMenuItem_Click);
            // 
            // opggToolStripMenuItem
            // 
            this.opggToolStripMenuItem.CheckOnClick = true;
            this.opggToolStripMenuItem.Name = "opggToolStripMenuItem";
            this.opggToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.opggToolStripMenuItem.Text = "Op.gg";
            this.opggToolStripMenuItem.Click += new System.EventHandler(this.OpggToolStripMenuItem_Click);
            // 
            // championggToolStripMenuItem
            // 
            this.championggToolStripMenuItem.CheckOnClick = true;
            this.championggToolStripMenuItem.Name = "championggToolStripMenuItem";
            this.championggToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.championggToolStripMenuItem.Text = "Champion.gg";
            this.championggToolStripMenuItem.Click += new System.EventHandler(this.ChampionggToolStripMenuItem_Click);
            // 
            // showNotificationsToolStripMenuItem
            // 
            this.showNotificationsToolStripMenuItem.CheckOnClick = true;
            this.showNotificationsToolStripMenuItem.Name = "showNotificationsToolStripMenuItem";
            this.showNotificationsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showNotificationsToolStripMenuItem.Text = "Show Notifications";
            this.showNotificationsToolStripMenuItem.Click += new System.EventHandler(this.ShowNotificationsToolStripMenuItem_Click);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.CheckOnClick = true;
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "Always On Top";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.AlwaysOnTopToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 729);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.loadingBar);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblChampionName);
            this.Controls.Add(this.txtboxChampName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "League of Legends - Mastery Lookup";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.browser)).EndInit();
            this.systemTrayMenu.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxChampName;
        private System.Windows.Forms.Label lblChampionName;
        private System.Windows.Forms.Button btnGo;
        private Microsoft.Toolkit.Forms.UI.Controls.WebView browser;
        private System.Windows.Forms.ProgressBar loadingBar;
        private System.Windows.Forms.NotifyIcon systemTray;
        private System.Windows.Forms.ContextMenuStrip systemTrayMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mobaylticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opggToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem championggToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showNotificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
    }
}

