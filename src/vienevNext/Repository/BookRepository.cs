using System;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAll();
    }

    public class BookRepository : IBookRepository
    {
        static readonly List<Book> _books = new List<Book>()
        {
            new Book {Title = "ASP.net en Mac", Author = "Eduard Tomás" , Year = 2014},
            new Book {Title = "Agile ALM y Motos", Author = "Juan Carlos Quijano", Year = 2010 },
            new Book {Title = "Conectando Windows Phone con cosas", Author = "Roberto Luis Bisbé", Year = 2009 }
        };

        public IEnumerable<Book> GetAll()
        {
            return _books;
        }
    }
}