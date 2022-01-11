using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Library.API.Data.Models;

namespace Library.API.Data.Models
{
    public class Library
    {
        public Guid Id { get; set; }
        [Required]
        public int NumberOfShells { get; set; }
        public List<Book> Books { get; set; }
    }
}
