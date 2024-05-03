using Microsoft.AspNetCore.Mvc;
using WebApplication;

namespace APICatalogo.Controllers{

    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase{
        private readonly reandoly AppDbContext _context;
        public ProdutosController(AppDbContext context){
            _context = context; 
        }
    }

    internal class reandoly
    {
    }
}