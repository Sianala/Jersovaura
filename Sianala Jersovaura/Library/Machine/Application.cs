using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sianala.Jersovaura.Machine
{
    public class Application
    {
        public static void Run(string Path)
        {
            var AppArgs = new ProcessStartInfo(Path);
            AppArgs.FileName = Path;
            Process.Start(AppArgs);
        }
    }
}
