using System;
using System.IO;
using System.Text;

namespace Sianala.Jersovaura.Drive
{
    public class File
    {
        public static void Create(string Path)
        {
            System.IO.File.CreateText(Path);
        }
        public static void Create(string Path, string Content)
        {
            System.IO.File.WriteAllText(Path, Content);
        }
        public static void Create(string Path, string Content, Encoding Encoding)
        {
            System.IO.File.WriteAllText(Path, Content, Encoding);
        }
        public static void Read(string Path)
        {
            System.IO.File.ReadAllText(Path);
        }
        public static void Read(string Path, Encoding Encoding)
        {
            System.IO.File.ReadAllText(Path, Encoding);
        }
        public static bool Exists(string Path)
        {
            return System.IO.File.Exists(Path);
        }
        public static void Remove(string Path)
        {
            if (Exists(Path) == false)
                return;
            else
            {
                System.IO.File.Delete(Path);
            }
        }
    }
    public class FileTime
    {
        public class Get
        {
            public static DateTime Creation(string Path)
            {
                return System.IO.File.GetCreationTime(Path);
            }
            public static DateTime Write(string Path)
            {
                return System.IO.File.GetLastWriteTime(Path);
            }
            public static DateTime Access(string Path)
            {
                return System.IO.File.GetLastAccessTime(Path);
            }
        }
        public class Set
        {
            public static void Creation(string Path, DateTime DateTime)
            {
                System.IO.File.SetCreationTime(Path, DateTime);
            }
            public static void Write(string Path, DateTime DateTime)
            {
                System.IO.File.SetLastWriteTime(Path, DateTime);
            }
            public static void Access(string Path, DateTime DateTime)
            {
                System.IO.File.SetLastAccessTime(Path, DateTime);
            }
        }
    }
    public class FileInfo
    {
        public class Attributes
        {
            public static FileAttributes Get(string Path)
            {
                return System.IO.File.GetAttributes(Path);
            }
            public static void Set(string Path, FileAttributes FileAttributes)
            {
                System.IO.File.SetAttributes(Path, FileAttributes);
            }
        }
        public static string FullPath(string Path)
        {
            return System.IO.Path.GetFullPath(Path);
        }
    }
}
