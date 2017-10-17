using System;

namespace ShuffleArrayLab
{
    public class FisherYatesShuffle
    {
        private static Random rng = new Random();
        public static void Shuffle<T>(T[] array)
        {
            rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n);
                n--;
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
    }
}