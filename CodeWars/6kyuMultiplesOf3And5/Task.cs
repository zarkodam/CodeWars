namespace CodeWars._6kyuMultiplesOf3And5
{
    public class Task
    {
        public static int Solution(int value)
        {
            int result = 0;

            for (int i = value - 1; i >= 0; i--)
                if (i % 3 == 0 || i % 5 == 0)
                    result += i;

            return result;
        }
    }
}
