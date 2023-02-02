using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OneWayUI;

namespace Baby_Thesis_Test
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
            new inputInfo();
            new FrmBack();
            new FrmSide();
            new FrmFront();
            Application.Run(new FrmHome());
        }
    }
}
