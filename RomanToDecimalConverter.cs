using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToDecimalConversion
{
    public class RomanToDecimalConverter
    {
        /// <summary>
        /// Gets the decimal value for roman symbol
        /// </summary>
        /// <param name="romanSymbol">roman symbol</param>
        /// <returns>decimal value of roman symbol</returns>
        private static int GetValueFromRomanSymbol(char romanSymbol)
        {
            switch (romanSymbol)
            { 
                case 'I' :
                    return 1;
                case 'V' :
                    return 5;
                case 'X':
                    return 10;
                case  'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return -1;
            }
        }

        /// <summary>
        /// Converts Roman numerals to decimal
        /// </summary>
        /// <param name="romanStr">string for the roman numerals</param>
        /// <returns>decimal value for the given roman numerals</returns>
        public static int RomanToDecimal(string romanStr)
        {
            int result = 0;
            char[] str = romanStr.ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                // Current symbol
                int current = GetValueFromRomanSymbol(str[i]);

                if (i + 1 < str.Length)
                {
                    // next symbol
                    int next = GetValueFromRomanSymbol(str[i + 1]);

                    if (current >= next)
                    {
                        //value of the current symbol is greater or equal to the next symbol
                        result += current;
                    }
                    else
                    {
                        //value of the current symbol is less then the next symbol
                        result = result + next - current;
                        i++;
                    }
                }
                else
                {
                    result = result + current;
                    i++;
                }

            }

            return result;
        }
    
    }
}
