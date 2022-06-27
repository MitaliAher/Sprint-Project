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
    
    public class CategoryController : ControllerBase
    {
        EcommerceProjectContext db;
        public CategoryController(EcommerceProjectContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<CategoryTbl1> GetCategory()
        {
            return db.CategoryTbl1s;
        }
        [HttpPost]
        public string post([FromBody] CategoryTbl1 ct)
        {
            db.CategoryTbl1s.Add(ct);
            db.SaveChanges();
            return "Success";
        }
    }
}
