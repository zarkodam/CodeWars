using System;
using System.Data;

namespace CodeWars.BetaMyBEDMASApprovedCalculator
{
    public class Task
    {
        public static double Calculate(string s)
        {
            //Console.WriteLine(new DataTable().Compute(s, ""));
            return new BedmasApprovedCalculator().Calculate(s);
        }
    }
}
