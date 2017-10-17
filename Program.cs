using System;
using System.Collections.Generic;

namespace ShuffleArrayLab
{
    class Program
    {
        private static Dictionary<string, int> outcomeRecord = new Dictionary<string, int>();
        static void Main(string[] args)
        {
            int[] ary = new int[] { 0, 1, 2 };

            for (int i = 0; i < 6000000; i++)
            {
                // ary.Shuffle();
                // new Random().Shuffle(ary);
                FisherYatesShuffle.Shuffle<int>(ary);
                WhichOutcome(ary);
            }

            PrintOutcomes();
        }

        private static void PrintOutcomes()
        {
            foreach (var item in outcomeRecord)
            {
                System.Console.WriteLine($"[{item.Key}]:{item.Value}");
            }
        }

        private static void WhichOutcome(int[] ary)
        {
            string key = String.Join("-", ary);

            if (outcomeRecord.ContainsKey(key))
                outcomeRecord[key]++;
            else
                outcomeRecord.Add(key, 1);
        }
    }
}
