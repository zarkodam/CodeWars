namespace CodeWars._4kyuCountingChangeCombinations
{
    public class Task
    {
        public static int CountCombinations(int money, int[] coins)
        {
            return HandleCombinations(money, coins, 0);
        }

        public static int HandleCombinations(int money, int[] coins, int currentIndex)
        {
            if (money == 0) return 1;
            if (money < 0 || coins.Length == currentIndex) return 0;

            int withFirstCoin = HandleCombinations(money - coins[currentIndex], coins, currentIndex);
            int withoutFirstCoin = HandleCombinations(money, coins, currentIndex + 1);

            return withFirstCoin + withoutFirstCoin;
        }

    }
}
