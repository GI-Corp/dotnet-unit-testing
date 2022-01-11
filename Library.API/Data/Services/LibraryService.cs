using Library.API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Data.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly List<Library> _libraries;

        public LibraryService()
        {
            _libraries = new List<Library>()
            {
                new Library()
                {
                    Id = new Guid("ab2bd111-98cd-4cf3-a80a-53ea0cd9c200"),
                    NumberOfShells = 5
                }
            };
        }

        public IEnumerable<Library> GetLibraries()
        {
            return _libraries;
        }

        public Library Create(Library library)
        {
            library.Id = Guid.NewGuid();
            _libraries.Add(library);
            return library;
        }

        public Library GetById(Guid id) 
        {
            return _libraries.Where(lib => lib.Id == id).FirstOrDefault();
        }

        public void Remove(Guid id)
        {
            var existing = _books.First(a => a.Id == id);
            _libraries.Remove(existing);
        }
    }
}