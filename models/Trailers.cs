namespace MikesMoves.Models;
public class Trailer
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Length { get; set; }
        public decimal Capacity { get; set; }
        public string Location { get; set; }
        public decimal BasePrice { get; set; }
        public decimal PricePerMile { get; set; }
        public ICollection<Item> Items { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public string ImageUrl { get; set; }
        public int UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
    }