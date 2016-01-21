using System;
using System.Collections.Generic;
using System.Linq;
//using System.Threading.Tasks;
using System.Windows.Forms;


namespace spirit
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new spirit.Formularios.mdiSpirit());

            Formularios.frmLogin ffrmLogin = new Formularios.frmLogin();
            ffrmLogin.ShowDialog();
            if (ffrmLogin.bLoginOk == true)
            {
                Application.Run(new spirit.Formularios.mdiSpirit());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
