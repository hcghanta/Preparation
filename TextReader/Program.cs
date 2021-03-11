using System;
using System.IO;
using System.Text;

namespace TextReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory() + @"\Important.txt";

            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                string createText = "File Does not exist. Please check..." + Environment.NewLine;
                File.WriteAllText(path, createText, Encoding.UTF8);
            }

            // Open the file to read from.
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
    }
}
