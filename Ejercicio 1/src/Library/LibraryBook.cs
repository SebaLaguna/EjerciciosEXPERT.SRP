using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Creo la clase LibraryBook que almacena los datos del sector y la estanteria del libro

namespace Library
{
    public class LibraryBook
    {
        public string LibrarySector { get; private set; }
        public string LibraryShelve { get; private set; }

        public LibraryBook()
        {

            this.LibrarySector = string.Empty;
            this.LibraryShelve = string.Empty;
        }

        public void AssignLocation(string sector, string shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }

        public void RemoveLocation()
        {
            this.LibrarySector = string.Empty;
            this.LibraryShelve = string.Empty;
        }
    }

}