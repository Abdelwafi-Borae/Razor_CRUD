using Abby_razor_Web.Data;
using Abby_razor_Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Abby_razor_Web.Pages.Shared.Catogeries
{
    public class IndexModel : PageModel { 
        private readonly AppDBContex _appDBContex;
        public IEnumerable<Catogery> Catogeries { get; set; }
        public IndexModel(AppDBContex appDBContex)
    {
            _appDBContex = appDBContex;


    }
    
        public void OnGet()
        {
            Catogeries = _appDBContex.Catogeries;
        }
    }
}
