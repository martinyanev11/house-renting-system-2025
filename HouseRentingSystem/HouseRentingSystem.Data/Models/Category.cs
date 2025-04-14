namespace HouseRentingSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Category
    {
        [Key]
        public int Id { get; init; }

        [Required, MaxLength(50)]
        public string Name { get; set; } = null!;

        public IEnumerable<House> Houses { get; set; } = new List<House>();
    }
}
