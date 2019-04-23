using System;
using System.Threading;

namespace Magic8
{
    class Program
    {
        static void Main(string[] args)
        {
            string v = "* Magic 8 Ball *";
            Console.SetCursorPosition((Console.WindowWidth - v.Length) / 2, Console.CursorTop);
            Console.WriteLine(v);
            Console.WriteLine(" ");
            string text = "The Magic 8 Ball \nPress ENTER for an answer\n";
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(75);
            }
            string x = Console.ReadLine();
            int z = 0;

            while(x != "q" || x != "Q")
            {
                z++;
                Console.Clear();
                Console.SetCursorPosition((Console.WindowWidth - v.Length) / 2, Console.CursorTop);
                Console.WriteLine(v);
                Console.WriteLine(" ");
                string s = Magic8();
                Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                Console.WriteLine(s);
                Console.WriteLine(" ");
                Console.WriteLine($"Answers count = {z}");
                Console.WriteLine("Press ENTER for a new answer");
                x = Console.ReadLine();
            }
        }

        private static string Magic8()
        {
            string x = "";
            string[] y = { "It is certain.", "Without a doubt.", "Outlook good.", "Signs point to yes.",
            "Ask again later.", "Cannot predict now.", "Don't count on it.", "My sources say no."};
            Random rng = new Random();
            int n = rng.Next(0, 8);

            x = y[n];

            return x;
        }
    }
}
