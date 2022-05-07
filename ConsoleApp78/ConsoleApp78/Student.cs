using System;
using System.Collections.Generic;
using System.Text;

namespace Tekrar7
{
    internal class Student
    {
        private string _fullname;
        private string _groupNo;
        public string FullName
        {
            get => _fullname;
            set
            {
                if (CheckFullName(value))
                    _fullname = value;
            }
        }
        public string GrupNo
        {
            get => _groupNo;
            set
            {
                if (CheckGroupNo(value))
                    _groupNo = value;
            }
        }
        public int Age { get; set; }
        public static bool CheckGroupNo(string groupNo)
        {
            //if (!string.IsNullOrEmpty(groupNo)&&groupNo.Length==4)
            //{
            //    if (char.IsUpper(groupNo[0])&&char.IsDigit(groupNo[1])&&char.IsDigit(groupNo[2])&&char.IsDigit(groupNo[3]))
            //    {
            //        return true;

            //    }
            //}

            if (!string.IsNullOrEmpty(groupNo) && groupNo.Length == 4 && char.IsUpper(groupNo[0]))
            {
                for (int i = 1; i < groupNo.Length; i++)
                {
                    if (!char.IsDigit(groupNo[i]))
                        return false;
                }
                return true;
            }
            return false;
        }
        public static bool CheckFullName(string txt)
        {
            if (!string.IsNullOrWhiteSpace(txt))
            {
                var word = txt.Split(' ');

                if (word.Length == 2 && char.IsUpper(word[0][0]) && char.IsUpper(word[1][0]))
                {
                    return true;
                }
            }
            return false;
        }
    }

}
