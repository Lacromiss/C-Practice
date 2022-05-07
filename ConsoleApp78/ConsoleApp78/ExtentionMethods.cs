using System;
using System.Collections.Generic;
using System.Text;

namespace Tekrar7
{
    static class ExtentionMethods
    {
        public static string ToCapitalize(this string text)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                string newText = char.ToUpper(text[0]) + text.Substring(1).ToLower();
                return newText;
            }
            return null;
        }
        public static bool IsOdd(this int num)
        {
            if (num % 2 != 0)
                return true;
            return false;

        }
        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
                return true;
            return false;
        }
        public static bool IsContainsDigit(this string text)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (char.IsDigit(text[i]))
                    {
                        return true;
                    }
                }
            }
            return false;


        }
        public static int[] GetValueIndexes(this string text, char letter)
        {
            int[] indexes = new int[0];
            if (!string.IsNullOrWhiteSpace(text))
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == letter)
                    {
                        Array.Resize(ref indexes, indexes.Length + 1);
                        indexes[indexes.Length - 1] = i;
                    }
                }


            }
            return indexes;
        }


     
    }
}