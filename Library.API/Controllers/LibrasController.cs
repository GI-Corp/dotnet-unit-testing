using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.API.Data;
using Library.API.Data.Models;
using Library.API.Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrasController : ControllerBase
    {
        private readonly ILibraService _libService;

        public LibrasController(ILibraService service)
        {
            _libService = service;
        }

        // GET api/libraries
        [HttpGet]
        public ActionResult<IEnumerable<Libra>> Get()
        {
            var items = _libService.GetAllLibraries();
            return Ok(items);
        }

        // GET api/library/1
        [HttpGet("{id}")]
        public ActionResult<Libra> Get(Guid id)
        {
            var item = _libService.GetById(id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        // Create book api/library
        [HttpPost]
        public ActionResult Create([FromBody] Libra libraModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var library = _libService.Create(libraModel);
            return CreatedAtAction("Get", new { id = library.Id }, library);
        }

        // DELETE api/library/1
        [HttpDelete("{id}")]
        public ActionResult Remove(Guid id)
        {
            var existingItem = _libService.GetById(id);

            if (existingItem == null)
            {
                return NotFound();
            }

            _libService.Remove(id);
            return Ok();
        }
    }
}
