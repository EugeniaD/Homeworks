using NUnit.Framework;
using System;

namespace Homeworks.Tests
{
    [TestFixture]
    class ListArrayTests
    {
        [SetUp]
        public void Setup()
        { }


        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 12)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, 20)]
        public void GetValExceptionTest(int[] arr, int index)
        {
            ListArray la = new ListArray(arr);

            var ex = Assert.Throws<ArgumentException>(() => la.GetVal(index));
            Assert.That(ex.Message, Is.EqualTo($"Не верно задан индекс"));
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 0, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 2, 3)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 9, 10)]
        public void GetValTest(int[] val, int index, int expected)
        {
            ListArray la = new ListArray(val);

            int actual = la.GetVal(index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, -1)]
        [TestCase(new int[] { 1, 2, 3 }, 3)]
        public void GetValTestException(int[] original, int index)
        {
            ListArray list = new ListArray(original);
            try
            {
                int idx = list.GetVal(index);
            }
            catch (ArgumentException e)
            {
                return;
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 0, 23, 23)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 1, 34, 34)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 5, 45, 45)]
        public void SetValTest(int[] val, int index, int value, int expected)
        {
            ListArray la = new ListArray(val);

            la.SetVal(index, value);

            Assert.AreEqual(expected, la.GetVal(index));
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 12, 23)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 13, 34)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 54, 45)]
        //public void GetExceptionTest(int index, int expected)
        public void SetValExceptionTest(int[] val, int index, int value)
        {
            ListArray la = new ListArray(val);

            var ex = Assert.Throws<ArgumentException>(() => la.SetVal(index, value));
            Assert.That(ex.Message, Is.EqualTo($"Не верно задан индекс"));
        }


        [TestCase(3, new int[] { 3 })]
        [TestCase(876, new int[] { 876 })]
        public void AddTest(int val, int[] expected)
        {
            ListArray la = new ListArray();
            la.Add(val);

            Assert.AreEqual(expected, la.GetValues());
        }

        [TestCase(new int[] { 3, 4, 65, 6, 3, 2 }, 987, new int[] { 3, 4, 65, 6, 3, 2, 987 })]
        [TestCase(new int[] { 3, 4, 65, 1, 1, 1, 1, 1, 1, 1 }, 987, new int[] { 3, 4, 65, 1, 1, 1, 1, 1, 1, 1, 987 })]
        public void AddTest(int[] arr, int val, int[] expected)
        {
            ListArray la = new ListArray(arr);
            la.Add(val);

            Assert.AreEqual(expected, la.GetValues());
        }


        [TestCase(new int[] { 3, 4, 65, 6, 3, 2 }, 2, 987, new int[] { 3, 4, 987, 65, 6, 3, 2 })]
        [TestCase(new int[] { 3, 4, 65, 1, 1, 1, 1, 1, 1, 1 }, 5, 987, new int[] { 3, 4, 65, 1, 1, 987, 1, 1, 1, 1, 1 })]
        public void AddOnIndexTest(int[] arr, int index, int val, int[] expected)
        {
            ListArray la = new ListArray(arr);
            la.AddOnIndex(index, val);

            Assert.AreEqual(expected, la.GetValues());
        }

        [TestCase(new int[] { 3, 4, 65 }, new int[] { 3, 4, 65 })]
        [TestCase(new int[] { 3, 4, 65, 6, 3, 2 }, new int[] { 3, 4, 65, 6, 3, 2 })]
        [TestCase(new int[] { 3, 4, 65, 1, 1, 1, 1, 1, 1, 1, 1 }, new int[] { 3, 4, 65, 1, 1, 1, 1, 1, 1, 1, 1 })]
        public void GetValuesTest(int[] val, int[] expected)
        {
            ListArray la = new ListArray(val);
            la.GetValues();

            Assert.AreEqual(expected, la.GetValues());
        }

        [TestCase(new int[] { 3, 4, 65 }, new int[] { 3, 4, 65 }, new int[] { 3, 4, 65, 3, 4, 65 })]
        [TestCase(new int[] { 3, 4, 65, 6, 3, 2 }, new int[] { 3, 4, 65, 6, 3, 2 }, new int[] { 3, 4, 65, 6, 3, 2, 3, 4, 65, 6, 3, 2 })]
        [TestCase(new int[] { 3, 4, 65, 1, 1, 1, 1, 1, 1, 1 }, new int[] { 876, 4, 65, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, new int[] { 3, 4, 65, 1, 1, 1, 1, 1, 1, 1, 876, 4, 65, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 })]
        public void AddAllTest(int[] arr, int[] val, int[] expected)
        {
            ListArray la = new ListArray(arr);
            la.AddAll(val);

            Assert.AreEqual(expected, la.GetValues());
        }

        [TestCase(new int[] { 3, 4, 65, 765 }, 2, new int[] { 3, 4, 65 }, new int[] { 3, 4, 3, 4, 65, 65, 765 })]
        [TestCase(new int[] { 3, 4, 65, 765, 8 }, 0, new int[] { 34, 67, 98 }, new int[] { 34, 67, 98, 3, 4, 65, 765, 8 })]
        [TestCase(new int[] { 3, 4, 65, 6, 3, 2 }, 3, new int[] { 3, 4, 65, 6, 3, 2 }, new int[] { 3, 4, 65, 3, 4, 65, 6, 3, 2, 6, 3, 2 })]
        public void AddAllOnIndexTest(int[] arr, int index, int[] val, int[] expected)
        {
            ListArray la = new ListArray(arr);
            la.AddAllOnIndex(index, val);

            Assert.AreEqual(expected, la.GetValues());
        }

        [TestCase(new int[] { 3, 4, 65 }, 3)]
        [TestCase(new int[] { 3, 4, 65, 6, 3, 2 }, 6)]
        [TestCase(new int[] { 3, 4, 65, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 14)]
        public void SizeTest(int[] value, int expected)
        {
            ListArray la = new ListArray(value);

            int actual = la.Size();

            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { 3, 4, 65 }, 3, true)]
        [TestCase(new int[] { 3, 4, 65, 2 }, 2, true)]
        [TestCase(new int[] { 3, 4, 65, 2 }, 65, true)]
        [TestCase(new int[] { 3, 4, 65, 1, }, 14, false)]
        public void ContainsTest(int[] arr, int value, bool expected)
        {
            ListArray la = new ListArray(arr);

            bool actual = la.Contains(value);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { 3, 4, 65 }, 3, 0)]
        [TestCase(new int[] { 3, 4, 65, 2 }, 2, 3)]
        [TestCase(new int[] { 3, 4, 65, 2 }, 65, 2)]
        [TestCase(new int[] { 3, 4, 65, 1, }, 14, -1)]
        public void IndexOfTest(int[] arr, int value, int expected)
        {
            ListArray la = new ListArray(arr);

            int actual = la.IndexOf(value);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { 3, 4, 65 }, 3, new int[] { 0 })]
        [TestCase(new int[] { 3, 4, 3, 2 }, 3, new int[] { 0, 2 })]
        [TestCase(new int[] { 1, 4, 1, 1 }, 1, new int[] { 0, 2, 3 })]
        [TestCase(new int[] { 1, 4, 1, 1 }, 65, new int[] { })]
        public void SearchTest(int[] arr, int value, int[] expected)
        {
            ListArray la = new ListArray(arr);

            int[] actual = la.Search(value);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { 3, 4, 65 }, 2, new int[] { 3, 4 })]
        [TestCase(new int[] { 3, 4, 3, 2 }, 3, new int[] { 3, 4, 3 })]
        public void RemoveAtTest(int[] arr, int index, int[] expected)
        {
            ListArray la = new ListArray(arr);

            la.RemoveAt(index);

            Assert.AreEqual(expected, la.GetValues());
        }

        [TestCase(new int[] { 3, 4, 65 }, 4, new int[] { 3, 65 })]
        [TestCase(new int[] { 3, 4, 3, 2 }, 3, new int[] { 4, 3, 2 })]
        [TestCase(new int[] { 3, 4, 3, 2 }, 2, new int[] { 3, 4, 3 })]
        public void RemoveTest(int[] arr, int value, int[] expected)
        {
            ListArray la = new ListArray(arr);

            la.Remove(value);

            Assert.AreEqual(expected, la.GetValues());
        }

        [TestCase(new int[] { 3, 4, 65, 4 }, 4, new int[] { 3, 65 })]
        [TestCase(new int[] { 3, 4, 3, 2 }, 3, new int[] { 4, 2 })]
        [TestCase(new int[] { 2, 34, 3, 2 }, 2, new int[] { 34, 3 })]
        public void RemoveAllTest(int[] arr, int value, int[] expected)
        {
            ListArray la = new ListArray(arr);

            la.RemoveAll(value);

            Assert.AreEqual(expected, la.GetValues());
        }

        [TestCase(new int[] { 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 })]
        public void ArrayExpansionTest(int[] arr, int[] expected)
        {
            ListArray la = new ListArray(arr);

            int[] actual = la.ArrayExpansion();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 }, new int[] { 1, 1, 1, 1, 1, 1 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 6, 8, 4, 12 }, new int[] { 1, 1, 1, 1, 1, 1 })]
        public void ArrayReductionTest(int[] arr, int[] expected)
        {
            ListArray la = new ListArray(arr);

            int[] actual = la.ArrayReduction();

            Assert.AreEqual(expected, actual);
        }

    }
}

