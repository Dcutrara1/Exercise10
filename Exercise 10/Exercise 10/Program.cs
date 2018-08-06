using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String line;
                int count = 1;

                // Open the Text.txt file.
                StreamReader inputFile = File.OpenText("Text.txt");

                // Create a List object to hold strings.                                
                List<string> wordList = new List<string>();

                // Open the file and get a StreamReader object.
                inputFile = File.OpenText("Text.txt");

                // Read the file's contents.
                while (!inputFile.EndOfStream)
                {
                    // Read a line and add it to the List.
                    line = inputFile.ReadLine();
                    Console.WriteLine(line);

                    // Trim the string.
                    line = line.Trim();
                    
                    // Create an array of delimiters.
                    char[] delim = { ',', ' ','.'};                                      
                    
                    //Tokenize the string using identified delimiters. 
                    string[] tokens = line.Split(delim);

                    // Count the number of words ending in e or t. 
                    foreach (string s in tokens)
                    {
                        if (s.EndsWith("e"))
                        {
                            count++;
                        }
                        if(s.EndsWith("t"))
                        {
                            count++;
                        }
                    }
                    // Display the number of words ending in t or e.
                    Console.WriteLine("There are " + count + 
                        " words that end in t or e.");

                    // Keep the console from closing.
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                }                                  
                // Close the file.
                inputFile.Close();                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);           
            }
        }
    }
}
