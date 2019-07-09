using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAsOperatorsTutorial
{
    class Speaker
    {
        public string Name { get; set; }
    }

    class Author
    {
        public string Name { get; set; }

        public static string GetAuthorName(dynamic obj)
        {
            Author author = obj as Author;
            return (author != null) ? author.Name : string.Empty;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //IS
            var speaker = new Speaker { Name = "Nemanja" };
            var isTrue = speaker is Speaker;
            Console.WriteLine($"speaker is of Speaker type: {isTrue}");

            var author = new Author { Name = "Nemanja" };
            isTrue = speaker is Author;
            Console.WriteLine($"speaker is of Author type: {isTrue}");

            //AS
            var authorName = Author.GetAuthorName(author);
            Console.WriteLine($"Author name is: {authorName}");

            authorName = Author.GetAuthorName(speaker);
            Console.WriteLine($"Author name is: {authorName}");


        }
    }
}
