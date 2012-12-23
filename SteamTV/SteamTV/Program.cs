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
using System.Threading;
using System.IO;
using Ini;
using System.Diagnostics;
using Processes;

namespace SteamTV
{
   public class Program
    {

        public static IniFile config = new IniFile(AppDomain.CurrentDomain.BaseDirectory + "/configs.ini");
        public static ProcessMethods process = new ProcessMethods();
        private static string Username = config.IniReadValue("SteamConfigs", "SteamUsername");
        private static string Password = config.IniReadValue("SteamConfigs", "SteamPassword");

        static public void Tick(Object stateInfo)
        {
            if (!process.IsProcessOpen("steam"))
            {
                try
                {
                    if (Convert.ToBoolean(config.IniReadValue("TVConfigs", "Shutdown")))
                    {
                        Process.Start("shutdown", "/s /t 0");
                    }
                }
                catch
                {
                    Console.WriteLine("There is something wrong in the configuration. Error 1");
                }
                Environment.Exit(0);
            }
        }

        static void Main(string[] args)
        {
            if (process.IsProcessOpen("steam"))
            {
                Console.WriteLine("Steam is open, closing steam.");
                process.CloseProcess("steam");
                System.Threading.Thread.Sleep(50);
            }
            
             if (!process.IsProcessOpen("steam"))
            {
                Console.WriteLine("Starting up Steam!");
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = config.IniReadValue("SteamConfigs", "SteamPath") + "/Steam.exe";
                startInfo.Arguments = "-login " + Username + " " + Password + " -tenfoot";
                Process.Start(startInfo);

            }
                     System.Threading.Thread.Sleep(1000);
                     TimerCallback callback = new TimerCallback(Tick);
                     Timer stateTimer = new Timer(callback, null, 0, 1000);
             for (; ; ) { }
        }
    }
}
