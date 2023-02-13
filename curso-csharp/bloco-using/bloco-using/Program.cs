using System;
using System.IO;

namespace bloco_using
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"c:\temp\file1.txt";

                using (StreamReader sr = File.OpenText(path))
                {
                    while(!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
