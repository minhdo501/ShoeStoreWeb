using System.ComponentModel.DataAnnotations;

namespace ShoeStore.Models
{
    public class ShoeType
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Shoe Type")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
