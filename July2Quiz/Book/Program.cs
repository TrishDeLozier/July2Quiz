using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Book 
    {
        public string Title { get; set; }
        public double Price { get; set; }

        public decimal Compare(Book other)
        {
            return Price.CompareTo(other.Price);
        }
    }   
    class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Book();
            book1.Price = 5.99;
            var book2 = new Book();
            book2.Price = 6.99;
            var answer = book1.Compare(book2);
            Console.WriteLine(answer);
        }

       

    }
}
