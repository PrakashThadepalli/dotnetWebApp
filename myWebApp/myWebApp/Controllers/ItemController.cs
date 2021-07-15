using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myWebApp.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace myWebApp.Controllers
{
    [Route("api/[controller]")]
    public class ItemController : Controller
    {

        private List<Item> Items = new List<Item> {
          new  Item() { Id=1, ItemName="Idly"},
          new Item() {Id=2, ItemName ="poori"}
        };
          
        
        // GET: api/values
        [HttpGet]
        public ActionResult<IEnumerable<Item>> Get()
        {
            return Items;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Item> Get(int id)
        {
            Item itemFound = Items.FirstOrDefault(i => i.Id==id);
            if (itemFound ==null)
            {
                return NotFound(new { Message = "Item has not been Not Found" });
            }
            return Ok(itemFound);
        }

        // POST api/values
        [HttpPost]
        public IEnumerable<Item> Post( Item value)
        {
            Console.WriteLine(value);
            Items.Add(value);
            return Items;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
