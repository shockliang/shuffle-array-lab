using System;
using System.Linq;

namespace ShuffleArrayLab
{
    public class OrderByShuffle
    {
        public static T[] Shuffle<T>(T[] ary)
        {
            return ary.OrderBy(elem => Guid.NewGuid()).ToArray();
        }
    }
}