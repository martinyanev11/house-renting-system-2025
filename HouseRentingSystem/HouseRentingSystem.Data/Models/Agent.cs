namespace HouseRentingSystem.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    public class Agent
    {
        public Agent()
        {
            Id = Guid.NewGuid();
            ManagedHouses = new List<House>();
        }

        [Key]
        public Guid Id { get; init; }

        [Required, MaxLength(15), MinLength(7)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = null!;
        public IdentityUser User { get; set; } = null!;

        public IEnumerable<House> ManagedHouses { get; set; }
    }
}
