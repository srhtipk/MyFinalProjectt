using Business.Abstract;
using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
using Entities.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //Loosely coupled
        IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll() 
        {
            // IProductService productService =new ProductManager(new EfProductDal());  //ProductManager productService yazabilirdim en baştaki kısma. Aynı referans değeri old. için bu yazım da doğru kabul edilir.
            // üst satırdaki IProductService ve EfProductDal Singleton içinde tanımladığımız için yukarı yazmaya gerek kalmadı.
            //var result = _productService.GetAll();
            //return result.Data;
            var result = _productService.GetAll();

            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }



        [HttpGet("getbyid")]
        public IActionResult GetByID(int id)
        {

            var result = _productService.GetById(id);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
           
            var result = _productService.Add(product);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



    }
}
