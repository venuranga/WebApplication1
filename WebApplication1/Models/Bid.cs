public class Bid
{
    public int BidId { get; set; }
    public int UserId { get; set; }
    public int CarId { get; set; }
    public decimal BidAmount { get; set; }
    public DateTime BidTimestamp { get; set; }
    /*public User User { get; set; } // Navigation property to the user entity
    public Car Car { get; set; } // Navigation property to the car entity

    public ICollection<Auction> Auctions { get; set; }
    */
}