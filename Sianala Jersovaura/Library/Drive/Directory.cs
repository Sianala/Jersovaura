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
    public class FolderTime
    {
        public class Get
        {
            public static DateTime Creation(string Path)
            {
                return Directory.GetCreationTime(Path);
            }
            public static DateTime Write(string Path)
            {
                return Directory.GetLastWriteTime(Path);
            }
            public static DateTime Access(string Path)
            {
                return Directory.GetLastAccessTime(Path);
            }
        }
        public class Set
        {
            public static void Creation(string Path, DateTime Time)
            {
                Directory.SetCreationTime(Path, Time);
            }
            public static void Write(string Path, DateTime Time)
            {
                Directory.SetLastWriteTime(Path, Time);
            }
            public static void Access(string Path, DateTime Time)
            {
                Directory.SetLastAccessTime(Path, Time);
            }
        }
    }
    public class FolderInfo
    {
        public static string FullPath(string Path)
        {
            return System.IO.Path.GetFullPath(Path);
        }
    }
}
