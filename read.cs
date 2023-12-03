// StreamReader Line Example
using System.IO;
namespace ReadFile
{   
    class Read {         
        static void Main(string[] args)
        {
            string Line = "";
            StreamReader TextFile = new StreamReader("file.txt");
            Line = TextFile.ReadLine();
            System.Console.WriteLine(Line);
            TextFile.Close();
        }
    }
}