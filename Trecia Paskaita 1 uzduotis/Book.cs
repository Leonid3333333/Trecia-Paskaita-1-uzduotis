using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Trecia_Paskaita_1_uzduotis
{
    class Book
    {
        string title;
        string author;
        int pages;
        public static int bookCount = 0;

        public Book(string aTitle, string aAuthor, int aPages)
        {
            this.title = aTitle;
            author = aAuthor;
            pages = aPages;
              bookCount++;


        }
        
        


    }

}
