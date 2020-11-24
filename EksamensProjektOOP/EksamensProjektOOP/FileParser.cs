using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace EksamensProjektOOP
{
    class FileParser
    {
        public User user;
        // Read .CSV file
        public string[,] ReadFile(char delimiter, string filePath)
        {
            //columncount = -1, da det fortæller om programmet fejler eller ej
            //foreach splitter filen op i string array columnValues
            //if sætter cloumnCount til længden af columnValues
            //for loop tæller columnValues in i row, row addes til userfiles, så den ikke bliver overrided
            List<List<String>> userFile = new List<List<string>>();
            int columnCount = -1;
            foreach (string line in File.ReadLines(filePath))
            {
                string[] columnValues = line.Split(delimiter);
                List<string> row = new List<string>();

                if (columnCount == -1)
                {
                    columnCount = columnValues.Length;
                }

                for (int i = 0; i < columnValues.Length; i++)
                {
                    row.Add(columnValues[i]);
                }

                userFile.Add(row);
            }

            //mulitdimensional array x-akse er rækkerne, y-akse er columncount(id, navn osv.)
            //[,] fortæller mængden af dimensioner
            string[,] output = new string[userFile.Count, columnCount];

            for (int i = 0; i < userFile.Count; i++)
            {
                for (int j = 0; j < userFile[i].Count; j++)
                {
                    output[i, j] = userFile[i][j];
                }
            }
            return output;
        }

        public void InitializeUsers()
        {
            char delimiter = ',';
            string filePath = @"C:\Users\nanna\source\repos\EksamensProjektOOP\users.csv";
            string[,] result = ReadFile(delimiter, filePath);
            for (int i = 1; i < result.GetLength(0); i++)
            {
                int userID = Convert.ToInt32(result[i, 0]);
                Console.WriteLine(userID);

                string firstName = result[i, 1];
                Console.WriteLine(firstName);

                string lastName = result[i, 2];
                Console.WriteLine(lastName);

                string userName = result[i, 3];
                Console.WriteLine(userName);

                decimal balance = Convert.ToDecimal(result[i, 4]);
                Console.WriteLine(balance);

                string email = result[i, 5];
                Console.WriteLine(email);

                User user = new User(userID, firstName, lastName, userName, balance, email);

                User.add(user);
                //userID = user.ID;
                //User result[i, 3] = new User(userID, firstName, lastName, userName, balance, email);
                //User userNam = new User(userID, firstName, lastName, userName, balance, email);
                //string userid = userNam.UserName;

            }
            //Console.WriteLine(result[0, 0]); // ID
            //Console.WriteLine(result[1, 0]); // 1
            //Console.WriteLine(result[2, 0]); // 2
            //Console.WriteLine(result[0, 1]); // FirstName
            //Console.WriteLine(result[0, 2]); // LastName
            //Console.WriteLine(result[0, 3]); // Username
            //Console.WriteLine(result[0, 4]); // Balance
            //Console.WriteLine(result[0, 5]); // Email

        }

        public void InitializeProducts()
        {
            char delimiter = ';';
            string filePath = @"C:\Users\nanna\source\repos\EksamensProjektOOP\products.csv";
            string[,] result = ReadFile(delimiter, filePath);
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    //Console.WriteLine(result[i, j]);
                }
            }
        }
    }
    
}
