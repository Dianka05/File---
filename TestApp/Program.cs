using System;
using System.Diagnostics;
using System.IO;
namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Recive();
            Random random = new Random();
            bool isTxtFormat = false;
            string path = "";
            string text = "";
            Console.WriteLine("Create your .txt file \t Write file name like test.txt");
            path = ReadLine("");
            Console.WriteLine("Write something to your file");
            text = ReadLine("");
            string format = FormatAdding(path);
            if (format == ".txt")
                isTxtFormat = true;
            else
                isTxtFormat = false; format = ".txt";
            switch (input[random.Next(input.Length)])
            {
                case "Login: Alioh77, password: 83888":
                    File.WriteAllText(path = (path == null || path == "") ? "test.txt" : path = (isTxtFormat) ? path : path + format, WriteTextToPath(text));
                    break;
                case "Login: Yojoj, password: dd323s":
                    File.WriteAllText(path = (path == null || path == "") ? "test.txt" : path = (isTxtFormat) ? path : path + format, WriteTextToPath(text));
                    break;
                default:
                    Console.WriteLine("non");
                    break;

            }

            Console.WriteLine("Do you want to open file?");
            string ans = ReadLine("");
            if (!string.IsNullOrEmpty(ans))
            {
                switch (ans)
                {
                    case "y":
                        Process.Start("notepad.exe", path = (path == null || path == "") ? "test.txt" : path);
                        break;
                    case "n":
                        Console.WriteLine("Bye =)");
                        break;
                    default:
                        break;
                }
            }
            Console.ReadKey();
        }
        public static string ReadLine(string? input)
        {
            input = Console.ReadLine();
            return !string.IsNullOrEmpty(input) ? input : "nond";
        }
        public static string FormatAdding(string? text)
        {
            string format = "";
            foreach (char s in text = (text == null || text == "") ? "test.txt" : text)
            {
                if (s == '.')
                    format = s.ToString();
                if (s == 't')
                    format = format + s.ToString();
                if (s == 'x')
                    format = format + s.ToString();
            }

            return format;
        }

        public static string[] Recive()
        {
            string[] vs = new string[2] { "Login: Alioh77, password: 83888", "Login: Yojoj, password: dd323s" };
            return vs;
        }

        public static string WriteTextToPath(string? text)
        {
            if (text != null && text != "")
            {
                return text;
            }
            return "Nons";
        }
    }
}