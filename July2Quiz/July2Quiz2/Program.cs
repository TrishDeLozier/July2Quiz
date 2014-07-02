using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace July2Quiz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1, book2;
            book1 = new Book("19.99");
            Console.WriteLine(book1.Describe());
            book2 = new Book("21.99");
            Console.WriteLine(book2.Describe());
            Console.ReadLine();
            if (book1.Price == book2.Price)
                Console.WriteLine("0");
            else if (book1.Price != book2.Price)
                Console.WriteLine("1");



        }
    }

    class Book
    {
        private string price;
        public Book(string price)
        {
        this.price = price;
        }
        public string Describe()
        {
            return ("This book is:" + Price);
        }
        public string Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
