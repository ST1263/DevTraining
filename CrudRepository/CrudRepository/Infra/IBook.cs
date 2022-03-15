using CrudRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudRepository.Data;

namespace CrudRepository.Infra
{
    public interface IBook
    {
        public List<Book> GetBooks();
        public Book GetBook(int BookId);
        public void DeleteBook(int BookId);
        public void Create(Book book);
        public void Update(Book book);

    }
}
