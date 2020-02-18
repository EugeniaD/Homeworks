using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    public class Homework_3
    {
        public int FindNumberOfDigits(int num, int digit)
        {
            int count = 0;
            while (num > 0)
            {
                if (num % 10 == digit)
                {
                    count++;
                    num /= 10;
                }
                else
                {
                    num /= 10;
                }
            }
            return count;
        }

        public string[,] MakeRectangle(int w, int h, string symb1, string symb2)
        {
            string[,] arr = new string[h, w];

            for (int i = 0; i < h; i++)
            {
                if (i == 0 || i == h - 1)
                {
                    for (int j = 0; j < w; j++)
                    {
                        arr[i, j] = symb1;
                    }
                }
                else
                {
                    for (int j = 0; j < w; j++)
                    {
                        if (j == 0 || j == w - 1)
                        {
                            arr[i, j] = symb1;
                        }
                        else
                        {
                            arr[i, j] = symb2;
                        }
                    }
                }
            }
            return arr;
        }

        public string PrintTwoDimensionalArrayString(string[,] arr) // ----------- не делать тест 
        {
            string a = "";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    a += $"{arr[i, j]} ";
                }
                a += "\n";
            }
            return a;
        }
        public string PrintTwoDimensionalArrayInt(int[,] arr) // --------------- не делать тест  
        {
            string a = "";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    a += $"{arr[i, j]} ";
                }
                a += "\n";
            }
            return a;
        }
        public int CountDividers(int number)
        {
            int divCounter = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    divCounter++;
                }
            }
            return divCounter;
        }

        public int[] NumberDividers(int number, int divCount)
        {
            int[] divArr = new int[divCount];
            int counter = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    divArr[counter] = i;
                    counter++;
                }
            }
            return divArr;
        }

        public int[,] FillTwoDimensionalArrayInt(int[,] arr, int min = 0, int max = 100) // ------рандом - не делать тест
        {
            Random rnd = new Random();
            int[,] arrNew = new int[arr.GetLength(0), arr.GetLength(1)];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arrNew[i, j] = rnd.Next(min, max);
                }
            }
            return arrNew;
        }
        public string[,] FillTwoDimensionalArraySrting(string[,] arr, string symb) // -------рандом - не делать тест
        {
            //string[,] arrNew = new string[arr.GetLength(0), arr.GetLength(1)];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = symb;
                }
            }
            return arr;
        }
        public int CountBigNumbers(int[,] arr)
        {
            int bigNumberCounter = 0, miniCounter;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    miniCounter = 0;

                    if (i - 1 > 0 && arr[i - 1, j] < arr[i, j])
                    {
                        miniCounter++;
                    }
                    if (j + 1 < arr.GetLength(1) && arr[i, j + 1] < arr[i, j])
                    {
                        miniCounter++;
                    }
                    if (i + 1 < arr.GetLength(0) && arr[i + 1, j] < arr[i, j])
                    {
                        miniCounter++;
                    }
                    if (j - 1 >= 0 && arr[i, j - 1] < arr[i, j])
                    {
                        miniCounter++;
                    }

                    if (miniCounter == 4)
                    {
                        bigNumberCounter++;
                    }
                }
            }
            return bigNumberCounter;
        }

        public int[] BigNumbersArr(int[,] arr, int amount)
        {
            int miniCounter, count = 0;
            int[] bigNumbers = new int[amount];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    miniCounter = 0;
                    if (i - 1 > 0 && arr[i - 1, j] < arr[i, j])
                    {
                        miniCounter++;
                    }
                    if (j + 1 < arr.GetLength(1) && arr[i, j + 1] < arr[i, j])
                    {
                        miniCounter++;
                    }
                    if (i + 1 < arr.GetLength(0) && arr[i + 1, j] < arr[i, j])
                    {
                        miniCounter++;
                    }
                    if (j - 1 >= 0 && arr[i, j - 1] < arr[i, j])
                    {
                        miniCounter++;
                    }
                    if (miniCounter == 4)
                    {
                        bigNumbers[count] = arr[i, j];
                        count++;
                    }
                }
            }
            return bigNumbers;
        }

        public int[,] SwapDiag(int[,] arr)
        {
            int temp, lehgthI = arr.GetLength(0), lehgthJ = arr.GetLength(1);

            for (int i = 0; i <= lehgthI; i++) // сначала меняем местами
            {
                for (int j = 0; j < lehgthJ; j++)
                {
                    if (i == j)
                    {
                        temp = arr[i, j];
                        arr[i, j] = arr[i, lehgthJ - 1 - j];
                        arr[i, lehgthJ - 1 - j] = temp;
                    }
                }
            }
            return arr;
        }

        public int CheckCells(string[,] arr, int r, int c, string currentMarker)
        {
            int markersCount = 0;
            // --------- проверяем существует и заполнена ли клетка СЛЕВА   -----------------------------------
            if (r - 1 >= 0 && arr[r - 1, c] == currentMarker)
            {
                markersCount = 2; // если заполнена увеличиваем счетчик

                if (r - 2 >= 0 && arr[r - 2, c] == currentMarker) // проверяем клетку за ней  
                {
                    markersCount = 3; // если заполнена увеличиваем счетчик
                }
                else if (r + 1 < 5 && arr[r + 1, c] == currentMarker) // проверяем клетку СПРАВА от начальной
                {
                    markersCount = 3;
                }
            }
            // --------- проверяем существует и заполнена ли клетка СЛЕВА СНИЗУ  ---------------------------------

            if (r - 1 >= 0 && c + 1 < 5 && markersCount != 3 && arr[r - 1, c + 1] == currentMarker)
            {
                markersCount = 2;

                if (r - 2 >= 0 && c + 2 < 5 && arr[r - 2, c + 2] == currentMarker) // проверяем клетку за ней  
                {
                    markersCount = 3;
                }
                else if (r + 1 < 5 && c - 1 >= 0 && arr[r + 1, c - 1] == currentMarker)// проверяем клетку СПРАВА СВЕРХУ от начальной
                {
                    markersCount = 3;
                }
            }
            // --------- проверяем существует и заполнена ли клетка СНИЗУ  ------------------------------
            if (c + 1 < 5 && markersCount != 3 && arr[r, c + 1] == currentMarker)
            {
                markersCount = 2;

                if (c + 2 < 5 && arr[r, c + 2] == currentMarker) // проверяем клетку за ней  
                {
                    markersCount = 3;
                }
                else if (c - 1 >= 0 && arr[r, c - 1] == currentMarker) // проверяем клетку СВЕРХУ от начальной
                {
                    markersCount = 3;
                }
            }
            // --------- проверяем существует и заполнена ли клетка СНИЗУ СПРАВА  ------------------------------
            if (r + 1 < 5 && c + 1 < 5 && markersCount != 3 && arr[r + 1, c + 1] == currentMarker)
            {
                markersCount = 2;

                if (r + 2 < 5 && c + 2 < 5 && arr[r + 2, c + 2] == currentMarker)// проверяем клетку за ней  
                {
                    markersCount = 3;
                }
                else if (r - 1 >= 0 && c - 1 >= 0 && arr[r - 1, c - 1] == currentMarker)// проверяем клетку СЛЕВА СВЕРХУ от начальной
                {
                    markersCount = 3;
                }
            }
            // --------- проверяем существует и заполнена ли клетка СПРАВА  ------------------------------
            if (r + 1 < 5 && markersCount != 3 && arr[r + 1, c] == currentMarker)
            {
                markersCount = 2;

                if (r + 2 < 5 && arr[r + 2, c] == currentMarker)// проверяем клетку за ней  
                {
                    markersCount = 3;
                }
                else if (r - 1 >= 0 && arr[r - 1, c] == currentMarker)// проверяем клетку СЛЕВА от начальной
                {
                    markersCount = 3;
                }
            }
            // --------- проверяем существует и заполнена ли клетка СПРАВА СВЕРХУ  ------------------------------
            if (r + 1 < 5 && c - 1 >= 0 && markersCount != 3 && arr[r + 1, c - 1] == currentMarker)
            {
                markersCount = 2;

                if (r + 2 < 5 && c - 2 >= 0 && arr[r + 2, c - 2] == currentMarker)// проверяем клетку за ней  
                {
                    markersCount = 3;
                }
                else if (r - 1 >= 0 && c + 1 < 5 && arr[r - 1, c + 1] == currentMarker)// проверяем клетку СЛЕВА СНИЗУ от начальной
                {
                    markersCount = 3;
                }
            }
            // --------- проверяем существует и заполнена ли клетка СВЕРХУ  ------------------------------
            if (c - 1 >= 0 && markersCount != 3 && arr[r, c - 1] == currentMarker)
            {
                markersCount = 2;

                if (c - 2 >= 0 && arr[r, c - 2] == currentMarker)// проверяем клетку за ней  
                {
                    markersCount = 3;
                }
                else if (c + 1 < 5 && arr[r, c + 1] == currentMarker)// проверяем клетку СНИЗУ от начальной
                {
                    markersCount = 3;
                }
            }
            // --------- проверяем существует и заполнена ли клетка СЛЕВА СВЕРХУ ------------------------------ 
            if (c - 1 >= 0 && r - 1 >= 0 && markersCount != 3 && arr[r - 1, c - 1] == currentMarker)
            {
                markersCount = 2;

                if (c - 2 >= 0 && r - 2 >= 0 && arr[r - 2, c - 2] == currentMarker)// проверяем клетку за ней 
                {
                    markersCount = 3;
                }
                else if (c + 1 < 5 && r + 1 >= 0 && arr[r + 1, c + 1] == currentMarker)// проверяем клетку СНИЗУ от начальной
                {
                    markersCount = 3;
                }
            }
            return markersCount;
        }


    }
}
