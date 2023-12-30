using System;
using System.Windows.Forms;

namespace project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///

        public static string ConnectionString = @"Data Source=DESKTOP-UDEA2GE\SQLEXPRESS;Initial Catalog=LULZ_library;Integrated Security=True";

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Login());
        }
    }
}