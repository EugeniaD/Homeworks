using NUnit.Framework;
using System;


namespace Homeworks.Tests
{
    [TestFixture]
    class GaussTests
    {
        //static object[] testDataForGetResultAtr =
        //{
        //    new object[] {  new int[,] {
        //                                {1,2,3,4 },
        //                                {1,2,3,6 },
        //                                {1,2,3,8 }
        //                               },
        //       new int[]{ 4, 6, 8 }
        //    },
        //    new object[] {  new int[,] {
        //                                {1,2,3,4, 5 },
        //                                {1,2,3,6, 7 },
        //                                {1,2,3,6, 34 },
        //                                {1,2,3,8, 65 }
        //                               },
        //       new int[]{ 5, 7, 34, 65 }
        //    },
        //    new object[] {  new int[,] {
        //                                {1,2,3 },
        //                                {1,2,69 },
        //                               },
        //       new int[]{ 3, 69 }
        //    },

        // };

        //[TestCaseSource("testDataForGetResultAtr")]
        //public void GetResultTest(int[,] finalMatrix, int[] expected)
        //{
        //    Gauss gauss = new Gauss();
        //    int[] actual = gauss.GetResult(finalMatrix);
        //    Assert.AreEqual(expected, actual);
        //}


        //[TestCase(new int[] { 3, 0, 0, 21 }, 3, new int[] { 1, 0, 0, 7 })]
        //[TestCase(new int[] { 0, 4, 0, 16 }, 4, new int[] { 0, 1, 0, 4 })]
        //[TestCase(new int[] { 0, 0, 5, 25 }, 5, new int[] { 0, 0, 1, 5 })]
        //public void GetDivadedRowTest(int[] row, int divider, int[] expected)
        //{
        //    Gauss gauss = new Gauss();
        //    int[] actual = gauss.GetDivadedRow(row, divider);
        //    Assert.AreEqual(expected, actual);
        //}

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
