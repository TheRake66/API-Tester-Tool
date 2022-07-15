using API_Tester_Tool.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_Tester_Tool
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                if (!File.Exists("Newtonsoft.Json.dll"))
                {
                   File.WriteAllBytes("Newtonsoft.Json.dll", Resources.Newtonsoft_Json1);
                }
                if (!File.Exists("Newtonsoft.Json.xml"))
                {
                    File.WriteAllText("Newtonsoft.Json.xml", Resources.Newtonsoft_Json);
                }
            }
            catch
            {
                MessageBox.Show("Unable to create resource files !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
