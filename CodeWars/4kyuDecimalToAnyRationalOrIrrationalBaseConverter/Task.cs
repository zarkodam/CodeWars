using System;

namespace CodeWars._4kyuDecimalToAnyRationalOrIrrationalBaseConverter
{
    public class Task
    {
        public static string Convert(double n, int decimals, double nbase)
        {
            const string aplphaUpperNumeric = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            var nAbs = Math.Abs(n);

            int indexToStartWith = 0;

            for (; ; indexToStartWith++)
                if (Math.Pow(nbase, indexToStartWith) > nAbs)
                {
                    indexToStartWith -= 1;
                    break;
                }

            string result = n < 0 ? "-" : "";
            if (indexToStartWith < 0) result += "0.";

            for (int i = indexToStartWith; i >= -decimals; i--)
            {
                double position = Math.Pow(nbase, i);
                int digit = (int)Math.Floor(nAbs / position);

                result += aplphaUpperNumeric[digit];
                nAbs -= position * digit;

                if (i == 0 && -decimals < 0) result += ".";
            }

            return result;
        }
    }
}
