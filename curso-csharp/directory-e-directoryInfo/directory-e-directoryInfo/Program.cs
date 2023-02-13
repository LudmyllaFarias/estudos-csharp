using System;
using System.IO;


namespace directory_e_directoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\docs";

            try
            {
                //Lista pasta e sub pastas informada
                var folder = Directory.EnumerateDirectories(path, "*.*",SearchOption.AllDirectories);
                Console.WriteLine("Folders:");
                foreach (string item in folder)
                {
                    Console.WriteLine(item);
                }

                // Lista arquivos de uma pasta
                var file = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files:");
                foreach (string item in file)
                {
                    Console.WriteLine(item);
                }

                // Cria uma pasta
                Directory.CreateDirectory(path + @"\newfolder");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
