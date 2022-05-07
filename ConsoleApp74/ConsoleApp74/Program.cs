using System;

namespace Tekrar4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number of studnent");
            int length = Convert.ToInt32(Console.ReadLine());
            while (length < 1)
            {
                Console.WriteLine("Enter correctly");
                length = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Enter number group name");
            string no = Console.ReadLine();
            while (!CheckNo(no))
            {
                Console.WriteLine("Enter Correctly");
                no = Console.ReadLine();

            }

            Group[] groups = new Group[length];

            for (int i = 0; i < length; i++)
            {
                groups[i] = new Group()
                {
                    No = no,
                    StudentLimit = length
                };
            }

            foreach (Group group in groups)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine(group.No);
            }
        }

        static bool CheckNo(string no)
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