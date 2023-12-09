// StreamReader While Example
using System;
using System.IO;
namespace ReadFile
{   
    class Read {         
        static void Main(string[] args)
        {
            string Line = "";
            StreamReader TextFile = new StreamReader("file.txt");
            Line = TextFile.ReadLine();
            
            while (Line != null)
            {
                Console.WriteLine(Line);
                Line = TextFile.ReadLine();
            }
            TextFile.Close();
        }
    }
}
