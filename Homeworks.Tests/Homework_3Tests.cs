using NUnit.Framework;

namespace Homeworks.Tests
{
    [TestFixture]
    public class Homework_3Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [TestCase(45676668, 6, 4)]
        [TestCase(648763897, 7, 2)]
        [TestCase(326010690, 0, 3)]
        public void FindNumberOfDigitsTest(int num, int digit, int expected)
        {
            Homework_3 hw3 = new Homework_3();

            int actual = hw3.FindNumberOfDigits(num, digit);
            Assert.AreEqual(expected, actual);
        }


         static object[] testDataForRectangleAtr =
         {
               new object[] { 4, 4, "a", "d", new string[,] {
                                                                {"a","a","a","a" },
                                                                {"a","d","d","a" },
                                                                {"a","d","d","a" },
                                                                {"a","a","a","a" } }
               },
               new object[] { 3, 3, "a", "d", new string[,] {
                                                                {"a","a","a" },
                                                                {"a","d","a" },
                                                                {"a","a","a" } }
               },
               new object[] { 5, 3, "*", "-", new string[,] {
                                                                {"*","*","*","*","*" },
                                                                {"*","-","-","-","*" },
                                                                {"*","*","*","*","*" } }
               }
         };

        [TestCaseSource("testDataForRectangleAtr")]
        public void MakeRectangleTest(int w, int h, string symb1, string symb2, string[,] expected)
        {
            Homework_3 hw3 = new Homework_3();
            string[,] actual = hw3.MakeRectangle(w, h, symb1, symb2);
            Assert.AreEqual(expected, actual);
        }  

        [TestCase(45, 6)]
        [TestCase(324, 15)]
        [TestCase(876, 12)]
        public void CountDividersTest(int number, int expected)
        {
            Homework_3 hw3 = new Homework_3();

            int actual = hw3.CountDividers(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(45, 6, new int[] { 1, 3, 5, 9, 15, 45 })]
        [TestCase(324, 15, new int[] { 1, 2, 3, 4, 6, 9, 12, 18, 27, 36, 54, 81, 108, 162, 324 })]
        [TestCase(876, 12, new int[] { 1, 2, 3, 4, 6, 12, 73, 146, 219, 292, 438, 876 })]
        public void NumberDividersTest(int number, int divCount, int[] expected)
        {
            Homework_3 hw3 = new Homework_3();

            int[] actual = hw3.NumberDividers(number, divCount);
            Assert.AreEqual(expected, actual);
        }

        static object[] CountBigNumbersAtr =
    {
               new object[] { new int[,] {
                { 46, 55, 10, 99, 24, 31 },
                { 24 ,41 ,5, 68, 18, 78 },
                { 0 ,16, 42, 91, 91 ,27},
                {61 ,86 ,30 ,24 ,71 ,19},
                {53 ,22, 48, 1, 74, 46},
                {86, 72 ,52 ,24 ,18 ,82} },
                   2
                },

              new object[] { new int[,] {
                {  68, 11, 10, 49, 95, 26 },
                { 99 ,35 ,26, 19, 78, 5 },
                { 66 ,45, 60 ,92, 95, 74},
                {90, 15, 89, 41, 91, 93},
                {52, 10, 21, 84, 76, 39},
                {90, 86, 12, 30, 69, 54} },
                   3
                }
        };
        [TestCaseSource("CountBigNumbersAtr")]
        public void CountBigNumbersTest(int[,] arr, int expected)
        {
            Homework_3 hw3 = new Homework_3();

            int actual = hw3.CountBigNumbers(arr);
            Assert.AreEqual(expected, actual);
        }


        static object[] BigNumbersArrAtr = 
        {
               new object[] { new int[,] {
                { 46, 55, 10, 99, 24, 31 },
                { 24 ,41 ,5, 68, 18, 78 },
                { 0 ,16, 42, 91, 91 ,27},
                {61 ,86 ,30 ,24 ,71 ,19},
                {53 ,22, 48, 1, 74, 46},
                {86, 72 ,52 ,24 ,18 ,82} },
                   2,
                   new int[] { 86, 74 }
                }
        };

        [TestCaseSource("BigNumbersArrAtr")]
        public void BigNumbersArrTest(int[,] arr, int amount, int[] expected)
        {
            Homework_3 hw3 = new Homework_3();
            int[] actual = hw3.BigNumbersArr(arr, amount);
            Assert.AreEqual(expected, actual);
        }


        static object[] SwapDiagAtr =
        {
               new object[] {  new int[,] { 
                                            { 1,2,3,4,5,6 },
                                            { 1,2,3,4,5,6 },
                                            { 1,2,3,4,5,6 },
                                            { 1,2,3,4,5,6 },
                                            { 1,2,3,4,5,6 },
                                            { 1,2,3,4,5,6 } 
                               },
                               new int[,] {
                                            { 6,2,3,4,5,1 },
                                            { 1,5,3,4,2,6 },
                                            { 1,2,4,3,5,6 },
                                            { 1,2,4,3,5,6 },
                                            { 1,5,3,4,2,6 },
                                            { 6,2,3,4,5,1 } 
                               },
               }
        };

        [TestCaseSource("SwapDiagAtr")]
        public void SwapDiagTest(int[,] arr, int[,] expected)
        {
            Homework_3 hw3 = new Homework_3();

            int[,] actual = hw3.SwapDiag(arr);
            Assert.AreEqual(expected, actual);
        }
    }
}

