using Abby_razor_Web.Data;
using Abby_razor_Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Abby_razor_Web.Pages.Catogeries
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly AppDBContex _AppDBContex;
        public DeleteModel(AppDBContex appDBContex)
        {
            _AppDBContex = appDBContex;

        }

        public Catogery catogery { get; set; }

        public void OnGet(int Id)
        {
            catogery = _AppDBContex.Catogeries.Find(Id);

        }
        public async Task<IActionResult> OnPost()
        {

            var catogeryfromdb = _AppDBContex.Catogeries.Find(catogery.Id);
            if (catogeryfromdb != null)
            {
                _AppDBContex.Catogeries.Remove(catogeryfromdb);

                await _AppDBContex.SaveChangesAsync();
                TempData["seccess"] = "Catogery deleted sccessfully";
                return RedirectToPage("Index");
            }
            return Page();

        }

        
    }
    }

