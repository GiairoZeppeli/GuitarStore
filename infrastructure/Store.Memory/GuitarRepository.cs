using System;
using GuitarStore;
using System.Linq;

namespace Store.Memory
{
    public class GuitarRepository : IGuitarRepository
    {
        private readonly Guitar[] guitars = new[]
        {
            new Guitar(1,"ISBN 12345-67890", "Fender SA-150"),
            new Guitar(2,"ISBN 14882-28148", "Yamaha F-310"),
            new Guitar(3,"ISBN 13378-84128", "Ibanez GIO"),
        };
        public Guitar[] GetAllByTitle(string titlePart)
        {
            return guitars.Where(guitar => guitar.Title.Contains(titlePart))
                           .ToArray();
        }

        public Guitar[] GetAllByIsbn(string isbn)
        {
            return guitars.Where(guitar => guitar.Isbn.Contains(isbn))
                           .ToArray();
        }
    }
}