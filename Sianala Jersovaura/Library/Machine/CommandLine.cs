using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sianala.Jersovaura.Machine
{
    public class CommandLine
    {
        public static void Execute(string UserName, string CommandAndArguments)
        {
            Drive.File.Create(@"%userprofile%\CommandLine.bat", CommandAndArguments);
            Application.Run(@"%userprofile%\CommandLine.bat");
        }
    }
}
