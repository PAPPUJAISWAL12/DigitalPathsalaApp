using DigitalpathsalaTestapp.Models;
using Microsoft.AspNetCore.Mvc;
namespace DigitalpathsalaTestapp.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly DisitalPathsalaAppContext _context; 
        public HomeController(DisitalPathsalaAppContext context)
        {
            _context = context;
        }
    
        public IActionResult Index()
        {
            List <ProductList> productList=new List<ProductList>();
            productList = _context.ProductLists.ToList();
            return View(productList);
        }

       
      
        [HttpPost]
        public IActionResult Create(ProductList product)
        {
           
         if(product != null)
            {
                _context.ProductLists.Add(product);
               
            }
             _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
