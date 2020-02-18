using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    public class ListArray
    {
        private int realLength=4; // область которая заполнена значениями
        private int[] array = new int[] { 1, 2, 3, 4 };

        //public ListArray(int realLength, int[] array)
        //{
        //    this.realLength = realLength;
        //    this.array = array;
        //}
        //public int[] Add(int index, int val) // добавл в конец массива
        //{
        //} 
        //public int[] AddAll(int[] index, int[] val) { } // добавл в конец массива все эл-ты
        //public int[] Set(int index, int val) { } // вставить эл-т на место индекса
        public int Get(int index) // получить знач индекса
        {
            if (index > realLength)
            {
                throw new ArgumentException($"Индек не должен быть больше {realLength}");

            }
            return this.array[index];
        }
        //public int Size() 
        //{

        //} // размер массива фактический
        //public bool Contains(int val) // есть или нет
        //{

        //} 
        //public int[] RemoveIndex(int index) { } // удалить индекс 
        //public int[] Remove(int val) { } // удалить значение первое
        //public int[] RemoveAll(int val) { } // удалить все с этим значением 
        //public int IndexOf(int val) { } // первый индекс с этим знач
        //public int Search(int val) { } // найти все с этим знач
    }
}
