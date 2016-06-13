using System;

namespace CodeWars
{
    class Program
    {
        //public static void

        public static string Run(Func<string, double> fitness, int length, double p_c, double p_m, int iterations = 100)
        {
            Console.WriteLine(fitness);
            return "";
        }


        static void Main(string[] args)
        {
            //// 6kyuVasyaClerk
            //Console.WriteLine(Task.Line.Tickets(new[] { 25, 25, 25, 25, 50, 100, 50 }));
            //Console.WriteLine(Task.Line.Tickets(new[] { 25, 25, 25, 25, 25, 25, 25, 50, 50, 50, 100, 100, 100, 100 }));
            //Console.WriteLine(Task.Line.Tickets(new[] { 25, 25, 50, 50, 100 }));
            //Console.WriteLine(Task.Line.Tickets(new[] { 25, 25, 25, 25, 25, 100, 100 }));
            //Console.WriteLine(Task.Line.Tickets(new[] { 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 }));
            //Console.WriteLine(Task.Line.Tickets(new[] { 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 }));
            //Console.WriteLine(Task.Line.Tickets(new[] { 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 }));
            //Console.WriteLine(Task.Line.Tickets(new[] { 25, 25, 25, 25, 50, 100, 50 }));
            //Console.WriteLine(Task.Line.Tickets(new[] { 50, 100, 100 }));
            //Console.WriteLine(Task.Line.Tickets(new[] { 25, 25, 25, 25, 25, 25, 25, 50, 50, 50, 100, 100, 100, 100 }));

            //// 6kyuTribonacciSequence
            //Console.WriteLine(string.Join(", ", Task.Xbonacci.Tribonacci(new double[] { 0, 4, 5 }, 0)));

            //// 6kyuIqTest
            //Console.WriteLine(string.Join(", ", Task.Iq.Test("1 18 1 1")));

            // 5kyuGreedIsGood
            //Console.WriteLine(Task.Kata.Score(new[] { 1, 1, 1, 1, 1 }));

            // 5kyuTicTacToe
            //Console.WriteLine(Task.TicTacToe.IsSolved(new[,]
            //{
            //    { 2, 1, 1 },
            //    { 0, 1, 1 },
            //    { 2, 2, 2 }
            //}));

            //2 1 2
            //2 1 1
            //1 2 1

            //Console.WriteLine(Task.TicTacToe.IsSolved(new[,]
            //{
            //    { 2, 2, 2 },
            //    { 0, 1, 1 },
            //    { 1, 0, 0 }
            //}));

            //Console.WriteLine(Task.SumStrings("00103", "08567"));


            //Console.WriteLine("2:eeeee/2:yy/=:hh/=:rr");
            //Console.WriteLine(Task.Mixing.Mix("Are they here", "yes, they are here"));

            //Console.WriteLine("1:ooo/1:uuu/2:sss/=:nnn/1:ii/2:aa/2:dd/2:ee/=:gg");
            //Console.WriteLine(Task.Mixing.Mix("looping is fun but dangerous", "less dangerous than coding"));

            //Console.WriteLine("1:aaa/1:nnn/1:gg/2:ee/2:ff/2:ii/2:oo/2:rr/2:ss/2:tt");
            //Console.WriteLine(Task.Mixing.Mix(" In many languages", " there's a pair of functions"));

            //Console.WriteLine("1:ee/1:ll/1:oo");
            //Console.WriteLine(Task.Mixing.Mix("Lords of the Fallen", "gamekult"));

            //Console.WriteLine("");
            //Console.WriteLine(Task.Mixing.Mix("codewars", "codewars"));

            //Console.WriteLine("1:nnnnn/1:ooooo/1:tttt/1:eee/1:gg/1:ii/1:mm/=:rr");
            //Console.WriteLine(Task.Mixing.Mix("A generation must confront the looming ", "codewarrs"));

            //Console.WriteLine("2:nnn/2:rrr/1:jj/1:kk/=:bb/=:ll/=:ss/=:ww");
            //Console.WriteLine(Task.Mixing.Mix(";ydfqSwajl0uskbVklpoBrjwn)bnsv", "Agrls1okws1dria&nvle?bbnwJpfrn"));


            // 4kyuPascalTriangle
            //Console.WriteLine(string.Join(", ", Task.PascalsTriangle(10)));

            // 7kyuVampireNumbers
            //Task.VampireTest(10, 11);

            // 6kyuFibonacciTribonacciAndFriends
            // Console.WriteLine(string.Join(", ", Task.Xbonacci(new double[] { 10, 6, 4, 17, 7, 18, 4, 17, 11, 16, 11, 1, 3, 4, 10, 17 }, 22)));

            // 4kyuNextBiggerNumberWithSameDigits
            //Task.Kata.NextBiggerNumber(9876543210);
            //Task.Kata.NextBiggerNumber(9876543201);


            //3kyuCanYouGetTheLoop
            //var loopDetector = new LoopDetector();
            //LoopDetector.Node rootNode = new LoopDetector.Node();
            //loopDetector.CreateChain(300, 30, rootNode, rootNode);
            //Console.WriteLine(Task.GetLoopSize(rootNode));

            //3kyuAlphabeticAnagrams
            //var stopwatch = new Stopwatch();
            //stopwatch.Start();

            //Console.WriteLine(Task.ListPosition("question"));
            //Console.WriteLine(Task.ListPosition("BOOKKEEPER"));

            //stopwatch.Stop();
            //Console.WriteLine("Time elapsed: " + stopwatch.ElapsedMilliseconds);

            // 2kyuBinaryGeneticAlgorithm
            //Func<string, double> fitness = i => 0.047619047619047616;
            //var geneticAlgorithm = new Task.GeneticAlgorithm();
            //Console.WriteLine(geneticAlgorithm.Run(fitness, 35, 0.6, 0.002, 100));

            // 7kyuGeneticAlgorithmSeries1Generate
            //Console.WriteLine(Task.Generate(4));

            // 7kyuGeneticAlgorithmSeries2Mutation
            //Console.WriteLine(Task.Mutate("1111", 1));

            // 7kyuGeneticAlgorithmSeries3Crossover
            //Console.WriteLine(Task.Crossover("1011011001111", "1011100100110", 4).First());
            //Console.WriteLine(Task.Crossover("1011011001111", "1011100100110", 4).Last());

            // 6kyuGeneticAlgorithmSeries5RouletteWheelSelection
            //Task.Select(new[] { "1", "2", "3" }, new[] { 0.05, 0.05, 0.90 });

            // 4kyuRomanNumeralsDecoder
            //Console.WriteLine(Task.Solution("MCMLIV"));
            //Console.WriteLine(Task.Solution("MMVIII"));

            // BetaMyBEDMASApprovedCalculator
            //Console.WriteLine(Task.Calculate("3+4*2"));
            //Console.WriteLine(Task.Calculate("5 + ((1 + 2) * 4) - 3"));
            //Console.WriteLine(bedmasApprovedCalculator.ReversePolishCalc(result));
            //Console.WriteLine(bedmasApprovedCalculator.ReversePolishCalc("0 -4 3 + - 5 -2 * +"));
            //Console.WriteLine(bedmasApprovedCalculator.InfixToRpnConverter("((((-4 + 3) * 5) - 3) * -61)"));
            //Console.WriteLine(Task.Calculate("3 * (4 + (2 / 3) * 6 - 5)"));
            //Console.WriteLine(Task.Calculate("3 + 5 * 2"));
            //Console.WriteLine(Task.Calculate("5 - 3 * 8 / 8"));
            //Console.WriteLine(Task.Calculate("6*(2 + 3)"));
            //Console.WriteLine(Task.Calculate("2^5"));
            //Console.WriteLine(Task.Calculate("3 + 5 * 2"));
            //Console.WriteLine(Task.Calculate("5 - 3 * 8 / 8"));
            //Console.WriteLine(Task.Calculate("6*(2 + 3)"));
            //Console.WriteLine(Task.Calculate("3 * (4 + (2 / 3) * 6 - 5)"));
            //Console.WriteLine(Task.Calculate("123 - ( 4 * ( 3 - 1) * 8 - 8 / ( 1 + 1 ) * (3 - 1) )"));
            //Console.WriteLine(Task.Calculate("123 -( 4^ ( 3 - 1) * 8 - 8 /( 1 + 1 ) *(3 -1) )"));
            //Console.WriteLine(Task.Calculate("4 + 2 * ( (226 - (5 * 3) ^ 2) ^ 2 + (10,7 - 7,4) ^ 2 - 6,89)"));
            //Console.WriteLine(Task.Calculate("4 + 2 * ( (226 - (5 * 3) + 2) + 2 + (10 - 7) + 2 - 6)"));

            // 4kyuReversePolishNotationCalculator
            //Console.WriteLine(Task.Evaluate("5 1 2 + 4 * + 3 -"));

            // StringCalculator
            //var infixToRpnParser = new InfixToReversePolishParser();
            //string result = infixToRpnParser.Parse("(1 +1  + - 2) + -(-(-4987) + (2+3 + ((6544))))");
            //string result = infixToRpnParser.Parse("12* 123/-(-5 + 2)");
            //string result = infixToRpnParser.Parse("(123,45*(678,90 / (-2,5+ 11,5)-(((80 -(19))) *33,25)) / 20)");
            //string result = infixToRpnParser.Parse("(123,45*(678,90 / (-2,5+ 11,5)-((80 -(19)) *33,25)) / 20) - (123,45*(678,90 / (-2,5+ 11,5)-((80 -(19)) *33,25)) / 20) + (13 - 2)/ -(-11)");
            //string result = infixToRpnParser.Parse("((((60))) + ((60)))");
            //string result = infixToRpnParser.Parse("123,45 * (678,90 / (-2,5 + 11,5) - (80 - 19) * 33,25) / 20");
            //Console.WriteLine(result);

            //var reversePolishCalc = new ReversePolishCalculator();
            //Console.WriteLine(reversePolishCalc.Calculate("123.45 678.90 -2.5 11.5 + / 80 19 - 33.25 * - 20 / *"));
            //Console.WriteLine(reversePolishCalc.Calculate(result));

            // 4kyuValidBraces
            //Task.Brace.ValidBraces("({})[({})]");

            // 4kyuBaseConversion
            //Console.WriteLine(Convert.ToString(3, 4));
            //Console.WriteLine(Task.GetBaseTen("2301", "01234"));
            //Console.WriteLine(Task.GetBaseTen("1111", "01"));
            //Task.ConvertFromBaseTen(223, 5);
            //Console.WriteLine(Task.Convert("CodeWars", "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ", "01"));

            //Console.WriteLine(1 * Math.Pow(Math.PI, 3) + 3 * Math.Pow(Math.PI, 2) + (Math.PI - 1) * Math.Pow(Math.PI, 0) + 1 * Math.Pow(Math.PI, -1));


            //Task.Convert("CodeWars", "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ", "01");

            //Console.WriteLine(Char.ConvertFromUtf32(7414));

            //// hex to int
            //string hexString = "8E2";
            //int num = int.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
            //Console.WriteLine(num);

            // 4kyuCountingChangeCombinations
            //Console.WriteLine(Task.CountCombinations(1000, new[] { 1, 2 }));

            // 4kyuHammingNumbers
            //Console.WriteLine(Task.Hamming(18));

            // 7kyuNumbersWhichSumOfPowersOfItsDigitsIsTheSameNumber
            //Console.WriteLine(string.Join(", ", Task.EqSumPowDig(370, 3)));

            // 6kyuRaiseMeToTheThirdPowerSearchMyDivisors
            //var stp = new Stopwatch();
            //stp.Start();
            //const int numb = 2;
            //Console.WriteLine(Task.IntCubeSumDiv(numb));
            //Console.WriteLine("\nElapsed time: {0}ms", stp.ElapsedMilliseconds);

            // 6kyuWhenSigma1FunctionHasEqualsValuesForAnntegerAndItsReversedOne
            //Console.WriteLine(Task.EqualSigma1(917));

            // 6kyuMultiplesOf3And5
            //Console.WriteLine(Task.Solution(10));

            // 6kyuLucasNumbers
            //var fast = new Stopwatch();
            //fast.Start();
            //Console.WriteLine(Task.Lucasnum(40));
            //fast.Stop();
            //Console.WriteLine("Elapsed time: {0}ms", fast.ElapsedMilliseconds);

            // 6kyuErmahgerd
            //Console.WriteLine(Task.Ermahgerd("ohmygod javascript, haskell, python, ruby, java, c sharp, clojure, coffeescript!! I love them all!!"));

            // 4kyuDecimalToAnyRationalOrIrrationalBaseConverter
            //Console.WriteLine(Task.Convert(13, 3, Math.PI));

            // 4yuPyramidSlideDown
            //Console.WriteLine(Task.PyramidSlideDown.LongestSlideDown(new[]
            //    {
            //      new[]    {3},
            //      new[]   {7, 4},
            //      new[]  {2, 4, 6},
            //      new[] {8, 5, 9, 3}
            //  }));

            Console.ReadLine();
        }
    }
}
