using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoL_Masteries_Lookup
{
    public partial class Form1 : Form
    {
        public bool ShouldLoadProgressBar = true;
        public ServerType server;

        public bool ShowNotifications;

        public Form1()
        {
            if (Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1)
                Process.GetCurrentProcess().Kill();

            InitializeComponent();

            AcceptButton = btnGo;

            browser.NavigationStarting += OnContentLoading;
            browser.NavigationCompleted += OnContentLoaded;

            LoadSettings();
            Thread t = new Thread(() => CheckServerResponseTime());
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            searchChampion();
        }

        private void searchChampion()
        {
            txtboxChampName.Text = FormatString(txtboxChampName.Text);

            string championName = txtboxChampName.Text.ToLowerInvariant();
            championName = championName.Replace(" ", "");
            championName = championName.Trim();
            if (championName == string.Empty)
                return;
            try
            {
                switch (server)
                {
                    case ServerType.Mobayltics:
                        browser.Navigate(@"https://app.mobalytics.gg/champions/" + championName + @"/build");
                        break;
                    case ServerType.Opgg:
                        browser.Navigate(@"http://www.op.gg/champion/" + championName + @"/statistics/");
                        break;
                    case ServerType.Championgg:
                        browser.Navigate(@"https://champion.gg/champion/" + championName + @"/");
                        break;
                    default:
                        browser.Navigate(@"https://app.mobalytics.gg/champions/" + championName + @"/build");
                        break;
                }
            } catch (Exception) { }
        }

        private void OnContentLoading(object sender, EventArgs e)
        {
            loadingBar.Style = ProgressBarStyle.Marquee;
            loadingBar.MarqueeAnimationSpeed = 20;
        }

        private void OnContentLoaded(object sender, EventArgs e)
        {
            loadingBar.Style = ProgressBarStyle.Blocks;
        }
        
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                if (ShowNotifications)
                    systemTray.ShowBalloonTip(1000, "League of Legends - Mastery Lookup", "Program has been minimized to the system tray.", ToolTipIcon.Info);
            }
            else if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                ShowInTaskbar = true;
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
            OnResize(null);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MobaylticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (server == ServerType.Mobayltics)
            {
                mobaylticsToolStripMenuItem.Checked = true;
                return;
            }

            opggToolStripMenuItem.Checked = false;
            championggToolStripMenuItem.Checked = false;

            ChangeServer(ServerType.Mobayltics);

            if (txtboxChampName.Text != string.Empty)
                searchChampion();
        }

        private void OpggToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (server == ServerType.Opgg)
            {
                opggToolStripMenuItem.Checked = true;
                return;
            }

            mobaylticsToolStripMenuItem.Checked = false;
            championggToolStripMenuItem.Checked = false;

            ChangeServer(ServerType.Opgg);

            if (txtboxChampName.Text != string.Empty)
                searchChampion();
        }

        private void ChampionggToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (server == ServerType.Championgg)
            {
                championggToolStripMenuItem.Checked = true;
                return;
            }

            mobaylticsToolStripMenuItem.Checked = false;
            opggToolStripMenuItem.Checked = false;

            ChangeServer(ServerType.Championgg);

            if (txtboxChampName.Text != string.Empty)
                searchChampion();
        }

        private void ShowNotificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNotifications = !ShowNotifications;
            Properties.Settings.Default.Notifications = ShowNotifications;
            Properties.Settings.Default.Save();
        }

        private void ChangeServer(ServerType serverType)
        {
            server = serverType;
            Properties.Settings.Default.Server = (ushort)serverType;
            Properties.Settings.Default.Save();
        }

        private void LoadSettings()
        {
            server = (ServerType)Properties.Settings.Default.Server;
            ShowNotifications = Properties.Settings.Default.Notifications;
            TopMost = Properties.Settings.Default.AlwaysOnTop;

            switch (server)
            {
                case ServerType.Mobayltics:
                    mobaylticsToolStripMenuItem.Checked = true;
                    break;
                case ServerType.Opgg:
                    opggToolStripMenuItem.Checked = true;
                    break;
                case ServerType.Championgg:
                    championggToolStripMenuItem.Checked = true;
                    break;
            }

            showNotificationsToolStripMenuItem.Checked = Properties.Settings.Default.Notifications;
            alwaysOnTopToolStripMenuItem.Checked = Properties.Settings.Default.AlwaysOnTop;
        }

        private void CheckServerResponseTime()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://app.mobalytics.gg/");
            Stopwatch timer = new Stopwatch();
            timer.Start();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            response.Close();
            timer.Stop();
            TimeSpan timeTakenMobalytics = timer.Elapsed;

            request = (HttpWebRequest)WebRequest.Create("https://app.mobalytics.gg/");
            timer.Reset();
            timer.Start();
            response = (HttpWebResponse)request.GetResponse();
            response.Close();
            timer.Stop();
            TimeSpan timeTakenOpgg = timer.Elapsed;

            request = (HttpWebRequest)WebRequest.Create("https://app.mobalytics.gg/");
            timer.Reset();
            timer.Start();
            response = (HttpWebResponse)request.GetResponse();
            response.Close();
            timer.Stop();
            TimeSpan timeTakenChampiongg = timer.Elapsed;

            mobaylticsToolStripMenuItem.Text = "Mobyltics - " + timeTakenMobalytics.TotalMilliseconds + " secs.";
            opggToolStripMenuItem.Text = "Op.gg - " + timeTakenOpgg.TotalMilliseconds + " secs.";
            championggToolStripMenuItem.Text = "Champion.gg - " + timeTakenChampiongg.TotalMilliseconds + " secs.";
        }

        private string FormatString(string str)
        {
            if (str.Length < 1) return string.Empty;

            return (str.Substring(0, 1).ToUpperInvariant() + str.Substring(1, str.Length - 1));
        }

        public enum ServerType
        {
            Mobayltics = 0,
            Opgg = 1,
            Championgg = 2
        }

        private void AlwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
            Properties.Settings.Default.AlwaysOnTop = TopMost;
            Properties.Settings.Default.Save();
        }
    }
}
