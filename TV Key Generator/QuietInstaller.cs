using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms;

namespace TV_Key_Generator
{
    class QuietInstaller
    {
        const string dllPath = "GameAISupport.dll";

        [DllImport(dllPath)]

        public static extern int GameAISupportQueryItem(String key);

        public static void install()
        {
            if (File.Exists(dllPath))
            {
                string key = KeyGenerator.generateKey();

                int retVal = GameAISupportQueryItem(key);

                if (retVal == 1)
                {
                    MessageBoxEx.Show("Successfully installed the key \"" + key + "\" for multiplayer fun!", "T:V Key Generator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBoxEx.Show("Failed to install key \"" + key + "\" :(\r\nPlease go to the Tribes install directory and run the TV Key Generator to try agan.", "T:V Key Generator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
