using System;
using System.Collections.Generic;
using System.Text;

namespace _16_Constructor
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string AAuthor, string ATitle, int APages)
        {
            title = ATitle;
            author = AAuthor;
            pages = APages;
        }

    }
}
