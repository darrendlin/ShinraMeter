﻿using System;
using System.Windows.Forms;

namespace Tera.DamageMeter
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Console.WriteLine(Keys.Delete);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DamageMeterForm());
        }
    }
}