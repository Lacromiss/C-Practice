using System;

namespace Tekrar6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("lacromis@gmail.com", "musi12345")
            {
                Fullname = "Musi Musiyev"
            };
           
            user.ShowInfo();


        }
    }
}