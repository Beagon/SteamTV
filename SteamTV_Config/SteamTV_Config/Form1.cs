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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Ini;

namespace SteamTV_Config
{
    public partial class Config : Form
    {
        private IniFile config = new IniFile(Path.GetDirectoryName(Application.ExecutablePath) + "/configs.ini");
        public Config()
        {
            InitializeComponent();
            try
            {
                this.SteamDirectory.Text = config.IniReadValue("SteamConfigs", "SteamPath");
                this.SteamUsername.Text = config.IniReadValue("SteamConfigs", "SteamUsername");
                this.SteamPassword.Text = config.IniReadValue("Steamconfigs", "SteamPassword");
            }
            catch
            {
            }
        }

        private void SelectSteamDirectory(object sender, EventArgs e)
        {
            if (BrowseSteamFolder.ShowDialog() == DialogResult.OK)
            {
                this.SteamDirectory.Text = BrowseSteamFolder.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          config.IniWriteValue("SteamConfigs", "SteamPath", this.SteamDirectory.Text);
          config.IniWriteValue("SteamConfigs", "SteamUsername", this.SteamUsername.Text);
          config.IniWriteValue("SteamConfigs", "SteamPassword", this.SteamPassword.Text);
        }

    }
}
