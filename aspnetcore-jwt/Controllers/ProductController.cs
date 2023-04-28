// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this

using aspnetcore_jwt.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore_jwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productResposity;

        public ProductController(IProductRepository productRespository)
        {
            _productResposity = productRespository;
        }

        [HttpGet]
        public IActionResult GettAllProducts(string search, double? from, double? to, string sortBy, int page = 1)
        {
            try
            {
                var result = _productResposity.GetAll(search, from, to, sortBy, page);
                return Ok(result);
            }
            catch
            {
                return BadRequest("We can't get the product.");
            }
        }
    }
}
