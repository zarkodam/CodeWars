namespace CodeWars._6kyuFibonacciTribonacciAndFriends
{
    public class Task
    {
        // Description:

        // If you have completed the Tribonacci sequence kata, you would know by now that mister Fibonacci has at least a bigger brother.If not, give it a quick look to get how things work.
        // Well, time to expand the family a little more: think of a Quadribonacci starting with a signature of 4 elements and each following element is the sum of the 4 previous, a Pentabonacci(well Cinquebonacci would probably sound a bit more italian, but it would also sound really awful) with a signature of 5 elements and each following element is the sum of the 5 previous, and so on.
        // Well, guess what? You have to build a Xbonacci function that takes a signature of X elements - and remember each next element is the sum of the last X elements - and returns the first n elements of the so seeded sequence.

        public static double[] Xbonacci(double[] signature, int n)
        {
            if (n == 0) return new double[] { };

            double[] result = new double[n];

            for (int i = 0; i < n; i++)
            {
                if (i < signature.Length) result[i] = signature[i];

                else
                    for (int j = 1; j < signature.Length + 1; j++)
                        result[i] += result[i - j];
            }

            return result;
        }
    }
}
