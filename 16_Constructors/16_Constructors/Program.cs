using System;

namespace _16_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("JK Rowling", "Harry Potter", 300);
            
            Book book2 = new Book("Tolkein", "LOTR", 900);

            Console.WriteLine(book1.author);
            Console.WriteLine(book2.pages);
        }
    }
}
