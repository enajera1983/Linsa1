using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linsa
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        public static bool OpenMDI { get; set; }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            OpenMDI = false;
            Application.Run(new login());
            if (OpenMDI)
            {
                Application.Run(new MDIParent1());
            }
            //Application.Run(new MDIParent1());
        }
    }
}
