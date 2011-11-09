﻿namespace Help
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.helpToolStrip = new System.Windows.Forms.ToolStrip();
            this.backIcon = new System.Windows.Forms.ToolStripButton();
            this.forwardIcon = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contentsIcon = new System.Windows.Forms.ToolStripButton();
            this.helpBrowser = new System.Windows.Forms.WebBrowser();
            this.helpProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.helpToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // helpToolStrip
            // 
            this.helpToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.helpToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backIcon,
            this.forwardIcon,
            this.toolStripSeparator1,
            this.contentsIcon,
            this.helpProgressBar});
            this.helpToolStrip.Location = new System.Drawing.Point(0, 0);
            this.helpToolStrip.Name = "helpToolStrip";
            this.helpToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.helpToolStrip.Size = new System.Drawing.Size(711, 25);
            this.helpToolStrip.TabIndex = 0;
            // 
            // backIcon
            // 
            this.backIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backIcon.Image = ((System.Drawing.Image)(resources.GetObject("backIcon.Image")));
            this.backIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backIcon.Name = "backIcon";
            this.backIcon.Size = new System.Drawing.Size(23, 22);
            this.backIcon.Text = "Back";
            // 
            // forwardIcon
            // 
            this.forwardIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forwardIcon.Image = ((System.Drawing.Image)(resources.GetObject("forwardIcon.Image")));
            this.forwardIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forwardIcon.Name = "forwardIcon";
            this.forwardIcon.Size = new System.Drawing.Size(23, 22);
            this.forwardIcon.Text = "Forward";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // contentsIcon
            // 
            this.contentsIcon.Image = ((System.Drawing.Image)(resources.GetObject("contentsIcon.Image")));
            this.contentsIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.contentsIcon.Name = "contentsIcon";
            this.contentsIcon.Size = new System.Drawing.Size(75, 22);
            this.contentsIcon.Tag = "";
            this.contentsIcon.Text = "Contents";
            // 
            // helpBrowser
            // 
            this.helpBrowser.AllowWebBrowserDrop = false;
            this.helpBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpBrowser.Location = new System.Drawing.Point(0, 25);
            this.helpBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.helpBrowser.Name = "helpBrowser";
            this.helpBrowser.Size = new System.Drawing.Size(711, 358);
            this.helpBrowser.TabIndex = 1;
            this.helpBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // helpProgressBar
            // 
            this.helpProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpProgressBar.Name = "helpProgressBar";
            this.helpProgressBar.Size = new System.Drawing.Size(100, 22);
            this.helpProgressBar.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 383);
            this.Controls.Add(this.helpBrowser);
            this.Controls.Add(this.helpToolStrip);
            this.Name = "MainWindow";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.helpToolStrip.ResumeLayout(false);
            this.helpToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip helpToolStrip;
        private System.Windows.Forms.WebBrowser helpBrowser;
        private System.Windows.Forms.ToolStripButton backIcon;
        private System.Windows.Forms.ToolStripButton forwardIcon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton contentsIcon;
        private System.Windows.Forms.ToolStripProgressBar helpProgressBar;
    }
}
