// StreamReader Line Example
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
            Console.WriteLine(Line);
            TextFile.Close();
        }
    }
}
