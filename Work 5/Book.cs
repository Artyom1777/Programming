using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work5
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime DatePublished { get; set; }
        public string YearPublished { get { return DatePublished.ToString("yyyy"); } }

        public Book(string title, string author, DateTime datePublished)
        {
            Title = title;
            Author = author;
            DatePublished = datePublished;
        }
        public override string ToString()
        {
            return "\tBook@" + GetHashCode() + "{\r\n" +
            "\t\tTitle: " + Title + "\r\n" +
            "\t\tAuthor: " + Author + "\r\n" +
            "\t\tDatePublished: " + DatePublished + "\r\n" +
            "\t\tYearPublished: " + YearPublished + "\r\n" +
            "\t}";
        }
    }
}
