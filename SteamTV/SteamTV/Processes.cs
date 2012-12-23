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
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;

namespace Processes
{
    public class ProcessMethods
    {
        public bool IsProcessOpen(string name)
        {
            Process[] myProcesses = Process.GetProcessesByName(name);
            if (myProcesses.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CloseProcess(string name)
        {
            Process[] myProcesses = Process.GetProcessesByName(name);
            if (myProcesses.Length > 0)
            {
                myProcesses[0].Kill();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
