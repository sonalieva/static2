using System;
using System.Collections.Generic;
using System.Text;

namespace Static2
{
    public static class Extenction
    {
        public static bool CheckGroupNo(this string str)
        {
            int count = 0;
            if (str.Length == 4 && char.IsUpper(str[0]))
            {
                for (int i = 1; i < str.Length; i++)
                {

                    if (char.IsDigit(str[i]))
                    {
                        count++;
                    }
                    if (count == 3)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool CheckFullname(this string smth)
        {
            var value = smth.Split(" ");
            if (value.Length == 2)
            {
                if (char.IsUpper(value[0][0]) && char.IsUpper((char)value[1][0]))
                {
                    return true;
                }
            }
            return false;
        }

}   }
