using System;
using System.Text.RegularExpressions;
namespace GuitarStore
{
    public class Guitar
    {
        public int Id { get; }

        public string Isbn { get; }

        public string Title { get; }

        public Guitar(int id, string isbn, string title)
        {
            Title = title;
            Id = id;
            Isbn = isbn;
            
        }

        internal static bool IsIsbn(string s)
        {
            if(s == null)
                return false;
            s = s.Replace("-", "")
                .Replace(" ", "")
                .ToUpper();
            return Regex.IsMatch(s, @"ISBN\d{10}");
        }
    }
}