﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Using for all of the browser stuff.
using CefSharp;
using CefSharp.WinForms;
using RED7Studios.UI.Forms;

namespace Full_Nitro_Client
{
    public partial class frmMain : ModernForm
    {
        // Create a public ChromiumWebBrowser called 'chromeBrowser'.
        // public ChromiumWebBrowser chromeBrowser;

        // The string for the cache directory.
        string cacheDirBase = "Caches";

        public frmMain()
        {
            // Initialize the form.
            InitializeComponent();
            // Initialize the browser.
            InitializeChromium();

            // Create a new frame load end function for scripts.
            chromeBrowser.FrameLoadEnd += ChromeBrowser_FrameLoadEnd;
        }

        public string BROWSER_URL
        {
            set => chromeBrowser.Load(value);
        }

        private void ChromeBrowser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            // If the Enable Gold Membership file exists.
            if (File.Exists(cacheDirBase + "\\EnableGoldMembership.dat"))
            {
                // If the URL is the garage or racing.
                if (chromeBrowser.Address.Contains("nitrotype.com/garage"))
                {
                    RunScript("Membership", false);
                }
            }

            if (File.Exists(cacheDirBase + "\\GiveAllCars.dat"))
            {
                if (chromeBrowser.Address.Contains("nitrotype.com/garage"))
                {
                    RunScript("AllCars", false);
                }
            }

            if (chromeBrowser.Address.Contains("nitrotype.com/race"))
            {
                // RunScript("Bot");
            }
        }

        public void InitializeChromium()
        {
            // Create a new CefSettings called 'settings'.
            CefSettings settings = new CefSettings();
            // Set up the cache path.
            settings.CachePath = Path.GetFullPath(Application.StartupPath) + @"\Caches";
            // Initialize cef with the provided settings
            Cef.Initialize(settings);

            chromeBrowser.Load("https://venge.io");

            /* Create a browser component
            chromeBrowser = new ChromiumWebBrowser("https://www.nitrotype.com/login")
            {
                // Dock it to fill.
                Dock = DockStyle.Fill
            };

            // Add it to the form and fill it to the form window.
            tlpMain.Controls.Add(chromeBrowser); */
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Removed some stuff.
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Handle a shutdown.
            HandleShutdown();
        }

        private void HandleRestart()
        {
            // Shutdown the CEF process.
            Cef.Shutdown();
            // Restart the application.
            Application.Restart();
        }

        private void HandleShutdown()
        {
            // Shutdown CEF process.
            Cef.Shutdown();
            // Reset all of the caches.
            ResetCaches();
            // Exit the application.
            Application.Exit();
        }

        private void ResetLocalStorage()
        {
            try
            {
                // Delete the local storage.
                Directory.Delete(cacheDirBase + "\\Local Storage", true);
            }
            catch (Exception ex)
            {
                // Write a line to the console with the error.
                Console.WriteLine("FATAL ERROR: " + ex.Message);
            }
        }

        private void ResetCaches()
        {
            try
            {
                // Delete the cache.
                Directory.Delete(cacheDirBase + "\\Cache", true);
                // Delete the code cache.
                Directory.Delete(cacheDirBase + "\\Code Cache", true);
                // Delete the GPU cache.
                Directory.Delete(cacheDirBase + "\\GPUCache", true);
            }
            catch (Exception ex)
            {
                // Write a line to the console with the error.
                Console.WriteLine("FATAL ERROR: " + ex.Message);
            }
        }

        private void ResetStorages()
        {
            // Delete the session storage.
            Directory.Delete(cacheDirBase + "\\Session Storage", true);
            // Delete the blob storage.
            Directory.Delete(cacheDirBase + "\\blob_storage", true);
        }

        private void ResetEverything()
        {
            try
            {
                // Reset local storage.
                ResetLocalStorage();
                // Reset all caches.
                ResetCaches();
                // Reset all storages.
                ResetStorages();
            }
            catch (Exception ex)
            {
                // Write a line to the console with the error.
                Console.WriteLine("FATAL ERROR: " + ex.Message);
            }
        }

        private void dangerResetEverythingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Shutdown the CEF process.
            Cef.Shutdown();
            // Delete the EnableMembership data file.
            File.Delete(cacheDirBase + "\\EnableGoldMembership.dat");
            // Delete the Remove Notice data file.
            File.Delete(cacheDirBase + "\\RemoveNotice.dat");
            // Reset all data and cache.
            ResetEverything();
            // Handle a restart.
            HandleRestart();
        }

        private void giveYourselfMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new AboutForm called 'about'.
            frmAbout about = new frmAbout();
            // Open the 'about' form as a dialog.
            about.ShowDialog();
            // Write a line to the console saying it was opened.
            Console.WriteLine("Opened the about form!");
        }

        private void activateBotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Start the auto typer.
            Process.Start(cacheDirBase + "\\NitroTyper.exe");
        }

        private void openDevToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the chromium dev tools.
            chromeBrowser.ShowDevTools();
        }

        private void RunScript(string name, bool reload)
        {
            // Write a line to the console saying it is executing.
            Console.WriteLine("Executing " + name + ".js Script!");
            // Execute the script.
            chromeBrowser.ExecuteScriptAsync(File.ReadAllText(cacheDirBase + "\\" + name +".js"));
            if (reload == true)
            {
                // Reload the browser.
                chromeBrowser.Reload();
            }
        }

        private void secretModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Set the title bar text to "Browser [BETA]".
            this.Text = "Browser [BETA]";
            // Hide the navbar.
            navbar.Visible = false;
            // Remove the first row in the table layout panel.
            Modules.TableLayoutHelper.RemoveArbitraryRow(tlpMain, 0); // https://stackoverflow.com/questions/15535214/removing-a-specific-row-in-tablelayoutpanel
            // Goto Google to make it look believable.
            BROWSER_URL = "https://google.com";
        }

        private void gotoURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Full_Nitro_Client.Controls.frmGotoURL uc = new Full_Nitro_Client.Controls.frmGotoURL();
            uc.ShowDialog();
        }

        private void tlpMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HacksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunScript("Hacks", true);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromeBrowser.Refresh();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            chromeBrowser.Forward();
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromeBrowser.Back();
        }
    }
}
