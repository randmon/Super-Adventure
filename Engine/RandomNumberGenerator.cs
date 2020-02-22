using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public static class RandomNumberGenerator
    {
        private static Random _generator = new Random();
        public static int NumberBetween(int minimumValue, int maximumValue)
        {
            return _generator.Next(minimumValue, maximumValue + 1);
        }
    }
}
/* In the simple version, we create a Random object (_generator) and use its Next() method to
get a random value between the minimum and maximum values passed in as parameter. */
