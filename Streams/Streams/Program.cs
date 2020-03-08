using System;
using System.IO;

namespace Streams
{
    class Program
    {
        static string dir = @"c:\MyDir";
        static string file = @"c:\MyDir\MyTest.txt";
        static string text = null;

        public static void CreateFile()
        {
            try
            {
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                    Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(dir));
                }
                if (!File.Exists(file))
                {
                    File.Create(file).Close();
                    Console.WriteLine("The directory was created successfully at {0}.", File.GetCreationTime(dir));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
        }

        public static void InputWord()
        {
                Console.WriteLine("Input string");
                text = Console.ReadLine();
        }

        public static void ChangeWord()
        {
            string text = File.ReadAllText(file);
            Console.WriteLine("Input string to replace");
            string some = Console.ReadLine();
            Console.WriteLine("Input string as result");
            string value = Console.ReadLine();
            text = text.Replace(some, value);
            File.WriteAllText(file, text);
        }

        public static void SaveToFile()
        {
            File.WriteAllText(file, text);
            Console.WriteLine("The text was saved at {0}.", File.GetLastWriteTime(file));
        }

        public static void ReadFile()
        {
            string text = File.ReadAllText(file);
            Console.WriteLine("Your file\n"+text);
            
        }

        static void Main()
        {
            CreateFile();
            InputWord();
            SaveToFile();
            ReadFile();
            ChangeWord();
            ReadFile();
        }

       
    }
}
