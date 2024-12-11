using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day16homework
{
    internal class MyHelper
    {
        public static int FindMinimum(int[] arr)
        {
            bool isSearchEnd = false;
            int changeCount = 0;
            while (!isSearchEnd)
            {
                changeCount = 0;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                        changeCount++;
                    }

                }
                if (changeCount == 0)
                {
                    isSearchEnd = true;
                }
            }




            return arr[0];
        }
        public static int CountUppercaseLetters(string strings)
        {
            char[] chars = new char[strings.Length];
            chars = strings.ToCharArray();
            int upperCount = 0;
            for (int i = 0; i < strings.Length - 1; i++)
            {
                if (char.IsUpper(strings[i]))
                {
                    upperCount++;
                }

            }
            return upperCount;
        }

    }
}
