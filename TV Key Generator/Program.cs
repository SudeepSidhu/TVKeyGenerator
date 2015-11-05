using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TV_Key_Generator
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

            string[] args = Environment.GetCommandLineArgs();
            bool installQuietly = false;

            foreach (string arg in args)
            {
                switch (arg.Substring(0, 2).ToLower())
                {
                    case "/q":
                        installQuietly = true;
                        break;

                    default:
                        break;
                }
            }

            if (installQuietly)
            {
                QuietInstaller.install();
            }
            else
            {
                Application.Run(new Form1());
            }
        }
    }
}
