using System;
using Trecia_Paskaita_1_uzduotis;

namespace PirmaPaskaita  
{
    class Program     
    {
        static void Main(string[] args)
        {


        Book book1 = new Book("Harry Porter", "JL Roeling", 400);

        Book book2 = new Book("Lord of the Rings", "Tolkein", 700);
            Console.WriteLine(Book.bookCount);

            Console.WriteLine(book1.title);







        }

    }
}
