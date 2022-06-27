using EcommerceApiProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        EcommerceProjectContext db;
        public ProductController(EcommerceProjectContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<ProductTbl> GetProducts()
        {
            return db.ProductTbls;
        }
        [HttpPost]
        public string post([FromBody] ProductTbl pd)
        {
            db.ProductTbls.Add(pd);
            db.SaveChanges();
            return "Sucess";
        }
    }
}
