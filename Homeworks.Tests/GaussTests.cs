using NUnit.Framework;
using System;


namespace Homeworks.Tests
{
    [TestFixture]
    class GaussTests
    {
        static object[] testDataForGetGuassAtr =
       {
            new object[] {  new int[,] {
                                        { -1, 2, 7, 39 },
                                        { 5, 3, 0, 19 },
                                        { 4, 0, 0, 8 }
                                       },
               new int[]{ 2, 3, 5 }
            },
            new object[] {  new int[,] {
                                        { 6, 3, 5, 4, 77 },
                                        { 3, -2, 8, 0, 67 },
                                        { 7, 2, 0, 0, 43 },
                                        { 4, 0, 0, 0, 12 }
                                       },
               new int[]{ 3, 11, 10, -6}
            }
         };

        [TestCaseSource("testDataForGetGuassAtr")]
        public void GetGuassTest(int[,] matrix, int[] expected)
        {
            Gauss gauss = new Gauss(matrix);
            int[] actual = gauss.GetGuass();
            Assert.AreEqual(expected, actual);
        }
    }
}
