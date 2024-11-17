using System;
using System.Windows.Forms;
using pv.Frontend;
using pv.Frontend.Vistas;

namespace pv
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VentaHecha());
        }
    }
}
