using NUnit.Framework;

namespace Homeworks.Tests
{
    [TestFixture]
    public class Homework_2Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(12345, 54321)]
        [TestCase(12005, 50021)]
        [TestCase(1040, 0401)]
        public void FlipNumberBackwardsTest(int n, int expected)
        {
            Homework_2 hw2 = new Homework_2();

            int actual = hw2.FlipNumberBackwards(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, -4, '+', 6)]
        [TestCase(10, -4, '-', 14)]
        [TestCase(7, -4, '*', -28)]
        [TestCase(10, 4, '/', 2.5f)]
        public void SubstituteSignеTest(float a, float b, char sign, float expected)
        {
            Homework_2 hw2 = new Homework_2();
            float actual = hw2.SubstituteSign(a, b, sign);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 })]
        [TestCase(22, new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711 })]
        public void FibonacciOfNumberTest(int n, int[] expected)
        {
            Homework_2 hw2 = new Homework_2();

            int[] actual = hw2.FibonacciOfNumber(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 12, 23, 34, 45, 56, 98, 76, 65, 645 }, new int[] { 645, 8 })]
        [TestCase(new int[] { 12, 23, 34, 45, 200, 98, 76 }, new int[] { 200, 4 })]
        [TestCase(new int[] { 765, 23, 34, 45, 56, 98, 76, 65, 645 }, new int[] { 765, 0 })]
        public void FindMaxInArrayTest(int[] arr, int[] expected)
        {
            Homework_2 hw2 = new Homework_2();

            int[] actual = hw2.FindMaxInArray(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 12, 23, 34, 45, 56, 98, 76, 65, 645 }, new int[] { 12, 0 })]
        [TestCase(new int[] { 12, 23, 34, 45, 0, 98, 76 }, new int[] { 0, 4 })]
        [TestCase(new int[] { 234, 23, 34, 45, 56, 98, 76, 65, 9 }, new int[] { 9, 8 })]
        public void FindMinInArray_arrTest(int[] arr, int[] expected)
        {
            Homework_2 hw2 = new Homework_2();

            int[] actual = hw2.FindMinInArray(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 12, 23, 34, 45, 56, 98 }, new int[] { 98, 56, 45, 34, 23, 12 })]
        [TestCase(new int[] { 1, 2, 0, 6, 5 }, new int[] { 5, 6, 0, 2, 1 })]
        public void ReverseArrayTest(int[] arr, int[] expected)
        {
            Homework_2 hw2 = new Homework_2();

            int[] actual = hw2.ReverseArray(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 3, 1, 2 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, 1, 2 })]
        public void SwapArrayPartsTest(int[] arr, int[] expected)
        {
            Homework_2 hw2 = new Homework_2();

            int[] actual = hw2.SwapArrayParts(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 12, 13, 70, 50, 32 }, 35)]
        [TestCase(new int[] { 54, 8, 23, 98, 9, 1 }, 32)]
        [TestCase(new int[] { 54, -8, -23, 98, 9, 1 }, 21)]
        public void CalcArithmeticalMeanTest(int[] arr, int expected)
        {
            Homework_2 hw2 = new Homework_2();

            int actual = hw2.CalcArithmeticalMean(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 12, 13, 70, 50, 32 }, new int[] { 12, 13, 32 })]
        [TestCase(new int[] { 54, 8, 23, 98, 9, 1 }, new int[] { 8, 23, 9, 1 })]
        [TestCase(new int[] { 54, -8, -23, 98, 9, 1 }, new int[] { -8, -23, 9, 1 })]
        public void GetNumbLessAvTest(int[] arr, int[] expected)
        {
            Homework_2 hw2 = new Homework_2();

            int[] actual = hw2.GetNumbLessAv(arr, 35);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 9, 13, 14, 9, 11, 12, 13, 3 }, 7, 2, 45)]
        [TestCase(new int[] { 54, 8, 23, 9, 98, 1 }, 4, 5, 0)]
        [TestCase(new int[] { 54, -80, -23, 3, 9, 100 }, 1, 5, -11)]
        public void GetSumBetweenMinMaxTest(int[] arr, int minResultIndex, int maxResultIndex, int expected)
        {
            Homework_2 hw2 = new Homework_2();

            int actual = hw2.GetSumBetweenMinMax(arr, minResultIndex, maxResultIndex);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10,13, "Загаданое число меньше")]
        [TestCase(10,3, "Загаданое число больше")]
        [TestCase(10,10, "Вы угадали!")]
        public void CheckEqualityTest(int number, int guess, string expected)
        {
            Homework_2 hw2 = new Homework_2();

            string actual = hw2.CheckEquality(number, guess);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 500, 2)]
        [TestCase(43, 200, 21.5 )]
        [TestCase(43, 84, 51.19)]
        public void CalcPercentageTest(int count, int amount, double expected)
        {
            Homework_2 hw2 = new Homework_2();

            double actual = hw2.CalcPercentage(count, amount);
            Assert.AreEqual(expected, actual);

        }

    }
}

