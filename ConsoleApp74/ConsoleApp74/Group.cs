using System;
using System.Collections.Generic;
using System.Text;

namespace Tekrar4
{
    internal class Group
    {
        private string _no;
        private int _studentLimit;


        public string No
        {
            get => this._no;
            set
            {

                if (CheckNo(value))
                    this._no = value;


            }
        }

        public int StudentLimit
        {

            get => this._studentLimit;
            set
            {
                if (value > 0)
                    this._studentLimit = value;

            }
        }

        public bool CheckNo(string no)
        {
            if (!string.IsNullOrWhiteSpace(no) && no.Length == 5 && char.IsUpper(no[0]) && char.IsUpper(no[1]))
            {

                for (int i = 2; i < 5; i++)
                {

                    if (!char.IsDigit(no[i]))
                        return false;
                }


                return true;
            }

            return false;



        }
    }
}