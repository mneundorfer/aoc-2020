using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace d1
{
    class Program
    {
        static void Main(string[] args)
        {
            var raw = File.ReadLines("input.txt");
            var entries = raw.Select(int.Parse).ToList();

            for (int i = 0; i < entries.Count; i++)
            {
                for (int j = i + 1; j < entries.Count - i; j++)
                {
                    var result = entries[i] + entries[j];
                    if (result == 2020) {
                        Console.WriteLine("Result Pt. 1:");
                        Console.WriteLine($"{entries[i] * entries[j]}");
                    }
                }
            }

            for (int i = 0; i < entries.Count; i++)
            {
                for (int j = i + 1; j < entries.Count; j++)
                {
                    for (int k = j + 1; k < entries.Count ; k++)
                    {
                        var result = entries[i] + entries[j] + entries[k];
                        if (result == 2020) {
                            Console.WriteLine("Result Pt. 2:");
                            Console.WriteLine($"{entries[i] * entries[j] * entries[k]}");
                        }
                    }
                }
            }
        }
    }
}
