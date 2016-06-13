using System.Collections.Generic;
using System.Linq;

namespace CodeWars._4kyuValidBraces
{
    public class Task
    {
        public class Brace
        {
            public static bool CurrentClosingWithSecond(List<char> bracesAsChars, int index)
            {
                int bracesDiff = bracesAsChars[index + 1] - bracesAsChars[index];
                return bracesDiff == 1 || bracesDiff == 2;
            }

            private static List<char> _charsBuffer = new List<char>();

            private static void CheckBraces()
            {
                for (int i = 0; i < _charsBuffer.Count - 1; i++)
                {
                    if (!CurrentClosingWithSecond(_charsBuffer, i)) continue;

                    _charsBuffer.RemoveAt(i);
                    _charsBuffer.RemoveAt(i);

                    CheckBraces();
                }
            }

            public static bool ValidBraces(string braces)
            {
                _charsBuffer = braces.Select(i => i).ToList();

                CheckBraces();

                return _charsBuffer.Count == 0;
            }

            // g964
            //public static bool validBraces(String str)
            //{
            //    string prev = "";
            //    while (str.Length != prev.Length)
            //    {
            //        prev = str;
            //        str = str
            //            .Replace("()", String.Empty)
            //            .Replace("[]", String.Empty)
            //            .Replace("{}", String.Empty);
            //    }
            //    return (str.Length == 0);
            //}
        }
    }
}
