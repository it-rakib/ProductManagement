using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBook.Model
{
    public class CoverType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("CoverType Name")]
        public string Name { get; set; }
    }
}
