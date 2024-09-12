using Abby_razor_Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Abby_razor_Web.Data
{
    public class AppDBContex:DbContext
    {
        public AppDBContex( DbContextOptions<AppDBContex> options):base(options)
        {
                
        }
      public  DbSet<Catogery> Catogeries { get; set; }
    }
}
