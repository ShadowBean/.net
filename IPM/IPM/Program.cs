using System;
using System.Text.RegularExpressions;

namespace IPM
{
    class Program
    {
        static readonly string patternIP = @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$";
        static readonly string patternMAIL = @"^[_A-Za-z0-9-\+]+(\.[_A-Za-z0-9-]+)*@[A-Za-z0-9-]+(\.[A-Za-z0-9]+)*(\.[A-Za-z]{2,})$";

        static string IP = null;
        static string email = null;

        private static bool Check(in string pattern, in string T)
        {
            Match valid = Regex.Match(T, pattern);
            if(valid.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void Input(out string IP, out string MAIL)
        {
            Console.WriteLine("Wprowadź IP");
            IP = Console.ReadLine();
            Console.WriteLine("Wprowadź email");
            MAIL = Console.ReadLine();

        }

        static void Main()
        {
            Input(out IP, out email);

            if (Check(patternIP, IP))
            {
                Console.WriteLine("IP poprawne");
            }
            else
            {
                Console.WriteLine("IP nie poprawne");
            }

            if (Check(patternMAIL, email))
            {
                Console.WriteLine("Email poprawny");
            }
            else
            {
                Console.WriteLine("Email nie poprawny");
            }
        }
    }
}
