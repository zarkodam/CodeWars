using System.Text.RegularExpressions;

namespace CodeWars._5kyuConvertStringToCamelCase
{
    public class Task
    {
        public static string ToCamelCase(string str)
        {
            string[] cleanString = new Regex("[^a-zA-Z]").Replace(str, " ").Split(' ');
            string result = cleanString[0];

            for (int i = 1; i < cleanString.Length; i++)
                result += char.ToUpper(cleanString[i][0]) + cleanString[i].Substring(1);

            return result;
        }
    }
}
