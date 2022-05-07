using System;
using System.Collections.Generic;
using System.Text;


namespace Tekrar6_2
{
    internal class User : IAccount
    {
        private string _password;
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password
        {
            get => _password;
            set
            {
                if (PasswordChecker(value))
                    _password = value;
            }
        }

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public bool PasswordChecker(string password)
        {
            if (!string.IsNullOrWhiteSpace(password) && password.Length >= 8)
            {
                bool hasDigit = false;
                bool hasLower = false;
                bool hasUpper = false;

                foreach (var item in password)
                {
                    if (char.IsDigit(item))
                        hasDigit = true;

                    if (char.IsLower(item))
                        hasLower = true;

                    if (char.IsUpper(item))
                        hasUpper = true;

                    if (hasDigit && hasLower && hasUpper)
                        return true;
                }
            }


            return false;
        }

        public void ShowInfo()
        {

            Console.WriteLine($"Fullname: {Fullname} - Email: {Email}");

        }
    }
}