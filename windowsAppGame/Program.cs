using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsAppGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

                using (App application = new App())
                {
                    application.Run();
                }

            


           // Application.EnableVisualStyles();
           // Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
          //  Application.Run(new _3Dform());
        }
    }
}
