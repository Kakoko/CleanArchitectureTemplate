namespace CleanMovie.Domain
{
    public class Rental
    {
        public int RentalId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime RentalExpiry { get; set; }
        public decimal TotalCost { get; set; }

        //One to Many Relationship
        public ICollection<Member> Members { get; set; }

        //Many to Many Relation
        public IList<MovieRental> MovieRentals { get; set; }
    }
}