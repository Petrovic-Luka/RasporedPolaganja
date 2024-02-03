using ClientSide.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSide
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
            //Application.Run(new FrmLogIn());
            MainCoordinator.Instance.frmLogIn=new FrmLogIn();
            MainCoordinator.Instance.CreateLogIn();
            Application.Run(MainCoordinator.Instance.frmLogIn);

        }
    }
}
