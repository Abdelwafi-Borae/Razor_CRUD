using Abby_razor_Web.Data;
using Abby_razor_Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Abby_razor_Web.Pages.Catogeries
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly AppDBContex _AppDBContex;
        public CreateModel(AppDBContex appDBContex )
        {
            _AppDBContex = appDBContex;
            
        }
        
        public Catogery catogery { get; set; }
        public void OnGet()
        
        {
        }
        public async Task<IActionResult> OnPost()
        {if (catogery.Name == catogery.DisplayOrder.ToString()) 
                ModelState.AddModelError("catogery.Name", "name and order cant be match");
            if (ModelState.IsValid) { 

            await _AppDBContex.Catogeries.AddAsync(catogery);

            await _AppDBContex.SaveChangesAsync();
                TempData["seccess"] = "Catogery created sccessfully";
                return RedirectToPage("Index");
        } return Page();
        
        }
        
    }
}
