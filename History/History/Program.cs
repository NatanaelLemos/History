using SILIB.View;
using System;
using System.Windows.Forms;

namespace History
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

            frmMap map = new frmMap();

            frmSplash splash = new frmSplash(Application.ProductName, Application.ProductVersion, map.Icon);
            splash.Progress = "Iniciando o sistema";
            splash.Show();
            splash.Wait(2000);

            splash.Dispose();

            Application.Run(map);
        }
    }
}
