using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace d2
{
    class Program
    {
        static void Main(string[] args)
        {
            var raw = File.ReadLines("input");

            var validPasswords = 0;

            foreach (string line in raw)
            {
                var tmp = line.Split(":");
                var rule = tmp[0];
                var value = tmp[1];

                var tmp2 = rule.Split(" ");
                var ruleRange = tmp2[0];
                var ruleChar = char.Parse(tmp2[1]);

                var occurrences = value.Where(x => (x == ruleChar)).Count();

                if (int.Parse(ruleRange.Split("-")[0]) <= occurrences && occurrences <= int.Parse(ruleRange.Split("-")[1])) {
                    validPasswords++;
                }
            }

            Console.WriteLine("Result Pt. 1:");
            Console.WriteLine($"{validPasswords}");

            validPasswords = 0;

            foreach (string line in raw)
            {
                var tmp = line.Split(":");
                var rule = tmp[0];
                var value = tmp[1];

                var tmp2 = rule.Split(" ");
                var rulePositions = tmp2[0];
                var ruleChar = char.Parse(tmp2[1]);

                var occurrences = value.Where(x => (x == ruleChar)).Count();

                var p1 = int.Parse(rulePositions.Split("-")[0]);
                var p2 = int.Parse(rulePositions.Split("-")[1]);

                var hits = 0;

                if (value.ElementAt(p1) == ruleChar)
                {
                    hits++;
                }

                if (value.ElementAt(p2) == ruleChar) {
                    hits++;
                }

                if (hits == 1) {
                    validPasswords++;
                }
            }

            Console.WriteLine("Result Pt. 2:");
            Console.WriteLine($"{validPasswords}");
        }
    }
}
