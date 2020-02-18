using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    public class Gauss
    {
        int[,] matrix;

        public Gauss(int[,] matrix)
        {
            this.matrix = matrix;
        }
        public Gauss()
        {
            this.matrix = new int[,]{
                { -1, 2, 7, 39 },
                { 5, 3, 0, 19 },
                { 4, 0, 0, 8 }
            };
        }

        // МЕТОДЫ

        public int[] GetGuass()
        {
            int matrixLength = matrix.GetLength(0);
            int dividerCount = 0;
            int[] resultArrey = new int[matrixLength];

            for (int i = matrixLength - 1; i >= 0; i--)
            {
                int[] row = new int[matrixLength + 1];

                GetDivadedRow(row, dividerCount, matrixLength, i);
                GetResult(resultArrey, row, dividerCount);
                GetSubtractedRow(row, dividerCount, matrixLength, i);

                dividerCount++; // увеличиваем позицию делителя
            }
            return resultArrey;
        }

        /// <summary>
        /// Деление всех элементов ряда на элемент побочной диагонали (divider)
        /// </summary>
        public void GetDivadedRow(int[] row, int dividerCount, int matrixLength, int i)
        {
            for (int j = 0; j < matrixLength + 1; j++)
            {
                if (matrix[i, j] != 0)
                {
                    row[j] = matrix[i, j] / matrix[i, dividerCount]; // делим элементы
                }
            }
        }

        /// <summary>
        /// Вычитаем из всех вышестоящих строк нижнюю 
        /// </summary>
        public void GetSubtractedRow(int[] row, int dividerCount, int matrixLength, int i)
        {
            if (i != 0) // первый ряд не обрабатываем
            {
                for (int k = i - 1; k >= 0; k--)
                {
                    int multiplier = matrix[k, dividerCount];
                    for (int g = 0; g < matrixLength + 1; g++)
                    {
                        matrix[k, g] = matrix[k, g] - (row[g] * multiplier);
                    }
                }
            }
        }

        /// <summary>
        /// Получение результата в виде одномерного массива
        /// </summary>
        public int[] GetResult(int[] arr, int[] row, int dividerCount)
        {
            arr[dividerCount] = row[row.Length - 1];
            return arr;
        }
    }
}
