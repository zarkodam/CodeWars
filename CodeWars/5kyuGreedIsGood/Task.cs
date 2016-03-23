namespace CodeWars._5kyuGreedIsGood
{

    // Greed is a dice game played with five six-sided dice.Your mission, should you choose to accept it, is to score a throw according to these rules. You will always be given an array with five six-sided dice values.
    // Three 1's => 1000 points
    // Three 6's =>  600 points
    // Three 5's =>  500 points
    // Three 4's =>  400 points
    // Three 3's =>  300 points
    // Three 2's =>  200 points
    // One   1   =>  100 points
    // One   5   =>   50 point

    // A single dice can only be counted once in each roll.For example, a "5" can only count as part of a triplet (contributing to the 500 points) or as a single 50 points, but not both in the same roll.
    // Throw       Score
    // ---------   ------------------
    // 5 1 3 4 1   50 + 2 * 100 = 250
    // 1 1 1 3 1   1000 + 100 = 1100
    // 2 4 4 5 4   400 + 50 = 450

    public class Task
    {
        public static class Kata
        {
            public static int Score(int[] dice)
            {
                int[] diceVal = new int[7];

                int result = 0;

                for (int i = 0; i < 5; i++)
                {
                    diceVal[dice[i]] += 1;

                    if (diceVal[dice[i]] == 3) result += dice[i] * 100;
                }

                result += diceVal[1] * 100;
                if (diceVal[1] >= 3) result += 900 - 300;
                result += diceVal[5] * 50;
                if (diceVal[5] >= 3) result -= 150;

                return result;
            }

            // _Alexey_
            //public static int Score(int[] dice)
            //{
            //    return Enumerable.Range(1, 7).Select(x => dice.Count(y => y == x) >= 3 ? (x == 1 ? 1000 : x * 100) : 0).Sum() + Enumerable.Range(1, 7).Select(x => ((x == 1 || x == 5) && dice.Count(y => y == x) % 3 != 0) ? (x == 1 ? 100 * (dice.Count(y => y == x) % 3) : x == 5 ? 50 * (dice.Count(y => y == x) % 3) : 0) : 0).Sum();
            //}
        }
    }
}
