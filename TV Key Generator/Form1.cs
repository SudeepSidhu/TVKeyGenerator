using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;

namespace TV_Key_Generator
{
    public partial class Form1 : Form
    {
        const string dllPath = "GameAISupport.dll";

        [DllImport(dllPath)]

        public static extern int GameAISupportQueryItem(String key);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPatch_Click(object sender, EventArgs e)
        {

            if (File.Exists(dllPath))
            {
                txtOut.Text = "Finding a key...";

                //because screw writing a background worker just so I can do a label update
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
                {
                    string key = KeyGenerator.generateKey();

                    int retVal = GameAISupportQueryItem(key);

                    if (retVal == 1)
                    {
                        txtOut.Invoke((MethodInvoker)(() => txtOut.Text = "Successfully installed \"" + key + "\""));
                    }
                    else
                    {
                        txtOut.Invoke((MethodInvoker)(() => txtOut.Text = "Problem installing \"" + key + "\" try again."));
                    }
                }));
            }
            else
            {
                MessageBoxEx.Show("GameAISupport.dll not found, please move this program to the Tribes Vengeance Bin folder, typically in " + ProgramFilesx86() + "\\VUGames\\Tribes Vengeance\\Program\\Bin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static string ProgramFilesx86()
        {
            if (8 == IntPtr.Size || (!String.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))))
            {
                return Environment.GetEnvironmentVariable("ProgramFiles(x86)");
            }

            return Environment.GetEnvironmentVariable("ProgramFiles");
        }
    }
}
