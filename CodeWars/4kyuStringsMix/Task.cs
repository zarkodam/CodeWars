using System;
using System.Linq;

namespace CodeWars._4kyuStringsMix
{
    public class Task
    {
        public class Mixing
        {
            public static string Mix(string s1, string s2)
            {
                string[] grouped1 = s1.Where(i => i > 96 && i < 123).GroupBy(i => i).Select(i => string.Join("", i)).Where(i => i.Length > 1).ToArray();
                string[] grouped2 = s2.Where(i => i > 96 && i < 123).GroupBy(i => i).Select(i => string.Join("", i)).Where(i => i.Length > 1).ToArray();

                string[] sameVals = grouped1.Intersect(grouped2).OrderBy(i => i).ToArray();

                var res = grouped1.Except(sameVals).Select(i => i + "/ 1:").Union(grouped2.Except(sameVals).Select(i => i + "/ 2:")).OrderByDescending(i => i).ThenBy(i => i).ToArray();

                Func<string, string> fixName = s => { string[] split = s.Split(' '); return split.Length > 1 ? split[1] + split[0] : s; };

                Func<string, string, bool> isCurrentAndLastTheSame = (i, j) => i[i.LastIndexOf("/", StringComparison.Ordinal) - 1] == j[0];

                string diff = (res.Any() ? res.Aggregate((i, j) => isCurrentAndLastTheSame(i, j) ? fixName(i) : fixName(i) + fixName(j)) : "");

                string common = sameVals.Length == 1 ? "3:" + sameVals[0] + "/" : (sameVals.Any() ? sameVals.Select(i => i + "/ 3:").Aggregate((i, j) => fixName(i) + fixName(j)) : "");

                return string.Join("/", string.Concat(diff, common).Split('/').OrderByDescending(i => i.Length).ThenBy(i => i)).Replace("3", "=").Replace(" ", "").TrimEnd('/');
            }


            // myjinxin2015
            //public static string Mix(string s1, string s2)
            //{
            //        var index = string.Concat(Regex.Replace((s1 + s2), "[^a-z]", "").Distinct().OrderBy(x => x));
            //    var rs = index
            //    .Where(x => s1.Count(y => y == x) > 1 | s2.Count(y => y == x) > 1)
            //    .Select(x => new Tuple<int, string, char>(Math.Max(s1.Count(y => y == x), s2.Count(y => y == x)), s1.Count(y => y == x) > s2.Count(y => y == x) ? "1:" : s1.Count(y => y == x) < s2.Count(y => y == x) ? "2:" : "=:", x));
            //    return string.Join("/", rs.OrderByDescending(x => x.Item1 * 10000 + (62 - x.Item2[0]) * 100 - x.Item3).Select(x => x.Item2 + new string(x.Item3, x.Item1)));
            //}
        }
    }
}