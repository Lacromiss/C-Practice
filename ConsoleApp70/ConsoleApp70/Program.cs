using System;

namespace Tekrar1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book[] books;

            int booksCount = GetInputInt("Kitablarin sayini daxil et", 0, int.MaxValue);

            books = new Book[booksCount];

            for (int i = 0; i < booksCount; i++)
            {
                int no = GetInputInt($"{i + 1}.  kitabin nomresini daxil et:", 2, int.MaxValue);
                int count = GetInputInt($"{i + 1}. kitabin sayini daxil et:", 3, int.MaxValue);
                string name = GetInputStr($"{i + 1}.     kitabin adini daxil et:", 2, 250);
                double price = GetInputDouble($"{i + 1}. kitabin qiymetini daxil et:", 0, double.MaxValue);
                string genre = GetInputStr($"{i + 1}. kitabin janr daxil et: ", 3, 147);


                books[i] = new Book(no, name, price, genre)
                {

                    Count = count

                };
            }


            int input;
            bool check = true;

            do
            {
                Console.WriteLine("\n=============== Menu ====================\n");
                Console.WriteLine("1. Kitablari qiymete gore filtirlerr");
                Console.WriteLine("2. Kitablar icinde  axtaris etmek");
                Console.WriteLine("3. Butun  kitablari gostermek");
                Console.WriteLine("0. Programi baglamaq");


                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        double minPrice = GetInputDouble("MinPrice daxil et:", 0, double.MaxValue);

                        double maxPrice = GetInputDouble("MaxPrice daxil et:", 0, double.MaxValue);

                        var filteredBooksByPrice = FilterBooksByPrice(books, minPrice, maxPrice);

                        Console.WriteLine("\n=============== Kitablarin siyahisi ====================\n");

                        Print(filteredBooksByPrice);

                        break;
                    case 2:
                        Console.WriteLine("Kitalar icerisinde axtaris etmek");
                        string name = GetInputStr("Kitab adi daxil et:", 3, 250);

                        var filteredBooksByName = FilterBooksByName(books, name);

                        Console.WriteLine("\n============== kitablarin siyahi ==================\n");

                        Print(filteredBooksByName);
                        break;
                    case 3:
                        Console.WriteLine("\n================= kitablarin siyahisi ==================\n");
                        Print(books);
                        break;
                    case 0:
                        check = false;
                        break;
                    default:
                        Console.WriteLine("dogru secim etmediniz");
                        break;
                }


            } while (check);


        }

      
        static int GetInputInt(string inputName, int min, int max)
        {
            string inputStr;
            int input;
            do
            {
                Console.WriteLine(inputName);

                inputStr = Console.ReadLine();

                input = Convert.ToInt32(inputStr);

            } while (input < min || input > max);

            return input;
        }

        static double GetInputDouble(string inputName, double min, double max)
        {
            string inputStr;

            double input;
            do
            {
                Console.WriteLine(inputName);
                inputStr = Console.ReadLine();
                input = Convert.ToDouble(inputStr);

            } while (input < min || input > max);

            return input;
        }
        static string GetInputStr(string inputName, int min, int max)
        {
            string input;

            do
            {
                Console.WriteLine(inputName);
                input = Console.ReadLine();

            } while (input.Length < min || input.Length > max);


            return input;
        }

        static void Print(Book[] books)
        {
            foreach (var item in books)

            {
                Console.WriteLine(item.GetInfo());
            }


        }
        static Book[] FilterBooksByPrice(Book[] books, double minPrice, double maxPrice)
        {
            Book[] filteredBooks = new Book[0];


            foreach (var item in books)
            {
                if (item.Price >= minPrice && item.Price <= maxPrice)
                {

                    Resize(ref filteredBooks, filteredBooks.Length +  1);

                    filteredBooks[filteredBooks.Length - 1] = item;
                }
            }

            return filteredBooks;
        }

        static void Resize(ref Book[] books, int newSize)
        {
            Book[] newArr = new Book[newSize];
            for (int i = 0; i < books.Length; i++)
            {
                newArr[i] = books[i];

            }

            books = newArr;
        }

        static Book[] FilterBooksByName(Book[] books, string name)
        {
            Book[] filteredBooks = new Book[0];


            foreach (var item in books)
            {

                if (item.Name == name)

                {
                    Resize(ref filteredBooks, filteredBooks.Length + 1);
                    filteredBooks[filteredBooks.Length - 1] = item;
                }
            }

            return filteredBooks;
        }

        
    }
}