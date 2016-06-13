using System.Collections.Generic;

namespace CodeWars._4kyuRomanNumeralsDecoder
{
    public class Task
    {
        public static int Solution(string roman)
        {
            var romanNumberWithValue = new Dictionary<char, int>
            {
                {'I', 1 },
                {'V', 5 },
                {'X', 10 },
                {'L', 50 },
                {'C', 100 },
                {'D', 500 },
                {'M', 1000 },
                {'0', 0 }
            };

            int result = 0;

            bool isCurrentLowerThanNext = false;

            int numberLength = roman.Length;

            for (int i = 0; i < numberLength; i++)
            {
                if (isCurrentLowerThanNext)
                {
                    isCurrentLowerThanNext = false;
                    continue;
                }

                char current = roman[i];

                if (i == numberLength - 1)
                {
                    result += romanNumberWithValue[current];
                    break;
                }

                char next = roman[i + 1];

                if (romanNumberWithValue[current] >= romanNumberWithValue[next])
                    result += romanNumberWithValue[current];
                else
                {
                    result += romanNumberWithValue[next] - romanNumberWithValue[current];
                    isCurrentLowerThanNext = true;
                }
            }

            return result;
        }
    }
}
