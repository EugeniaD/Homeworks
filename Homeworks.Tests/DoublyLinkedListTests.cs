using NUnit.Framework;
using System;


namespace Homeworks.Tests
{
    [TestFixture]
    class DoublyLinkedListTests
    {
        DoublyLinkedList dLList = new DoublyLinkedList();

        [SetUp]
        public void Setup()
        {
            dLList.AddLast(1);
            dLList.AddLast(2);
            dLList.AddLast(3);
            dLList.AddLast(4);
            dLList.AddLast(5);
            dLList.AddLast(6);
        }


        [TearDown]
        public void AfterTest() { dLList = new DoublyLinkedList(); }


        [TestCase(6)] // доделать с большим размером
        public void GetSizeTest(int expected)
        {
            int actual = dLList.GetSize();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 11, 111 }, new int[] { 1, 11, 111, 1, 2, 3, 4, 5, 6 })]
        public void AddFirstTest(int[] vals, int[] expected)
        {
            dLList.AddFirst(vals);
            int[] actual = dLList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(987, 987)]
        [TestCase(765, 765)]
        [TestCase(567, 567)]
        [TestCase(4, 4)]
        public void AddFirstTest(int val, int expected)
        {
            dLList.AddFirst(val);
            int actual = dLList.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 11, 111 }, new int[] { 1, 2, 3, 4, 5, 6, 1, 11, 111 })]
        public void AddLastTest(int[] vals, int[] expected)
        {
            dLList.AddLast(vals);
            int[] actual = dLList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(987, 987)]
        [TestCase(765, 765)]
        [TestCase(567, 567)]
        [TestCase(4, 4)]
        public void AddLastTest(int val, int expected)
        {
            dLList.AddLast(val);
            int actual = dLList.GetLast();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 1111, new int[] { 1, 2, 1111, 3, 4, 5, 6 })]
        public void AddAtTest(int id, int val, int[] expected)
        {
            dLList.AddAt(id, val);
            int[] actual = dLList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, new int[] { 1, 11, 111 }, new int[] { 1, 2, 3, 1, 11, 111, 4, 5, 6 })]
        public void AddAtTest(int id, int[] vals, int[] expected)
        {
            dLList.AddAt(id, vals);
            int[] actual = dLList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, new int[] { 1, 2, 4, 5, 6 })]
        public void RemoveAtTest(int id, int[] expected)
        {
            dLList.RemoveAt(id);
            int[] actual = dLList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, new int[] { 1, 3, 4, 5, 6 })]
        public void RemoveAllTest(int val, int[] expected)
        {
            dLList.AddLast(2);
            dLList.RemoveAll(val);
            int[] actual = dLList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 3, 4, 5, 6 })]
        public void RemoveFirstTest(int[] expected)
        {
            dLList.RemoveFirst();
            int[] actual = dLList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        public void RemoveLastTest(int[] expected)
        {
            dLList.RemoveLast();
            int[] actual = dLList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, true)]
        [TestCase(19, false)]
        public void ContainsTest(int val, bool expected)
        {
            bool actual = dLList.Contains(val);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 1)]
        [TestCase(2, 3)]
        [TestCase(5, 6)]
        public void getTest(int id, int expected)
        {
            int actual = dLList.Get(id);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 876, 876)]
        [TestCase(5, 88, 88)]
        [TestCase(3, 111, 111)]
        public void SetTest(int id, int val, int expected)
        {
            dLList.Set(id, val);
            int actual = dLList.Get(id);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 2)]
        [TestCase(6, 5)]
        [TestCase(2, 1)]
        [TestCase(534, -1)]
        public void IndexOfTest(int val, int expected)
        {
            int actual = dLList.IndexOf(val);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 6, 5, 4, 3, 2, 1 })]
        public void ReverseTest(int[] expected)
        {
            dLList.Reverse();
            int[] actual = dLList.ToArray();
            Assert.AreEqual(expected, actual);
        }
    }
}
