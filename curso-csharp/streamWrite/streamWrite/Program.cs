using System;
using System.IO;

namespace streamWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";

            try
            {
                // Ler todo conteudo do arquivo e guardar no array de strings
                string[] linec = File.ReadAllLines(sourcePath);
            
                //Escrever no arquivo de saida
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in linec)
                    {
                        //Escrever no arquivo
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
