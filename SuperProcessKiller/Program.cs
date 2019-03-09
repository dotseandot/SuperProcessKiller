using System;
using System.Windows.Forms;

namespace SuperProcessKiller
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //If started with parameters, don't load UI and just kill the requested process 
            //Examples:
                //SPK.exe notepad
                //SPK.exe notepad s
            bool safe = false;
            if (args.Length > 0)
            {
                string app =  args[0];

                if (args.Length > 1)
                {
                    string mode = args[1];
                    //if second arg is 's', try to kill the process safely
                    if (mode == "s")
                    {
                        safe = true;
                    }
                }
                Killer.Kill(app, safe);
            }
            //If not started with parameters, load the UI
            else
            {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SuperProcessKiller());
            }
        }
    }
}
