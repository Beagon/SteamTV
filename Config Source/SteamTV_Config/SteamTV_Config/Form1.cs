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

namespace SteamTV_Config
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
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
            // Compose a string that consists of three lines.
            string lines = "Test";

            // Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter("test.txt");
            file.WriteLine(lines);

            file.Close();
        }

    }
}
