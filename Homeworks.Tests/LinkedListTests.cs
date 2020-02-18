using NUnit.Framework;
using System;


namespace Homeworks.Tests
{
    [TestFixture]
    class LinkedListTests
    {
        LinkedList lList = new LinkedList();

        [SetUp]
        public void Setup()
        {
            lList.AddLast(7);
            lList.AddLast(67);
            lList.AddLast(43);
            lList.AddLast(2);
            lList.AddLast(8);
            lList.AddLast(91);
            lList.AddLast(43);
        }

        [TearDown]
        public void AfterTest() { lList = new LinkedList(); }


        [TestCase(7)] // доделать с большим размером
        public void GetSizeTest(int expected)
        {
            int actual = lList.GetSize();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 11, 111 }, new int[] { 1, 11, 111, 7, 67, 43, 2, 8, 91, 43 })]
        public void AddFirstArrTest(int[] vals, int[] expected)
        {
            lList.AddFirst(vals);
            int[] actual = lList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(987, 987)]
        [TestCase(765, 765)]
        [TestCase(567, 567)]
        [TestCase(4, 4)]
        public void AddFirstTest(int val, int expected)
        {
            lList.AddFirst(val);
            int actual = lList.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 11, 111 }, new int[] { 7, 67, 43, 2, 8, 91, 43, 1, 11, 111 })]
        public void AddLastArrTest(int[] vals, int[] expected)
        {
            lList.AddLast(vals);
            int[] actual = lList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(987, 987)]
        [TestCase(765, 765)]
        [TestCase(567, 567)]
        [TestCase(4, 4)]
        public void AddLastTest(int val, int expected)
        {
            lList.AddLast(val);
            int actual = lList.GetLast();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, new int[] { 1, 11, 111 }, new int[] { 7, 67, 43, 1, 11, 111, 2, 8, 91, 43 })]
        public void AddAtArrTest(int id, int[] vals, int[] expected)
        {
            lList.AddAt(id, vals);
            int[] actual = lList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 1111, new int[] { 7, 67, 1111, 43, 2, 8, 91, 43 })]
        public void AddAtTest(int id, int val, int[] expected)
        {
            lList.AddAt(id, val);
            int[] actual = lList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, new int[] { 67, 43, 2, 8, 91, 43 })]
        public void RemoveAtTest(int id, int[] expected)
        {
            lList.RemoveAt(id);
            int[] actual = lList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(43, new int[] { 7, 67, 2, 8, 91 })]
        public void RemoveAllTest(int val, int[] expected)
        {
            lList.RemoveAll(val);
            int[] actual = lList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 67, 43, 2, 8, 91, 43 })]
        public void RemoveFirstTest(int[] expected)
        {
            lList.RemoveFirst();
            int[] actual = lList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 7, 67, 43, 2, 8, 91 })]
        public void RemoveLastTest(int[] expected)
        {
            lList.RemoveLast();
            int[] actual = lList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(43, true)]
        [TestCase(19, false)]
        public void ContainsTest(int val, bool expected)
        {
            bool actual = lList.Contains(val);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 7)]
        [TestCase(2, 43)]
        [TestCase(5, 91)]
        public void getTest(int id, int expected)
        {
            int actual = lList.Get(id);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 876, 876)]
        [TestCase(5, 88, 88)]
        [TestCase(3, 111, 111)]
        public void SetTest(int id, int val, int expected)
        {
            lList.Set(id, val);
            int actual = lList.Get(id);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(43, 2)]
        [TestCase(91, 5)]
        [TestCase(2, 3)]
        [TestCase(543, -1)]
        public void IndexOfTest(int val, int expected)
        {
            int actual = lList.IndexOf(val);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 43, 91, 8, 2, 43, 67, 7 })]
        public void ReverseTest(int[] expected)
        {
            lList.Reverse();
            int[] actual = lList.ToArray();
            Assert.AreEqual(expected, actual);
        }
    }
}
