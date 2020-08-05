using System;
using System.Collections.Generic;

namespace Inicials
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Input Fio:");
                string fio = Console.ReadLine();
                
                //one string
                Console.WriteLine($"Inicial one string: {(fio.Split(' ').Length > 0 ? fio.Split(' ')[0] : String.Empty)} {(fio.Split(' ').Length > 1 ? fio.Split(' ')[1].Substring(0, 1) + "." : String.Empty)} {(fio.Split(' ').Length > 2 ? fio.Split(' ')[2].Substring(0, 1) + "." : String.Empty)}");

                //full version
                List<string> words = new List<string>(fio.Split(' '));
                string result = words.Count > 0 ? words[0] + " " : String.Empty;
                words.RemoveRange(0, 1);
                foreach (string word in words)
                        result += String.IsNullOrEmpty(word) ? String.Empty : word.Substring(0, 1) + ". ";
                Console.WriteLine($"Inicial full version: {result}");
                
            }
        }

    }
}
