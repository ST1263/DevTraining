using CrudRepository.Data;
using CrudRepository.Infra;
using CrudRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace CrudRepository.Services
{
    public class BookRepository: IBook
    {
        public databaseContext _context;

        public BookRepository(databaseContext context)
        {
            _context = context;
        }
        public List<Book> GetBooks()
        {
            return _context.Book.ToList();
        }

        public Book GetBook(int BookId)
        {
            return _context.Book.FirstOrDefault(f => f.BookId == f.BookId);
        }
         public void DeleteBook(int BookId)
        {
            var deleteid = _context.Book.Where(f => f.BookId == BookId).FirstOrDefault();
            _context.Book.Remove(deleteid);
            _context.SaveChanges();
          
        }
        public void Create(Book book)
        {
            _context.Add(book);
            _context.SaveChanges();
        }
        public void Update(Book book)
        {
            _context.Update(book);
            _context.SaveChanges();
        }

    }
}
