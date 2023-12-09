// StreamWriter Line Example 
using System; 
using System.IO; 
namespace WriteFile 
{    
    class Write {          
        static void Main(string[] args) 
        { 
            StreamWriter fileOut = new StreamWriter("fileName.txt"); 
            fileOut.WriteLine("testing123");
            fileOut.Close(); 
        } 
    } 
} 
