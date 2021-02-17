using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sianala.Jersovaura.Machine
{
    public class User
    {
        public static string Name()
        {
            return Environment.UserName;
        }
    }
    public class Computer
    {
        public static string Name()
        {
            return Environment.MachineName;
        }
    }
}
