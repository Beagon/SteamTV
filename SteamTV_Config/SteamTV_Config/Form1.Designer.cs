/*    Copyright (C) 2012  Robin Rijkeboer

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
								                                    */
namespace SteamTV_Config
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.label1 = new System.Windows.Forms.Label();
            this.SteamConfig = new System.Windows.Forms.GroupBox();
            this.SteamPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.SteamUsername = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.BrowseFile = new System.Windows.Forms.Button();
            this.SteamDirectory = new System.Windows.Forms.TextBox();
            this.TVConfig = new System.Windows.Forms.GroupBox();
            this.TVSteamShutdown = new System.Windows.Forms.CheckBox();
            this.BrowseSteamFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.TVSteamExplorer = new System.Windows.Forms.CheckBox();
            this.SteamConfig.SuspendLayout();
            this.TVConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Steam Directory";
            // 
            // SteamConfig
            // 
            this.SteamConfig.Controls.Add(this.SteamPassword);
            this.SteamConfig.Controls.Add(this.Password);
            this.SteamConfig.Controls.Add(this.SteamUsername);
            this.SteamConfig.Controls.Add(this.Username);
            this.SteamConfig.Controls.Add(this.BrowseFile);
            this.SteamConfig.Controls.Add(this.SteamDirectory);
            this.SteamConfig.Controls.Add(this.label1);
            this.SteamConfig.Location = new System.Drawing.Point(12, 12);
            this.SteamConfig.Name = "SteamConfig";
            this.SteamConfig.Size = new System.Drawing.Size(191, 154);
            this.SteamConfig.TabIndex = 1;
            this.SteamConfig.TabStop = false;
            this.SteamConfig.Text = "Steam Configurations";
            // 
            // SteamPassword
            // 
            this.SteamPassword.Location = new System.Drawing.Point(7, 123);
            this.SteamPassword.Name = "SteamPassword";
            this.SteamPassword.Size = new System.Drawing.Size(172, 20);
            this.SteamPassword.TabIndex = 6;
            this.SteamPassword.UseSystemPasswordChar = true;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(6, 107);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(56, 13);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password:";
            // 
            // SteamUsername
            // 
            this.SteamUsername.Location = new System.Drawing.Point(7, 84);
            this.SteamUsername.Name = "SteamUsername";
            this.SteamUsername.Size = new System.Drawing.Size(172, 20);
            this.SteamUsername.TabIndex = 4;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(6, 68);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(58, 13);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username:";
            // 
            // BrowseFile
            // 
            this.BrowseFile.Location = new System.Drawing.Point(126, 30);
            this.BrowseFile.Name = "BrowseFile";
            this.BrowseFile.Size = new System.Drawing.Size(53, 23);
            this.BrowseFile.TabIndex = 2;
            this.BrowseFile.Text = "Browse";
            this.BrowseFile.Click += new System.EventHandler(this.SelectSteamDirectory);
            // 
            // SteamDirectory
            // 
            this.SteamDirectory.Location = new System.Drawing.Point(7, 33);
            this.SteamDirectory.Name = "SteamDirectory";
            this.SteamDirectory.Size = new System.Drawing.Size(113, 20);
            this.SteamDirectory.TabIndex = 1;
            this.SteamDirectory.Click += new System.EventHandler(this.SelectSteamDirectory);
            // 
            // TVConfig
            // 
            this.TVConfig.Controls.Add(this.TVSteamExplorer);
            this.TVConfig.Controls.Add(this.TVSteamShutdown);
            this.TVConfig.Location = new System.Drawing.Point(209, 12);
            this.TVConfig.Name = "TVConfig";
            this.TVConfig.Size = new System.Drawing.Size(200, 154);
            this.TVConfig.TabIndex = 2;
            this.TVConfig.TabStop = false;
            this.TVConfig.Text = "Steam TV Settings";
            // 
            // TVSteamShutdown
            // 
            this.TVSteamShutdown.AutoSize = true;
            this.TVSteamShutdown.Location = new System.Drawing.Point(17, 19);
            this.TVSteamShutdown.Name = "TVSteamShutdown";
            this.TVSteamShutdown.Size = new System.Drawing.Size(164, 17);
            this.TVSteamShutdown.TabIndex = 0;
            this.TVSteamShutdown.Text = "Shutdown computer on close";
            this.TVSteamShutdown.UseVisualStyleBackColor = true;
            // 
            // BrowseSteamFolder
            // 
            this.BrowseSteamFolder.ShowNewFolderButton = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TVSteamExplorer
            // 
            this.TVSteamExplorer.AutoSize = true;
            this.TVSteamExplorer.Location = new System.Drawing.Point(17, 42);
            this.TVSteamExplorer.Name = "TVSteamExplorer";
            this.TVSteamExplorer.Size = new System.Drawing.Size(180, 17);
            this.TVSteamExplorer.TabIndex = 1;
            this.TVSteamExplorer.Text = "Kill Windows Explorer on launch.";
            this.TVSteamExplorer.UseVisualStyleBackColor = true;
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 206);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TVConfig);
            this.Controls.Add(this.SteamConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Config";
            this.Text = "SteamTV Configuration";
            this.SteamConfig.ResumeLayout(false);
            this.SteamConfig.PerformLayout();
            this.TVConfig.ResumeLayout(false);
            this.TVConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox SteamConfig;
        private System.Windows.Forms.Button BrowseFile;
        private System.Windows.Forms.TextBox SteamDirectory;
        private System.Windows.Forms.GroupBox TVConfig;
        private System.Windows.Forms.FolderBrowserDialog BrowseSteamFolder;
        private System.Windows.Forms.TextBox SteamUsername;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox SteamPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox TVSteamShutdown;
        private System.Windows.Forms.CheckBox TVSteamExplorer;
    }
}

