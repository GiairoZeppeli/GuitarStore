using System;

namespace GuitarStore
{
    public class Guitar
    {
        public int Id { get; }

        public string Title { get; }

        public Guitar(int id, string title)
        {
            Title = title;
            Id = id;
        }
    }
}