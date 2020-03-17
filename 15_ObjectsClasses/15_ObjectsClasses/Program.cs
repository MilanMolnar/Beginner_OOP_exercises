using System;

namespace _15_ObjectsClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Author = "JK Rowling";
            book1.Title = "Harry Potter";
            book1.Pages = 300;

            Book book2 = new Book();
            book2.Author = "Tolkein";
            book2.Title = "LOTR";
            book2.Pages = 900;
            Console.WriteLine(book1.Title);
            Console.WriteLine(book2.Author);
            Console.ReadLine();

        }
    }
}
