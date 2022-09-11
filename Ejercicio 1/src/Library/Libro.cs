using System;

/* 
A mi parecer no se cumple el principio de SRP, hay demasiados datos a conocer para una única clase. Yo dividiria el título y el
autor en una única clase -WhichBook-, el código en otra clase -Identifier- y dejaría ShelveBook moviendo los getter/setter de Book
a dicha clase.
*/
namespace SRP
{
    public class WhichBook
    {
        public string Title { get ; }
        public string Author { get ; }

        public WhichBook(String title, String author)
        {
            this.Title = title;
            this.Author = author;
        }
    }
    
    public class Identifier
    {
        public string Code { get ;  }

        public Identifier(String code)
        {
            this.Code = code;
        }
    }

    public class ShelveBook
    {
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }
        public ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
    }
}
