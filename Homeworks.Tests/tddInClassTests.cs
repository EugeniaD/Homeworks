using NUnit.Framework;

namespace Homeworks.Tests
{
    [TestFixture]
    class TddInClassTests
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(10, "X")]
        [TestCase(20, "XX")]
        [TestCase(30, "XXX")]
        [TestCase(33, "XXXIII")]
        [TestCase(4, "IV")]
        [TestCase(9, "IX")]
        [TestCase(111, "CXI")]
        [TestCase(3876, "MMMDCCCLXXVI")]
        public void GetRomanNumberTest(int arabicNumber, string expected)
        {
            TddInClass Tic = new TddInClass();

            string actual = Tic.GetRomanNumber(arabicNumber);
            Assert.AreEqual(expected, actual);
        }
    }
}
