using System;
using System.IO;

namespace classe_path
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\docs\doc\doc1.txt";

            Console.WriteLine(Path.GetDirectoryName(path));
            Console.WriteLine(Path.DirectorySeparatorChar);
            Console.WriteLine(Path.PathSeparator);
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));
        }
    }
}
