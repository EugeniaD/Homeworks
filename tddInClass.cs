using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    public class TddInClass
    {
        public string[] romanAlphabet = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        public int[] arabicAlternative = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

        public string GetRomanNumber(int number)
        {
            StringBuilder romanNamber = new StringBuilder();

            for (int i = 0; i < romanAlphabet.Length; i++)
            {
                while (number >= arabicAlternative[i])
                {
                    romanNamber.Append(romanAlphabet[i]);
                    number -= arabicAlternative[i];
                }
            }
            //while (number >= 10) //------- до этого было через if
            //{
            //    romanNamber.Append("X");
            //    number -= 10;
            //}

            //while (number-- > 0)
            //{
            //    romanNamber.Append("I");
            //}

            return romanNamber.ToString();
        }
    }
}
