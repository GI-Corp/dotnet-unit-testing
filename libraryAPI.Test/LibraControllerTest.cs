using Library.API.Controllers;
using Library.API.Data.Models;
using Library.API.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace libraryAPI.Test
{
    public class LibrasControllerTest
    {
        LibrasController _controller;
        ILibraService _service;

        public LibrasControllerTest()
        {
            _service = new LibraService();
            _controller = new LibrasController(_service);

        }

        // [Theory]
        // [InlineData("ab2bd123-98cd-4cf3-a80a-53ea0cd9c200", "ab2bd123-98cd-4cf3-a80a-53ea0cd9c111")]
        // public void GetLibrasByIdTest(string guid1,string guid2)
        // {
        //     var validGuid = new Guid(guid1);
        //     var invalidGuid = new Guid(guid2);

        //     var notFoundResult = _controller.Get(invalidGuid);
        //     var okResult = _controller.Get(validGuid);

        //     Assert.IsType<NotFoundResult>(notFoundResult.Result);
        //     Assert.IsType<OkResult>(okResult);

        // }

        [Fact]
        public void CreateLibraTest()
        {
            var library = new Libra()
            {
                NumberOfShells = 5
            };

            var createdResponse = _controller.Create(library);

            Assert.IsType<CreatedAtActionResult>(createdResponse);

            var item = createdResponse as CreatedAtActionResult;
            Assert.IsType<Libra>(item.Value);

            var libraItem = item.Value as Libra;
            Assert.Equal(library.NumberOfShells, libraItem.NumberOfShells);
        }

    }
}
