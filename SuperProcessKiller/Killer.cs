using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperProcessKiller
{
    public static class Killer
    {
        public static int Kill(string app, bool safe)
        {
            var total = 0;

            //Loop through all processes with a matching name (using diagnostics namespace)
            foreach (var process in Process.GetProcessesByName(app))
            {
                if (safe == true)
                {
                    process.CloseMainWindow();
                }
                else
                {
                    process.Kill();
                }
                //Increment total of processes killed
                total++;
            }

            return total;
        }
    }
}
