using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    public class Homework_1
    {

        public double[] CalcCreditPayments(int loanAmount, int years, double percentage)
        {
            double monthlyPayment, totalPayment;

            monthlyPayment = (loanAmount * percentage * Math.Pow((1 + percentage), years)) / (12 * (Math.Pow(1 + percentage
                , years) - 1));

            totalPayment = Math.Round(((monthlyPayment * 12) * years));

            double[] payments = new double[] { Math.Round(monthlyPayment), totalPayment };

            return payments;
        }

        public double CalcHypotenuse(double cathet_1, double cathet_2)
        {
            return Math.Round(Math.Sqrt(Math.Pow(cathet_1, 2) + Math.Pow(cathet_2, 2)), 2);
        }

        public float[] CalcStraightLineEquation(float x1, float y1, float x2, float y2)
        {
            float k, b;
            k = (y2 - y1) / (x2 - x1);
            b = y1 - k * x1;

            float[] result = new float[] { k, b };
            return result;
        }

        public double CalcDiscriminant(double a, double b, double c)
        {
            double discriminant = Math.Pow(b, 2) - 4 * a * c;
            return discriminant;
        }

        public double[] CalcRoots(double a, double b, double c)
        {
            double x1, x2, discriminant;
            discriminant = CalcDiscriminant(a, b, c);
            double[] result = new double[] { };

            if (discriminant > 0)
            {
                x1 = Math.Round((-b - Math.Sqrt(discriminant)) / (2 * a), 3);
                x2 = Math.Round((-b + Math.Sqrt(discriminant)) / (2 * a), 3);
                result = new double[] { x1, x2 };
            }
            else if (discriminant == 0)
            {
                x1 = Math.Round(-(b / (2 * a)), 3);
                result = new double[] { x1 };
            }
            return result;
        }

        public int Mult(int a, int b, int c)
        {
            int result = a * b * c;
            return result;
        }

        public int Add(int a, int b, int c)
        {
            int result = a + b + c;
            return result;
        }

        public int CalcMaxPlusThree(int a, int b, int c)
        {
            int result = 0, sum = a + b + c, mult = a * b * c;

            if (sum > mult)
            {
                result = sum + 3;
            }
            else if (sum < mult)
            {
                result = mult + 3;
            }

            return result;
        }

        public int[] CalcEuclideanDivision(int a, int b)
        {
            int quotient, remainder = 0;

            if (a % b == 0)
            {
                quotient = a / b;
            }
            else
            {
                remainder = a % b;
                quotient = a / b;
            }

            int[] arr = new int[] { quotient, remainder };
            return arr;

        }
        public int DefineQuarter(int x, int y)
        {
            int quarter = 0;

            if (x > 0 && y > 0)
            {
                quarter = 1;
            }
            else if (x > 0 && y < 0)
            {
                quarter = 2;
            }
            else if (x < 0 && y < 0)
            {
                quarter = 3;
            }
            else if (x < 0 && y > 0)
            {
                quarter = 4;
            }
            return quarter;
        }

        public bool IsInToCircle(double x, double y, double r)
        {
            double hypotenuse = CalcHypotenuse(x, y);

            return r > hypotenuse;
        }

        public int CalcFactorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        public double CalcFunctionValues(double x)
        {
            double y = Math.Round((-0.23 * Math.Pow(x, 2) + x), 2);
            return y;
        }

        public int[] CalcSumDigitsInNumber(int x, int sumRes)
        {
            sumRes += x % 10;
            x /= 10;
            int[] result = new int[] { x, sumRes };
            return result;
        }

        public int[] CalcMultDigitsInNumber(int x, int multRes)
        {
            multRes *= x % 10;
            x /= 10;
            int[] result = new int[] { x, multRes };
            return result;
        }

        public int SumNaturalNumbers(int n)
        {
            int result = 0;
            for (int i = 0; i <= n; i++)
            {
                result += i;
            }
            return result;
        }

        public int RightSideOfEquation(int n)
        {
            int right = n * (n + 1) / 2;
            return right;
        }

        public int[] EquationCheck(int a, int b, int amount = 100000)
        {
            int counterTrue = 0, counterFalse = 0;

            for (int i = 0; i < amount; i++)
            {
                if (a == b)
                {
                    counterTrue++;
                }
                else
                {
                    counterFalse++;
                }
            }
            int[] result = new int[2] { counterTrue, counterFalse };
            return result;
        }
    }
}
