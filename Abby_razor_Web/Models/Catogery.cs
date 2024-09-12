using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Abby_razor_Web.Models
{
    public class Catogery
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order") ]
        public int DisplayOrder { get; set; }
    }
}
