using System;
using System.Collections;
using System.Collections.Generic;

namespace yieldTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Library l = new Library();

            foreach (Book b in l.GetBooks(5))
            {
                Console.WriteLine(b.Name);
            }
            Console.ReadLine();
        }
    }

    class Book
    {
        public Book(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
    }

    class Library
    {
        private Book[] books;

        public Library()
        {
            books = new Book[] { new Book("Отцы и дети"), new Book("Война и мир"),
            new Book("Евгений Онегин") };
        }

        public int Length
        {
            get { return books.Length; }
        }

        public IEnumerable GetBooks(int max)
        {
            for (int i = 0; i < max; i++)
            {
                if (i == books.Length)
                {
                    break;
                }
                else
                {
                    yield return books[i];
                }
            }
        }
    }
}
