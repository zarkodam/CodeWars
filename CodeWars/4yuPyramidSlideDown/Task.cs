using System.Collections.Generic;

namespace CodeWars._4yuPyramidSlideDown
{
    public class Task
    {
        public class PyramidSlideDown
        {
            public static int LongestSlideDown(int[][] pyramid)
            {
                var cache = new List<int>(pyramid[pyramid.Length - 1]);

                for (int y = pyramid.Length - 2; y >= 0; y--)
                {
                    var xCache = new List<int>();

                    for (int x = 0; x < pyramid[y].Length; x++)
                    {
                        int currentX = pyramid[y][x];
                        int cacheCurrent = cache[x];
                        int cacheNext = cache[x + 1];

                        if (cacheCurrent > cacheNext) xCache.Add(cacheCurrent + currentX);
                        else xCache.Add(cacheNext + currentX);
                    }

                    cache.Clear();
                    cache.AddRange(xCache);
                }

                return cache[0];
            }
        }

    }
}
