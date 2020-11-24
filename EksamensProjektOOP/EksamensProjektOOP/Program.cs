using System;
using System.IO;

namespace EksamensProjektOOP
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            FileParser fileParser = new FileParser();

            fileParser.InitializeProducts();
            fileParser.InitializeUsers();
        }
    }
}
