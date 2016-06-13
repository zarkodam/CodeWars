using System.Text.RegularExpressions;

namespace CodeWars._6kyuErmahgerd
{
    public class Task
    {
        public static string Ermahgerd(string text)
        {
            string textUpper = text.ToUpper();
            string vowelReplacemenet = Regex.Replace(textUpper, "[AEIOU]", "ER");
            string[] inLines = Regex.Split(vowelReplacemenet, "([A-Z0-1]+)");

            string result = "";

            foreach (var line in inLines)
            {
                var fixedLine = line.Replace("MY", "MAH");
                fixedLine = fixedLine.Replace("ERER", "ER").Replace("ERH", "ER");
                fixedLine = fixedLine.Replace("RR", "R");

                if (fixedLine.Length > 2 && fixedLine.EndsWith("ER"))
                {
                    result += Regex.Replace(fixedLine, @"([ER]{2})\b", "");
                    continue;
                }

                result += fixedLine;
            }

            return result;
        }

        // Streetmentioner
        //public static string Ermahgerd(string text)
        //{
        //    // Add your code here...
        //    text = text.ToUpper();
        //    text = Regex.Replace(text, "[AEIOU]", "ER");
        //    text = Regex.Replace(text, "ERER|ERH", "ER");
        //    text = Regex.Replace(text, "MY", "MAH");
        //    text = Regex.Replace(text, "RR", "R");
        //    text = Regex.Replace(text, @"\b(\w{4,})ER\b", "$1");
        //    return text;
        //}
    }
}
