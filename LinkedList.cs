using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    public class LinkedList
    {
        private int size;
        private Node head; //первый элемент
        private Node tail; // последний элемент

        #region Конструктор
        public LinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }
        #endregion

        // МЕТОДЫ

        #region AddFirst
        public void AddFirst(int val) // добавление в начало списка
        {
            Node node = new Node(val);
            node.next = head;
            head = node;
            if (size == 0) { tail = head; }

            size++;
        }
        #endregion

        #region AddFirst arr
        public void AddFirst(int[] vals)  // то же самое, но с массивом
        {
            for (int i = 0; i < vals.Length; i++)
            {
                AddAt(i, vals[i]);
            }
        }
        #endregion

        #region AddLast
        public void AddLast(int val) // добавление в конец списка
        {
            Node node = new Node(val);

            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.next = node;
            }
            tail = node;

            size++;
        }
        #endregion

        #region AddLast arr
        public void AddLast(int[] vals) // то же самое, но с массивом
        {
            for (int i = 0; i < vals.Length; i++)
            {
                AddLast(vals[i]);
            }
        }
        #endregion

        #region AddAt
        public void AddAt(int idx, int val) // вставка по указанному индексу
        {
            Node node = new Node(val);

            if (idx == 0)
            {
                node.next = head;
                head = node;
                if (size == 0) { tail = head; }
            }
            else if (idx == size)
            {
                tail.next = node;
                tail = node;
            }
            else
            {
                Node current = head;
                Node previous = null;
                int count = 0;
                while (count != idx)
                {
                    previous = current;
                    current = current.next;
                    count++;
                }
                previous.next = node;
                node.next = current;
            }
            size++;
        }
        #endregion

        #region AddAt arr
        public void AddAt(int idx, int[] vals)  // то же самое, но с массивом
        {

            for (int i = 0; i < vals.Length; i++)
            {
                AddAt(idx, vals[i]);
                idx++;
            }
        }
        #endregion

        #region GetSize
        public int GetSize() // узнать кол-во элементов в списке
        {
            return size;
        }
        #endregion

        #region Set
        public void Set(int idx, int val)  // поменять значение элемента с указанным индексом
        {
            Node current = head;
            int count = 0;
            while (count != idx)
            {
                current = current.next;
                count++;
            }
            current.value = val;
        }
        #endregion

        #region RemoveFirst
        public void RemoveFirst() // удаление первого элемента
        {
            head = head.next;

            if (head == null) { tail = null; }
            size--;
        }
        #endregion

        #region RemoveLast
        public void RemoveLast() // удаление последнего элемента
        {
            if (head == null) return;

            Node current = head;
            Node previous = null;

            while (current.next != null)
            {
                previous = current;
                current = current.next;
            }

            tail = previous;
            previous.next = null;
            size--;
        }
        #endregion

        #region RemoveAt
        public void RemoveAt(int idx)  // удаление по индексу
        {
            Node current = head;
            Node previous = null;
            int count = 0;

            while (count != idx)
            {
                previous = current;
                current = current.next;
                count++;
            }

            if (previous != null)
            {
                previous.next = current.next;
                if (current.next == null) { tail = previous; }
            }
            else
            {
                head = head.next;

                if (head == null) { tail = null; }
            }
            size--;
        }
        #endregion

        #region RemoveAll
        public void RemoveAll(int val) // удалить все элементы, равные val
        {
            Node current = head;
            Node previous = null;

            while (current != null)
            {
                if (current.value == val)
                {
                    if (previous != null)
                    {
                        previous.next = current.next;
                        if (current.next == null) { tail = previous; }
                    }
                    else
                    {
                        head = head.next;
                        if (head == null) { tail = null; }
                    }
                    size--;
                }
                previous = current;
                current = current.next;
            }
        }
        #endregion

        #region Contains
        public bool Contains(int val) // проверка, есть ли элемент в списке
        {
            Node current = head;
            while (current != null)
            {
                if (current.value == val) { return true; }
                current = current.next;
            }
            return false;
        }
        #endregion

        #region IndexOf
        public int IndexOf(int val)  // вернёт индекс первого найденного элемента, равного val
        {
            int count = 0;
            for (Node current = head; current != null; current = current.next, count++)
            {
                if (val.Equals(current.value))
                    return count;
            }
            return -1;
        }
        #endregion

        #region ToArray
        public int[] ToArray() // преобразовать список в массив
        {
            Node current = head;
            int count = 0;
            int[] arr = new int[size];
            while (current != null)
            {
                arr[count] = current.value;
                current = current.next;
                count++;
            }
            return arr;
        }
        #endregion

        #region GetFirst
        public int GetFirst() // вернёт значение первого элемента списка       
        {
            return head.value;
        }
        #endregion

        #region GetLast
        public int GetLast() // вернёт значение последнего элемента списка
        {
            return tail.value;
        }
        #endregion

        #region Get
        public int Get(int idx) // вернёт значение элемента списка с указанным индексом
        {
            Node current = head;
            int count = 0;
            while (count != idx)
            {
                current = current.next;
                count++;
            }
            return current.value;
        }
        #endregion

        #region Reverse
        public void Reverse() // изменение порядка элементов списка на обратный
        {
            Node tmp = head;

            while (tmp.next != null)
            {
                Node curr = tmp.next;
                tmp.next = tmp.next.next;
                curr.next = head;
                head = curr;
            }
        }
        #endregion
    }
}
