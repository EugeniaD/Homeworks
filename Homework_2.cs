using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    public class Homework_2
    {        
        public int FlipNumberBackwards(int n)
        {
            string a = "";
            int result;

            while (n > 0)
            {
                int x = n % 10;
                n /= 10;

                a += Convert.ToString(x);
            }

            result = Convert.ToInt32(a);
            return result;
        }

        public float SubstituteSign(float a, float b, char sign)
        {
            float result = 0;
            if (sign == '+')
            {
                result = a + b;
            }
            else if (sign == '-')
            {
                result = a - b;
            }
            else if (sign == '*')
            {
                result = a * b;
            }
            else if (sign == '/')
            {
                result = a / b;
            }
            return result;
        }

        public int CheckRandom(int amount) // -------------- не делать тест ?
        {
            int n, count = 0;
            Random rnd = new Random();

            for (int i = 0; i < amount; i++)
            {
                n = rnd.Next(-100, 100);
                if (n % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        public double CalcPercentage(int count, int amount)  
        {
            double perc = Math.Round(( count * 100.0 / amount),2);
            return perc;
        }

        public string CheckEquality(int number, int guess)  
        {
            string result;
            if (guess > number)
            {
                result = "Загаданое число меньше";
            }
            else if (guess < number)
            {
                result = "Загаданое число больше";
            }
            else
            {
                result = "Вы угадали!";
            }
            return result;

        }

        public int[] FibonacciOfNumber(int number)
        {
            int fib = 2, fib1 = 1, x;
            int [] fibArr = new int[number] ;
            fibArr[0] = 1;

            for (int i = 1; i < number; i++)
            {
                if (i < 2)
                {
                    fibArr[i] = i;
                }
                else
                {
                    x = fib1;
                    fib1 = fib;
                    fib = x + fib1;
                    fibArr[i]= fib1;
                }
            }
            return fibArr;
        }

        public int[] FillArray(int length,int min = 0, int max = 100) // ----------- не делать тест ?
        {
            int[] arr = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(min, max);
            }
            return arr;
        }

        public string PrintArray(int[] arr) // -------------- не делать тест ?
        {
            string a = "";

            for (int i = 0; i < arr.Length; i++)
            {
                a += $"{arr[i]} ";
            }
            return a;
        }

        public int[] FindMaxInArray(int[] arr)
        {
            int max = arr[0], index = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (max < arr[i + 1])
                {
                    max = arr[i + 1];
                    index = i + 1;
                }
            }
            int[] result = new int[] { max, index };
            return result;
        }

        public int[] FindMinInArray(int[] arr)
        {
            int min = arr[0], index = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (min > arr[i + 1])
                {
                    min = arr[i + 1];
                    index = i + 1;
                }                
            }
            int[] result = new int[] { min, index };
            return result;
        }

        public int[] ReverseArray(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }
            return arr;
        }

        public int[] SwapArrayParts(int[] arr)
        {
            int middle = arr.Length / 2, temp;

            for (int i = 0; i < arr.Length / 2; i++)
            {
               temp = arr[i];
                if (arr.Length % 2 == 0) //even
                {
                    arr[i] = arr[middle];
                    arr[middle] = temp;
                }
                else //odd
                {
                    arr[i] = arr[middle + 1];
                    arr[middle + 1] = temp;
                }
                middle++;
            }
            return arr;
        }

        public int CalcArithmeticalMean(int[] arr)
        {
            int sum = 0, mean;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            mean = sum / arr.Length;
            return mean;
        }

        public int[] GetNumbLessAv(int[] arr, int arithmMean)
        {
            int count = 0, counter=0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arithmMean)
                {
                    count++;
                }
            }
            
            int[] lessAvArr = new int[count];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arithmMean)
                {
                    lessAvArr[counter] = arr[i];
                    counter++;
                }
            }
            return lessAvArr;
        }

        public int GetSumBetweenMinMax(int[] arr, int minResultIndex, int maxResultIndex)
        {
            int sum = 0;
            if (minResultIndex < maxResultIndex)
            {
                for (int i = minResultIndex + 1; i <= maxResultIndex - 1; i++)
                {
                    sum += arr[i];
                }
            }
            else
            {
                for (int i = maxResultIndex + 1; i <= minResultIndex - 1; i++)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
    }
}
