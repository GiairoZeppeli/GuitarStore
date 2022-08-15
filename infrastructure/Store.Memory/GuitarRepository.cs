using System;
using GuitarStore;
using System.Linq;

namespace Store.Memory
{
    public class GuitarRepository : IGuitarRepository
    {
        private readonly Guitar[] guitars = new[]
        {
            new Guitar(1, "Fender SA-150"),
            new Guitar(2, "Yamaha F-310"),
            new Guitar(3, "Ibanez GIO"),
        };
        public Guitar[] GeyAllByTitle(string titlePart)
        {
            return guitars.Where(guitar => guitar.Title.Contains(titlePart))
                           .ToArray();
        }
    }
}