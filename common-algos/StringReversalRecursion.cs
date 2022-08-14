using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ar.codes.common_algos
{
    public class StringIsPolu
    {
        /// <summary>
        /// reverses string using recursion
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Reverse(string input)
        {
            return ReverseInternal(input, 0);
        }

        public static string ReverseInternal(string input, int offset)
        {


            if(string.IsNullOrEmpty(input))
                return string.Empty;

            if (input.Length==1)
                return input;


        }
    }
}
