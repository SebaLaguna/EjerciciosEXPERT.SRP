using System;

namespace SRP
{
    public class Book
    {

        public string Title { get; }
        public string Author { get; }
        public string Code { get; }
        // public string LibrarySector { get; set; }
        // public string LibraryShelve { get; set; }

        //Creo otra clase que almacene los datos del sector y la estanteria del libro ya que la clase "Book"
        //  no necesita conocer esos datos

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        // public void ShelveBook(String sector, String shelve)
        // {
        //     // this.LibrarySector = sector;
        //     // this.LibraryShelve = shelve;
        // }

    }
}
