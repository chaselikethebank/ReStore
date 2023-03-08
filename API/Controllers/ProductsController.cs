using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
        [ApiController]
        [Route("api/[controller]")]

    public class ProductsController : ControllerBase
    //dependancy injection
    //ctor + "return"
    {
        private readonly Data.StoreContext _context; 
        public ProductsController(Data.StoreContext context)
        {
            _context=context;
        }

        //create endpoints

        //get all
        [HttpGet]
        public async Task<ActionResult<List<Entities.Product>>> GetProducts()
        {
            return await _context.Products.ToListAsync();

        }

        //get 1 via id
        [HttpGet("{id}")] 
        public async Task<ActionResult<Entities.Product>> GetProduct(int id)
            {
                return await _context.Products.FindAsync(id);
            }
    }
}