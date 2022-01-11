using Library.API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Data.Services
{
    public interface ILibraService
    {
        IEnumerable<Libra> GetAllLibraries();
        Libra Create(Libra library);
        Libra GetById(Guid id);
        void Remove(Guid id);
    }
}
