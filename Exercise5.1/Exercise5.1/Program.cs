using System;
using System.IO;
using System.Linq.Expressions;

class WriteToFile
{
    // Main Method
    static void Main(string[] args)
    {
        // This will create a file named tmp.txt
        // at the specified location
        StreamWriter sw = new StreamWriter("D://Programming/tmp.txt");
        // To write on the console screen
        Console.WriteLine("Enter the Text that you want to write on File");
        // To read the input from the user
        string str = Console.ReadLine();
        // To write a line in buffer
        sw.WriteLine(str);
        // To write in output stream
        sw.Flush();
        // To close the stream
        sw.Close();
        Console.ReadKey();
        Console.WriteLine("Do you want to read file that you have wrote? \n Please enter 'y' if you do or 'n' if you dont ");
        char userchoice = Console.ReadKey().KeyChar;

        if (userchoice is 'y' or 'Y')
        {
            //Reading content of file
            StreamReader sr = new StreamReader("D://Programming/tmp.txt");
            Console.WriteLine("\nContent of the File that you have wrote");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string umi = sr.ReadLine();
            while (umi != null)
            {
                Console.WriteLine(umi);
                umi = sr.ReadLine();

            }
            Console.ReadLine();
            sr.Close();

        }
        else if (userchoice is 'n' or 'N')
        {
            Console.WriteLine("Maybe next time ^^");
        }
        else
        {
            Console.WriteLine("\nInvalid input. Please enter 'y' or 'n'.");
        }
    
    }
}