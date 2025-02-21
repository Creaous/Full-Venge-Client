﻿
using System;

namespace Full_Nitro_Client
{
    partial class frmMain
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.navbar = new System.Windows.Forms.MenuStrip();
            this.visualTweaksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.HacksStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gotoURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.secretModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.additionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dANGERResetEverythingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDevToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chromeBrowser = new CefSharp.WinForms.ChromiumWebBrowser();
            this.tlpMain.SuspendLayout();
            this.navbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.Controls.Add(this.navbar, 0, 0);
            this.tlpMain.Controls.Add(this.chromeBrowser, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(1, 33);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(1140, 504);
            this.tlpMain.TabIndex = 2;
            this.tlpMain.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpMain_Paint);
            // 
            // navbar
            // 
            this.navbar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.navbar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.navbar.Dock = System.Windows.Forms.DockStyle.None;
            this.navbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualTweaksToolStripMenuItem1,
            this.additionalToolStripMenuItem});
            this.navbar.Location = new System.Drawing.Point(457, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(226, 24);
            this.navbar.TabIndex = 0;
            this.navbar.Text = "menuStrip2";
            // 
            // visualTweaksToolStripMenuItem1
            // 
            this.visualTweaksToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.otherToolStripMenuItem,
            this.toolStripSeparator2,
            this.secretModeToolStripMenuItem});
            this.visualTweaksToolStripMenuItem1.Name = "visualTweaksToolStripMenuItem1";
            this.visualTweaksToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.visualTweaksToolStripMenuItem1.Text = "Scripts";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HacksStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Tweaks";
            // 
            // HacksStripMenuItem
            // 
            this.HacksStripMenuItem.Name = "HacksStripMenuItem";
            this.HacksStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.HacksStripMenuItem.Text = "Hacks (Bannable)";
            this.HacksStripMenuItem.Click += new System.EventHandler(this.HacksToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gotoURLToolStripMenuItem,
            this.toolStripSeparator3,
            this.toolStripMenuItem3,
            this.goBackToolStripMenuItem,
            this.toolStripSeparator4,
            this.refreshToolStripMenuItem});
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // gotoURLToolStripMenuItem
            // 
            this.gotoURLToolStripMenuItem.Name = "gotoURLToolStripMenuItem";
            this.gotoURLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gotoURLToolStripMenuItem.Text = "Goto URL";
            this.gotoURLToolStripMenuItem.Click += new System.EventHandler(this.gotoURLToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "Go Forward";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // goBackToolStripMenuItem
            // 
            this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.goBackToolStripMenuItem.Text = "Go Back";
            this.goBackToolStripMenuItem.Click += new System.EventHandler(this.goBackToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // secretModeToolStripMenuItem
            // 
            this.secretModeToolStripMenuItem.Name = "secretModeToolStripMenuItem";
            this.secretModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.secretModeToolStripMenuItem.Text = "Secret Mode";
            this.secretModeToolStripMenuItem.Click += new System.EventHandler(this.secretModeToolStripMenuItem_Click);
            // 
            // additionalToolStripMenuItem
            // 
            this.additionalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dANGERResetEverythingToolStripMenuItem,
            this.openDevToolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.additionalToolStripMenuItem.Name = "additionalToolStripMenuItem";
            this.additionalToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.additionalToolStripMenuItem.Text = "Help";
            // 
            // dANGERResetEverythingToolStripMenuItem
            // 
            this.dANGERResetEverythingToolStripMenuItem.Name = "dANGERResetEverythingToolStripMenuItem";
            this.dANGERResetEverythingToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.dANGERResetEverythingToolStripMenuItem.Text = "Reset Everything";
            this.dANGERResetEverythingToolStripMenuItem.Click += new System.EventHandler(this.dangerResetEverythingToolStripMenuItem_Click);
            // 
            // openDevToolsToolStripMenuItem
            // 
            this.openDevToolsToolStripMenuItem.Name = "openDevToolsToolStripMenuItem";
            this.openDevToolsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.openDevToolsToolStripMenuItem.Text = "Open Dev Tools";
            this.openDevToolsToolStripMenuItem.Click += new System.EventHandler(this.openDevToolsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.aboutToolStripMenuItem.Text = "About Full Nitro Client";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // chromeBrowser
            // 
            this.chromeBrowser.ActivateBrowserOnCreation = false;
            this.chromeBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromeBrowser.Location = new System.Drawing.Point(3, 27);
            this.chromeBrowser.Name = "chromeBrowser";
            this.chromeBrowser.Size = new System.Drawing.Size(1134, 474);
            this.chromeBrowser.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1142, 538);
            this.ColorScheme.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(64)))), ((int)(((byte)(101)))));
            this.ColorScheme.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.ColorScheme.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.ColorScheme.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.tlpMain);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Full Venge Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.MenuStrip navbar;
        private System.Windows.Forms.ToolStripMenuItem visualTweaksToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem additionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dANGERResetEverythingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDevToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem HacksStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem secretModeToolStripMenuItem;
        private CefSharp.WinForms.ChromiumWebBrowser chromeBrowser;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gotoURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

