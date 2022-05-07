using System;
using System.Text;

namespace Tekrar2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Yazi daxil et:");
            string sentence = Console.ReadLine();

            MakeSentence(ref sentence);

            Console.WriteLine(sentence);
            Console.WriteLine(CheckString(sentence));
            Console.WriteLine(CheckFullName(sentence));
        }

        static void MakeSentence(ref string str)
        {
            StringBuilder strBuilder = new StringBuilder();
            bool lastIsSpace = false;
            for (int i = 0; i < str.Length; i++)
            {
               
                if (str[i] != ' ')
                {
                    strBuilder.Append(str[i]);
                    lastIsSpace = false;
                }
                else if (!lastIsSpace)
                {
                    strBuilder.Append(str[i]);
                    lastIsSpace = true;
                }


            }

            str = strBuilder.ToString().Trim();
        }

        static bool CheckString(string str)
        {
            bool hasDigit = false;
            bool hasLower = false;
            bool hasUpper = false;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                    hasUpper = true;
                else if (char.IsLower(str[i]))
                    hasLower = true;
                else if (char.IsDigit(str[i]))
                    hasDigit = true;

                if (hasDigit && hasLower && hasUpper)
                    return true;
            }

            return false;
        }

        static bool CheckFullName(string str)
        {
            MakeSentence(ref str);
            var words = str.Split('a');

            if (words.Length == 2 && char.IsUpper(words[0][0]) && char.IsUpper(words[1][0]))
                return true;

            return false;
        }

        static void AddInt(ref int[] arr, int num)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = num;
        }

    }
}