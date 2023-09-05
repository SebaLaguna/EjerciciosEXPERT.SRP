using System;
using Library;


//Implemento las otras 2 clases y asigno datos a los libros

namespace SRP
{
    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns", "Erich Gamma & Others", "001-034");
            Book book2 = new Book("Pro C#", "Troelsen", "001-035");

            LibraryBook libraryBook1 = new LibraryBook();
            LibraryBook libraryBook2 = new LibraryBook();

            libraryBook1.AssignLocation("A", "7");
            libraryBook2.AssignLocation("B", "3");

            //Luego de crear las clases y asignar los datos, muestro los datos de los libros en la terminal

            Console.WriteLine($"Book 1: {book1.Title} by {book1.Author}, Code: {book1.Code}, Sector: {libraryBook1.LibrarySector}, Shelve: {libraryBook1.LibraryShelve}");
            Console.WriteLine($"Book 2: {book2.Title} by {book2.Author}, Code: {book2.Code}, Sector: {libraryBook2.LibrarySector}, Shelve: {libraryBook2.LibraryShelve}");
        }
    }
}
