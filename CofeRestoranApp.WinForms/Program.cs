using CofeRestoranApp.WinForms.AnaMenu;
using System;
using System.Windows.Forms;

namespace CofeRestoranApp.WinForms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Ana_Form());
        }
    }
}
