using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTo_DoList
{
    public class Book
    {
        public string? Name { get; set; }
        public string? Author { get; set; }
        public double Price { get; set; }
        public int LibraryNumber { get; set; } = new Random().Next();
        public Book(string name, string author, double price)
        {
            Name = name;
            Author = author;
            Price = price;
        }
        public void ShowInformation()
        {
            Console.WriteLine(
                 $"Name: {Name}\n" +
                 $"Author: {Author}\n" +
                 $"Price: ${Price} \n" +
                 $"Book ID: {LibraryNumber} \n");
        }
        public override string ToString()
        {
            return
                $"Name: {Name}\n" +
                $"Author: {Author}\n" +
                $"Price: {Price}\n" +
                $"ID: {LibraryNumber}\n";
        }
    }
}
