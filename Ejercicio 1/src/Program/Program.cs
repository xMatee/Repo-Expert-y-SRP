using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            WhichBook book1 = new WhichBook("Design Patterns","Erich Gamma & Others");
            WhichBook book2 = new WhichBook("Pro C#","Troelsen");

            Identifier bookId1 = new Identifier("001-034");
            Identifier bookId2 = new Identifier("001-035");
            
            ShelveBook bookShelve1 = new ShelveBook("A","7");
            ShelveBook bookShelve2 = new ShelveBook("B","3");
        }
    }
}
