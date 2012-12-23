using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

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
