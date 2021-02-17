using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sianala.Jersovaura.Drive
{
    public class Folder
    {
        public static void Create(string Path)
        {
            Directory.CreateDirectory(Path);
        }
        public static void Create(string Path, string DirContent)
        {
            Directory.CreateDirectory(Path);
            Directory.Move(DirContent, Path);
        }
        public static bool Exists(string Path)
        {
            return Directory.Exists(Path);
        }
        public static void Remove(string Path)
        {
            Directory.Delete(Path);
        }
        
    }
}
