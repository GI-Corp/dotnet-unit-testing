using Library.API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Data.Services
{
    public interface ILibraryService
    {
        IEnumerable<Book> GetAllBooks();
        Library Create(Book book);
        Library GetById(Guid id);
        void Remove(Guid id);
    }
}
