using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    public class DoublyLinkedList
    {
        private int size;
        private DoublyNode head;
        private DoublyNode tail;

        #region Конструктор
        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }
        #endregion

        #region AddFirst
        public void AddFirst(int val) // добавление в начало списка
        {
            DoublyNode node = new DoublyNode(val);
            DoublyNode temp = head;
            node.next = temp;
            head = node;
            if (size == 0) { tail = head; }
            else { temp.previous = node; }
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
            DoublyNode node = new DoublyNode(val);

            if (head == null) { head = node; }
            else
            {
                tail.next = node;
                node.previous = tail;
            }
            tail = node;
            size++;
        }
        #endregion

        #region AddLast arr
        public void AddLast(int[] vals) // добавление в конец списка массива
        {
            for (int i = 0; i < vals.Length; i++)
            {
                AddLast(vals[i]);
            }
            return;
        }
        #endregion

        #region AddAt
        public void AddAt(int idx, int val) // вставка по указанному индексу
        {
            DoublyNode node = new DoublyNode(val);

            if (idx == 0)
            {
                DoublyNode temp = head;
                node.next = temp;
                head = node;
                if (size == 0) { tail = head; }
                else { temp.previous = node; }

            }
            else if (idx == size)
            {
                tail.next = node;
                node.previous = tail;
                tail = node;
            }
            else
            {
                DoublyNode currentNode = head;
                DoublyNode temp;
                int count = 0;
                while (count != idx)
                {
                    currentNode = currentNode.next;
                    count++;
                }
                temp = currentNode;
                node.previous = temp.previous;
                currentNode.previous.next = node;
                node.next = currentNode;
                currentNode.previous = node;
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
            DoublyNode current = head;
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
            head.previous = null;

            if (head == null) { tail = null; }
            size--;
        }
        #endregion

        #region RemoveLast
        public void RemoveLast() // удаление последнего элемента
        {
            if (head == null) return;

            tail.previous.next = tail.next; 
            tail = tail.previous;

            size--;
        }
        #endregion

        #region RemoveAt
        public void RemoveAt(int idx)  // удаление по индексу
        {
            DoublyNode current = head;
            int count = 0;

            while (count < idx)
            {
                current = current.next;
                count++;
            }

            if (current != null)
            {
                if (current.next != null) { current.next.previous = current.previous; }
                else { tail = current.previous; }

                if (current.previous != null) { current.previous.next = current.next; }
                else { head = current.next; }
            }

            size--;
        }
        #endregion

        #region RemoveAll
        public void RemoveAll(int val) // удалить все элементы, равные val
        {
            DoublyNode current = head;

            while (current != null)
            {
                if (current.value == val)
                {
                    if (current != null)
                    {
                        if (current.next != null) { current.next.previous = current.previous; }
                        else { tail = current.previous; }

                        if (current.previous != null) { current.previous.next = current.next; }
                        else { head = current.next; }
                    }
                    size--;
                }
                current = current.next;
            }
        }
        #endregion

        #region Contains
        public bool Contains(int val) // проверка, есть ли элемент в списке
        {
            DoublyNode current = head;
            while (current != null)
            {
                if (current.value == val)
                    return true;
                current = current.next;
            }
            return false;
        }
        #endregion

        #region IndexOf
        public int IndexOf(int val)  // вернёт индекс первого найденного элемента, равного val(или -1, если элементов с таким значением в списке нет)
        {
            int count = 0;
            for (DoublyNode current = head; current != null; current = current.next, count++)
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
            DoublyNode current = head;
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
            DoublyNode current = head;
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
            DoublyNode tmp = null;
            DoublyNode curr = head;

            while (curr != null)
            {
                tmp = curr.previous;
                curr.previous = curr.next;
                curr.next = tmp;
                curr = curr.previous;
            }

            if (tmp != null)
            {
                head = tmp.previous;
            }
        }
        #endregion        
    }
}
