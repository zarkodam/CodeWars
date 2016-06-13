using System;

namespace CodeWars._7kyuGeneticAlgorithmSeries1Generate
{
    public class Task
    {
        private static readonly Random Random = new Random();

        public static string Generate(int length)
        {
            string binaryString = "";

            for (int i = 0; i < length; i++)
                binaryString += Random.Next(0, 2);

            return binaryString;
        }
    }
}
