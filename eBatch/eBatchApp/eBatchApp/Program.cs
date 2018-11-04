﻿using eBatchApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBatchApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new Login());
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
        internal static void HandleException(Exception ex)
        {
            string LF = Environment.NewLine + Environment.NewLine;
            string title = $"Oh Dear! Something not worked as expected at: {DateTime.Now}";
            string infos = $"Please take a screenshot of this message\n\r\n\r" +
                           $"Message : {LF}{ex.Message}{LF}" +
                           $"Source : {LF}{ex.Source}{LF}" +
                           $"Stack : {LF}{ex.StackTrace}{LF}" +
                           $"InnerException : {ex.InnerException}";

            MessageBox.Show(infos, title, MessageBoxButtons.OK, MessageBoxIcon.Error); // Do logging of exception details

        }
    }
}
