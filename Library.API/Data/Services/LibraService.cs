using Library.API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Data.Services
{
    public class LibraService : ILibraService
    {
        private readonly List<Libra> _libraries;

        public LibraService()
        {
            _libraries = new List<Libra>()
            {
                new Libra()
                {
                    Id = new Guid("ab2bd111-98cd-4cf3-a80a-53ea0cd9c200"),
                    NumberOfShells = 5
                }
            };
        }

        public IEnumerable<Libra> GetAllLibraries()
        {
            return _libraries;
        }

        public Libra Create(Libra library)
        {
            library.Id = Guid.NewGuid();
            _libraries.Add(library);
            return library;
        }

        public Libra GetById(Guid id) 
        {
            return _libraries.Where(lib => lib.Id == id).FirstOrDefault();
        }

        public void Remove(Guid id)
        {
            var existing = _libraries.First(a => a.Id == id);
            _libraries.Remove(existing);
        }
    }
}