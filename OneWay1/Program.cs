using Baby_Thesis_Test;
using OneWay;
using OneWayUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneWay1
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
            Application.Run(new FrmOfficerLogin());

            new FrmHome();
            new FrmBack();
            new FrmFront();
            new FrmFullScale();
            new FrmGazeMoto();
            new FrmSide();

        }
    }
}
