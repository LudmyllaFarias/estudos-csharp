using System;
using System.IO;

namespace filestream_e_streamreader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";

            StreamReader sr = null;
            
            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream) 
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

            }
            catch(Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(sr != null) sr.Close();
   
            }
        }
    }
}
