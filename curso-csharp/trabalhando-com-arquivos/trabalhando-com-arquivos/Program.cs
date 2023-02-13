using System;
using System.IO;

namespace trabalhando_com_arquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt";
            string targePath = @"c:\temp\file2.txt";

            try
            {
                FileInfo fileInfo= new FileInfo(sourcePath);
                fileInfo.CopyTo(targePath);
                string[] lines = File.ReadAllLines(sourcePath); 
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }   

            }catch(Exception ex)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
