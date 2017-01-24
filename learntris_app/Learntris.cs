using System;
using System.Text;
using System.IO;

namespace Learntris
{
    public class Learntris
    {
        public static void Main(string[] args)
        {
            Stream inputStream = Console.OpenStandardInput();
            byte[] inputBytes = new byte[100];
            int inputLength = inputStream.Read(inputBytes, 0, 100);
            char[] inputChars = Encoding.UTF8.GetChars(inputBytes, 0, inputLength);
            string[] commands = new string(inputChars).Split(new char[]{});

            foreach(string c in commands)
            {
                if(c != String.Empty)
                    ProcessCommand(c);
            }
                
        }

        public static void ProcessCommand(string arg)
        {
            switch (arg)
            {
                case "q":
                    return;
                case "p":
                    string[,] field = CreateField(22, 10);
                    Print(field);
                    break;
                default:
                    System.Console.WriteLine(String.Format("Command not supported: '{0}'", arg));
                    break;
            }
        }

        public static string[,] CreateField(int rows, int columns)
        {
            string[,] field = new string[rows,columns];
            for(int i = 0; i < field.GetLength(0); i++)
            {
                for(int j = 0; j < field.GetLength(1); j++)
                    field[i, j] = ".";
            }

            return field;
        }

        public static void Print(string[,] field)
        {
            for(int i = 0; i < field.GetLength(0); i++)
            {
                for(int j = 0; j < field.GetLength(1); j++)
                    System.Console.Write(string.Format("{0} ", field[i, j]));
                
                System.Console.Write("\n");
            }
        }
    }
}
