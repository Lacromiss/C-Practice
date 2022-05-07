using System;
using System.Collections.Generic;
using System.Text;

namespace Tekrar6_2
{
    internal interface IAccount
    {
        bool PasswordChecker(string password);
        void ShowInfo();
    }
}