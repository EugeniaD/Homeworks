using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    public class ListArray
    {
        private int[] array;
        private int realLength; // область которая заполнена значениями

        public int[] Array { get { return array; } }
        public int RealLength { get { return realLength; } }

        #region Конструкторы
        public ListArray()
        {
            realLength = 0;
            array = new int[10];
        }

        public ListArray(int[] array)
        {
            this.array = array;
            realLength += array.Length;
        }
        #endregion

        // МЕТОДЫ

        #region ArrayExpansion
        public int[] ArrayExpansion()
        {
            int arrayNewLength = Convert.ToInt32((array.Length * 3) / 2 + 1);
            int[] bigArray = new int[arrayNewLength];
            for (int i = 0; i < array.Length; i++)
            {
                bigArray[i] = array[i];
            }
            return bigArray;
        }

        #endregion

        #region ArrayReduction
        public int[] ArrayReduction()
        {
            int arrayNewLength = Convert.ToInt32((array.Length - 1) * 2 / 3);
            int[] smallArray = new int[arrayNewLength];
            for (int i = 0; i < arrayNewLength; i++)
            {
                smallArray[i] = array[i];
            }
            return smallArray;
        }
        #endregion

        #region Add
        public void Add(int val) // добавл в конец массива
        {
            if (realLength == array.Length)
            {
                array = ArrayExpansion();
            }
            array[realLength] = val;
            realLength++;
        }
        #endregion

        #region AddAll
        public void AddAll(int[] val) // добавл  массив в конец массива 
        {
            for (int i = 0; i < val.Length; i++)
            {
                if (realLength + val.Length >= array.Length)
                {
                    array = ArrayExpansion();
                }
                array[realLength + i] = val[i];
            }
            realLength += val.Length;
        }
        #endregion

        #region AddOnIndex
        public void AddOnIndex(int index, int val)  // добавляет эл-т под индексом и сдвигает массив
        {
            if (index < 0 || index >= realLength)
            {
                throw new ArgumentException($"Не верно задан индекс");
            }
            if (realLength == array.Length)
            {
                array = ArrayExpansion();
            }

            for (int i = realLength + 1; i > 0; i--)
            {
                if (i > index)
                {
                    array[i] = array[i - 1];
                }
                if (i == index)
                {
                    array[i] = val;
                }
            }
            realLength++;
        }
        #endregion

        #region AddAll on index
        public void AddAllOnIndex(int index, int[] val)  // добавл  массив на место индекса
        {
            if (index < 0 || index >= realLength)
            {
                throw new ArgumentException($"Не верно задан индекс");
            }

            if (realLength + val.Length >= array.Length)
            {
                int arrayNewLength = array.Length + val.Length;
                int[] bigArray = new int[arrayNewLength];
                for (int i = 0; i < array.Length; i++)
                {
                    bigArray[i] = array[i];
                }
                array = bigArray;
            }

            for (int i = realLength + val.Length - 1; i > 0; i--)
            {
                if (i - val.Length >= index)
                {
                    array[i] = array[i - val.Length];
                }
                if (i - val.Length == index)
                {
                    for (int j = 0; j < val.Length; j++)
                    {
                        array[index + j] = val[j];
                    }
                }
            }

            realLength += val.Length;
        }
        #endregion

        #region SetVal
        public void SetVal(int index, int val) // вставить эл-т на место индекса
        {
            if (index < 0 || index >= realLength)
            {
                throw new ArgumentException($"Не верно задан индекс");
            }
            array[index] = val;
        }
        #endregion

        #region GetVal
        public int GetVal(int index) // получить знач индекса
        {
            if (index < 0 || index >= realLength)
            {
                throw new ArgumentException($"Не верно задан индекс");
            }
            return array[index];
        }
        #endregion

        #region Size
        public int Size()
        {
            // фактический размер массива 
            return realLength;
        }
        #endregion

        #region GetValues
        public int[] GetValues() // возвращает эл-ты внутри массива array от 0 до reallength, может вернуть пустой массив 
        {
            int[] newArr = new int[realLength];
            for (int i = 0; i < realLength; i++)
            {
                newArr[i] = array[i];
            }
            return newArr;
        }
        #endregion

        #region Contains
        public bool Contains(int val)
        {
            for (int i = 0; i < realLength; i++)
            {
                if (array[i] == val)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region RemoveAt
        public void RemoveAt(int index)  // удалить индекс 
        {
            if (index < 0 || index >= realLength)
            {
                throw new ArgumentException($"Не верно задан индекс");
            }

            for (int i = index; i < realLength; i++)
            {
                if (i == array.Length - 1)
                {
                    array[i] = 0;
                    realLength--;
                    return;
                }
                array[i] = array[i + 1];
            }
            realLength--;
        }
        #endregion

        #region Remove
        public void Remove(int val) // удалить значение первое
        {
            if (!Contains(val))
            {
                return;
            }

            for (int i = 0; i < realLength; i++)
            {
                if (array[i] == val)
                {
                    for (int j = i; j < realLength; j++)
                    {
                        if (j == array.Length - 1)
                        {
                            array[j] = 0;
                            realLength--;
                            return;
                        }
                        array[j] = array[j + 1];
                    }
                    realLength--;
                    return;
                }
            }

        }
        #endregion

        #region RemoveAll
        public void RemoveAll(int val) // удалить все эл-ты с этим значением 
        {
            if (!Contains(val))
            {
                return;
            }

            int[] newArr = new int[array.Length];
            int count = 0;
            for (int i = 0; i < realLength; i++)
            {
                if (array[i] != val)
                {
                    newArr[count] = array[i];
                    count++;
                }
            }
            realLength = count;
            array = newArr;

            if (array.Length / 2 > realLength)
            {
                array = ArrayReduction();
            }
            return;
        }
        #endregion

        #region IndexOf
        public int IndexOf(int val) // первый индекс с этим знач
        {
            for (int i = 0; i < realLength; i++)
            {
                if (array[i] == val)
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion

        #region Search
        public int[] Search(int val) // вернет массив с индексами
        {
            int count = 0, counter = 0;
            for (int i = 0; i < realLength; i++)
            {
                if (array[i] == val)
                {
                    count++;
                }
            }

            int[] foundIndices = new int[count];
            for (int i = 0; i < realLength; i++)
            {
                if (array[i] == val)
                {
                    foundIndices[counter] = i;
                    counter++;
                }
            }
            return foundIndices;
        }
        #endregion
    }

}
