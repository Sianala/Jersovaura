using System;

namespace Sianala.Jersovaura.Drive
{
    public class File
    {
        public static void Create(string Path)
        {
            System.IO.File.Create(Path);
        }
        public static void Create(string Path, string Content)
        {
            System.IO.File.WriteAllText(Path, Content);
        }
        public static void Rename(string Path, string NewName)
        {
            var File = new System.IO.FileInfo(Path);
        }
    }
}
