using NUnit.Framework;

namespace Homeworks.Tests
{
    [TestFixture]
    public class Homework_1Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1000000, 20, 0.15, new double[] { 13313, 3195229 })]
        [TestCase(1000000, 10, 0.15, new double[] { 16604, 1992521 })]
        public void CalcCreditPaymentsTest(int loanAmount, int years, double percentage, double[] expected)
        {
            Homework_1 hw1 = new Homework_1();

            double[] actual = hw1.CalcCreditPayments(loanAmount, years, percentage);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 120)]
        [TestCase(1, 1)]
        [TestCase(6, 720)]
        public void CalcFactorialTest(int n, int expected)
        {

            Homework_1 hw1 = new Homework_1();

            int actual = hw1.CalcFactorial(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 4, 5)]
        [TestCase(34, 7, 34.71)]
        [TestCase(2, 77, 77.03)]
        public void CalcHypotenuseTest(double cathet_1, double cathet_2, double expected)
        {
            Homework_1 hw1 = new Homework_1();

            double actual = hw1.CalcHypotenuse(cathet_1, cathet_2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 5, 10, 10, new float[] { 0.625F, 3.75F })]
        [TestCase(2, 3, 4, -1, new float[] { -2, 7 })]
        [TestCase(-8, -6, -4, 0, new float[] { 1.5F, 6F })]
        public void CalcStraightLineEquationTest(float x1, float y1, float x2, float y2, float[] expected)
        {
            Homework_1 hw1 = new Homework_1();

            float[] actual = hw1.CalcStraightLineEquation(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, -8, 7, 36)]
        [TestCase(-17, 0, 0, 0)]
        [TestCase(13, -43, 56, -1063)]
        public void CalcDiscriminantTest(double a, double b, double c, double expected)
        {
            Homework_1 hw1 = new Homework_1();

            double actual = hw1.CalcDiscriminant(a, b, c);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(1, -8, 7, new double[] { 1, 7 })]
        [TestCase(-17, 0, 0, new double[] { 0 })]
        [TestCase(13, -43, 56, new double[] { })]
        public void CalcRootsTest(double a, double b, double c, double[] expected)
        {
            Homework_1 hw1 = new Homework_1();

            double[] actual = hw1.CalcRoots(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 2, 2, 8)]
        [TestCase(-2, 2, 2, -8)]
        [TestCase(2, 0, 2, 0)]
        public void MultTest(int a, int b, int c, int expected)
        {
            Homework_1 hw1 = new Homework_1();
            int actual = hw1.Mult(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 2, 2, 6)]
        [TestCase(-2, 2, 2, 2)]
        [TestCase(2, 0, 2, 4)]
        public void AddTest(int a, int b, int c, int expected)
        {
            Homework_1 hw1 = new Homework_1();
            int actual = hw1.Add(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 2, 2, 11)]
        [TestCase(-2, 2, 2, 5)]
        [TestCase(2, 0, 2, 7)]
        public void CalcMaxPlusThreeTest(int a, int b, int c, int expected)
        {
            Homework_1 hw1 = new Homework_1();
            int actual = hw1.CalcMaxPlusThree(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(70, 32, new int[] { 2, 6 })]
        [TestCase(70, 2, new int[] { 35,0 })]
        [TestCase(-65, -3, new int[] { 21, -2 })]
        public void CalcEuclideanDivisionTest(int a, int b, int[] expected)
        {
            Homework_1 hw1 = new Homework_1();

            int[] actual = hw1.CalcEuclideanDivision(a, b);
            Assert.AreEqual(expected, actual);

            int c = 70, d = 2;
            expected = new int[] { 35, 0 };
            actual = hw1.CalcEuclideanDivision(c, d);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0, 0)]
        [TestCase(2, 2, 1)]
        [TestCase(2, -2, 2)]
        [TestCase(-2, -2, 3)]
        [TestCase(-2, 2, 4)]
        public void DefineQuarterTest(int x, int y, int expected)
        {
            Homework_1 hw1 = new Homework_1();

            int actual = hw1.DefineQuarter(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-4, 8, 10, true)]
        [TestCase(15, 15, 10, false)] 
        [TestCase(4, -7, 10, true)]
        [TestCase(-10, 8, 10, false)]
        public void IsInCircleTest(double x, double y, double r, bool expected)
        {
            Homework_1 hw1 = new Homework_1();

            bool actual = hw1.IsInToCircle(x, y, r);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-10, -33)]
        [TestCase(-2, -2.92)]
        [TestCase(0, 0)]
        [TestCase(2, 1.08)]
        [TestCase(6, -2.28)]
        public void CalcFunctionValuesTest(double x, double expected)
        {
            Homework_1 hw1 = new Homework_1();
            
            double actual = hw1.CalcFunctionValues(x);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(365, 0, new int[] { 36, 5 })]
        [TestCase(36, 2, new int[] { 3, 8 })]
        [TestCase(351, 9, new int[] { 35, 10 })]
        [TestCase(300, 3, new int[] { 30, 3 })]
        public void CalcSumDigitsInNumberTest(int x, int sumRes, int[] expected)
        {
            Homework_1 hw1 = new Homework_1();
            
            int[] actual = hw1.CalcSumDigitsInNumber(x, sumRes);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(365, 0, new int[] { 36, 0 })]
        [TestCase(36, 1, new int[] { 3, 6})]
        [TestCase(352, 9, new int[] { 35,18 })]
        [TestCase(300, 3, new int[] { 30, 0 })]
        public void CalcMultDigitsInNumberTest(int x, int multRes, int[] expected)
        {
            Homework_1 hw1 = new Homework_1();
           
            int[] actual = hw1.CalcMultDigitsInNumber(x, multRes);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(762, 290703)]
        [TestCase(999, 499500)]
        [TestCase(6, 21)]
        public void SumNaturalNumbersTest(int n, int expected)
        {
            Homework_1 hw1 = new Homework_1();
            
            int actual = hw1.SumNaturalNumbers(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(762, 290703)]
        [TestCase(999, 499500)]
        [TestCase(6, 21)]
        public void RightSideOfEquationTest(int n, int expected)
        {
            Homework_1 hw1 = new Homework_1();

            int actual = hw1.RightSideOfEquation(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(762, 762, new int[] { 100000, 0 })]
        [TestCase(999, 2, new int[] { 0, 100000 })]
        [TestCase(6, 6, new int[] { 100000, 0 })]
        public void EquationCheck(int a ,int  b, int[] expected)
        {
            Homework_1 hw1 = new Homework_1();
            int[] actual = hw1.EquationCheck(a, b);
            Assert.AreEqual(expected, actual);

            a = 762;
            b = 62;
            expected = new int[] { 0, 100000 };
            actual = hw1.EquationCheck(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}